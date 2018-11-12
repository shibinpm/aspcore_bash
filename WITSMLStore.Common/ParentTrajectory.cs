using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "parentTrajectory", Namespace = "http://www.witsml.org/schemas/1series")]
    public class ParentTrajectory
    {
        [XmlElement(ElementName = "trajectoryReference", Namespace = "http://www.witsml.org/schemas/1series")]
        public TrajectoryReference TrajectoryReference { get; set; }
        [XmlElement(ElementName = "wellboreParent", Namespace = "http://www.witsml.org/schemas/1series")]
        public WellboreParent WellboreParent { get; set; }
    }
}
