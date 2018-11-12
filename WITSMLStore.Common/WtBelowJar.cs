using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "wtBelowJar", Namespace = "http://www.witsml.org/schemas/1series")]
    public class WtBelowJar
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
