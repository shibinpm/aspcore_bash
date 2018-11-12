using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "projectedY", Namespace = "http://www.witsml.org/schemas/1series")]
    public class ProjectedY
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
