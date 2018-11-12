using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "rateTurn", Namespace = "http://www.witsml.org/schemas/1series")]
    public class RateTurn
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
