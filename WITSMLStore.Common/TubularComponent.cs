using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "tubularComponent", Namespace = "http://www.witsml.org/schemas/131")]
    public class TubularComponent
    {
        [XmlElement(ElementName = "typeTubularComp", Namespace = "http://www.witsml.org/schemas/131")]
        public string TypeTubularComp { get; set; }
        [XmlElement(ElementName = "sequence", Namespace = "http://www.witsml.org/schemas/131")]
        public string Sequence { get; set; }
        [XmlElement(ElementName = "description", Namespace = "http://www.witsml.org/schemas/131")]
        public string Description { get; set; }
        [XmlElement(ElementName = "id", Namespace = "http://www.witsml.org/schemas/131")]
        public Id Id { get; set; }
        [XmlElement(ElementName = "od", Namespace = "http://www.witsml.org/schemas/131")]
        public Od Od { get; set; }
        [XmlElement(ElementName = "odMx", Namespace = "http://www.witsml.org/schemas/131")]
        public OdMx OdMx { get; set; }
        [XmlElement(ElementName = "len", Namespace = "http://www.witsml.org/schemas/131")]
        public Len Len { get; set; }
        [XmlElement(ElementName = "lenJointAv", Namespace = "http://www.witsml.org/schemas/131")]
        public LenJointAv LenJointAv { get; set; }
        [XmlElement(ElementName = "numJointStand", Namespace = "http://www.witsml.org/schemas/131")]
        public string NumJointStand { get; set; }
        [XmlElement(ElementName = "wtPerLen", Namespace = "http://www.witsml.org/schemas/131")]
        public WtPerLen WtPerLen { get; set; }
        [XmlElement(ElementName = "grade", Namespace = "http://www.witsml.org/schemas/131")]
        public string Grade { get; set; }
        [XmlElement(ElementName = "odDrift", Namespace = "http://www.witsml.org/schemas/131")]
        public OdDrift OdDrift { get; set; }
        [XmlElement(ElementName = "tensYield", Namespace = "http://www.witsml.org/schemas/131")]
        public TensYield TensYield { get; set; }
        [XmlElement(ElementName = "tqYield", Namespace = "http://www.witsml.org/schemas/131")]
        public TqYield TqYield { get; set; }
        [XmlElement(ElementName = "stressFatig", Namespace = "http://www.witsml.org/schemas/131")]
        public StressFatig StressFatig { get; set; }
        [XmlElement(ElementName = "lenFishneck", Namespace = "http://www.witsml.org/schemas/131")]
        public LenFishneck LenFishneck { get; set; }
        [XmlElement(ElementName = "idFishneck", Namespace = "http://www.witsml.org/schemas/131")]
        public IdFishneck IdFishneck { get; set; }
        [XmlElement(ElementName = "odFishneck", Namespace = "http://www.witsml.org/schemas/131")]
        public OdFishneck OdFishneck { get; set; }
        [XmlElement(ElementName = "disp", Namespace = "http://www.witsml.org/schemas/131")]
        public Disp Disp { get; set; }
        [XmlElement(ElementName = "presBurst", Namespace = "http://www.witsml.org/schemas/131")]
        public PresBurst PresBurst { get; set; }
        [XmlElement(ElementName = "presCollapse", Namespace = "http://www.witsml.org/schemas/131")]
        public PresCollapse PresCollapse { get; set; }
        [XmlElement(ElementName = "classService", Namespace = "http://www.witsml.org/schemas/131")]
        public string ClassService { get; set; }
        [XmlElement(ElementName = "wearWall", Namespace = "http://www.witsml.org/schemas/131")]
        public WearWall WearWall { get; set; }
        [XmlElement(ElementName = "thickWall", Namespace = "http://www.witsml.org/schemas/131")]
        public ThickWall ThickWall { get; set; }
        [XmlElement(ElementName = "configCon", Namespace = "http://www.witsml.org/schemas/131")]
        public string ConfigCon { get; set; }
        [XmlElement(ElementName = "bendStiffness", Namespace = "http://www.witsml.org/schemas/131")]
        public BendStiffness BendStiffness { get; set; }
        [XmlElement(ElementName = "axialStiffness", Namespace = "http://www.witsml.org/schemas/131")]
        public AxialStiffness AxialStiffness { get; set; }
        [XmlElement(ElementName = "torsionalStiffness", Namespace = "http://www.witsml.org/schemas/131")]
        public TorsionalStiffness TorsionalStiffness { get; set; }
        [XmlElement(ElementName = "typeMaterial", Namespace = "http://www.witsml.org/schemas/131")]
        public string TypeMaterial { get; set; }
        [XmlElement(ElementName = "doglegMx", Namespace = "http://www.witsml.org/schemas/131")]
        public DoglegMx DoglegMx { get; set; }
        [XmlElement(ElementName = "vendor", Namespace = "http://www.witsml.org/schemas/131")]
        public string Vendor { get; set; }
        [XmlElement(ElementName = "model", Namespace = "http://www.witsml.org/schemas/131")]
        public string Model { get; set; }
        [XmlElement(ElementName = "nameTag", Namespace = "http://www.witsml.org/schemas/131")]
        public NameTag NameTag { get; set; }
        [XmlElement(ElementName = "bitRecord", Namespace = "http://www.witsml.org/schemas/131")]
        public BitRecord BitRecord { get; set; }
        [XmlElement(ElementName = "areaNozzleFlow", Namespace = "http://www.witsml.org/schemas/131")]
        public AreaNozzleFlow AreaNozzleFlow { get; set; }
        [XmlElement(ElementName = "nozzle", Namespace = "http://www.witsml.org/schemas/131")]
        public Nozzle Nozzle { get; set; }
        [XmlElement(ElementName = "connection", Namespace = "http://www.witsml.org/schemas/131")]
        public Connection Connection { get; set; }
        [XmlElement(ElementName = "jar", Namespace = "http://www.witsml.org/schemas/131")]
        public Jar Jar { get; set; }
        [XmlElement(ElementName = "mwdTool", Namespace = "http://www.witsml.org/schemas/131")]
        public MwdTool MwdTool { get; set; }
        [XmlElement(ElementName = "motor", Namespace = "http://www.witsml.org/schemas/131")]
        public Motor Motor { get; set; }
        [XmlElement(ElementName = "stabilizer", Namespace = "http://www.witsml.org/schemas/131")]
        public Stabilizer Stabilizer { get; set; }
        [XmlElement(ElementName = "bend", Namespace = "http://www.witsml.org/schemas/131")]
        public Bend Bend { get; set; }
        [XmlElement(ElementName = "holeOpener", Namespace = "http://www.witsml.org/schemas/131")]
        public HoleOpener HoleOpener { get; set; }
        [XmlElement(ElementName = "rotarySteerableTool", Namespace = "http://www.witsml.org/schemas/131")]
        public RotarySteerableTool RotarySteerableTool { get; set; }
        [XmlElement(ElementName = "customData", Namespace = "http://www.witsml.org/schemas/131")]
        public string CustomData { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
