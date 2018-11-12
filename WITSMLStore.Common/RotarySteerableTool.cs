using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "rotarySteerableTool", Namespace = "http://www.witsml.org/schemas/131")]
    public class RotarySteerableTool
    {
        [XmlElement(ElementName = "deflectionMethod", Namespace = "http://www.witsml.org/schemas/131")]
        public string DeflectionMethod { get; set; }
        [XmlElement(ElementName = "bendAngle", Namespace = "http://www.witsml.org/schemas/131")]
        public BendAngle BendAngle { get; set; }
        [XmlElement(ElementName = "bendOffset", Namespace = "http://www.witsml.org/schemas/131")]
        public BendOffset BendOffset { get; set; }
        [XmlElement(ElementName = "holeSizeMn", Namespace = "http://www.witsml.org/schemas/131")]
        public HoleSizeMn HoleSizeMn { get; set; }
        [XmlElement(ElementName = "holeSizeMx", Namespace = "http://www.witsml.org/schemas/131")]
        public HoleSizeMx HoleSizeMx { get; set; }
        [XmlElement(ElementName = "wobMx", Namespace = "http://www.witsml.org/schemas/131")]
        public WobMx WobMx { get; set; }
        [XmlElement(ElementName = "operatingSpeed", Namespace = "http://www.witsml.org/schemas/131")]
        public OperatingSpeed OperatingSpeed { get; set; }
        [XmlElement(ElementName = "speedMx", Namespace = "http://www.witsml.org/schemas/131")]
        public SpeedMx SpeedMx { get; set; }
        [XmlElement(ElementName = "flowRateMn", Namespace = "http://www.witsml.org/schemas/131")]
        //public FlowRateMn FlowRateMn { get; set; }
        //[XmlElement(ElementName = "flowRateMx", Namespace = "http://www.witsml.org/schemas/131")]
        //public FlowRateMx FlowRateMx { get; set; }
        //[XmlElement(ElementName = "downLinkFlowRateMn", Namespace = "http://www.witsml.org/schemas/131")]
        public DownLinkFlowRateMn DownLinkFlowRateMn { get; set; }
        [XmlElement(ElementName = "downLinkFlowRateMx", Namespace = "http://www.witsml.org/schemas/131")]
        public DownLinkFlowRateMx DownLinkFlowRateMx { get; set; }
        [XmlElement(ElementName = "pressLossFact", Namespace = "http://www.witsml.org/schemas/131")]
        public string PressLossFact { get; set; }
        [XmlElement(ElementName = "padCount", Namespace = "http://www.witsml.org/schemas/131")]
        public string PadCount { get; set; }
        [XmlElement(ElementName = "padLen", Namespace = "http://www.witsml.org/schemas/131")]
        public PadLen PadLen { get; set; }
        [XmlElement(ElementName = "padWidth", Namespace = "http://www.witsml.org/schemas/131")]
        public PadWidth PadWidth { get; set; }
        [XmlElement(ElementName = "padOffset", Namespace = "http://www.witsml.org/schemas/131")]
        public PadOffset PadOffset { get; set; }
        [XmlElement(ElementName = "openPadOd", Namespace = "http://www.witsml.org/schemas/131")]
        public OpenPadOd OpenPadOd { get; set; }
        [XmlElement(ElementName = "closePadOd", Namespace = "http://www.witsml.org/schemas/131")]
        public ClosePadOd ClosePadOd { get; set; }
        [XmlElement(ElementName = "sensor", Namespace = "http://www.witsml.org/schemas/131")]
        public Sensor Sensor { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
    }
}
