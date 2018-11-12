using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;


namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "actDoglegMx", Namespace = "http://www.witsml.org/schemas/1series")]
    public class ActDoglegMx
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}
