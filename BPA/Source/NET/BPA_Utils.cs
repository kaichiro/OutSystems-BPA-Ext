using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OutSystems.NssBPA
{
    public static class BPA_Utils
    {
        public enum Tipo { ESPACO, ZERO, NADA }
        private enum TipoPad { LEFT, RIGHT }

        private static char TipoChar(Tipo tipo_)
            => (Tipo.ESPACO.Equals(tipo_) ? char.Parse(" ") : (Tipo.ZERO.Equals(tipo_) ? char.Parse("0") : char.Parse("")));

        public static string RemoverAcentuacao(this string text)
        {
            return Regex.Replace(RemoveDiacritics(text), "[^0-9a-zA-Z ]+", "");

            //if (string.IsNullOrEmpty(text))
            //    return String.Empty;
            //byte[] bytes = System.Text.Encoding.GetEncoding("iso-8859-8").GetBytes(text);
            //return System.Text.Encoding.UTF8.GetString(bytes);

            //return new string(text
            //    .Normalize(NormalizationForm.FormD)
            //    .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
            //    .ToArray());
        }

        public static string RetornApenasNumeros(string s) 
            => String.Join("", System.Text.RegularExpressions.Regex.Split(s, @"[^\d]"));


        public static string UPadLeft(string string_, int length_, Tipo tipo_)
        {
            string s_ = Tipo.ZERO.Equals(tipo_) ? RetornApenasNumeros(string_) : RemoverAcentuacao(string_);
            return s_.PadLeft(length_, TipoChar(tipo_)).Substring(0, length_);
        }

        public static string UPadRight(string string_, int length_, Tipo tipo_)
        {
            string s = Tipo.ESPACO.Equals(tipo_) ? RemoverAcentuacao(string_) : string_;
            return s.PadRight(length_, TipoChar(tipo_)).Substring(0, length_);
        }

        #region Diacritics
        public static string RemoveDiacritics(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > 255)
                    sb.Append(text[i]);
                else
                    sb.Append(s_Diacritics[text[i]]);
            }

            return sb.ToString();
        }

        private static readonly char[] s_Diacritics = GetDiacritics();
        private static char[] GetDiacritics()
        {
            char[] accents = new char[256];

            for (int i = 0; i < 256; i++)
                accents[i] = (char)i;

            accents[(byte)'á'] = accents[(byte)'à'] = accents[(byte)'ã'] = accents[(byte)'â'] = accents[(byte)'ä'] = 'a';
            accents[(byte)'Á'] = accents[(byte)'À'] = accents[(byte)'Ã'] = accents[(byte)'Â'] = accents[(byte)'Ä'] = 'A';

            accents[(byte)'é'] = accents[(byte)'è'] = accents[(byte)'ê'] = accents[(byte)'ë'] = 'e';
            accents[(byte)'É'] = accents[(byte)'È'] = accents[(byte)'Ê'] = accents[(byte)'Ë'] = 'E';

            accents[(byte)'í'] = accents[(byte)'ì'] = accents[(byte)'î'] = accents[(byte)'ï'] = 'i';
            accents[(byte)'Í'] = accents[(byte)'Ì'] = accents[(byte)'Î'] = accents[(byte)'Ï'] = 'I';

            accents[(byte)'ó'] = accents[(byte)'ò'] = accents[(byte)'ô'] = accents[(byte)'õ'] = accents[(byte)'ö'] = 'o';
            accents[(byte)'Ó'] = accents[(byte)'Ò'] = accents[(byte)'Ô'] = accents[(byte)'Õ'] = accents[(byte)'Ö'] = 'O';

            accents[(byte)'ú'] = accents[(byte)'ù'] = accents[(byte)'û'] = accents[(byte)'ü'] = 'u';
            accents[(byte)'Ú'] = accents[(byte)'Ù'] = accents[(byte)'Û'] = accents[(byte)'Ü'] = 'U';

            accents[(byte)'ç'] = 'c';
            accents[(byte)'Ç'] = 'C';

            accents[(byte)'ñ'] = 'n';
            accents[(byte)'Ñ'] = 'N';

            accents[(byte)'ÿ'] = accents[(byte)'ý'] = 'y';
            accents[(byte)'Ý'] = 'Y';

            return accents;
        }
        #endregion
    }
}
