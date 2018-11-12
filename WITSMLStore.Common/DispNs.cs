using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "dispNs", Namespace = "http://www.witsml.org/schemas/1series")]
    public class DispNs
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
