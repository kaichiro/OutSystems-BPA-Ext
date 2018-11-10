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
        private string Cbc_smt_vrf_06 { get; set; }

        public BPA_Cabecalho(DateTime cbc_mvm_03, int cbc_lin_04, int cbc_flh_05/*, string cbc_smt_vrf_06*/)
        {
            Cbc_mvm_03 = cbc_mvm_03;
            Cbc_lin_04 = cbc_lin_04;
            Cbc_flh_05 = cbc_flh_05;
            //Cbc_smt_vrf_06 = cbc_smt_vrf_06 ?? throw new ArgumentNullException(nameof(cbc_smt_vrf_06));
        }

        public string GetCabecalhoLine(string _Cbc_smt_vrf_06_)
        {
            Cbc_smt_vrf_06 = _Cbc_smt_vrf_06_;
            return "01" + "#BPA#"
                + BPA_Utils.UPadLeft(Cbc_mvm_03.ToString(), 6, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Cbc_lin_04.ToString(), 6, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Cbc_flh_05.ToString(), 6, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Cbc_smt_vrf_06.ToString(), 4, BPA_Utils.Tipo.ZERO)
                ;
        }
    }
}