using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSystems.NssBPA
{
    public static class BPA_Utils
    {
        public enum Tipo { ESPACO, ZERO, NADA }
        private enum TipoPad { LEFT, RIGHT }

        private static char TipoChar(Tipo tipo_) { return (Tipo.ESPACO.Equals(tipo_) ? char.Parse(" ") : (Tipo.ZERO.Equals(tipo_) ? char.Parse("0") : char.Parse(""))); }

        public static string RetornApenasNumeros(string s)
        {
            return String.Join("", System.Text.RegularExpressions.Regex.Split(s, @"[^\d]"));
        }

        public static string UPadLeft(string string_, int length_, Tipo tipo_)
        {
            string s_ = Tipo.ZERO.Equals(tipo_) ? RetornApenasNumeros(string_) : string_;
            return s_.PadLeft(length_, TipoChar(tipo_)).Substring(0, length_);
        }

        public static string UPadRight(string string_, int length_, Tipo tipo_)
        {
            return string_.PadRight(length_, TipoChar(tipo_)).Substring(0, length_);
        }

    }
}
