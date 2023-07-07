using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siemens.Engineering;
using Siemens.Engineering.HW.Features;
using Siemens.Engineering.HW;
using Siemens.Engineering.SW;
using Siemens.Engineering.SW.Tags;
using Siemens.Engineering.SW.Blocks;
using Siemens.Engineering.Hmi.Globalization;
using Siemens.Engineering.Hmi.RuntimeScripting;
using Siemens.Engineering.Hmi.Screen;
using Siemens.Engineering.Hmi.Tag;
using Siemens.Engineering.Hmi;
using Siemens.Engineering.Library.MasterCopies;
using Siemens.Engineering.Library.Types;
using Siemens.Engineering.Library;
using Siemens.Engineering.SW.ExternalSources;
using Siemens.Engineering.SW.Types;
using System.Collections.ObjectModel;
using OpennessConsole.Models;
using System.Runtime.InteropServices;
using OpennessConsole.Models.Elements;
using System.ComponentModel;
using OpennessConsole.Enums;
using System.Text.RegularExpressions;
using System.Globalization;

namespace OpennessConsole
{
    internal class TiaHandling
    {
        public TiaPortalProcess process { get; set; }
        private Project project;

        /// <summary>
        /// Connecting to the process
        /// </summary>
        public TiaHandling() 
        { 
            SelectProcess();
        }

        /// <summary>
        /// Connecting to the process selected by it's index
        /// </summary>
        /// <param name="id">Index of process</param>
        public TiaHandling(int id)
        {
            IList<TiaPortalProcess> processes;
            processes = TiaPortal.GetProcesses();
            try { process = processes[id]; }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
        }


        #region Connecting to TIA
        /// <summary>
        /// Default function for selecting tia process.
        /// If theres only 1 process then no user input is needed
        /// </summary>
        private void SelectProcess()
        {
            int selectedProcess;
            string userInput;
            
            IList<TiaPortalProcess> processes = TiaPortal.GetProcesses();
            int i = 0;

            foreach (TiaPortalProcess proc in processes)
            {
                Console.WriteLine($"{i}\t{proc.ProjectPath}");
                i++;
            }

            if (i > 1)
            {
                Console.WriteLine("Select process:");
                
                userInput = Console.ReadLine();

                try
                {
                    selectedProcess = int.Parse(userInput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            else if (i > 0)
            {
                selectedProcess = 0;
            }
            else
            {
                throw new Exception("Tia process not found");
            }
            process = processes[selectedProcess];
            return;
        }


        /// <summary>
        /// Function returns first PLC software it finds in project
        /// ToDo; maybe it is possible to not iterate through everything?
        /// </summary>
        /// <param name="tiaPortal"></param>
        /// <param name="writeInConsole">Flag for writing scan information</param>
        /// <returns></returns>
        public PlcSoftware GetPlcSoftware(TiaPortal tiaPortal, bool writeInConsole)
        {
            ProjectComposition projectComposition = tiaPortal.Projects;
            SoftwareContainer softwareContainer;
            project = projectComposition[0];

            foreach (Project project in projectComposition)
            {
                if (writeInConsole) Console.WriteLine($"Project: {project.Name}");

                foreach (Device device in project.Devices)
                {
                    if (writeInConsole && device.TypeIdentifier.Contains("1500")) Console.WriteLine($"\t {device.TypeIdentifier}");

                    foreach (DeviceItem deviceItem in device.DeviceItems)
                    {
                        if (writeInConsole && deviceItem.TypeIdentifier != null) Console.WriteLine("\t\t" + deviceItem.TypeIdentifier);
                        
                        softwareContainer = ((IEngineeringServiceProvider)deviceItem).GetService<SoftwareContainer>();

                        if (softwareContainer != null && softwareContainer.Software is PlcSoftware)
                        {
                            if (writeInConsole) Console.WriteLine($"\t\t\tPlcProgram: {softwareContainer.Software.Name}");
                            return softwareContainer.Software as PlcSoftware;
                        }
                    }
                }
            }
            return null;
        }


        /// <summary>
        /// Overload which doesnt writes information
        /// </summary>
        /// <param name="tiaPortal"></param>
        /// <returns></returns>
        public PlcSoftware GetPlcSoftware(TiaPortal tiaPortal)
        {
            return GetPlcSoftware(tiaPortal, false);
        }
        #endregion


        /// <summary>
        /// Function writes all tags in console.
        /// </summary>
        /// <param name="plcSoftware"></param>
        public void ShowAllTags(PlcSoftware plcSoftware)
        {
            PlcTagTableSystemGroup plcTagTableSystemGroup = plcSoftware.TagTableGroup;
            foreach (PlcTagTable plcTagTable in plcTagTableSystemGroup.TagTables)
            {
                Console.WriteLine($"{plcTagTable.Name}");
                foreach (PlcTag plcTag in plcTagTable.Tags)
                {
                    Console.WriteLine($"\tTag:\t{plcTag.Name}\t\t\t{plcTag.DataTypeName}\t{plcTag.LogicalAddress}");
                }

                foreach (PlcUserConstant plcUserConstant in plcTagTable.UserConstants)
                {
                    Console.WriteLine($"\tConst:\t{plcUserConstant.Name}\t\t\t{plcUserConstant.DataTypeName}\t{plcUserConstant.Value}");
                }
            }

            foreach (PlcTagTableUserGroup tagTableUserGroup in plcSoftware.TagTableGroup.Groups)
            {
                Console.WriteLine($"{tagTableUserGroup.Name}");

                foreach (PlcTagTable plcTagTable in tagTableUserGroup.TagTables)
                {
                    Console.WriteLine($"\t{plcTagTable.Name}");
                    foreach (PlcTag plcTag in plcTagTable.Tags)
                    {
                        Console.WriteLine($"\t\tTag:\t{plcTag.Name}\t\t\t{plcTag.DataTypeName}\t{plcTag.LogicalAddress}");
                    }

                    foreach (PlcUserConstant plcUserConstant in plcTagTable.UserConstants)
                    {
                        Console.WriteLine($"\t\tConst:\t{plcUserConstant.Name}\t\t\t{plcUserConstant.DataTypeName}\t{plcUserConstant.Value}");
                    }
                }
            }
        }


        /// <summary>
        /// Creates group of tag tables
        /// ToDo options to create subgroups
        /// </summary>
        /// <param name="plcSoftware">plcSoftware process</param>
        /// <param name="groupName">Name of group to create</param>
        public static void CreatePlcTagTableUserGroup(PlcSoftware plcSoftware, string groupName)
        {
            PlcTagTableSystemGroup systemGroup = plcSoftware.TagTableGroup;
            PlcTagTableUserGroupComposition groupComposition = systemGroup.Groups;
            PlcTagTableUserGroup myCreatedGroup = groupComposition.Create(groupName);
        }


        #region Getting program structure
        /// <summary>
        /// Prints blocks in main group and then call recursive function
        /// </summary>
        /// <param name="plcSoftware">Connected software</param>
        public void showProgramStructure(PlcSoftware plcSoftware)
        {
            SubLevel nestingLevel = new SubLevel();

            foreach (PlcBlock block in plcSoftware.BlockGroup.Blocks)
                Console.WriteLine($"-{(block as PlcBlock).Name}");

            programStructureRecursive(plcSoftware.BlockGroup.Groups, nestingLevel);
        }


        /// <summary>
        /// Checks group for blacks and checking subgroups by recurse
        /// </summary>
        /// <param name="groupComposition">Subgroup</param>
        /// <param name="nestLevel">saves sublevel</param>
        public void programStructureRecursive(PlcBlockUserGroupComposition groupComposition, SubLevel nestLevel)
        {
            foreach (PlcBlockGroup blockGroup in groupComposition)
            {
                Console.WriteLine($"{nestLevel.GetTabs()}{blockGroup.Name}");
                nestLevel.NextLeveL();
                foreach (PlcBlock plcBlock in blockGroup.Blocks)
                {
                    Console.WriteLine($"{nestLevel.GetTabs()}-{plcBlock.Name}");
                }
                programStructureRecursive(blockGroup.Groups, nestLevel);
                nestLevel.PrevLeveL();
            }
        }
        #endregion


        #region Getting all elements
        /// <summary>
        /// Prints groups and blocks
        /// </summary>
        /// <param name="plcSoftware"></param>
        public void ShowAllElements(PlcSoftware plcSoftware)
        {
            Collection<object> list = new Collection<object>();

            RecursiveGetAllElements(plcSoftware, ref list);

            foreach (object item in list)
            {
                if (item is PlcBlock) Console.WriteLine((item as PlcBlock).Name);
                else Console.WriteLine((item as PlcBlockGroup).Name);
            }
        }


        /// <summary>
        /// Recursively gathers all subitems and folder in the provided folder
        /// </summary>
        /// <param name="folder">The folder.</param>
        /// <param name="collection">The collection.</param>
        private static void RecursiveGetAllElements(object folder, ref Collection<object> collection)
        {
            foreach (var item in GetSubItem(folder))
              collection.Add(item);

            foreach (var subfolder in GetSubFolder(folder))
            {
                collection.Add(subfolder);
                RecursiveGetAllElements(subfolder, ref collection);
            }
        }


        /// <summary>Returns a IEnumerable of all subitems of item</summary>
        /// <param name="item">The item.</param>
        /// <returns>IEnumerable&lt;object&gt;</returns>
        public static IEnumerable<object> GetSubItem(object item)
        {
            object subItem = null;
            if (item != null)
            {
                if (item is Project)
                {
                    subItem = new Collection<object>();
                    foreach (var device in (item as Project).Devices)
                        (subItem as Collection<object>).Add(device);
                    (subItem as Collection<object>).Add((item as Project).Graphics);
                }
                else if (item is DeviceUserGroup)
                    subItem = (item as DeviceUserGroup).Devices;
                else if (item is PlcSoftware)
                    subItem = new Collection<object>();
                else if (item is HmiTarget)
                    subItem = new Collection<object>();
                else if (item is Device)
                    subItem = (item as Device).Items;
                else if (item is DeviceItem)
                    subItem = (item as DeviceItem).Items;
                else if (item is PlcBlockGroup)
                    subItem = (item as PlcBlockGroup).Blocks;
                else if (item is PlcSystemBlockGroupComposition)
                    subItem = new Collection<object>();
                else if (item is PlcTagTableGroup)
                    subItem = (item as PlcTagTableGroup).TagTables;
                else if (item is PlcTypeGroup)
                    subItem = (item as PlcTypeGroup).Types;
                else if (item is PlcExternalSourceGroup)
                    subItem = (item as PlcExternalSourceGroup).ExternalSources;
                else if (item is TagFolder)
                    subItem = (item as TagFolder).TagTables;
                else if (item is ScreenFolder)
                    subItem = (item as ScreenFolder).Screens;
                else if (item is ScreenTemplateFolder)
                    subItem = (item as ScreenTemplateFolder).ScreenTemplates;
                else if (item is ScreenPopupFolder)
                    subItem = (item as ScreenPopupFolder).ScreenPopups;
                else if (item is ScreenSlideinSystemFolder)
                    subItem = (item as ScreenSlideinSystemFolder).ScreenSlideins;
                else if (item is VBScriptFolder)
                    subItem = (item as VBScriptFolder).VBScripts;
                else if (item is MultiLingualGraphicComposition)
                    subItem = item;
                else if (item is TagTable)
                    subItem = (item as TagTable).Tags;
                else if (item is IEngineeringComposition)
                    subItem = item;
                else if (item is ProjectLibrary)
                    subItem = new Collection<object>();
                else if (item is MasterCopyFolder)
                    subItem = (item as MasterCopyFolder).MasterCopies;
                else if (item is LibraryTypeFolder)
                    subItem = (item as LibraryTypeFolder).Types;
                else
                {
                    subItem = new Collection<object>();
                }
            }

            return subItem as IEnumerable<object>;
        }


        /// <summary>Returns a IEnumerbale of all subfolder of item</summary>
        /// <param name="item">The item.</param>
        /// <returns>IEnumerable&lt;object&gt;</returns>
        public static IEnumerable<object> GetSubFolder(object item)
        {
            object subFolder;

            if (item is PlcSoftware)
            {
                var sw = item as PlcSoftware;
                var col = new Collection<object>();
                col.Add(sw.BlockGroup);
                col.Add(sw.TagTableGroup);
                col.Add(sw.TypeGroup);
                col.Add(sw.ExternalSourceGroup);
                subFolder = col;
            }
            else if (item is HmiTarget)
            {
                var target = item as HmiTarget;
                var col = new Collection<object>();
                col.Add(target.ScreenFolder);
                col.Add(target.ScreenTemplateFolder);
                col.Add(target.TagFolder);
                col.Add(target.Connections);
                col.Add(target.VBScriptFolder);
                col.Add(target.Cycles);
                subFolder = col;
            }
            else if (item is Device)
                subFolder = new Collection<object>();
            else if (item is DeviceItem)
                subFolder = new Collection<object>();
            else if (item is PlcBlockSystemGroup)
            {
                var col = new Collection<object>();
                var group = item as PlcBlockSystemGroup;
                foreach (var element in group.Groups)
                {
                    col.Add(element);
                }
                if ((item as PlcBlockSystemGroup).SystemBlockGroups != null)
                    col.Add(group.SystemBlockGroups);
                subFolder = col;
            }
            else if (item is PlcBlockGroup)
                subFolder = (item as PlcBlockGroup).Groups;
            else if (item is PlcSystemBlockGroupComposition)
            {
                var col = new Collection<object>();
                var group = item as PlcSystemBlockGroupComposition;
                foreach (var element in group)
                {
                    col.Add(element);
                }
                subFolder = col;
            }
            else if (item is PlcSystemBlockGroup)
                subFolder = (item as PlcSystemBlockGroup).Groups;
            else if (item is TagFolder)
                subFolder = (item as TagFolder).Folders;
            else if (item is PlcTagTableGroup)
                subFolder = (item as PlcTagTableGroup).Groups;
            else if (item is PlcTypeGroup)
                subFolder = (item as PlcTypeGroup).Groups;
            else if (item is VBScriptFolder)
                subFolder = (item as VBScriptFolder).Folders;
            else if (item is ScreenFolder)
                subFolder = (item as ScreenFolder).Folders;
            else if (item is ScreenTemplateFolder)
                subFolder = (item as ScreenTemplateFolder).Folders;
            else if (item is ScreenPopupFolder)
                subFolder = (item as ScreenPopupFolder).Folders;
            else if (item is ProjectLibrary)
                subFolder = (item as ProjectLibrary).MasterCopyFolder.Folders;
            else if (item is TagTable)
                subFolder = (item as TagTable).Tags;
            else if (item is LibraryTypeFolder)
                subFolder = (item as LibraryTypeFolder).Folders;
            else if (item is MasterCopyFolder)
                subFolder = (item as MasterCopyFolder).Folders;
            else if (item is DeviceUserGroup)
                subFolder = item;
            else if (item is Project)
            {
                subFolder = new Collection<object>();
                //foreach (object obj in GetAllTargets(item))
                //    subFolder.Add(obj);
                foreach (var folder in (item as Project).DeviceGroups)
                    (subFolder as Collection<object>).Add(folder);
            }
            else
            {
                subFolder = new Collection<object>();
            }

            return subFolder as IEnumerable<object>;
        }
        #endregion


        #region Finding system group
        /// <summary>
        /// Finds defalut philogic block user group eg. !!!!!Functions
        /// </summary>
        /// <param name="mainBlockGroup">Program blocks</param>
        /// <param name="defGroup">eg. !!!!!Functions defined in def groups</param>
        /// <returns>Default philogic group or null</returns>
        public PlcBlockUserGroup GetDefaultGroup(PlcBlockSystemGroup mainBlockGroup, DefGroup defGroup)
        {
            PlcBlockUserGroup plcSystemGroup = null;

            
            string groupName = GetTypeDescription(defGroup);

            //Console.WriteLine(groupName);

            if (groupName != null) 
            {
                plcSystemGroup = mainBlockGroup.Groups.Find(groupName);
            }

            return plcSystemGroup;
        }

        /// <summary>
        /// Get description of defined program element
        /// </summary>
        /// <param name="defGroup">Group from DefGroup enum</param>
        /// <returns>String with group name</returns>
        private string GetTypeDescription(DefGroup defGroup)
        {
            Type enumType = typeof(DefGroup);

            var groupInfo = enumType.GetField(defGroup.ToString());
            var attribute = groupInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            var description = (DescriptionAttribute)attribute[0];

            return description.Description;
        }

        #endregion

        /// <summary>
        /// Finds sequence blocks
        /// </summary>
        /// <param name="mainBlockGroup">Group with sequences</param>
        /// <returns>Collection of sequences blocks</returns>
        public Collection<PlcBlock> GetSequencesBlocks(PlcBlockSystemGroup mainBlockGroup)
        {
            PlcBlockUserGroup sequencesGroup = GetDefaultGroup(mainBlockGroup, DefGroup.Sequences);
            //Console.WriteLine(sequencesGroup.Name);
            Collection<PlcBlock> sequences = new Collection<PlcBlock>();

            RecursiveGetSeqBlocks(sequencesGroup, ref sequences);
            
            return sequences;
        }

        
        private static void RecursiveGetSeqBlocks(PlcBlockUserGroup group, ref Collection<PlcBlock> sequences)
        {

            string pattern = @"(Step\w*)|(DB\w*)|((FC|FB)\w*(Handling))";
            // Setting flag RegexOptions.IgnoreCase and RegexOptions.Multiline
            RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Multiline;
            foreach (PlcBlock block in group.Blocks)
            {
                
                if ( !( Regex.IsMatch(block.Name, pattern, options) ) )
                {
                    sequences.Add(block);
                    //Console.WriteLine(block.Name);
                }
            }

            foreach (PlcBlockUserGroup userGroup in group.Groups)
            {
                RecursiveGetSeqBlocks(userGroup, ref sequences);
                //Console.WriteLine(userGroup.Name);
            }
        }


        /*public PlcBlock GetBlockByName(PlcBlockSystemGroup mainBlockGroup, string name)
        {
            foreach
        }*/

        public PlcBlockGroup GetGroupByBlockName(PlcBlockGroup blockGroup, string blockName)
        {
            PlcBlock plcBlock = blockGroup.Blocks.FirstOrDefault(block => block.Name == blockName);
            if (plcBlock != null) return blockGroup;
            else
            {
                foreach (PlcBlockGroup plcBlockGroup in blockGroup.Groups)
                {
                    //Console.WriteLine(plcBlockGroup.Name);
                    PlcBlockGroup resultGroup = GetGroupByBlockName(plcBlockGroup, blockName);
                    if (resultGroup != null) return resultGroup;
                }
            }

            return null;
        }


        public PlcBlockGroup GetGroupByGroupName(PlcBlockGroup blockGroup, string groupName)
        {
            PlcBlockGroup plcBlockGroup = blockGroup.Groups.FirstOrDefault(group => group.Name == groupName);
            Console.WriteLine(plcBlockGroup.Name);
            if (plcBlockGroup != null) return plcBlockGroup;
            else
            {
                foreach (PlcBlockGroup subBlockGroup in blockGroup.Groups)
                {
                    Console.WriteLine(subBlockGroup.Name);
                    PlcBlockGroup resultGroup = GetGroupByGroupName(subBlockGroup, groupName);
                    if (resultGroup != null) return resultGroup;
                }
            }
            return null;
        }



        /// <summary>
        /// Get list of active languages
        /// </summary>
        /// <returns></returns>
        public List<CultureInfo> GetProjectCultures()
        {
            List<CultureInfo> cultureList = new List<CultureInfo>();

            LanguageSettings languageSettings = project.LanguageSettings;
            LanguageAssociation activeLanguages = languageSettings.ActiveLanguages;
            foreach (Language lang in activeLanguages)
            {
                cultureList.Add(lang.Culture);
            }

            return cultureList;
        }

        /// <summary>
        /// Displaying composition informations
        /// </summary>
        /// <param name="obj"></param>
        public void DisplayCompositionInfos(IEngineeringObject obj)
        {
            IList<EngineeringCompositionInfo> compositionInfos = obj.GetCompositionInfos();
            foreach (EngineeringCompositionInfo compositionInfo in compositionInfos)
            {
                Console.WriteLine(compositionInfo.Name);
            }
        }


        public string GetProcessPath()
        {
            if (process == null) { return "No process selected"; }
            else return process.ProjectPath.FullName;
        }


        public string GetProcessName()
        {
            if (process == null) { return "No process selected"; }
            else return process.ProjectPath.Name;
        }
    }
}
