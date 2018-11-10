using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutSystems.NssBPA
{
    public class BPA_Cabecalho
    {
        private DateTime Cbc_mvm_03 { get; set; }
        private int Cbc_lin_04 { get; set; }
        private int Cbc_flh_05 { get; set; }

        public BPA_Cabecalho() { }

        public BPA_Cabecalho(DateTime cbc_mvm_03, int cbc_lin_04, int cbc_flh_05)
        {
            Cbc_mvm_03 = cbc_mvm_03;
            Cbc_lin_04 = cbc_lin_04;
            Cbc_flh_05 = cbc_flh_05;
        }

        public string GetCabecalhoLine()
        {
            return "01" + "#BPA#"
                + Cbc_mvm_03.ToString()
                + Cbc_lin_04.ToString()
                + Cbc_flh_05.ToString()
                ;
        }
    }
}