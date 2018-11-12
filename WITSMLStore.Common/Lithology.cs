using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "lithology", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Lithology
    {
        [XmlElement(ElementName = "type", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Type { get; set; }
        [XmlElement(ElementName = "codeLith", Namespace = "http://www.witsml.org/schemas/1series")]
        public string CodeLith { get; set; }
        [XmlElement(ElementName = "lithPc", Namespace = "http://www.witsml.org/schemas/1series")]
        public LithPc LithPc { get; set; }
        [XmlElement(ElementName = "description", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Description { get; set; }
        [XmlElement(ElementName = "lithClass", Namespace = "http://www.witsml.org/schemas/1series")]
        public string LithClass { get; set; }
        [XmlElement(ElementName = "grainType", Namespace = "http://www.witsml.org/schemas/1series")]
        public string GrainType { get; set; }
        [XmlElement(ElementName = "dunhamClass", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DunhamClass { get; set; }
        [XmlElement(ElementName = "color", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Color { get; set; }
        [XmlElement(ElementName = "texture", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Texture { get; set; }
        [XmlElement(ElementName = "hardness", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Hardness { get; set; }
        [XmlElement(ElementName = "compaction", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Compaction { get; set; }
        [XmlElement(ElementName = "sizeGrain", Namespace = "http://www.witsml.org/schemas/1series")]
        public string SizeGrain { get; set; }
        [XmlElement(ElementName = "roundness", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Roundness { get; set; }
        [XmlElement(ElementName = "sphericity", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Sphericity { get; set; }
        [XmlElement(ElementName = "sorting", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Sorting { get; set; }
        [XmlElement(ElementName = "matrixCement", Namespace = "http://www.witsml.org/schemas/1series")]
        public string MatrixCement { get; set; }
        [XmlElement(ElementName = "porosityVisible", Namespace = "http://www.witsml.org/schemas/1series")]
        public string PorosityVisible { get; set; }
        [XmlElement(ElementName = "porosityFabric", Namespace = "http://www.witsml.org/schemas/1series")]
        public string PorosityFabric { get; set; }
        [XmlElement(ElementName = "permeability", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Permeability { get; set; }
        [XmlElement(ElementName = "densShale", Namespace = "http://www.witsml.org/schemas/1series")]
        public DensShale DensShale { get; set; }
        [XmlElement(ElementName = "qualifier", Namespace = "http://www.witsml.org/schemas/1series")]
        public Qualifier Qualifier { get; set; }
        [XmlElement(ElementName = "extensionNameValue", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionNameValue { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
