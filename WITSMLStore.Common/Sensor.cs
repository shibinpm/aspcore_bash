using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "sensor", Namespace = "http://www.witsml.org/schemas/131")]
    public class Sensor
    {
        [XmlElement(ElementName = "typeMeasurement", Namespace = "http://www.witsml.org/schemas/131")]
        public string TypeMeasurement { get; set; }
        [XmlElement(ElementName = "offsetBot", Namespace = "http://www.witsml.org/schemas/131")]
        public OffsetBot OffsetBot { get; set; }
        [XmlElement(ElementName = "comments", Namespace = "http://www.witsml.org/schemas/131")]
        public string Comments { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
