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
        private int QtdeLinhas { get; set; }
        private int NrSequencial { get; set; }

        public void CreateBPA_Cabecalho(DateTime cbc_mvm_03/*, int cbc_lin_04, int cbc_flh_05, string cbc_smt_vrf_06*/,
                string cbc_rsp_07, string cbc_sgl_08, string cbc_cgccpf_09, string cbc_dst_10, string cbc_dst_in_11,
                int nrFolhaIniciar
            )
            => bpaCabecalho = new BPA_Cabecalho(cbc_mvm_03/*, cbc_lin_04, cbc_flh_05, cbc_smt_vrf_06*/, cbc_rsp_07,
                    cbc_sgl_08, cbc_cgccpf_09, cbc_dst_10, cbc_dst_in_11, nrFolhaIniciar
                );

        public void AddBPA_Individualizado(string prd_cnes_02, DateTime prd_cmp_03, string prd_cnsmed_04, string prd_cbo_05,
                DateTime prd_dtaten_06/*, int prd_flh_07, int prd_seq_08*/, string prd_pa_09, string prd_cnspac_10,
                string prd_sexo_11, string prd_ibge_12, string prd_cid_13/*, int prd_idade_14*/, int prd_qt_15,
                string prd_caten_16, string prd_naut_17, string prd_org_18, string prd_nmpac_19, DateTime prd_dtnasc_20,
                string prd_raca_21, string prd_etnia_22, string prd_nac_23, string prd_srv_24, string prd_clf_25,
                string prd_equipe_seq_26, string prd_equipe_area_27, string prd_cnpj_28, string prd_cp_pcnte_29,
                string prd_lograd_pcnte_pcnte_30, string prd_end_pcnte_pcnte_31, string prd_compl_pcnte_32,
                string prd_num_pcnte_33, string prd_bairro_pcnte_34, string prd_ddtel_pcnte_35, string prd_email_pcnte_36,
                string prd_ine_37
            )
            => bpaIndividualizados.Add(new BPA_Individualizado(prd_cnes_02, prd_cmp_03, prd_cnsmed_04, prd_cbo_05,
                    prd_dtaten_06/*, prd_flh_07, prd_seq_08*/, prd_pa_09, prd_cnspac_10,
                    prd_sexo_11, prd_ibge_12, prd_cid_13/*, prd_idade_14*/, prd_qt_15,
                    prd_caten_16, prd_naut_17, prd_org_18, prd_nmpac_19, prd_dtnasc_20,
                    prd_raca_21, prd_etnia_22, prd_nac_23, prd_srv_24, prd_clf_25,
                    prd_equipe_seq_26, prd_equipe_area_27, prd_cnpj_28, prd_cp_pcnte_29,
                    prd_lograd_pcnte_pcnte_30, prd_end_pcnte_pcnte_31, prd_compl_pcnte_32,
                    prd_num_pcnte_33, prd_bairro_pcnte_34, prd_ddtel_pcnte_35, prd_email_pcnte_36,
                    prd_ine_37
                ));

        private string GetIndividualizadosLines()
        {
            NrSequencial = bpaCabecalho.NrFolhaIniciar;
            int QtdeLinhasLocal = 0;

            Int64 acum = 0;
            string individualizadosLinhas = "";
            foreach (BPA_Individualizado indiv in bpaIndividualizados)
            {
                if (QtdeLinhasLocal < 100)
                {
                    QtdeLinhasLocal++;
                }
                else
                {
                    QtdeLinhasLocal = 1;
                    NrSequencial++;
                }

                acum += indiv.Get_09_15();
                indiv.Prd_flh_07 = QtdeLinhasLocal;
                indiv.Prd_seq_08 = NrSequencial;
                individualizadosLinhas += indiv.GetIndividualizadoLine() ;
            }

            bpaCabecalho.Cbc_lin_04 = QtdeLinhas;
            bpaCabecalho.Cbc_flh_05 = NrSequencial;

            return bpaCabecalho.GetCabecalhoLine($"{(acum % 1111) + 1111}") + individualizadosLinhas;
        }

        public string GetFullBPA() => GetIndividualizadosLines();
    }
}

