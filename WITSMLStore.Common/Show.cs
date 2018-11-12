using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "show", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Show
    {
        [XmlElement(ElementName = "showRat", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ShowRat { get; set; }
        [XmlElement(ElementName = "stainColor", Namespace = "http://www.witsml.org/schemas/1series")]
        public string StainColor { get; set; }
        [XmlElement(ElementName = "stainDistr", Namespace = "http://www.witsml.org/schemas/1series")]
        public string StainDistr { get; set; }
        [XmlElement(ElementName = "stainPc", Namespace = "http://www.witsml.org/schemas/1series")]
        public StainPc StainPc { get; set; }
        [XmlElement(ElementName = "natFlorColor", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NatFlorColor { get; set; }
        [XmlElement(ElementName = "natFlorPc", Namespace = "http://www.witsml.org/schemas/1series")]
        public NatFlorPc NatFlorPc { get; set; }
        [XmlElement(ElementName = "natFlorLevel", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NatFlorLevel { get; set; }
        [XmlElement(ElementName = "natFlorDesc", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NatFlorDesc { get; set; }
        [XmlElement(ElementName = "cutColor", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CutColor { get; set; }
        [XmlElement(ElementName = "cutSpeed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CutSpeed { get; set; }
        [XmlElement(ElementName = "cutStrength", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CutStrength { get; set; }
        [XmlElement(ElementName = "cutForm", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CutForm { get; set; }
        [XmlElement(ElementName = "cutLevel", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CutLevel { get; set; }
        [XmlElement(ElementName = "cutFlorColor", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CutFlorColor { get; set; }
        [XmlElement(ElementName = "cutFlorSpeed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CutFlorSpeed { get; set; }
        [XmlElement(ElementName = "cutFlorStrength", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CutFlorStrength { get; set; }
        [XmlElement(ElementName = "cutFlorForm", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CutFlorForm { get; set; }
        [XmlElement(ElementName = "cutFlorLevel", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CutFlorLevel { get; set; }
        [XmlElement(ElementName = "residueColor", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ResidueColor { get; set; }
        [XmlElement(ElementName = "showDesc", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ShowDesc { get; set; }
        [XmlElement(ElementName = "impregnatedLitho", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ImpregnatedLitho { get; set; }
        [XmlElement(ElementName = "odor", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Odor { get; set; }
    }

}
