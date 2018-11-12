using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "mdDelta", Namespace = "http://www.witsml.org/schemas/1series")]
    public class MdDelta
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
