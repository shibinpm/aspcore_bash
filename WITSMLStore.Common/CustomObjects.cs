using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "customObjects", Namespace = "http://www.witsml.org/schemas/1series")]
    public class CustomObjects
    {
        [XmlElement(ElementName = "customObject", Namespace = "http://www.witsml.org/schemas/1series")]
        public CustomObject CustomObject { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}
