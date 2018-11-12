using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "bhaRun", Namespace = "http://www.witsml.org/schemas/1series")]
    public class BhaRun
    {
        [XmlElement(ElementName = "nameWell", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NameWell { get; set; }
        [XmlElement(ElementName = "nameWellbore", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NameWellbore { get; set; }
        [XmlElement(ElementName = "name", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Name { get; set; }
        [XmlElement(ElementName = "tubular", Namespace = "http://www.witsml.org/schemas/1series")]
        public Tubular Tubular { get; set; }
        [XmlElement(ElementName = "dTimStart", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimStart { get; set; }
        [XmlElement(ElementName = "dTimStop", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimStop { get; set; }
        [XmlElement(ElementName = "dTimStartDrilling", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimStartDrilling { get; set; }
        [XmlElement(ElementName = "dTimStopDrilling", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimStopDrilling { get; set; }
        [XmlElement(ElementName = "planDogleg", Namespace = "http://www.witsml.org/schemas/1series")]
        public PlanDogleg PlanDogleg { get; set; }
        [XmlElement(ElementName = "actDogleg", Namespace = "http://www.witsml.org/schemas/1series")]
        public ActDogleg ActDogleg { get; set; }
        [XmlElement(ElementName = "actDoglegMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public ActDoglegMx ActDoglegMx { get; set; }
        [XmlElement(ElementName = "statusBha", Namespace = "http://www.witsml.org/schemas/1series")]
        public string StatusBha { get; set; }
        [XmlElement(ElementName = "numBitRun", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NumBitRun { get; set; }
        [XmlElement(ElementName = "numStringRun", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NumStringRun { get; set; }
        [XmlElement(ElementName = "reasonTrip", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ReasonTrip { get; set; }
        [XmlElement(ElementName = "objectiveBha", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ObjectiveBha { get; set; }
        [XmlElement(ElementName = "drillingParams", Namespace = "http://www.witsml.org/schemas/1series")]
        public DrillingParams DrillingParams { get; set; }
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
