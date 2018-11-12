using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "toolErrorTermSets", Namespace = "http://www.witsml.org/schemas/1series")]
    public class ToolErrorTermSets
    {
        [XmlElement(ElementName = "toolErrorTermSet", Namespace = "http://www.witsml.org/schemas/1series")]
        public ToolErrorTermSet ToolErrorTermSet { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}
