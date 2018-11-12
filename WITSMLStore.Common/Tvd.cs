using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "tvd", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Tvd
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
        [XmlAttribute(AttributeName = "datum")]
        public string Datum { get; set; }
    }
}
