using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutSystems.NssBPA
{
    public class BPA_Individualizado
    {
        public BPA_Individualizado(string prd_cnes_02, DateTime prd_cmp_03, string prd_cnsmed_04, string prd_cbo_05,
            DateTime prd_dtaten_06/*, int prd_flh_07, int prd_seq_08*/, string prd_pa_09, string prd_cnspac_10,
            string prd_sexo_11, string prd_ibge_12, string prd_cid_13/*, int prd_idade_14*/, int prd_qt_15,
            string prd_caten_16, string prd_naut_17, string prd_org_18, string prd_nmpac_19, DateTime prd_dtnasc_20,
            string prd_raca_21, string prd_etnia_22, string prd_nac_23, string prd_srv_24, string prd_clf_25,
            string prd_equipe_seq_26, string prd_equipe_area_27, string prd_cnpj_28, string prd_cep_pcnte_29,
            string prd_lograd_pcnte_pcnte_30, string prd_end_pcnte_pcnte_31, string prd_compl_pcnte_32,
            string prd_num_pcnte_33, string prd_bairro_pcnte_34, string prd_ddtel_pcnte_35, string prd_email_pcnte_36,
            string prd_ine_37)
        {
            Prd_cnes_02 = prd_cnes_02 ?? throw new ArgumentNullException(nameof(prd_cnes_02));
            Prd_cmp_03 = prd_cmp_03;
            Prd_cnsmed_04 = prd_cnsmed_04 ?? throw new ArgumentNullException(nameof(prd_cnsmed_04));
            Prd_cbo_05 = prd_cbo_05 ?? throw new ArgumentNullException(nameof(prd_cbo_05));
            Prd_dtaten_06 = prd_dtaten_06;
            //Prd_flh_07 = prd_flh_07;
            //Prd_seq_08 = prd_seq_08;
            Prd_pa_09 = prd_pa_09 ?? throw new ArgumentNullException(nameof(prd_pa_09));
            Prd_cnspac_10 = prd_cnspac_10 ?? throw new ArgumentNullException(nameof(prd_cnspac_10));
            Prd_sexo_11 = prd_sexo_11 ?? throw new ArgumentNullException(nameof(prd_sexo_11));
            Prd_ibge_12 = prd_ibge_12 ?? throw new ArgumentNullException(nameof(prd_ibge_12));
            Prd_cid_13 = prd_cid_13 ?? throw new ArgumentNullException(nameof(prd_cid_13));
            Prd_idade_14 = prd_dtnasc_20.Year - Prd_dtaten_06.Year;
            Prd_qt_15 = prd_qt_15;
            Prd_caten_16 = prd_caten_16;
            Prd_naut_17 = prd_naut_17 ?? throw new ArgumentNullException(nameof(prd_naut_17));
            Prd_org_18 = prd_org_18 ?? throw new ArgumentNullException(nameof(prd_org_18));
            Prd_nmpac_19 = prd_nmpac_19 ?? throw new ArgumentNullException(nameof(prd_nmpac_19));
            Prd_dtnasc_20 = prd_dtnasc_20;
            Prd_raca_21 = prd_raca_21 ?? throw new ArgumentNullException(nameof(prd_raca_21));
            Prd_etnia_22 = prd_etnia_22 ?? throw new ArgumentNullException(nameof(prd_etnia_22));
            Prd_nac_23 = prd_nac_23 ?? throw new ArgumentNullException(nameof(prd_nac_23));
            Prd_srv_24 = prd_srv_24 ?? throw new ArgumentNullException(nameof(prd_srv_24));
            Prd_clf_25 = prd_clf_25 ?? throw new ArgumentNullException(nameof(prd_clf_25));
            Prd_equipe_seq_26 = prd_equipe_seq_26 ?? throw new ArgumentNullException(nameof(prd_equipe_seq_26));
            Prd_equipe_area_27 = prd_equipe_area_27 ?? throw new ArgumentNullException(nameof(prd_equipe_area_27));
            Prd_cnpj_28 = prd_cnpj_28 ?? throw new ArgumentNullException(nameof(prd_cnpj_28));
            Prd_cep_pcnte_29 = prd_cep_pcnte_29 ?? throw new ArgumentNullException(nameof(prd_cep_pcnte_29));
            Prd_lograd_pcnte_pcnte_30 = prd_lograd_pcnte_pcnte_30 ?? throw new ArgumentNullException(nameof(prd_lograd_pcnte_pcnte_30));
            Prd_end_pcnte_pcnte_31 = prd_end_pcnte_pcnte_31 ?? throw new ArgumentNullException(nameof(prd_end_pcnte_pcnte_31));
            Prd_compl_pcnte_32 = prd_compl_pcnte_32 ?? throw new ArgumentNullException(nameof(prd_compl_pcnte_32));
            Prd_num_pcnte_33 = prd_num_pcnte_33 ?? throw new ArgumentNullException(nameof(prd_num_pcnte_33));
            Prd_bairro_pcnte_34 = prd_bairro_pcnte_34 ?? throw new ArgumentNullException(nameof(prd_bairro_pcnte_34));
            Prd_ddtel_pcnte_35 = prd_ddtel_pcnte_35 ?? throw new ArgumentNullException(nameof(prd_ddtel_pcnte_35));
            Prd_email_pcnte_36 = prd_email_pcnte_36 ?? throw new ArgumentNullException(nameof(prd_email_pcnte_36));
            Prd_ine_37 = prd_ine_37 ?? throw new ArgumentNullException(nameof(prd_ine_37));
        }

        private string Prd_cnes_02 { get; set; }
        private DateTime Prd_cmp_03 { get; set; }
        private string Prd_cnsmed_04 { get; set; }
        private string Prd_cbo_05 { get; set; }
        private DateTime Prd_dtaten_06 { get; set; }
        public int Prd_flh_07 { get; set; }
        public int Prd_seq_08 { get; set; }
        private string Prd_pa_09 { get; set; }
        private string Prd_cnspac_10 { get; set; }
        private string Prd_sexo_11 { get; set; }
        private string Prd_ibge_12 { get; set; }
        private string Prd_cid_13 { get; set; }
        private int Prd_idade_14 { get; set; }
        private int Prd_qt_15 { get; set; }
        private string Prd_caten_16 { get; set; }
        private string Prd_naut_17 { get; set; }
        private string Prd_org_18 { get; set; }
        private string Prd_nmpac_19 { get; set; }
        private DateTime Prd_dtnasc_20 { get; set; }
        private string Prd_raca_21 { get; set; }
        private string Prd_etnia_22 { get; set; }
        private string Prd_nac_23 { get; set; }
        private string Prd_srv_24 { get; set; }
        private string Prd_clf_25 { get; set; }
        private string Prd_equipe_seq_26 { get; set; }
        private string Prd_equipe_area_27 { get; set; }
        private string Prd_cnpj_28 { get; set; }
        private string Prd_cep_pcnte_29 { get; set; }
        private string Prd_lograd_pcnte_pcnte_30 { get; set; }
        private string Prd_end_pcnte_pcnte_31 { get; set; }
        private string Prd_compl_pcnte_32 { get; set; }
        private string Prd_num_pcnte_33 { get; set; }
        private string Prd_bairro_pcnte_34 { get; set; }
        private string Prd_ddtel_pcnte_35 { get; set; }
        private string Prd_email_pcnte_36 { get; set; }
        private string Prd_ine_37 { get; set; }

        public long Get_09_15() => Prd_qt_15 + long.Parse("0" + BPA_Utils.RetornApenasNumeros(Prd_pa_09));

        public string GetIndividualizadoLine()
        {
            string retorno = "03"
                + BPA_Utils.UPadLeft(Prd_cnes_02, 7, BPA_Utils.Tipo.ZERO)
                + $"{Prd_cmp_03:yyyyMM}"
                + BPA_Utils.UPadLeft(Prd_cnsmed_04.ToString(), 15, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadRight(Prd_cbo_05, 6, BPA_Utils.Tipo.ESPACO)
                + $"{Prd_dtaten_06:yyyyMMdd}"
                + BPA_Utils.UPadLeft(Prd_flh_07.ToString(), 3, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_seq_08.ToString(), 2, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_pa_09, 10, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_cnspac_10, 15, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadRight(Prd_sexo_11, 1, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadLeft(Prd_ibge_12, 6, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadRight(Prd_cid_13, 4, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadLeft(Prd_idade_14.ToString(), 3, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_qt_15.ToString(), 6, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_caten_16.ToString(), 2, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_naut_17.ToString(), 13, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadRight(Prd_org_18, 3, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadRight(Prd_nmpac_19, 30, BPA_Utils.Tipo.ESPACO)
                + $"{Prd_dtnasc_20:yyyyMMdd}"
                + BPA_Utils.UPadLeft(Prd_raca_21, 2, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_etnia_22, 4, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_nac_23, 3, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_srv_24, 3, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_clf_25, 3, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_equipe_seq_26, 8, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_equipe_area_27, 4, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_cnpj_28, 14, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_cep_pcnte_29, 8, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadLeft(Prd_lograd_pcnte_pcnte_30, 3, BPA_Utils.Tipo.ZERO)
                + BPA_Utils.UPadRight(Prd_end_pcnte_pcnte_31, 30, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadRight(Prd_compl_pcnte_32, 10, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadRight(Prd_num_pcnte_33, 5, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadRight(Prd_bairro_pcnte_34, 30, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadRight(Prd_ddtel_pcnte_35, 11, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadRight(Prd_email_pcnte_36, 40, BPA_Utils.Tipo.ESPACO)
                + BPA_Utils.UPadLeft(Prd_ine_37, 10, BPA_Utils.Tipo.ZERO)
                ;
            retorno = retorno.Replace("\r\n", "") + "\r\n";
            return retorno + $"({retorno.Length})" + "\r\n";
        }
    }
}