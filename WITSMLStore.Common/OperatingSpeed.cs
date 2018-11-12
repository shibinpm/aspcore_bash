using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "operatingSpeed", Namespace = "http://www.witsml.org/schemas/131")]
    public class OperatingSpeed
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
