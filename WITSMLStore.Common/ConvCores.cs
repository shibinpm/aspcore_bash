using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "convCores", Namespace = "http://www.witsml.org/schemas/1series")]
    public class ConvCores
    {
        [XmlElement(ElementName = "convCore", Namespace = "http://www.witsml.org/schemas/1series")]
        public ConvCore ConvCore { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}
