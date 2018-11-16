using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutSystems.NssBPA
{
    public class BPA_Controller
    {
        private BPA_Cabecalho bpaCabecalho;
        private List<BPA_Individualizado> bpaIndividualizados = new List<BPA_Individualizado>();

        public void CreateBPA_Cabecalho(DateTime cbc_mvm_03, int cbc_lin_04, int cbc_flh_05/*, string cbc_smt_vrf_06*/,
            string cbc_rsp_07, string cbc_sgl_08, string cbc_cgccpf_09, string cbc_dst_10, string cbc_dst_in_11)
            => bpaCabecalho = new BPA_Cabecalho(cbc_mvm_03, cbc_lin_04, cbc_flh_05/*, cbc_smt_vrf_06*/, cbc_rsp_07, cbc_sgl_08,
                cbc_cgccpf_09, cbc_dst_10, cbc_dst_in_11);

        public void AddBPA_Individualizado(string prd_cnes_02, DateTime prd_cmp_03, string prd_cnsmed_04, string prd_pa_09, int prd_qt_15)
            => bpaIndividualizados.Add(new BPA_Individualizado(prd_cnes_02, prd_cmp_03, prd_cnsmed_04, prd_pa_09, prd_qt_15));

        private string GetIndividualizadosLines()
        {
            Int64 acum = 0;
            string individualizadosLinhas = "";
            foreach (BPA_Individualizado indiv in bpaIndividualizados)
            {
                acum += indiv.Get_09_15();
                individualizadosLinhas += indiv.GetIndividualizadoLine() + "\r\n";
            }
            return bpaCabecalho.GetCabecalhoLine($"{(acum % 1111) + 1111}") + "\r\n" + individualizadosLinhas;
        }

        public string GetFullBPA() => GetIndividualizadosLines();
    }
}

