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

        public void CreateBPA_Cabecalho(DateTime cbc_mvm_03, int cbc_lin_04, int cbc_flh_05)
            => bpaCabecalho = new BPA_Cabecalho(cbc_mvm_03, cbc_lin_04, cbc_flh_05);

        public void AddBPA_Individualizado(string prd_cnes_02, DateTime prd_cmp_03, string prd_cnsmed_04)
            => bpaIndividualizados.Add(new BPA_Individualizado(prd_cnes_02, prd_cmp_03, prd_cnsmed_04));

        private string GetIndividualizadosLines()
        {
            string individualizadosLinhas = "";
            foreach (BPA_Individualizado indiv in bpaIndividualizados)
            {
                individualizadosLinhas += "\r\n" + indiv.GetIndividualizadoLine();
            }
            return individualizadosLinhas;
        }

        public string GetFullBPA() => bpaCabecalho.GetCabecalhoLine() + GetIndividualizadosLines();
    }
}

