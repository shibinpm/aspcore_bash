using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "trajectoryParent", Namespace = "http://www.witsml.org/schemas/1series")]
    public class TrajectoryParent
    {
        [XmlAttribute(AttributeName = "uidRef")]
        public string UidRef { get; set; }
    }
}
