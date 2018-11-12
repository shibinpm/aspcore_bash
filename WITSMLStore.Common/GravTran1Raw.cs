using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "gravTran1Raw", Namespace = "http://www.witsml.org/schemas/1series")]
    public class GravTran1Raw
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }

}
