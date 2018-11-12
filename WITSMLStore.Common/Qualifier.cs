using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "qualifier", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Qualifier
    {
        [XmlElement(ElementName = "type", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Type { get; set; }
        [XmlElement(ElementName = "mdTop", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdTop MdTop { get; set; }
        [XmlElement(ElementName = "mdBottom", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdBottom MdBottom { get; set; }
        [XmlElement(ElementName = "abundance", Namespace = "http://www.witsml.org/schemas/1series")]
        public Abundance Abundance { get; set; }
        [XmlElement(ElementName = "abundanceCode", Namespace = "http://www.witsml.org/schemas/1series")]
        public string AbundanceCode { get; set; }
        [XmlElement(ElementName = "description", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Description { get; set; }
        [XmlElement(ElementName = "extensionNameValue", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionNameValue { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
