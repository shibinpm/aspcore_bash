using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "geologyInterval", Namespace = "http://www.witsml.org/schemas/1series")]
    public class GeologyInterval
    {
        [XmlElement(ElementName = "typeLithology", Namespace = "http://www.witsml.org/schemas/1series")]
        public string TypeLithology { get; set; }
        [XmlElement(ElementName = "mdTop", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdTop MdTop { get; set; }
        [XmlElement(ElementName = "mdBottom", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdBottom MdBottom { get; set; }
        [XmlElement(ElementName = "dTim", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTim { get; set; }
        [XmlElement(ElementName = "tvdTop", Namespace = "http://www.witsml.org/schemas/1series")]
        public TvdTop TvdTop { get; set; }
        [XmlElement(ElementName = "tvdBase", Namespace = "http://www.witsml.org/schemas/1series")]
        public TvdBase TvdBase { get; set; }
        [XmlElement(ElementName = "ropAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public RopAv RopAv { get; set; }
        [XmlElement(ElementName = "ropMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public RopMn RopMn { get; set; }
        [XmlElement(ElementName = "ropMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public RopMx RopMx { get; set; }
        [XmlElement(ElementName = "wobAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public WobAv WobAv { get; set; }
        [XmlElement(ElementName = "tqAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public TqAv TqAv { get; set; }
        [XmlElement(ElementName = "currentAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public CurrentAv CurrentAv { get; set; }
        [XmlElement(ElementName = "rpmAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public RpmAv RpmAv { get; set; }
        [XmlElement(ElementName = "wtMudAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public WtMudAv WtMudAv { get; set; }
        [XmlElement(ElementName = "ecdTdAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public EcdTdAv EcdTdAv { get; set; }
        [XmlElement(ElementName = "dxcAv", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DxcAv { get; set; }
        [XmlElement(ElementName = "lithology", Namespace = "http://www.witsml.org/schemas/1series")]
        public Lithology Lithology { get; set; }
        [XmlElement(ElementName = "show", Namespace = "http://www.witsml.org/schemas/1series")]
        public Show Show { get; set; }
        [XmlElement(ElementName = "chromatograph", Namespace = "http://www.witsml.org/schemas/1series")]
        public Chromatograph Chromatograph { get; set; }
        [XmlElement(ElementName = "mudGas", Namespace = "http://www.witsml.org/schemas/1series")]
        public MudGas MudGas { get; set; }
        [XmlElement(ElementName = "densBulk", Namespace = "http://www.witsml.org/schemas/1series")]
        public DensBulk DensBulk { get; set; }
        [XmlElement(ElementName = "densShale", Namespace = "http://www.witsml.org/schemas/1series")]
        public DensShale DensShale { get; set; }
        [XmlElement(ElementName = "calcite", Namespace = "http://www.witsml.org/schemas/1series")]
        public Calcite Calcite { get; set; }
        [XmlElement(ElementName = "dolomite", Namespace = "http://www.witsml.org/schemas/1series")]
        public Dolomite Dolomite { get; set; }
        [XmlElement(ElementName = "cec", Namespace = "http://www.witsml.org/schemas/1series")]
        public Cec Cec { get; set; }
        [XmlElement(ElementName = "qft", Namespace = "http://www.witsml.org/schemas/1series")]
        public Qft Qft { get; set; }
        [XmlElement(ElementName = "calcStab", Namespace = "http://www.witsml.org/schemas/1series")]
        public CalcStab CalcStab { get; set; }
        [XmlElement(ElementName = "nameFormation", Namespace = "http://www.witsml.org/schemas/1series")]
        public string NameFormation { get; set; }
        [XmlElement(ElementName = "lithostratigraphic", Namespace = "http://www.witsml.org/schemas/1series")]
        public Lithostratigraphic Lithostratigraphic { get; set; }
        [XmlElement(ElementName = "chronostratigraphic", Namespace = "http://www.witsml.org/schemas/1series")]
        public Chronostratigraphic Chronostratigraphic { get; set; }
        [XmlElement(ElementName = "sizeMn", Namespace = "http://www.witsml.org/schemas/1series")]
        public SizeMn SizeMn { get; set; }
        [XmlElement(ElementName = "sizeMx", Namespace = "http://www.witsml.org/schemas/1series")]
        public SizeMx SizeMx { get; set; }
        [XmlElement(ElementName = "lenPlug", Namespace = "http://www.witsml.org/schemas/1series")]
        public LenPlug LenPlug { get; set; }
        [XmlElement(ElementName = "description", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Description { get; set; }
        [XmlElement(ElementName = "cuttingFluid", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CuttingFluid { get; set; }
        [XmlElement(ElementName = "cleaningMethod", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CleaningMethod { get; set; }
        [XmlElement(ElementName = "dryingMethod", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DryingMethod { get; set; }
        [XmlElement(ElementName = "comments", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Comments { get; set; }
        [XmlElement(ElementName = "commonTime", Namespace = "http://www.witsml.org/schemas/1series")]
        public CommonTime CommonTime { get; set; }
        [XmlElement(ElementName = "extensionNameValue", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionNameValue { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
