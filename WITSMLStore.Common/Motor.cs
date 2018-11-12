using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "motor", Namespace = "http://www.witsml.org/schemas/131")]
    public class Motor
    {
        [XmlElement(ElementName = "offsetTool", Namespace = "http://www.witsml.org/schemas/131")]
        public OffsetTool OffsetTool { get; set; }
        [XmlElement(ElementName = "presLossFact", Namespace = "http://www.witsml.org/schemas/131")]
        public string PresLossFact { get; set; }
        [XmlElement(ElementName = "flowrateMn", Namespace = "http://www.witsml.org/schemas/131")]
        public FlowrateMn FlowrateMn { get; set; }
        [XmlElement(ElementName = "flowrateMx", Namespace = "http://www.witsml.org/schemas/131")]
        public FlowrateMx FlowrateMx { get; set; }
        [XmlElement(ElementName = "diaRotorNozzle", Namespace = "http://www.witsml.org/schemas/131")]
        public DiaRotorNozzle DiaRotorNozzle { get; set; }
        [XmlElement(ElementName = "clearanceBearBox", Namespace = "http://www.witsml.org/schemas/131")]
        public ClearanceBearBox ClearanceBearBox { get; set; }
        [XmlElement(ElementName = "lobesRotor", Namespace = "http://www.witsml.org/schemas/131")]
        public string LobesRotor { get; set; }
        [XmlElement(ElementName = "lobesStator", Namespace = "http://www.witsml.org/schemas/131")]
        public string LobesStator { get; set; }
        [XmlElement(ElementName = "typeBearing", Namespace = "http://www.witsml.org/schemas/131")]
        public string TypeBearing { get; set; }
        [XmlElement(ElementName = "tempOpMx", Namespace = "http://www.witsml.org/schemas/131")]
        public TempOpMx TempOpMx { get; set; }
        [XmlElement(ElementName = "rotorCatcher", Namespace = "http://www.witsml.org/schemas/131")]
        public string RotorCatcher { get; set; }
        [XmlElement(ElementName = "dumpValve", Namespace = "http://www.witsml.org/schemas/131")]
        public string DumpValve { get; set; }
        [XmlElement(ElementName = "diaNozzle", Namespace = "http://www.witsml.org/schemas/131")]
        public DiaNozzle DiaNozzle { get; set; }
        [XmlElement(ElementName = "rotatable", Namespace = "http://www.witsml.org/schemas/131")]
        public string Rotatable { get; set; }
        [XmlElement(ElementName = "bendSettingsMn", Namespace = "http://www.witsml.org/schemas/131")]
        public BendSettingsMn BendSettingsMn { get; set; }
        [XmlElement(ElementName = "bendSettingsMx", Namespace = "http://www.witsml.org/schemas/131")]
        public BendSettingsMx BendSettingsMx { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
    }

}
