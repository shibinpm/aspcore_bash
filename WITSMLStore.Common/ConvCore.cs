using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "convCore", Namespace = "http://www.witsml.org/schemas/1series")]
    public class ConvCore
    {
        [XmlElement(ElementName = "nameWell", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NameWell { get; set; }
        [XmlElement(ElementName = "nameWellbore", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NameWellbore { get; set; }
        [XmlElement(ElementName = "name", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Name { get; set; }
        [XmlElement(ElementName = "mdCoreTop", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdCoreTop MdCoreTop { get; set; }
        [XmlElement(ElementName = "mdCoreBottom", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdCoreBottom MdCoreBottom { get; set; }
        [XmlElement(ElementName = "dTimCoreStart", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimCoreStart { get; set; }
        [XmlElement(ElementName = "dTimCoreEnd", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimCoreEnd { get; set; }
        [XmlElement(ElementName = "coreReference", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CoreReference { get; set; }
        [XmlElement(ElementName = "coringContractor", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CoringContractor { get; set; }
        [XmlElement(ElementName = "analysisContractor", Namespace = "http://www.witsml.org/schemas/1series")]
        public string AnalysisContractor { get; set; }
        [XmlElement(ElementName = "coreBarrel", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CoreBarrel { get; set; }
        [XmlElement(ElementName = "innerBarrelUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string InnerBarrelUsed { get; set; }
        [XmlElement(ElementName = "innerBarrelType", Namespace = "http://www.witsml.org/schemas/1series")]
        public string InnerBarrelType { get; set; }
        [XmlElement(ElementName = "lenBarrel", Namespace = "http://www.witsml.org/schemas/1series")]
        public LenBarrel LenBarrel { get; set; }
        [XmlElement(ElementName = "coreBitType", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CoreBitType { get; set; }
        [XmlElement(ElementName = "diaBit", Namespace = "http://www.witsml.org/schemas/1series")]
        public DiaBit DiaBit { get; set; }
        [XmlElement(ElementName = "diaCore", Namespace = "http://www.witsml.org/schemas/1series")]
        public DiaCore DiaCore { get; set; }
        [XmlElement(ElementName = "lenCored", Namespace = "http://www.witsml.org/schemas/1series")]
        public LenCored LenCored { get; set; }
        [XmlElement(ElementName = "lenRecovered", Namespace = "http://www.witsml.org/schemas/1series")]
        public LenRecovered LenRecovered { get; set; }
        [XmlElement(ElementName = "recoverPc", Namespace = "http://www.witsml.org/schemas/1series")]
        public RecoverPc RecoverPc { get; set; }
        [XmlElement(ElementName = "inclHole", Namespace = "http://www.witsml.org/schemas/1series")]
        public InclHole InclHole { get; set; }
        [XmlElement(ElementName = "coreOrientation", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CoreOrientation { get; set; }
        [XmlElement(ElementName = "coreMethod", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CoreMethod { get; set; }
        [XmlElement(ElementName = "coreTreatmentMethod", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CoreTreatmentMethod { get; set; }
        [XmlElement(ElementName = "coreFluidUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CoreFluidUsed { get; set; }
        [XmlElement(ElementName = "nameFormation", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NameFormation { get; set; }
        [XmlElement(ElementName = "geologyInterval", Namespace = "http://www.witsml.org/schemas/1series")]
        public GeologyInterval GeologyInterval { get; set; }
        [XmlElement(ElementName = "coreDescription", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CoreDescription { get; set; }
        [XmlElement(ElementName = "commonData", Namespace = "http://www.witsml.org/schemas/1series")]
        public CommonData CommonData { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CustomData { get; set; }
        [XmlAttribute(AttributeName = "uidWell")]
        public string UidWell { get; set; }
        [XmlAttribute(AttributeName = "uidWellbore")]
        public string UidWellbore { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
