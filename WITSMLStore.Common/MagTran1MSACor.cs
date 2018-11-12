using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "magTran1MSACor", Namespace = "http://www.witsml.org/schemas/1series")]
    public class MagTran1MSACor
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
