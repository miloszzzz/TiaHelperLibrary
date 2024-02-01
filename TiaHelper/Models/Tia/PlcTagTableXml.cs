using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiaHelperLibrary.Models.Tia
{
    public class TagTableXml
    {

        // UWAGA: Wygenerowany kod może wymagać co najmniej programu .NET Framework 4.5 lub .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Document
        {

            private DocumentEngineering engineeringField;

            private DocumentDocumentInfo documentInfoField;

            private DocumentSWTagsPlcTagTable sWTagsPlcTagTableField;

            /// <remarks/>
            public DocumentEngineering Engineering
            {
                get
                {
                    return this.engineeringField;
                }
                set
                {
                    this.engineeringField = value;
                }
            }

            /// <remarks/>
            public DocumentDocumentInfo DocumentInfo
            {
                get
                {
                    return this.documentInfoField;
                }
                set
                {
                    this.documentInfoField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SW.Tags.PlcTagTable")]
            public DocumentSWTagsPlcTagTable SWTagsPlcTagTable
            {
                get
                {
                    return this.sWTagsPlcTagTableField;
                }
                set
                {
                    this.sWTagsPlcTagTableField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentEngineering
        {

            private string versionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentDocumentInfo
        {

            private System.DateTime createdField;

            private string exportSettingField;

            private DocumentDocumentInfoInstalledProducts installedProductsField;

            /// <remarks/>
            public System.DateTime Created
            {
                get
                {
                    return this.createdField;
                }
                set
                {
                    this.createdField = value;
                }
            }

            /// <remarks/>
            public string ExportSetting
            {
                get
                {
                    return this.exportSettingField;
                }
                set
                {
                    this.exportSettingField = value;
                }
            }

            /// <remarks/>
            public DocumentDocumentInfoInstalledProducts InstalledProducts
            {
                get
                {
                    return this.installedProductsField;
                }
                set
                {
                    this.installedProductsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentDocumentInfoInstalledProducts
        {

            private object[] itemsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("OptionPackage", typeof(DocumentDocumentInfoInstalledProductsOptionPackage))]
            [System.Xml.Serialization.XmlElementAttribute("Product", typeof(DocumentDocumentInfoInstalledProductsProduct))]
            public object[] Items
            {
                get
                {
                    return this.itemsField;
                }
                set
                {
                    this.itemsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentDocumentInfoInstalledProductsOptionPackage
        {

            private string displayNameField;

            private string displayVersionField;

            /// <remarks/>
            public string DisplayName
            {
                get
                {
                    return this.displayNameField;
                }
                set
                {
                    this.displayNameField = value;
                }
            }

            /// <remarks/>
            public string DisplayVersion
            {
                get
                {
                    return this.displayVersionField;
                }
                set
                {
                    this.displayVersionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentDocumentInfoInstalledProductsProduct
        {

            private string displayNameField;

            private string displayVersionField;

            /// <remarks/>
            public string DisplayName
            {
                get
                {
                    return this.displayNameField;
                }
                set
                {
                    this.displayNameField = value;
                }
            }

            /// <remarks/>
            public string DisplayVersion
            {
                get
                {
                    return this.displayVersionField;
                }
                set
                {
                    this.displayVersionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTable
        {

            private DocumentSWTagsPlcTagTableAttributeList attributeListField;

            private DocumentSWTagsPlcTagTableObjectList objectListField;

            private byte idField;

            /// <remarks/>
            public DocumentSWTagsPlcTagTableAttributeList AttributeList
            {
                get
                {
                    return this.attributeListField;
                }
                set
                {
                    this.attributeListField = value;
                }
            }

            /// <remarks/>
            public DocumentSWTagsPlcTagTableObjectList ObjectList
            {
                get
                {
                    return this.objectListField;
                }
                set
                {
                    this.objectListField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableAttributeList
        {

            private string nameField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectList
        {

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcTag sWTagsPlcTagField;

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstant[] sWTagsPlcUserConstantField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SW.Tags.PlcTag")]
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcTag SWTagsPlcTag
            {
                get
                {
                    return this.sWTagsPlcTagField;
                }
                set
                {
                    this.sWTagsPlcTagField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SW.Tags.PlcUserConstant")]
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstant[] SWTagsPlcUserConstant
            {
                get
                {
                    return this.sWTagsPlcUserConstantField;
                }
                set
                {
                    this.sWTagsPlcUserConstantField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcTag
        {

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagAttributeList attributeListField;

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectList objectListField;

            private byte idField;

            private string compositionNameField;

            /// <remarks/>
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagAttributeList AttributeList
            {
                get
                {
                    return this.attributeListField;
                }
                set
                {
                    this.attributeListField = value;
                }
            }

            /// <remarks/>
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectList ObjectList
            {
                get
                {
                    return this.objectListField;
                }
                set
                {
                    this.objectListField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string CompositionName
            {
                get
                {
                    return this.compositionNameField;
                }
                set
                {
                    this.compositionNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagAttributeList
        {

            private string dataTypeNameField;

            private bool externalAccessibleField;

            private bool externalVisibleField;

            private bool externalWritableField;

            private string logicalAddressField;

            private string nameField;

            /// <remarks/>
            public string DataTypeName
            {
                get
                {
                    return this.dataTypeNameField;
                }
                set
                {
                    this.dataTypeNameField = value;
                }
            }

            /// <remarks/>
            public bool ExternalAccessible
            {
                get
                {
                    return this.externalAccessibleField;
                }
                set
                {
                    this.externalAccessibleField = value;
                }
            }

            /// <remarks/>
            public bool ExternalVisible
            {
                get
                {
                    return this.externalVisibleField;
                }
                set
                {
                    this.externalVisibleField = value;
                }
            }

            /// <remarks/>
            public bool ExternalWritable
            {
                get
                {
                    return this.externalWritableField;
                }
                set
                {
                    this.externalWritableField = value;
                }
            }

            /// <remarks/>
            public string LogicalAddress
            {
                get
                {
                    return this.logicalAddressField;
                }
                set
                {
                    this.logicalAddressField = value;
                }
            }

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectList
        {

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectListMultilingualText multilingualTextField;

            /// <remarks/>
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectListMultilingualText MultilingualText
            {
                get
                {
                    return this.multilingualTextField;
                }
                set
                {
                    this.multilingualTextField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectListMultilingualText
        {

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectListMultilingualTextMultilingualTextItem[] objectListField;

            private byte idField;

            private string compositionNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("MultilingualTextItem", IsNullable = false)]
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectListMultilingualTextMultilingualTextItem[] ObjectList
            {
                get
                {
                    return this.objectListField;
                }
                set
                {
                    this.objectListField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string CompositionName
            {
                get
                {
                    return this.compositionNameField;
                }
                set
                {
                    this.compositionNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectListMultilingualTextMultilingualTextItem
        {

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectListMultilingualTextMultilingualTextItemAttributeList attributeListField;

            private byte idField;

            private string compositionNameField;

            /// <remarks/>
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectListMultilingualTextMultilingualTextItemAttributeList AttributeList
            {
                get
                {
                    return this.attributeListField;
                }
                set
                {
                    this.attributeListField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string CompositionName
            {
                get
                {
                    return this.compositionNameField;
                }
                set
                {
                    this.compositionNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcTagObjectListMultilingualTextMultilingualTextItemAttributeList
        {

            private string cultureField;

            private object textField;

            /// <remarks/>
            public string Culture
            {
                get
                {
                    return this.cultureField;
                }
                set
                {
                    this.cultureField = value;
                }
            }

            /// <remarks/>
            public object Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstant
        {

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantAttributeList attributeListField;

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectList objectListField;

            private string idField;

            private string compositionNameField;

            /// <remarks/>
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantAttributeList AttributeList
            {
                get
                {
                    return this.attributeListField;
                }
                set
                {
                    this.attributeListField = value;
                }
            }

            /// <remarks/>
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectList ObjectList
            {
                get
                {
                    return this.objectListField;
                }
                set
                {
                    this.objectListField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string CompositionName
            {
                get
                {
                    return this.compositionNameField;
                }
                set
                {
                    this.compositionNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantAttributeList
        {

            private string dataTypeNameField;

            private string nameField;

            private byte valueField;

            /// <remarks/>
            public string DataTypeName
            {
                get
                {
                    return this.dataTypeNameField;
                }
                set
                {
                    this.dataTypeNameField = value;
                }
            }

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public byte Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectList
        {

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectListMultilingualText multilingualTextField;

            /// <remarks/>
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectListMultilingualText MultilingualText
            {
                get
                {
                    return this.multilingualTextField;
                }
                set
                {
                    this.multilingualTextField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectListMultilingualText
        {

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectListMultilingualTextMultilingualTextItem[] objectListField;

            private string idField;

            private string compositionNameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("MultilingualTextItem", IsNullable = false)]
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectListMultilingualTextMultilingualTextItem[] ObjectList
            {
                get
                {
                    return this.objectListField;
                }
                set
                {
                    this.objectListField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string CompositionName
            {
                get
                {
                    return this.compositionNameField;
                }
                set
                {
                    this.compositionNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectListMultilingualTextMultilingualTextItem
        {

            private DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectListMultilingualTextMultilingualTextItemAttributeList attributeListField;

            private string idField;

            private string compositionNameField;

            /// <remarks/>
            public DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectListMultilingualTextMultilingualTextItemAttributeList AttributeList
            {
                get
                {
                    return this.attributeListField;
                }
                set
                {
                    this.attributeListField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ID
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string CompositionName
            {
                get
                {
                    return this.compositionNameField;
                }
                set
                {
                    this.compositionNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class DocumentSWTagsPlcTagTableObjectListSWTagsPlcUserConstantObjectListMultilingualTextMultilingualTextItemAttributeList
        {

            private string cultureField;

            private string textField;

            /// <remarks/>
            public string Culture
            {
                get
                {
                    return this.cultureField;
                }
                set
                {
                    this.cultureField = value;
                }
            }

            /// <remarks/>
            public string Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }


    }
}
