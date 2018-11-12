using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "forSealFric", Namespace = "http://www.witsml.org/schemas/131")]
    public class ForSealFric
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
