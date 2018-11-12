using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "drillingParams", Namespace = "http://www.witsml.org/schemas/1series")]
    public class DrillingParams
    {
        [XmlElement(ElementName = "eTimOpBit", Namespace = "http://www.witsml.org/schemas/1series")]
        public ETimOpBit ETimOpBit { get; set; }
        [XmlElement(ElementName = "mdHoleStart", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdHoleStart MdHoleStart { get; set; }
        [XmlElement(ElementName = "mdHoleStop", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdHoleStop MdHoleStop { get; set; }
        [XmlElement(ElementName = "tubular", Namespace = "http://www.witsml.org/schemas/1series")]
        public Tubular Tubular { get; set; }
        [XmlElement(ElementName = "hkldRot", Namespace = "http://www.witsml.org/schemas/1series")]
        public HkldRot HkldRot { get; set; }
        [XmlElement(ElementName = "overPull", Namespace = "http://www.witsml.org/schemas/1series")]
        public OverPull OverPull { get; set; }
        [XmlElement(ElementName = "slackOff", Namespace = "http://www.witsml.org/schemas/1series")]
        public SlackOff SlackOff { get; set; }
        [XmlElement(ElementName = "hkldUp", Namespace = "http://www.witsml.org/schemas/1series")]
        public HkldUp HkldUp { get; set; }
        [XmlElement(ElementName = "hkldDn", Namespace = "http://www.witsml.org/schemas/1series")]
        public HkldDn HkldDn { get; set; }
        [XmlElement(ElementName = "tqOnBotAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public TqOnBotAv TqOnBotAv { get; set; }
        [XmlElement(ElementName = "tqOnBotMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public TqOnBotMx TqOnBotMx { get; set; }
        [XmlElement(ElementName = "tqOnBotMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public TqOnBotMn TqOnBotMn { get; set; }
        [XmlElement(ElementName = "tqOffBotAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public TqOffBotAv TqOffBotAv { get; set; }
        [XmlElement(ElementName = "tqDhAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public TqDhAv TqDhAv { get; set; }
        [XmlElement(ElementName = "wtAboveJar", Namespace = "http://www.witsml.org/schemas/1series")]
        public WtAboveJar WtAboveJar { get; set; }
        [XmlElement(ElementName = "wtBelowJar", Namespace = "http://www.witsml.org/schemas/1series")]
        public WtBelowJar WtBelowJar { get; set; }
        [XmlElement(ElementName = "wtMud", Namespace = "http://www.witsml.org/schemas/1series")]
        public WtMud WtMud { get; set; }
        [XmlElement(ElementName = "flowratePump", Namespace = "http://www.witsml.org/schemas/1series")]
        public FlowratePump FlowratePump { get; set; }
        [XmlElement(ElementName = "powBit", Namespace = "http://www.witsml.org/schemas/1series")]
        public PowBit PowBit { get; set; }
        [XmlElement(ElementName = "velNozzleAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public VelNozzleAv VelNozzleAv { get; set; }
        [XmlElement(ElementName = "presDropBit", Namespace = "http://www.witsml.org/schemas/1series")]
        public PresDropBit PresDropBit { get; set; }
        [XmlElement(ElementName = "cTimHold", Namespace = "http://www.witsml.org/schemas/1series")]
        public CTimHold CTimHold { get; set; }
        [XmlElement(ElementName = "cTimSteering", Namespace = "http://www.witsml.org/schemas/1series")]
        public CTimSteering CTimSteering { get; set; }
        [XmlElement(ElementName = "cTimDrillRot", Namespace = "http://www.witsml.org/schemas/1series")]
        public CTimDrillRot CTimDrillRot { get; set; }
        [XmlElement(ElementName = "cTimDrillSlid", Namespace = "http://www.witsml.org/schemas/1series")]
        public CTimDrillSlid CTimDrillSlid { get; set; }
        [XmlElement(ElementName = "cTimCirc", Namespace = "http://www.witsml.org/schemas/1series")]
        public CTimCirc CTimCirc { get; set; }
        [XmlElement(ElementName = "cTimReam", Namespace = "http://www.witsml.org/schemas/1series")]
        public CTimReam CTimReam { get; set; }
        [XmlElement(ElementName = "distDrillRot", Namespace = "http://www.witsml.org/schemas/1series")]
        public DistDrillRot DistDrillRot { get; set; }
        [XmlElement(ElementName = "distDrillSlid", Namespace = "http://www.witsml.org/schemas/1series")]
        public DistDrillSlid DistDrillSlid { get; set; }
        [XmlElement(ElementName = "distReam", Namespace = "http://www.witsml.org/schemas/1series")]
        public DistReam DistReam { get; set; }
        [XmlElement(ElementName = "distHold", Namespace = "http://www.witsml.org/schemas/1series")]
        public DistHold DistHold { get; set; }
        [XmlElement(ElementName = "distSteering", Namespace = "http://www.witsml.org/schemas/1series")]
        public DistSteering DistSteering { get; set; }
        [XmlElement(ElementName = "rpmAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public RpmAv RpmAv { get; set; }
        [XmlElement(ElementName = "rpmMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public RpmMx RpmMx { get; set; }
        [XmlElement(ElementName = "rpmMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public RpmMn RpmMn { get; set; }
        [XmlElement(ElementName = "rpmAvDh", Namespace = "http://www.witsml.org/schemas/1series")]
        public RpmAvDh RpmAvDh { get; set; }
        [XmlElement(ElementName = "ropAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public RopAv RopAv { get; set; }
        [XmlElement(ElementName = "ropMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public RopMx RopMx { get; set; }
        [XmlElement(ElementName = "ropMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public RopMn RopMn { get; set; }
        [XmlElement(ElementName = "wobAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public WobAv WobAv { get; set; }
        [XmlElement(ElementName = "wobMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public WobMx WobMx { get; set; }
        [XmlElement(ElementName = "wobMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public WobMn WobMn { get; set; }
        [XmlElement(ElementName = "wobAvDh", Namespace = "http://www.witsml.org/schemas/1series")]
        public WobAvDh WobAvDh { get; set; }
        [XmlElement(ElementName = "reasonTrip", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ReasonTrip { get; set; }
        [XmlElement(ElementName = "objectiveBha", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ObjectiveBha { get; set; }
        [XmlElement(ElementName = "aziTop", Namespace = "http://www.witsml.org/schemas/1series")]
        public AziTop AziTop { get; set; }
        [XmlElement(ElementName = "aziBottom", Namespace = "http://www.witsml.org/schemas/1series")]
        public AziBottom AziBottom { get; set; }
        [XmlElement(ElementName = "inclStart", Namespace = "http://www.witsml.org/schemas/1series")]
        public InclStart InclStart { get; set; }
        [XmlElement(ElementName = "inclMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public InclMx InclMx { get; set; }
        [XmlElement(ElementName = "inclMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public InclMn InclMn { get; set; }
        [XmlElement(ElementName = "inclStop", Namespace = "http://www.witsml.org/schemas/1series")]
        public InclStop InclStop { get; set; }
        [XmlElement(ElementName = "tempMudDhMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public TempMudDhMx TempMudDhMx { get; set; }
        [XmlElement(ElementName = "presPumpAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public PresPumpAv PresPumpAv { get; set; }
        [XmlElement(ElementName = "flowrateBit", Namespace = "http://www.witsml.org/schemas/1series")]
        public FlowrateBit FlowrateBit { get; set; }
        [XmlElement(ElementName = "mudClass", Namespace = "http://www.witsml.org/schemas/1series")]
        public string MudClass { get; set; }
        [XmlElement(ElementName = "mudSubClass", Namespace = "http://www.witsml.org/schemas/1series")]
        public string MudSubClass { get; set; }
        [XmlElement(ElementName = "comments", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Comments { get; set; }
        [XmlElement(ElementName = "extensionNameValue", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionNameValue { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
