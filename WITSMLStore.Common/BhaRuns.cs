using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "bhaRuns", Namespace = "http://www.witsml.org/schemas/1series")]
    public class BhaRuns
    {
        [XmlElement(ElementName = "bhaRun", Namespace = "http://www.witsml.org/schemas/1series")]
        public BhaRun BhaRun { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }
}
