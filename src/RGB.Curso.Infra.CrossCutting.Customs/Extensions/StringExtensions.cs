using System;
using System.Linq;

namespace RGB.Curso.Infra.CrossCutting.Customs.Extensions
{
    public static class StringExtensions
    {
        public static string SomenteNumeros(this string strIn)
        {
            if (strIn != null)
            {
                var somentenumeros = new String(strIn.Where(c => Char.IsDigit(c)).ToArray());
                return somentenumeros;
            }
            return "";
        }

        public static string SomenteLetras(this string strIn)
        {
            if (strIn != null)
            {
                var somenteletras = new String(strIn.Where(c => Char.IsLetter(c)).ToArray());
                return somenteletras;
            }
            return "";
        }

        public static string DefaultString(this Object value, string defaultValue = "")
        {
            if (value == Convert.DBNull)
                return Convert.ToString(defaultValue);
            return Convert.ToString(value).Trim();
        }

        public static string PadraoDecimal(this string strIn)
        {
            if (string.IsNullOrEmpty(strIn) || strIn == "00,00")
            {
                return "0.00";
            }

            if (strIn.Length <= 2)
            {
                return strIn + "." + "00";
            }
            else
            {
                strIn = strIn.Replace(".", "").Replace(",", "");
                strIn = strIn.Substring(0, strIn.Length - 2) + "." + strIn.Substring(strIn.Length - 2, 2);
            }
            return strIn;
        }
    }
}
