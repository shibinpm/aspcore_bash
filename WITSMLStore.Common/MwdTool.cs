using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "mwdTool", Namespace = "http://www.witsml.org/schemas/131")]
    public class MwdTool
    {
        [XmlElement(ElementName = "flowrateMn", Namespace = "http://www.witsml.org/schemas/131")]
        public FlowrateMn FlowrateMn { get; set; }
        [XmlElement(ElementName = "flowrateMx", Namespace = "http://www.witsml.org/schemas/131")]
        public FlowrateMx FlowrateMx { get; set; }
        [XmlElement(ElementName = "tempMx", Namespace = "http://www.witsml.org/schemas/131")]
        public TempMx TempMx { get; set; }
        [XmlElement(ElementName = "idEquv", Namespace = "http://www.witsml.org/schemas/131")]
        public IdEquv IdEquv { get; set; }
        [XmlElement(ElementName = "sensor", Namespace = "http://www.witsml.org/schemas/131")]
        public Sensor Sensor { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
    }
}
