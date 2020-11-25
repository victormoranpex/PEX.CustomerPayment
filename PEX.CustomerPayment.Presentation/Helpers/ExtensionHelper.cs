using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace PEX.CustomerPayment.Presentation.Helpers
{
    public static class ExtensionHelper
    {
        public static string ToXML(this object value)
        {
            var stringwriter = new StringWriter();
            var serializer = new XmlSerializer(value.GetType());
            serializer.Serialize(stringwriter, value);
            return stringwriter.ToString();
        }

        public static bool IsNullOrEmpty(this string val)
        {
            return string.IsNullOrEmpty(val);
        }

        public static string RemoveSpecialCharacters(this String val)
        {
            if (val.IsNullOrEmpty())
                return "";

            StringBuilder sb = new StringBuilder();
            foreach (var item in val)
            {
                if (!item.Equals("'") && !item.Equals("-"))
                {
                    sb.Append(item);
                }
            }

            val = sb.ToString().ToUpper(CultureInfo.CurrentCulture).Trim();
            return val;
        }

        public static string ConvertToUTF8(this string text)
        {
            return text.Replace("\\A1", "í").Replace("\\A0", "á").Replace("\\A2", "ó").Replace("\\82", "é").Replace("\\A4", "ñ").Replace("\\A3", "ú");
        }
    }
}