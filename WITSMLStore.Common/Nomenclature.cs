using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "nomenclature", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Nomenclature
    {
        [XmlElement(ElementName = "parameter", Namespace = "http://www.witsml.org/schemas/1series")]
        public Parameter Parameter { get; set; }
        [XmlElement(ElementName = "function", Namespace = "http://www.witsml.org/schemas/1series")]
        public Function Function { get; set; }
        [XmlElement(ElementName = "constant", Namespace = "http://www.witsml.org/schemas/1series")]
        public Constant Constant { get; set; }
    }
}
