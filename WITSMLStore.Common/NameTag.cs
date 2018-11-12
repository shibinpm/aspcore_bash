using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{

    [XmlRoot(ElementName = "nameTag", Namespace = "http://www.witsml.org/schemas/131")]
    public class NameTag
    {
        [XmlElement(ElementName = "name", Namespace = "http://www.witsml.org/schemas/131")]
        public string Name { get; set; }
        [XmlElement(ElementName = "numberingScheme", Namespace = "http://www.witsml.org/schemas/131")]
        public string NumberingScheme { get; set; }
        [XmlElement(ElementName = "technology", Namespace = "http://www.witsml.org/schemas/131")]
        public string Technology { get; set; }
        [XmlElement(ElementName = "location", Namespace = "http://www.witsml.org/schemas/131")]
        public string Location { get; set; }
        [XmlElement(ElementName = "installationDate", Namespace = "http://www.witsml.org/schemas/131")]
        public string InstallationDate { get; set; }
        [XmlElement(ElementName = "installationCompany", Namespace = "http://www.witsml.org/schemas/131")]
        public string InstallationCompany { get; set; }
        [XmlElement(ElementName = "mountingCode", Namespace = "http://www.witsml.org/schemas/131")]
        public string MountingCode { get; set; }
        [XmlElement(ElementName = "comment", Namespace = "http://www.witsml.org/schemas/131")]
        public string Comment { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
