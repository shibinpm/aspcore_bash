using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "toolErrorTermSet", Namespace = "http://www.witsml.org/schemas/1series")]
    public class ToolErrorTermSet
    {
        [XmlElement(ElementName = "name", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Name { get; set; }
        [XmlElement(ElementName = "authorization", Namespace = "http://www.witsml.org/schemas/1series")]
        public Authorization Authorization { get; set; }
        [XmlElement(ElementName = "nomenclature", Namespace = "http://www.witsml.org/schemas/1series")]
        public Nomenclature Nomenclature { get; set; }
        [XmlElement(ElementName = "errorTerm", Namespace = "http://www.witsml.org/schemas/1series")]
        public ErrorTerm ErrorTerm { get; set; }
        [XmlElement(ElementName = "commonData", Namespace = "http://www.witsml.org/schemas/1series")]
        public CommonData CommonData { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CustomData { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
