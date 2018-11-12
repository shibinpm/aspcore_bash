using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "targets", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Targets
    {
        [XmlElement(ElementName = "target", Namespace = "http://www.witsml.org/schemas/1series")]
        public Target Target { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}
