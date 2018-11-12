using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "tubulars", Namespace = "http://www.witsml.org/schemas/131")]
    public class Tubulars
    {
        [XmlElement(ElementName = "tubular", Namespace = "http://www.witsml.org/schemas/131")]
        public Tubular Tubular { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}
