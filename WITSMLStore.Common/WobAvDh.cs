using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "wobAvDh", Namespace = "http://www.witsml.org/schemas/1series")]
    public class WobAvDh
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }

}
