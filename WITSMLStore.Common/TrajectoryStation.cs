using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "trajectoryStation", Namespace = "http://www.witsml.org/schemas/1series")]
    public class TrajectoryStation
    {
        [XmlElement(ElementName = "target", Namespace = "http://www.witsml.org/schemas/1series")]
        public Target Target { get; set; }
        [XmlElement(ElementName = "dTimStn", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimStn { get; set; }
        [XmlElement(ElementName = "typeTrajStation", Namespace = "http://www.witsml.org/schemas/1series")]
        public string TypeTrajStation { get; set; }
        [XmlElement(ElementName = "typeSurveyTool", Namespace = "http://www.witsml.org/schemas/1series")]
        public string TypeSurveyTool { get; set; }
        [XmlElement(ElementName = "calcAlgorithm", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CalcAlgorithm { get; set; }
        [XmlElement(ElementName = "md", Namespace = "http://www.witsml.org/schemas/1series")]
        public Md Md { get; set; }
        [XmlElement(ElementName = "tvd", Namespace = "http://www.witsml.org/schemas/1series")]
        public Tvd Tvd { get; set; }
        [XmlElement(ElementName = "incl", Namespace = "http://www.witsml.org/schemas/1series")]
        public Incl Incl { get; set; }
        [XmlElement(ElementName = "azi", Namespace = "http://www.witsml.org/schemas/1series")]
        public Azi Azi { get; set; }
        [XmlElement(ElementName = "mtf", Namespace = "http://www.witsml.org/schemas/1series")]
        public Mtf Mtf { get; set; }
        [XmlElement(ElementName = "gtf", Namespace = "http://www.witsml.org/schemas/1series")]
        public Gtf Gtf { get; set; }
        [XmlElement(ElementName = "dispNs", Namespace = "http://www.witsml.org/schemas/1series")]
        public DispNs DispNs { get; set; }
        [XmlElement(ElementName = "dispEw", Namespace = "http://www.witsml.org/schemas/1series")]
        public DispEw DispEw { get; set; }
        [XmlElement(ElementName = "vertSect", Namespace = "http://www.witsml.org/schemas/1series")]
        public VertSect VertSect { get; set; }
        [XmlElement(ElementName = "dls", Namespace = "http://www.witsml.org/schemas/1series")]
        public Dls Dls { get; set; }
        [XmlElement(ElementName = "rateTurn", Namespace = "http://www.witsml.org/schemas/1series")]
        public RateTurn RateTurn { get; set; }
        [XmlElement(ElementName = "rateBuild", Namespace = "http://www.witsml.org/schemas/1series")]
        public RateBuild RateBuild { get; set; }
        [XmlElement(ElementName = "mdDelta", Namespace = "http://www.witsml.org/schemas/1series")]
        public MdDelta MdDelta { get; set; }
        [XmlElement(ElementName = "tvdDelta", Namespace = "http://www.witsml.org/schemas/1series")]
        public TvdDelta TvdDelta { get; set; }
        [XmlElement(ElementName = "modelToolError", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ModelToolError { get; set; }
        [XmlElement(ElementName = "iscwsaToolErrorModel", Namespace = "http://www.witsml.org/schemas/1series")]
        public IscwsaToolErrorModel IscwsaToolErrorModel { get; set; }
        [XmlElement(ElementName = "gravTotalUncert", Namespace = "http://www.witsml.org/schemas/1series")]
        public GravTotalUncert GravTotalUncert { get; set; }
        [XmlElement(ElementName = "dipAngleUncert", Namespace = "http://www.witsml.org/schemas/1series")]
        public DipAngleUncert DipAngleUncert { get; set; }
        [XmlElement(ElementName = "magTotalUncert", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagTotalUncert MagTotalUncert { get; set; }
        [XmlElement(ElementName = "gravAccelCorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string GravAccelCorUsed { get; set; }
        [XmlElement(ElementName = "magXAxialCorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string MagXAxialCorUsed { get; set; }
        [XmlElement(ElementName = "sagCorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string SagCorUsed { get; set; }
        [XmlElement(ElementName = "magDrlstrCorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string MagDrlstrCorUsed { get; set; }
        [XmlElement(ElementName = "infieldRefCorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string InfieldRefCorUsed { get; set; }
        [XmlElement(ElementName = "interpolatedInfieldRefCorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string InterpolatedInfieldRefCorUsed { get; set; }
        [XmlElement(ElementName = "inHoleRefCorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string InHoleRefCorUsed { get; set; }
        [XmlElement(ElementName = "axialMagInterferenceCorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string AxialMagInterferenceCorUsed { get; set; }
        [XmlElement(ElementName = "cosagCorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CosagCorUsed { get; set; }
        [XmlElement(ElementName = "MSACorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string MSACorUsed { get; set; }
        [XmlElement(ElementName = "gravTotalFieldReference", Namespace = "http://www.witsml.org/schemas/1series")]
        public GravTotalFieldReference GravTotalFieldReference { get; set; }
        [XmlElement(ElementName = "magTotalFieldReference", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagTotalFieldReference MagTotalFieldReference { get; set; }
        [XmlElement(ElementName = "magDipAngleReference", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagDipAngleReference MagDipAngleReference { get; set; }
        [XmlElement(ElementName = "magModelUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string MagModelUsed { get; set; }
        [XmlElement(ElementName = "magModelValid", Namespace = "http://www.witsml.org/schemas/1series")]
        public string MagModelValid { get; set; }
        [XmlElement(ElementName = "geoModelUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public string GeoModelUsed { get; set; }
        [XmlElement(ElementName = "statusTrajStation", Namespace = "http://www.witsml.org/schemas/1series")]
        public string StatusTrajStation { get; set; }
        [XmlElement(ElementName = "rawData", Namespace = "http://www.witsml.org/schemas/1series")]
        public RawData RawData { get; set; }
        [XmlElement(ElementName = "corUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public CorUsed CorUsed { get; set; }
        [XmlElement(ElementName = "valid", Namespace = "http://www.witsml.org/schemas/1series")]
        public Valid Valid { get; set; }
        [XmlElement(ElementName = "matrixCov", Namespace = "http://www.witsml.org/schemas/1series")]
        public MatrixCov MatrixCov { get; set; }
        [XmlElement(ElementName = "location", Namespace = "http://www.witsml.org/schemas/1series")]
        public Location Location { get; set; }
        [XmlElement(ElementName = "sourceStation", Namespace = "http://www.witsml.org/schemas/1series")]
        public SourceStation SourceStation { get; set; }
        [XmlElement(ElementName = "commonData", Namespace = "http://www.witsml.org/schemas/1series")]
        public CommonData CommonData { get; set; }
        [XmlElement(ElementName = "extensionNameValue", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionNameValue { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
