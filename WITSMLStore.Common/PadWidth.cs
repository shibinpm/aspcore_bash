﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WITSMLStore.Common
{
    [XmlRoot(ElementName = "padWidth", Namespace = "http://www.witsml.org/schemas/131")]
    public class PadWidth
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
    }

}
