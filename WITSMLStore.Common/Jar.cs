using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "jar", Namespace = "http://www.witsml.org/schemas/131")]
    public class Jar
    {
        [XmlElement(ElementName = "forUpSet", Namespace = "http://www.witsml.org/schemas/131")]
        public ForUpSet ForUpSet { get; set; }
        [XmlElement(ElementName = "forDownSet", Namespace = "http://www.witsml.org/schemas/131")]
        public ForDownSet ForDownSet { get; set; }
        [XmlElement(ElementName = "forUpTrip", Namespace = "http://www.witsml.org/schemas/131")]
        public ForUpTrip ForUpTrip { get; set; }
        [XmlElement(ElementName = "forDownTrip", Namespace = "http://www.witsml.org/schemas/131")]
        public ForDownTrip ForDownTrip { get; set; }
        [XmlElement(ElementName = "forPmpOpen", Namespace = "http://www.witsml.org/schemas/131")]
        public ForPmpOpen ForPmpOpen { get; set; }
        [XmlElement(ElementName = "forSealFric", Namespace = "http://www.witsml.org/schemas/131")]
        public ForSealFric ForSealFric { get; set; }
        [XmlElement(ElementName = "typeJar", Namespace = "http://www.witsml.org/schemas/131")]
        public string TypeJar { get; set; }
        [XmlElement(ElementName = "jarAction", Namespace = "http://www.witsml.org/schemas/131")]
        public string JarAction { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
    }
}
