using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "h2sAv", Namespace = "http://www.witsml.org/schemas/1series")]
    public class H2sAv
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
