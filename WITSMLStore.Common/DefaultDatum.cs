using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "defaultDatum", Namespace = "http://www.witsml.org/schemas/1series")]
    public class DefaultDatum
    {
        [XmlAttribute(AttributeName = "uidRef")]
        public string UidRef { get; set; }
    }
}
