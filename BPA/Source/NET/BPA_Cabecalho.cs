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
        private string Cbc_rsp_07 { get; set; }
        private string Cbc_sgl_08 { get; set; }
        private string Cbc_cgccpf_09 { get; set; }
        private string Cbc_dst_10 { get; set; }
        private string Cbc_dst_in_11 { get; set; }
        private string Cbc_versao_12 { get; set; }

        public BPA_Cabecalho(DateTime cbc_mvm_03, int cbc_lin_04, int cbc_flh_05/*, string cbc_smt_vrf_06*/,
            string cbc_rsp_07, string cbc_sgl_08, string cbc_cgccpf_09, string cbc_dst_10, string cbc_dst_in_11)
        {
            Cbc_mvm_03 = cbc_mvm_03;
            Cbc_lin_04 = cbc_lin_04;
            Cbc_flh_05 = cbc_flh_05;
            //Cbc_smt_vrf_06 = cbc_smt_vrf_06 ?? throw new ArgumentNullException(nameof(cbc_smt_vrf_06));
            Cbc_rsp_07 = cbc_rsp_07;
            Cbc_sgl_08 = cbc_sgl_08;
            Cbc_cgccpf_09 = cbc_cgccpf_09;
            Cbc_dst_10 = cbc_dst_10;
            Cbc_dst_in_11 = cbc_dst_in_11;
            Cbc_versao_12 = "v1.00.00";
        }

        public string GetCabecalhoLine(string _Cbc_smt_vrf_06_)
        {
            Cbc_smt_vrf_06 = _Cbc_smt_vrf_06_;
            string retorno = "01" + "#BPA#"
                + BPA_Utils.UPadLeft(Cbc_mvm_03.ToString(), 6, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Cbc_lin_04.ToString(), 6, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Cbc_flh_05.ToString(), 6, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Cbc_smt_vrf_06.ToString(), 4, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadRight(Cbc_rsp_07, 30, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadRight(Cbc_sgl_08, 6, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadLeft(Cbc_cgccpf_09, 14, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadRight(Cbc_dst_10, 40, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadRight(Cbc_dst_in_11, 1, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadRight(Cbc_versao_12, 10, BPA_Utils.Tipo.ESPACO)
                ;
            return retorno + string.Format("({0})", retorno.Length);
        }
    }
}