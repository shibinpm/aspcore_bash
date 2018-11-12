using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "rotation", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Rotation
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }

}
