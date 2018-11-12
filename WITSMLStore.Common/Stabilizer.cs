using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "stabilizer", Namespace = "http://www.witsml.org/schemas/131")]
    public class Stabilizer
    {
        [XmlElement(ElementName = "lenBlade", Namespace = "http://www.witsml.org/schemas/131")]
        public LenBlade LenBlade { get; set; }
        [XmlElement(ElementName = "lenBladeGauge", Namespace = "http://www.witsml.org/schemas/131")]
        public LenBladeGauge LenBladeGauge { get; set; }
        [XmlElement(ElementName = "odBladeMx", Namespace = "http://www.witsml.org/schemas/131")]
        public OdBladeMx OdBladeMx { get; set; }
        [XmlElement(ElementName = "odBladeMn", Namespace = "http://www.witsml.org/schemas/131")]
        public OdBladeMn OdBladeMn { get; set; }
        [XmlElement(ElementName = "distBladeBot", Namespace = "http://www.witsml.org/schemas/131")]
        public DistBladeBot DistBladeBot { get; set; }
        [XmlElement(ElementName = "shapeBlade", Namespace = "http://www.witsml.org/schemas/131")]
        public string ShapeBlade { get; set; }
        [XmlElement(ElementName = "factFric", Namespace = "http://www.witsml.org/schemas/131")]
        public string FactFric { get; set; }
        [XmlElement(ElementName = "typeBlade", Namespace = "http://www.witsml.org/schemas/131")]
        public string TypeBlade { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }

}
