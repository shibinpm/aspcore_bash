using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "md", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Md
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
        [XmlAttribute(AttributeName = "datum")]
        public string Datum { get; set; }
    }
}
