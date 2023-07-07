
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

    private DocumentSWBlocksFC sWBlocksFCField;

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
    [System.Xml.Serialization.XmlElementAttribute("SW.Blocks.FC")]
    public DocumentSWBlocksFC SWBlocksFC
    {
        get
        {
            return this.sWBlocksFCField;
        }
        set
        {
            this.sWBlocksFCField = value;
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
public partial class DocumentSWBlocksFC
{

    private DocumentSWBlocksFCAttributeList attributeListField;

    private DocumentSWBlocksFCObjectList objectListField;

    private byte idField;

    /// <remarks/>
    public DocumentSWBlocksFCAttributeList AttributeList
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
    public DocumentSWBlocksFCObjectList ObjectList
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
public partial class DocumentSWBlocksFCAttributeList
{

    private bool autoNumberField;

    private DocumentSWBlocksFCAttributeListCodeModifiedDate codeModifiedDateField;

    private DocumentSWBlocksFCAttributeListCompileDate compileDateField;

    private DocumentSWBlocksFCAttributeListCreationDate creationDateField;

    private DocumentSWBlocksFCAttributeListHandleErrorsWithinBlock handleErrorsWithinBlockField;

    private object headerAuthorField;

    private object headerFamilyField;

    private object headerNameField;

    private decimal headerVersionField;

    private DocumentSWBlocksFCAttributeListInterface interfaceField;

    private DocumentSWBlocksFCAttributeListInterfaceModifiedDate interfaceModifiedDateField;

    private DocumentSWBlocksFCAttributeListIsConsistent isConsistentField;

    private bool isIECCheckEnabledField;

    private DocumentSWBlocksFCAttributeListIsKnowHowProtected isKnowHowProtectedField;

    private DocumentSWBlocksFCAttributeListIsWriteProtected isWriteProtectedField;

    private DocumentSWBlocksFCAttributeListLibraryConformanceStatus libraryConformanceStatusField;

    private string memoryLayoutField;

    private DocumentSWBlocksFCAttributeListModifiedDate modifiedDateField;

    private string nameField;

    private byte numberField;

    private DocumentSWBlocksFCAttributeListParameterModified parameterModifiedField;

    private DocumentSWBlocksFCAttributeListPLCSimAdvancedSupport pLCSimAdvancedSupportField;

    private string programmingLanguageField;

    private bool setENOAutomaticallyField;

    private DocumentSWBlocksFCAttributeListStructureModified structureModifiedField;

    private object uDABlockPropertiesField;

    private bool uDAEnableTagReadbackField;

    /// <remarks/>
    public bool AutoNumber
    {
        get
        {
            return this.autoNumberField;
        }
        set
        {
            this.autoNumberField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListCodeModifiedDate CodeModifiedDate
    {
        get
        {
            return this.codeModifiedDateField;
        }
        set
        {
            this.codeModifiedDateField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListCompileDate CompileDate
    {
        get
        {
            return this.compileDateField;
        }
        set
        {
            this.compileDateField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListCreationDate CreationDate
    {
        get
        {
            return this.creationDateField;
        }
        set
        {
            this.creationDateField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListHandleErrorsWithinBlock HandleErrorsWithinBlock
    {
        get
        {
            return this.handleErrorsWithinBlockField;
        }
        set
        {
            this.handleErrorsWithinBlockField = value;
        }
    }

    /// <remarks/>
    public object HeaderAuthor
    {
        get
        {
            return this.headerAuthorField;
        }
        set
        {
            this.headerAuthorField = value;
        }
    }

    /// <remarks/>
    public object HeaderFamily
    {
        get
        {
            return this.headerFamilyField;
        }
        set
        {
            this.headerFamilyField = value;
        }
    }

    /// <remarks/>
    public object HeaderName
    {
        get
        {
            return this.headerNameField;
        }
        set
        {
            this.headerNameField = value;
        }
    }

    /// <remarks/>
    public decimal HeaderVersion
    {
        get
        {
            return this.headerVersionField;
        }
        set
        {
            this.headerVersionField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListInterface Interface
    {
        get
        {
            return this.interfaceField;
        }
        set
        {
            this.interfaceField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListInterfaceModifiedDate InterfaceModifiedDate
    {
        get
        {
            return this.interfaceModifiedDateField;
        }
        set
        {
            this.interfaceModifiedDateField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListIsConsistent IsConsistent
    {
        get
        {
            return this.isConsistentField;
        }
        set
        {
            this.isConsistentField = value;
        }
    }

    /// <remarks/>
    public bool IsIECCheckEnabled
    {
        get
        {
            return this.isIECCheckEnabledField;
        }
        set
        {
            this.isIECCheckEnabledField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListIsKnowHowProtected IsKnowHowProtected
    {
        get
        {
            return this.isKnowHowProtectedField;
        }
        set
        {
            this.isKnowHowProtectedField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListIsWriteProtected IsWriteProtected
    {
        get
        {
            return this.isWriteProtectedField;
        }
        set
        {
            this.isWriteProtectedField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListLibraryConformanceStatus LibraryConformanceStatus
    {
        get
        {
            return this.libraryConformanceStatusField;
        }
        set
        {
            this.libraryConformanceStatusField = value;
        }
    }

    /// <remarks/>
    public string MemoryLayout
    {
        get
        {
            return this.memoryLayoutField;
        }
        set
        {
            this.memoryLayoutField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListModifiedDate ModifiedDate
    {
        get
        {
            return this.modifiedDateField;
        }
        set
        {
            this.modifiedDateField = value;
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
    public byte Number
    {
        get
        {
            return this.numberField;
        }
        set
        {
            this.numberField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListParameterModified ParameterModified
    {
        get
        {
            return this.parameterModifiedField;
        }
        set
        {
            this.parameterModifiedField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListPLCSimAdvancedSupport PLCSimAdvancedSupport
    {
        get
        {
            return this.pLCSimAdvancedSupportField;
        }
        set
        {
            this.pLCSimAdvancedSupportField = value;
        }
    }

    /// <remarks/>
    public string ProgrammingLanguage
    {
        get
        {
            return this.programmingLanguageField;
        }
        set
        {
            this.programmingLanguageField = value;
        }
    }

    /// <remarks/>
    public bool SetENOAutomatically
    {
        get
        {
            return this.setENOAutomaticallyField;
        }
        set
        {
            this.setENOAutomaticallyField = value;
        }
    }

    /// <remarks/>
    public DocumentSWBlocksFCAttributeListStructureModified StructureModified
    {
        get
        {
            return this.structureModifiedField;
        }
        set
        {
            this.structureModifiedField = value;
        }
    }

    /// <remarks/>
    public object UDABlockProperties
    {
        get
        {
            return this.uDABlockPropertiesField;
        }
        set
        {
            this.uDABlockPropertiesField = value;
        }
    }

    /// <remarks/>
    public bool UDAEnableTagReadback
    {
        get
        {
            return this.uDAEnableTagReadbackField;
        }
        set
        {
            this.uDAEnableTagReadbackField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DocumentSWBlocksFCAttributeListCodeModifiedDate
{

    private bool readOnlyField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public System.DateTime Value
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
public partial class DocumentSWBlocksFCAttributeListCompileDate
{

    private bool readOnlyField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public System.DateTime Value
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
public partial class DocumentSWBlocksFCAttributeListCreationDate
{

    private bool readOnlyField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public System.DateTime Value
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
public partial class DocumentSWBlocksFCAttributeListHandleErrorsWithinBlock
{

    private bool readOnlyField;

    private bool valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public bool Value
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
public partial class DocumentSWBlocksFCAttributeListInterface
{

    private SectionsSection[] sectionsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v4")]
    [System.Xml.Serialization.XmlArrayItemAttribute("Section", IsNullable = false)]
    public SectionsSection[] Sections
    {
        get
        {
            return this.sectionsField;
        }
        set
        {
            this.sectionsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v4")]
public partial class SectionsSection
{

    private SectionsSectionMember[] memberField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Member")]
    public SectionsSectionMember[] Member
    {
        get
        {
            return this.memberField;
        }
        set
        {
            this.memberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v4")]
public partial class SectionsSectionMember
{

    private SectionsSectionMemberMember[] memberField;

    private string nameField;

    private string datatypeField;

    private string accessibilityField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Member")]
    public SectionsSectionMemberMember[] Member
    {
        get
        {
            return this.memberField;
        }
        set
        {
            this.memberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Datatype
    {
        get
        {
            return this.datatypeField;
        }
        set
        {
            this.datatypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Accessibility
    {
        get
        {
            return this.accessibilityField;
        }
        set
        {
            this.accessibilityField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v4")]
public partial class SectionsSectionMemberMember
{

    private string nameField;

    private string datatypeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Datatype
    {
        get
        {
            return this.datatypeField;
        }
        set
        {
            this.datatypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DocumentSWBlocksFCAttributeListInterfaceModifiedDate
{

    private bool readOnlyField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public System.DateTime Value
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
public partial class DocumentSWBlocksFCAttributeListIsConsistent
{

    private bool readOnlyField;

    private bool valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public bool Value
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
public partial class DocumentSWBlocksFCAttributeListIsKnowHowProtected
{

    private bool readOnlyField;

    private bool valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public bool Value
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
public partial class DocumentSWBlocksFCAttributeListIsWriteProtected
{

    private bool readOnlyField;

    private bool valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public bool Value
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
public partial class DocumentSWBlocksFCAttributeListLibraryConformanceStatus
{

    private bool readOnlyField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
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
public partial class DocumentSWBlocksFCAttributeListModifiedDate
{

    private bool readOnlyField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public System.DateTime Value
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
public partial class DocumentSWBlocksFCAttributeListParameterModified
{

    private bool readOnlyField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public System.DateTime Value
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
public partial class DocumentSWBlocksFCAttributeListPLCSimAdvancedSupport
{

    private bool readOnlyField;

    private bool valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public bool Value
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
public partial class DocumentSWBlocksFCAttributeListStructureModified
{

    private bool readOnlyField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool ReadOnly
    {
        get
        {
            return this.readOnlyField;
        }
        set
        {
            this.readOnlyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public System.DateTime Value
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
public partial class DocumentSWBlocksFCObjectList
{

    private object[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MultilingualText", typeof(DocumentSWBlocksFCObjectListMultilingualText))]
    [System.Xml.Serialization.XmlElementAttribute("SW.Blocks.CompileUnit", typeof(DocumentSWBlocksFCObjectListSWBlocksCompileUnit))]
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
public partial class DocumentSWBlocksFCObjectListMultilingualText
{

    private DocumentSWBlocksFCObjectListMultilingualTextMultilingualTextItem[] objectListField;

    private byte idField;

    private string compositionNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("MultilingualTextItem", IsNullable = false)]
    public DocumentSWBlocksFCObjectListMultilingualTextMultilingualTextItem[] ObjectList
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
public partial class DocumentSWBlocksFCObjectListMultilingualTextMultilingualTextItem
{

    private DocumentSWBlocksFCObjectListMultilingualTextMultilingualTextItemAttributeList attributeListField;

    private byte idField;

    private string compositionNameField;

    /// <remarks/>
    public DocumentSWBlocksFCObjectListMultilingualTextMultilingualTextItemAttributeList AttributeList
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
public partial class DocumentSWBlocksFCObjectListMultilingualTextMultilingualTextItemAttributeList
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
public partial class DocumentSWBlocksFCObjectListSWBlocksCompileUnit
{

    private DocumentSWBlocksFCObjectListSWBlocksCompileUnitAttributeList attributeListField;

    private DocumentSWBlocksFCObjectListSWBlocksCompileUnitMultilingualText[] objectListField;

    private string idField;

    private string compositionNameField;

    /// <remarks/>
    public DocumentSWBlocksFCObjectListSWBlocksCompileUnitAttributeList AttributeList
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
    [System.Xml.Serialization.XmlArrayItemAttribute("MultilingualText", IsNullable = false)]
    public DocumentSWBlocksFCObjectListSWBlocksCompileUnitMultilingualText[] ObjectList
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
public partial class DocumentSWBlocksFCObjectListSWBlocksCompileUnitAttributeList
{

    private DocumentSWBlocksFCObjectListSWBlocksCompileUnitAttributeListNetworkSource networkSourceField;

    private string programmingLanguageField;

    /// <remarks/>
    public DocumentSWBlocksFCObjectListSWBlocksCompileUnitAttributeListNetworkSource NetworkSource
    {
        get
        {
            return this.networkSourceField;
        }
        set
        {
            this.networkSourceField = value;
        }
    }

    /// <remarks/>
    public string ProgrammingLanguage
    {
        get
        {
            return this.programmingLanguageField;
        }
        set
        {
            this.programmingLanguageField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DocumentSWBlocksFCObjectListSWBlocksCompileUnitAttributeListNetworkSource
{

    private StructuredText structuredTextField;

    private FlgNet flgNetField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
    public StructuredText StructuredText
    {
        get
        {
            return this.structuredTextField;
        }
        set
        {
            this.structuredTextField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
    public FlgNet FlgNet
    {
        get
        {
            return this.flgNetField;
        }
        set
        {
            this.flgNetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3", IsNullable = false)]
public partial class StructuredText
{

    private object[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Access", typeof(StructuredTextAccess))]
    [System.Xml.Serialization.XmlElementAttribute("Blank", typeof(StructuredTextBlank))]
    [System.Xml.Serialization.XmlElementAttribute("LineComment", typeof(StructuredTextLineComment))]
    [System.Xml.Serialization.XmlElementAttribute("NewLine", typeof(StructuredTextNewLine))]
    [System.Xml.Serialization.XmlElementAttribute("Token", typeof(StructuredTextToken))]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextAccess
{

    private StructuredTextAccessSymbol symbolField;

    private string scopeField;

    private byte uIdField;

    /// <remarks/>
    public StructuredTextAccessSymbol Symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Scope
    {
        get
        {
            return this.scopeField;
        }
        set
        {
            this.scopeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextAccessSymbol
{

    private object[] itemsField;

    private byte uIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Address", typeof(StructuredTextAccessSymbolAddress))]
    [System.Xml.Serialization.XmlElementAttribute("Component", typeof(StructuredTextAccessSymbolComponent))]
    [System.Xml.Serialization.XmlElementAttribute("Token", typeof(StructuredTextAccessSymbolToken))]
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextAccessSymbolAddress
{

    private string areaField;

    private string typeField;

    private ushort bitOffsetField;

    private bool informativeField;

    private byte blockNumberField;

    private bool blockNumberFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Area
    {
        get
        {
            return this.areaField;
        }
        set
        {
            this.areaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort BitOffset
    {
        get
        {
            return this.bitOffsetField;
        }
        set
        {
            this.bitOffsetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Informative
    {
        get
        {
            return this.informativeField;
        }
        set
        {
            this.informativeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte BlockNumber
    {
        get
        {
            return this.blockNumberField;
        }
        set
        {
            this.blockNumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BlockNumberSpecified
    {
        get
        {
            return this.blockNumberFieldSpecified;
        }
        set
        {
            this.blockNumberFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextAccessSymbolComponent
{

    private object[] itemsField;

    private string nameField;

    private byte uIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Access", typeof(StructuredTextAccessSymbolComponentAccess))]
    [System.Xml.Serialization.XmlElementAttribute("Token", typeof(StructuredTextAccessSymbolComponentToken))]
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextAccessSymbolComponentAccess
{

    private StructuredTextAccessSymbolComponentAccessConstant constantField;

    private string scopeField;

    private byte uIdField;

    /// <remarks/>
    public StructuredTextAccessSymbolComponentAccessConstant Constant
    {
        get
        {
            return this.constantField;
        }
        set
        {
            this.constantField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Scope
    {
        get
        {
            return this.scopeField;
        }
        set
        {
            this.scopeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextAccessSymbolComponentAccessConstant
{

    private StructuredTextAccessSymbolComponentAccessConstantConstantType constantTypeField;

    private StructuredTextAccessSymbolComponentAccessConstantConstantValue constantValueField;

    private byte uIdField;

    /// <remarks/>
    public StructuredTextAccessSymbolComponentAccessConstantConstantType ConstantType
    {
        get
        {
            return this.constantTypeField;
        }
        set
        {
            this.constantTypeField = value;
        }
    }

    /// <remarks/>
    public StructuredTextAccessSymbolComponentAccessConstantConstantValue ConstantValue
    {
        get
        {
            return this.constantValueField;
        }
        set
        {
            this.constantValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextAccessSymbolComponentAccessConstantConstantType
{

    private bool informativeField;

    private byte uIdField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Informative
    {
        get
        {
            return this.informativeField;
        }
        set
        {
            this.informativeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextAccessSymbolComponentAccessConstantConstantValue
{

    private byte uIdField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextAccessSymbolComponentToken
{

    private string textField;

    private byte uIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextAccessSymbolToken
{

    private string textField;

    private byte uIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextBlank
{

    private byte numField;

    private byte uIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Num
    {
        get
        {
            return this.numField;
        }
        set
        {
            this.numField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextLineComment
{

    private StructuredTextLineCommentText textField;

    private bool insertedField;

    private bool noClosingBracketField;

    private byte uIdField;

    /// <remarks/>
    public StructuredTextLineCommentText Text
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Inserted
    {
        get
        {
            return this.insertedField;
        }
        set
        {
            this.insertedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool NoClosingBracket
    {
        get
        {
            return this.noClosingBracketField;
        }
        set
        {
            this.noClosingBracketField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextLineCommentText
{

    private byte uIdField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextNewLine
{

    private byte numField;

    private byte uIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Num
    {
        get
        {
            return this.numField;
        }
        set
        {
            this.numField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/StructuredText/v3")]
public partial class StructuredTextToken
{

    private string textField;

    private byte uIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4", IsNullable = false)]
public partial class FlgNet
{

    private FlgNetParts partsField;

    private FlgNetWire[] wiresField;

    /// <remarks/>
    public FlgNetParts Parts
    {
        get
        {
            return this.partsField;
        }
        set
        {
            this.partsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Wire", IsNullable = false)]
    public FlgNetWire[] Wires
    {
        get
        {
            return this.wiresField;
        }
        set
        {
            this.wiresField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetParts
{

    private FlgNetPartsAccess[] accessField;

    private FlgNetPartsCall callField;

    private FlgNetPartsPart[] partField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Access")]
    public FlgNetPartsAccess[] Access
    {
        get
        {
            return this.accessField;
        }
        set
        {
            this.accessField = value;
        }
    }

    /// <remarks/>
    public FlgNetPartsCall Call
    {
        get
        {
            return this.callField;
        }
        set
        {
            this.callField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Part")]
    public FlgNetPartsPart[] Part
    {
        get
        {
            return this.partField;
        }
        set
        {
            this.partField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsAccess
{

    private FlgNetPartsAccessConstant constantField;

    private FlgNetPartsAccessSymbol symbolField;

    private string scopeField;

    private byte uIdField;

    /// <remarks/>
    public FlgNetPartsAccessConstant Constant
    {
        get
        {
            return this.constantField;
        }
        set
        {
            this.constantField = value;
        }
    }

    /// <remarks/>
    public FlgNetPartsAccessSymbol Symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Scope
    {
        get
        {
            return this.scopeField;
        }
        set
        {
            this.scopeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsAccessConstant
{

    private FlgNetPartsAccessConstantConstantType constantTypeField;

    private FlgNetPartsAccessConstantConstantValue constantValueField;

    private FlgNetPartsAccessConstantStringAttribute stringAttributeField;

    private string nameField;

    /// <remarks/>
    public FlgNetPartsAccessConstantConstantType ConstantType
    {
        get
        {
            return this.constantTypeField;
        }
        set
        {
            this.constantTypeField = value;
        }
    }

    /// <remarks/>
    public FlgNetPartsAccessConstantConstantValue ConstantValue
    {
        get
        {
            return this.constantValueField;
        }
        set
        {
            this.constantValueField = value;
        }
    }

    /// <remarks/>
    public FlgNetPartsAccessConstantStringAttribute StringAttribute
    {
        get
        {
            return this.stringAttributeField;
        }
        set
        {
            this.stringAttributeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsAccessConstantConstantType
{

    private bool informativeField;

    private bool informativeFieldSpecified;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Informative
    {
        get
        {
            return this.informativeField;
        }
        set
        {
            this.informativeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool InformativeSpecified
    {
        get
        {
            return this.informativeFieldSpecified;
        }
        set
        {
            this.informativeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsAccessConstantConstantValue
{

    private bool informativeField;

    private bool informativeFieldSpecified;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Informative
    {
        get
        {
            return this.informativeField;
        }
        set
        {
            this.informativeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool InformativeSpecified
    {
        get
        {
            return this.informativeFieldSpecified;
        }
        set
        {
            this.informativeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsAccessConstantStringAttribute
{

    private string nameField;

    private bool informativeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Informative
    {
        get
        {
            return this.informativeField;
        }
        set
        {
            this.informativeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsAccessSymbol
{

    private FlgNetPartsAccessSymbolComponent[] componentField;

    private FlgNetPartsAccessSymbolAddress addressField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Component")]
    public FlgNetPartsAccessSymbolComponent[] Component
    {
        get
        {
            return this.componentField;
        }
        set
        {
            this.componentField = value;
        }
    }

    /// <remarks/>
    public FlgNetPartsAccessSymbolAddress Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsAccessSymbolComponent
{

    private FlgNetPartsAccessSymbolComponentAccess accessField;

    private string nameField;

    private string accessModifierField;

    /// <remarks/>
    public FlgNetPartsAccessSymbolComponentAccess Access
    {
        get
        {
            return this.accessField;
        }
        set
        {
            this.accessField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string AccessModifier
    {
        get
        {
            return this.accessModifierField;
        }
        set
        {
            this.accessModifierField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsAccessSymbolComponentAccess
{

    private FlgNetPartsAccessSymbolComponentAccessSymbol symbolField;

    private string scopeField;

    /// <remarks/>
    public FlgNetPartsAccessSymbolComponentAccessSymbol Symbol
    {
        get
        {
            return this.symbolField;
        }
        set
        {
            this.symbolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Scope
    {
        get
        {
            return this.scopeField;
        }
        set
        {
            this.scopeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsAccessSymbolComponentAccessSymbol
{

    private FlgNetPartsAccessSymbolComponentAccessSymbolComponent componentField;

    /// <remarks/>
    public FlgNetPartsAccessSymbolComponentAccessSymbolComponent Component
    {
        get
        {
            return this.componentField;
        }
        set
        {
            this.componentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsAccessSymbolComponentAccessSymbolComponent
{

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsAccessSymbolAddress
{

    private string areaField;

    private string typeField;

    private ushort blockNumberField;

    private bool blockNumberFieldSpecified;

    private ushort bitOffsetField;

    private bool informativeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Area
    {
        get
        {
            return this.areaField;
        }
        set
        {
            this.areaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort BlockNumber
    {
        get
        {
            return this.blockNumberField;
        }
        set
        {
            this.blockNumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool BlockNumberSpecified
    {
        get
        {
            return this.blockNumberFieldSpecified;
        }
        set
        {
            this.blockNumberFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort BitOffset
    {
        get
        {
            return this.bitOffsetField;
        }
        set
        {
            this.bitOffsetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Informative
    {
        get
        {
            return this.informativeField;
        }
        set
        {
            this.informativeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsCall
{

    private FlgNetPartsCallCallInfo callInfoField;

    private byte uIdField;

    /// <remarks/>
    public FlgNetPartsCallCallInfo CallInfo
    {
        get
        {
            return this.callInfoField;
        }
        set
        {
            this.callInfoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsCallCallInfo
{

    private FlgNetPartsCallCallInfoIntegerAttribute integerAttributeField;

    private FlgNetPartsCallCallInfoDateAttribute dateAttributeField;

    private FlgNetPartsCallCallInfoInstance instanceField;

    private FlgNetPartsCallCallInfoParameter[] parameterField;

    private string nameField;

    private string blockTypeField;

    /// <remarks/>
    public FlgNetPartsCallCallInfoIntegerAttribute IntegerAttribute
    {
        get
        {
            return this.integerAttributeField;
        }
        set
        {
            this.integerAttributeField = value;
        }
    }

    /// <remarks/>
    public FlgNetPartsCallCallInfoDateAttribute DateAttribute
    {
        get
        {
            return this.dateAttributeField;
        }
        set
        {
            this.dateAttributeField = value;
        }
    }

    /// <remarks/>
    public FlgNetPartsCallCallInfoInstance Instance
    {
        get
        {
            return this.instanceField;
        }
        set
        {
            this.instanceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Parameter")]
    public FlgNetPartsCallCallInfoParameter[] Parameter
    {
        get
        {
            return this.parameterField;
        }
        set
        {
            this.parameterField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string BlockType
    {
        get
        {
            return this.blockTypeField;
        }
        set
        {
            this.blockTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsCallCallInfoIntegerAttribute
{

    private string nameField;

    private bool informativeField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Informative
    {
        get
        {
            return this.informativeField;
        }
        set
        {
            this.informativeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsCallCallInfoDateAttribute
{

    private string nameField;

    private bool informativeField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Informative
    {
        get
        {
            return this.informativeField;
        }
        set
        {
            this.informativeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public System.DateTime Value
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsCallCallInfoInstance
{

    private FlgNetPartsCallCallInfoInstanceComponent componentField;

    private FlgNetPartsCallCallInfoInstanceAddress addressField;

    private string scopeField;

    private byte uIdField;

    /// <remarks/>
    public FlgNetPartsCallCallInfoInstanceComponent Component
    {
        get
        {
            return this.componentField;
        }
        set
        {
            this.componentField = value;
        }
    }

    /// <remarks/>
    public FlgNetPartsCallCallInfoInstanceAddress Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Scope
    {
        get
        {
            return this.scopeField;
        }
        set
        {
            this.scopeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsCallCallInfoInstanceComponent
{

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsCallCallInfoInstanceAddress
{

    private string areaField;

    private string typeField;

    private byte blockNumberField;

    private byte bitOffsetField;

    private bool informativeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Area
    {
        get
        {
            return this.areaField;
        }
        set
        {
            this.areaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte BlockNumber
    {
        get
        {
            return this.blockNumberField;
        }
        set
        {
            this.blockNumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte BitOffset
    {
        get
        {
            return this.bitOffsetField;
        }
        set
        {
            this.bitOffsetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Informative
    {
        get
        {
            return this.informativeField;
        }
        set
        {
            this.informativeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsCallCallInfoParameter
{

    private FlgNetPartsCallCallInfoParameterStringAttribute stringAttributeField;

    private string nameField;

    private string sectionField;

    private string typeField;

    /// <remarks/>
    public FlgNetPartsCallCallInfoParameterStringAttribute StringAttribute
    {
        get
        {
            return this.stringAttributeField;
        }
        set
        {
            this.stringAttributeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Section
    {
        get
        {
            return this.sectionField;
        }
        set
        {
            this.sectionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsCallCallInfoParameterStringAttribute
{

    private string nameField;

    private bool informativeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool Informative
    {
        get
        {
            return this.informativeField;
        }
        set
        {
            this.informativeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsPart
{

    private FlgNetPartsPartTemplateValue templateValueField;

    private string nameField;

    private byte uIdField;

    private bool disabledENOField;

    private bool disabledENOFieldSpecified;

    /// <remarks/>
    public FlgNetPartsPartTemplateValue TemplateValue
    {
        get
        {
            return this.templateValueField;
        }
        set
        {
            this.templateValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool DisabledENO
    {
        get
        {
            return this.disabledENOField;
        }
        set
        {
            this.disabledENOField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DisabledENOSpecified
    {
        get
        {
            return this.disabledENOFieldSpecified;
        }
        set
        {
            this.disabledENOFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetPartsPartTemplateValue
{

    private string nameField;

    private string typeField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetWire
{

    private object[] itemsField;

    private byte uIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("IdentCon", typeof(FlgNetWireIdentCon))]
    [System.Xml.Serialization.XmlElementAttribute("NameCon", typeof(FlgNetWireNameCon))]
    [System.Xml.Serialization.XmlElementAttribute("OpenCon", typeof(FlgNetWireOpenCon))]
    [System.Xml.Serialization.XmlElementAttribute("Powerrail", typeof(object))]
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetWireIdentCon
{

    private byte uIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetWireNameCon
{

    private byte uIdField;

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/NetworkSource/FlgNet/v4")]
public partial class FlgNetWireOpenCon
{

    private byte uIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UId
    {
        get
        {
            return this.uIdField;
        }
        set
        {
            this.uIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class DocumentSWBlocksFCObjectListSWBlocksCompileUnitMultilingualText
{

    private DocumentSWBlocksFCObjectListSWBlocksCompileUnitMultilingualTextMultilingualTextItem[] objectListField;

    private string idField;

    private string compositionNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("MultilingualTextItem", IsNullable = false)]
    public DocumentSWBlocksFCObjectListSWBlocksCompileUnitMultilingualTextMultilingualTextItem[] ObjectList
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
public partial class DocumentSWBlocksFCObjectListSWBlocksCompileUnitMultilingualTextMultilingualTextItem
{

    private DocumentSWBlocksFCObjectListSWBlocksCompileUnitMultilingualTextMultilingualTextItemAttributeList attributeListField;

    private string idField;

    private string compositionNameField;

    /// <remarks/>
    public DocumentSWBlocksFCObjectListSWBlocksCompileUnitMultilingualTextMultilingualTextItemAttributeList AttributeList
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
public partial class DocumentSWBlocksFCObjectListSWBlocksCompileUnitMultilingualTextMultilingualTextItemAttributeList
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v4")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.siemens.com/automation/Openness/SW/Interface/v4", IsNullable = false)]
public partial class Sections
{

    private SectionsSection[] sectionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Section")]
    public SectionsSection[] Section
    {
        get
        {
            return this.sectionField;
        }
        set
        {
            this.sectionField = value;
        }
    }
}

