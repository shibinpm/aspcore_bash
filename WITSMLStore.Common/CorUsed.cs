using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "corUsed", Namespace = "http://www.witsml.org/schemas/1series")]
    public class CorUsed
    {
        [XmlElement(ElementName = "gravAxialAccelCor", Namespace = "http://www.witsml.org/schemas/1series")]
        public GravAxialAccelCor GravAxialAccelCor { get; set; }
        [XmlElement(ElementName = "gravTran1AccelCor", Namespace = "http://www.witsml.org/schemas/1series")]
        public GravTran1AccelCor GravTran1AccelCor { get; set; }
        [XmlElement(ElementName = "gravTran2AccelCor", Namespace = "http://www.witsml.org/schemas/1series")]
        public GravTran2AccelCor GravTran2AccelCor { get; set; }
        [XmlElement(ElementName = "magAxialDrlstrCor", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagAxialDrlstrCor MagAxialDrlstrCor { get; set; }
        [XmlElement(ElementName = "magTran1DrlstrCor", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagTran1DrlstrCor MagTran1DrlstrCor { get; set; }
        [XmlElement(ElementName = "magTran2DrlstrCor", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagTran2DrlstrCor MagTran2DrlstrCor { get; set; }
        [XmlElement(ElementName = "magTran1MSACor", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagTran1MSACor MagTran1MSACor { get; set; }
        [XmlElement(ElementName = "magTran2MSACor", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagTran2MSACor MagTran2MSACor { get; set; }
        [XmlElement(ElementName = "magAxialMSACor", Namespace = "http://www.witsml.org/schemas/1series")]
        public MagAxialMSACor MagAxialMSACor { get; set; }
        [XmlElement(ElementName = "sagIncCor", Namespace = "http://www.witsml.org/schemas/1series")]
        public SagIncCor SagIncCor { get; set; }
        [XmlElement(ElementName = "sagAziCor", Namespace = "http://www.witsml.org/schemas/1series")]
        public SagAziCor SagAziCor { get; set; }
        [XmlElement(ElementName = "stnMagDeclUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public StnMagDeclUsed StnMagDeclUsed { get; set; }
        [XmlElement(ElementName = "stnGridCorUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public StnGridCorUsed StnGridCorUsed { get; set; }
        [XmlElement(ElementName = "stnGridConUsed", Namespace = "http://www.witsml.org/schemas/1series")]
        public StnGridConUsed StnGridConUsed { get; set; }
        [XmlElement(ElementName = "dirSensorOffset", Namespace = "http://www.witsml.org/schemas/1series")]
        public DirSensorOffset DirSensorOffset { get; set; }
    }
}
