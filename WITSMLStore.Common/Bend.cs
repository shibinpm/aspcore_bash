using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "bend", Namespace = "http://www.witsml.org/schemas/131")]
    public class Bend
    {
        [XmlElement(ElementName = "angle", Namespace = "http://www.witsml.org/schemas/131")]
        public Angle Angle { get; set; }
        [XmlElement(ElementName = "distBendBot", Namespace = "http://www.witsml.org/schemas/131")]
        public DistBendBot DistBendBot { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
