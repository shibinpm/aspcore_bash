using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "gravTotalFieldReference", Namespace = "http://www.witsml.org/schemas/1series")]
    public class GravTotalFieldReference
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
