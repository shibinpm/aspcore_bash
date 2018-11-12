using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "chromatograph", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Chromatograph
    {
        [XmlElement(ElementName = "dTim", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTim { get; set; }
        [XmlElement(ElementName = "mdTop", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdTop MdTop { get; set; }
        [XmlElement(ElementName = "mdBottom", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdBottom MdBottom { get; set; }
        [XmlElement(ElementName = "wtMudIn", Namespace = "http://www.witsml.org/schemas/1series")]
        public WtMudIn WtMudIn { get; set; }
        [XmlElement(ElementName = "wtMudOut", Namespace = "http://www.witsml.org/schemas/1series")]
        public WtMudOut WtMudOut { get; set; }
        [XmlElement(ElementName = "chromType", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ChromType { get; set; }
        [XmlElement(ElementName = "eTimChromCycle", Namespace = "http://www.witsml.org/schemas/1series")]
        public ETimChromCycle ETimChromCycle { get; set; }
        [XmlElement(ElementName = "chromIntRpt", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ChromIntRpt { get; set; }
        [XmlElement(ElementName = "methAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public MethAv MethAv { get; set; }
        [XmlElement(ElementName = "methMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public MethMn MethMn { get; set; }
        [XmlElement(ElementName = "methMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public MethMx MethMx { get; set; }
        [XmlElement(ElementName = "ethAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public EthAv EthAv { get; set; }
        [XmlElement(ElementName = "ethMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public EthMn EthMn { get; set; }
        [XmlElement(ElementName = "ethMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public EthMx EthMx { get; set; }
        [XmlElement(ElementName = "propAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public PropAv PropAv { get; set; }
        [XmlElement(ElementName = "propMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public PropMn PropMn { get; set; }
        [XmlElement(ElementName = "propMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public PropMx PropMx { get; set; }
        [XmlElement(ElementName = "ibutAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public IbutAv IbutAv { get; set; }
        [XmlElement(ElementName = "ibutMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public IbutMn IbutMn { get; set; }
        [XmlElement(ElementName = "ibutMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public IbutMx IbutMx { get; set; }
        [XmlElement(ElementName = "nbutAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public NbutAv NbutAv { get; set; }
        [XmlElement(ElementName = "nbutMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public NbutMn NbutMn { get; set; }
        [XmlElement(ElementName = "nbutMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public NbutMx NbutMx { get; set; }
        [XmlElement(ElementName = "ipentAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public IpentAv IpentAv { get; set; }
        [XmlElement(ElementName = "ipentMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public IpentMn IpentMn { get; set; }
        [XmlElement(ElementName = "ipentMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public IpentMx IpentMx { get; set; }
        [XmlElement(ElementName = "npentAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public NpentAv NpentAv { get; set; }
        [XmlElement(ElementName = "npentMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public NpentMn NpentMn { get; set; }
        [XmlElement(ElementName = "npentMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public NpentMx NpentMx { get; set; }
        [XmlElement(ElementName = "epentAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public EpentAv EpentAv { get; set; }
        [XmlElement(ElementName = "epentMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public EpentMn EpentMn { get; set; }
        [XmlElement(ElementName = "epentMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public EpentMx EpentMx { get; set; }
        [XmlElement(ElementName = "ihexAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public IhexAv IhexAv { get; set; }
        [XmlElement(ElementName = "ihexMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public IhexMn IhexMn { get; set; }
        [XmlElement(ElementName = "ihexMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public IhexMx IhexMx { get; set; }
        [XmlElement(ElementName = "nhexAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public NhexAv NhexAv { get; set; }
        [XmlElement(ElementName = "nhexMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public NhexMn NhexMn { get; set; }
        [XmlElement(ElementName = "nhexMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public NhexMx NhexMx { get; set; }
        [XmlElement(ElementName = "co2Av", Namespace = "http://www.witsml.org/schemas/1series")]
        public Co2Av Co2Av { get; set; }
        [XmlElement(ElementName = "co2Mn", Namespace = "http://www.witsml.org/schemas/1series")]
        public Co2Mn Co2Mn { get; set; }
        [XmlElement(ElementName = "co2Mx", Namespace = "http://www.witsml.org/schemas/1series")]
        public Co2Mx Co2Mx { get; set; }
        [XmlElement(ElementName = "h2sAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public H2sAv H2sAv { get; set; }
        [XmlElement(ElementName = "h2sMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public H2sMn H2sMn { get; set; }
        [XmlElement(ElementName = "h2sMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public H2sMx H2sMx { get; set; }
        [XmlElement(ElementName = "acetylene", Namespace = "http://www.witsml.org/schemas/1series")]
        public Acetylene Acetylene { get; set; }
    }
}
