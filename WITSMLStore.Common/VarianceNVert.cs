﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "varianceNVert", Namespace = "http://www.witsml.org/schemas/1series")]
    public class VarianceNVert
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }
}