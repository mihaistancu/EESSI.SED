﻿using System.Xml;
using System.Xml.Serialization;

namespace EESSI.SED.Tests
{
    public class XmlToObject
    {
        public static T Deserialize<T>(XmlNode xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new XmlNodeReader(xml))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
