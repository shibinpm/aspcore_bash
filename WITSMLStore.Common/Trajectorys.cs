using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "trajectorys", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Trajectorys
    {
        [XmlElement(ElementName = "trajectory", Namespace = "http://www.witsml.org/schemas/1series")]
        public Trajectory Trajectory { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}
