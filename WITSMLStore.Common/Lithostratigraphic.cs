using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "lithostratigraphic", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Lithostratigraphic
    {
        [XmlAttribute(AttributeName = "kind")]
        public string Kind { get; set; }
    }
}
