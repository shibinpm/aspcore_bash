using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "commonTime", Namespace = "http://www.witsml.org/schemas/1series")]
    public class CommonTime
    {
        [XmlElement(ElementName = "dTimCreation", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimCreation { get; set; }
        [XmlElement(ElementName = "dTimLastChange", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimLastChange { get; set; }
    }
}
