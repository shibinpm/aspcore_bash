using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "commonData", Namespace = "http://www.witsml.org/schemas/1series")]
    public class CommonData
    {
        [XmlElement(ElementName = "sourceName", Namespace = "http://www.witsml.org/schemas/1series")]
        public string SourceName { get; set; }
        [XmlElement(ElementName = "dTimCreation", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimCreation { get; set; }
        [XmlElement(ElementName = "dTimLastChange", Namespace = "http://www.witsml.org/schemas/1series")]
        public string DTimLastChange { get; set; }
        [XmlElement(ElementName = "itemState", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ItemState { get; set; }
        [XmlElement(ElementName = "serviceCategory", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ServiceCategory { get; set; }
        [XmlElement(ElementName = "comments", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Comments { get; set; }
        [XmlElement(ElementName = "acquisitionTimeZone", Namespace = "http://www.witsml.org/schemas/1series")]
        public AcquisitionTimeZone AcquisitionTimeZone { get; set; }
        [XmlElement(ElementName = "defaultDatum", Namespace = "http://www.witsml.org/schemas/1series")]
        public DefaultDatum DefaultDatum { get; set; }
        [XmlElement(ElementName = "privateGroupOnly", Namespace = "http://www.witsml.org/schemas/1series")]
        public string PrivateGroupOnly { get; set; }
        [XmlElement(ElementName = "extensionAny", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionAny { get; set; }
        [XmlElement(ElementName = "extensionNameValue", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionNameValue { get; set; }
    }
}
