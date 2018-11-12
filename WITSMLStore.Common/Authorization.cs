using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "authorization", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Authorization
    {
        [XmlElement(ElementName = "author", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Author { get; set; }
        [XmlElement(ElementName = "source", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Source { get; set; }
        [XmlElement(ElementName = "authority", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Authority { get; set; }
        [XmlElement(ElementName = "status", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Status { get; set; }
        [XmlElement(ElementName = "version", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Version { get; set; }
        [XmlElement(ElementName = "comment", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Comment { get; set; }
    }
}
