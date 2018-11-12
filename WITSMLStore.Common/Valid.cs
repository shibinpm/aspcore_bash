using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "valid", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Valid
    {
        [XmlElement(ElementName = "magTotalFieldCalc", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagTotalFieldCalc MagTotalFieldCalc { get; set; }
        [XmlElement(ElementName = "magDipAngleCalc", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagDipAngleCalc MagDipAngleCalc { get; set; }
        [XmlElement(ElementName = "gravTotalFieldCalc", Namespace = "http://www.witsml.org/schemas/1series")]
        public GravTotalFieldCalc GravTotalFieldCalc { get; set; }
    }
}
