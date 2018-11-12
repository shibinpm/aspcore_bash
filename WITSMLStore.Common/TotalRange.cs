using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "totalRange", Namespace = "http://www.witsml.org/schemas/1series")]
    public class TotalRange
    {
        [XmlElement(ElementName = "min", Namespace = "http://www.witsml.org/schemas/1series")]
        public Min Min { get; set; }
        [XmlElement(ElementName = "max", Namespace = "http://www.witsml.org/schemas/1series")]
        public Max Max { get; set; }
        [XmlElement(ElementName = "minTime", Namespace = "http://www.witsml.org/schemas/1series")]
        public string MinTime { get; set; }
        [XmlElement(ElementName = "maxTime", Namespace = "http://www.witsml.org/schemas/1series")]
        public string MaxTime { get; set; }
    }
}
