using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "diaPassThru", Namespace = "http://www.witsml.org/schemas/131")]
    public class DiaPassThru
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
