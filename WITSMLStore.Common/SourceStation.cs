using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "sourceStation", Namespace = "http://www.witsml.org/schemas/1series")]
    public class SourceStation
    {
        [XmlElement(ElementName = "stationReference", Namespace = "http://www.witsml.org/schemas/1series")]
        public string StationReference { get; set; }
        [XmlElement(ElementName = "trajectoryParent", Namespace = "http://www.witsml.org/schemas/1series")]
        public TrajectoryParent TrajectoryParent { get; set; }
        [XmlElement(ElementName = "wellboreParent", Namespace = "http://www.witsml.org/schemas/1series")]
        public WellboreParent WellboreParent { get; set; }
    }
}
