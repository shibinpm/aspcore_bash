using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "location", Namespace = "http://www.witsml.org/schemas/1series")]
    public class Location
    {
        [XmlElement(ElementName = "wellCRS", Namespace = "http://www.witsml.org/schemas/1series")]
        public WellCRS WellCRS { get; set; }
        [XmlElement(ElementName = "latitude", Namespace = "http://www.witsml.org/schemas/1series")]
        public Latitude Latitude { get; set; }
        [XmlElement(ElementName = "longitude", Namespace = "http://www.witsml.org/schemas/1series")]
        public Longitude Longitude { get; set; }
        [XmlElement(ElementName = "easting", Namespace = "http://www.witsml.org/schemas/1series")]
        public Easting Easting { get; set; }
        [XmlElement(ElementName = "northing", Namespace = "http://www.witsml.org/schemas/1series")]
        public Northing Northing { get; set; }
        [XmlElement(ElementName = "westing", Namespace = "http://www.witsml.org/schemas/1series")]
        public Westing Westing { get; set; }
        [XmlElement(ElementName = "southing", Namespace = "http://www.witsml.org/schemas/1series")]
        public Southing Southing { get; set; }
        [XmlElement(ElementName = "projectedX", Namespace = "http://www.witsml.org/schemas/1series")]
        public ProjectedX ProjectedX { get; set; }
        [XmlElement(ElementName = "projectedY", Namespace = "http://www.witsml.org/schemas/1series")]
        public ProjectedY ProjectedY { get; set; }
        [XmlElement(ElementName = "localX", Namespace = "http://www.witsml.org/schemas/1series")]
        public LocalX LocalX { get; set; }
        [XmlElement(ElementName = "localY", Namespace = "http://www.witsml.org/schemas/1series")]
        public LocalY LocalY { get; set; }
        [XmlElement(ElementName = "original", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Original { get; set; }
        [XmlElement(ElementName = "description", Namespace = "http://www.witsml.org/schemas/1series")]
        public string Description { get; set; }
        [XmlElement(ElementName = "extensionNameValue", Namespace = "http://www.witsml.org/schemas/1series")]
        public string ExtensionNameValue { get; set; }
        [XmlAttribute(AttributeName = "uid")]
        public string Uid { get; set; }
    }
}
