using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "acquisitionTimeZone", Namespace = "http://www.witsml.org/schemas/1series")]
    public class AcquisitionTimeZone
    {
        [XmlAttribute(AttributeName = "dTim")]
        public string DTim { get; set; }
    }
}
