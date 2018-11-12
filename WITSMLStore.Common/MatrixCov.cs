using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "matrixCov", Namespace = "http://www.witsml.org/schemas/1series")]
    public class MatrixCov
    {
        [XmlElement(ElementName = "varianceNN", Namespace = "http://www.witsml.org/schemas/1series")]
        public VarianceNN VarianceNN { get; set; }
        [XmlElement(ElementName = "varianceNE", Namespace = "http://www.witsml.org/schemas/1series")]
        public VarianceNE VarianceNE { get; set; }
        [XmlElement(ElementName = "varianceNVert", Namespace = "http://www.witsml.org/schemas/1series")]
        public VarianceNVert VarianceNVert { get; set; }
        [XmlElement(ElementName = "varianceEE", Namespace = "http://www.witsml.org/schemas/1series")]
        public VarianceEE VarianceEE { get; set; }
        [XmlElement(ElementName = "varianceEVert", Namespace = "http://www.witsml.org/schemas/1series")]
        public VarianceEVert VarianceEVert { get; set; }
        [XmlElement(ElementName = "varianceVertVert", Namespace = "http://www.witsml.org/schemas/1series")]
        public VarianceVertVert VarianceVertVert { get; set; }
        [XmlElement(ElementName = "biasN", Namespace = "http://www.witsml.org/schemas/1series")]
        public BiasN BiasN { get; set; }
        [XmlElement(ElementName = "biasE", Namespace = "http://www.witsml.org/schemas/1series")]
        public BiasE BiasE { get; set; }
        [XmlElement(ElementName = "biasVert", Namespace = "http://www.witsml.org/schemas/1series")]
        public BiasVert BiasVert { get; set; }
    }
}
