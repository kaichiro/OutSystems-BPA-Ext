using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;

namespace OutSystems.NssBPA
{

    public class CssBPA : IssBPA
    {

        /// <summary>
        /// . Acrescenta linha referente a registros de Individualizados (tipo 03) .
        /// </summary>
        /// <param name="ssprd_cnes_02">. Cadastro Nacional de Estabelecimentos de Saúde - CNES .</param>
        /// <param name="ssprd_cmp_03">. Competência/data de realialização do procedimento. .</param>
        /// <param name="ssprd_cnsmed_04">. Número CNS do Profissional, com dígito verificador válido. .</param>
        /// <param name="ssprd_cbo_05">. Código Brasileiro de Ocupação - COB do profissional. .</param>
        /// <param name="ssprd_dtaten_06">. Data do atendimento. .</param>
        /// <param name="ssprd_pa_09">. Código do procedimento ambulatorial, com dígito verificador. Ex.: 0202010015, 0202020541, ... .</param>
        /// <param name="ssprd_cnspac_10">. CNS do paciente, com dígito verificador. .</param>
        /// <param name="ssprd_sexo_11">. Sexo do paciente (M masculino, F feminino). .</param>
        /// <param name="ssprd_ibge_12">. Código IBGE do município de residência paciente. .</param>
        /// <param name="ssprd_cid_13">. CID-10 .</param>
        /// <param name="ssprd_qt_15">. Quantidade de procedimentos produzidos. .</param>
        /// <param name="ssprd_caten_16">. Carater de atendimento (apenas código): 01-eletivo, 02-urgência, 03-acidente no local de trabalho, 04-acidente no trajeto par ao trabalho, 05-outros tipos de acidente de trânsito, 06-outros tipos de lesões. .</param>
        /// <param name="ssprd_naut_17">. Número de autorização do estabelecimento (número protocolo). .</param>
        /// <param name="ssprd_org_18">. Orgão de informações: BPA-SIA/SUS, PNI-Prog. Nac. de Imunizações, SIE-SIGAE, SIB-SIGAB, PAC-Programa Ação Comunitária, SCL-SISCOLO, EXT-Outros sistemas. Por padrão, informe BPA. .</param>
        /// <param name="ssprd_nmpac_19">. Nome completo do paciente. .</param>
        /// <param name="ssprd_dtnasc_20">. Data nascimento do paciente. .</param>
        /// <param name="ssIndividualizadoStrc"></param>
        public void MssAddIndividualizado(RLIndividualizadoRecordList ssIndividualizado)
        {
            // TODO: Write implementation for action
        } // MssAddIndividualizado

        BPA_Controller bpaCTRL;

        //string prd_cnes_02
        //DateTime prd_cmp_03
        //string prd_cnsmed_04
        //string prd_cbo_05
        //DateTime prd_dtaten_06
        //string prd_pa_09
        //string prd_cnspac_10
        //string prd_sexo_11
        //string prd_ibge_12
        //string prd_cid_13
        //int prd_qt_15
        //string prd_caten_16
        //string prd_naut_17
        //string prd_org_18
        //string prd_nmpac_19
        //DateTime prd_dtnasc_20
        //string prd_raca_21
        //string prd_etnia_22
        //string prd_nac_23
        //string prd_srv_24
        //string prd_clf_25
        //string prd_equipe_seq_26
        //string prd_equipe_area_27
        //string prd_cnpj_28
        //string prd_cp_pcnte_29
        //string prd_lograd_pcnte_pcnte_30
        //string prd_end_pcnte_pcnte_31
        //string prd_compl_pcnte_32
        //string prd_num_pcnte_33
        //string prd_bairro_pcnte_34
        //string prd_ddtel_pcnte_35
        //string prd_email_pcnte_36
        //string prd_ine_37

        /// <summary>
        /// . Cria cabeçalho de registro Boletim de Produção Ambulatorial (BPA). .
        /// </summary>
        /// <param name="sscbc_mvm_03">. Data de Processamento de Produção. .</param>
        /// <param name="sscbc_rsp_07">. Nome do orgão responsável pela informação. Ex.: Laboratorio Ab Clinico .</param>
        /// <param name="sscbc_sgl_08">. Sigla do orgão responsável pela informação. Ex.: LABC .</param>
        /// <param name="sscbc_cgccpf_09">. CGC/CPF do prestador ou do órgão público responsável pela informação, conforme cadastro na Receita Federal. .</param>
        /// <param name="sscbc_dst_10">. Nome do órgão de saúde destino do arquivo. Ex.: Secretaria Mpnicipal de Saudade de Resende .</param>
        /// <param name="sscbc_dst_in_11">. Indicador do órgão destino (E estadual ou M municipal). .</param>
        /// <param name="ssnrFolhaIniciar">. Contador de folhas. Ex.: 300 .</param>
        public void MssCreateCabecalho(DateTime sscbc_mvm_03, string sscbc_rsp_07, string sscbc_sgl_08, string sscbc_cgccpf_09, string sscbc_dst_10, string sscbc_dst_in_11, int ssnrFolhaIniciar, RCCabecalhoRecord ssCabecalho)
        {
            // TODO: Write implementation for action
            bpaCTRL.CreateBPA_Cabecalho(sscbc_mvm_03, sscbc_rsp_07, sscbc_sgl_08, sscbc_cgccpf_09, sscbc_dst_10, sscbc_dst_in_11, ssnrFolhaIniciar);
        } // MssCreateCabecalho

    } // CssBPA

} // OutSystems.NssBPA

