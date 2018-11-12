using System;
using System.Collections.Generic;
using WITSMLStore.Common;

namespace WITSMLStore.Converters
{
    public class WellConverter
    {
        public Well ToWell(string xml)
        {
            return new Well();
        }

        public string ToXml(Well well)
        {
            return string.Empty;
        }

        public string ToXml(List<Well> wells)
        {
            return string.Empty;
        }
    }
}
