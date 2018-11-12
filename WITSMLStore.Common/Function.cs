using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "function", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Function
    {
        [XmlElement(ElementName = "name", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Name { get; set; }
        [XmlElement(ElementName = "description", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Description { get; set; }
        [XmlElement(ElementName = "extensionNameValue", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionNameValue { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
