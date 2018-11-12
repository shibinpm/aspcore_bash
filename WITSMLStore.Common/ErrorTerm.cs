using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "errorTerm", Namespace = "http://www.witsml.org/schemas/1series")]
    public class ErrorTerm
    {
        [XmlElement(ElementName = "name", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Name { get; set; }
        [XmlElement(ElementName = "type", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Type { get; set; }
        [XmlElement(ElementName = "measureClass", Namespace = "http://www.witsml.org/schemas/1series")]
        public string MeasureClass { get; set; }
        [XmlElement(ElementName = "label", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Label { get; set; }
        [XmlElement(ElementName = "description", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Description { get; set; }
        [XmlElement(ElementName = "errorCoefficient", Namespace = "http://www.witsml.org/schemas/1series")]
        public ErrorCoefficient ErrorCoefficient { get; set; }
        [XmlElement(ElementName = "operatingMode", Namespace = "http://www.witsml.org/schemas/1series")]
        public string OperatingMode { get; set; }
        [XmlElement(ElementName = "extensionNameValue", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionNameValue { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
