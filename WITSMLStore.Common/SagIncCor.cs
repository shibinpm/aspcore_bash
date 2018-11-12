using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "sagIncCor", Namespace = "http://www.witsml.org/schemas/1series")]
    public class SagIncCor
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
