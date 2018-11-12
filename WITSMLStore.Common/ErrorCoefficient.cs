using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "errorCoefficient", Namespace = "http://www.witsml.org/schemas/1series")]
    public class ErrorCoefficient
    {
        [XmlElement(ElementName = "azi", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Azi { get; set; }
        [XmlElement(ElementName = "inc", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Inc { get; set; }
        [XmlElement(ElementName = "depth", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Depth { get; set; }
        [XmlElement(ElementName = "tvd", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Tvd { get; set; }
        [XmlElement(ElementName = "extensionNameValue", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionNameValue { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
