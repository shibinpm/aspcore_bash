using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "trajectory", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Trajectory
    {
        [XmlElement(ElementName = "nameWell", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NameWell { get; set; }
        [XmlElement(ElementName = "nameWellbore", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NameWellbore { get; set; }
        [XmlElement(ElementName = "name", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Name { get; set; }
        [XmlElement(ElementName = "objectGrowing", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ObjectGrowing { get; set; }
        [XmlElement(ElementName = "parentTrajectory", Namespace = "http://www.witsml.org/schemas/1series")]
        public ParentTrajectory ParentTrajectory { get; set; }
        [XmlElement(ElementName = "dTimTrajStart", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimTrajStart { get; set; }
        [XmlElement(ElementName = "dTimTrajEnd", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimTrajEnd { get; set; }
        [XmlElement(ElementName = "mdMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdMn MdMn { get; set; }
        [XmlElement(ElementName = "mdMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdMx MdMx { get; set; }
        [XmlElement(ElementName = "serviceCompany", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ServiceCompany { get; set; }
        [XmlElement(ElementName = "magDeclUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagDeclUsed MagDeclUsed { get; set; }
        [XmlElement(ElementName = "gridCorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public GridCorUsed GridCorUsed { get; set; }
        [XmlElement(ElementName = "gridConUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public GridConUsed GridConUsed { get; set; }
        [XmlElement(ElementName = "aziVertSect", Namespace = "http://www.witsml.org/schemas/1series")]
        public AziVertSect AziVertSect { get; set; }
        [XmlElement(ElementName = "dispNsVertSectOrig", Namespace = "http://www.witsml.org/schemas/1series")]
        public DispNsVertSectOrig DispNsVertSectOrig { get; set; }
        [XmlElement(ElementName = "dispEwVertSectOrig", Namespace = "http://www.witsml.org/schemas/1series")]
        public DispEwVertSectOrig DispEwVertSectOrig { get; set; }
        [XmlElement(ElementName = "definitive", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Definitive { get; set; }
        [XmlElement(ElementName = "memory", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Memory { get; set; }
        [XmlElement(ElementName = "finalTraj", Namespace = "http://www.witsml.org/schemas/1series")]
        public string FinalTraj { get; set; }
        [XmlElement(ElementName = "aziRef", Namespace = "http://www.witsml.org/schemas/1series")]
        public string AziRef { get; set; }
        [XmlElement(ElementName = "trajectoryStation", Namespace = "http://www.witsml.org/schemas/1series")]
        public TrajectoryStation TrajectoryStation { get; set; }
        [XmlElement(ElementName = "commonData", Namespace = "http://www.witsml.org/schemas/1series")]
        public CommonData CommonData { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CustomData { get; set; }
        [XmlAttribute(AttributeName = "uidWell")]
        public string UidWell { get; set; }
        [XmlAttribute(AttributeName = "uidWellbore")]
        public string UidWellbore { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
