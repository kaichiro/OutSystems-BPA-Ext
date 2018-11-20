using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssBPA {

	public interface IssBPA {

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
		/// <param name="ssCabecalho">. Utilizando uma Structure Cabecalho em forma de Record. .</param>
		void MssCreateCabecalho(DateTime sscbc_mvm_03, string sscbc_rsp_07, string sscbc_sgl_08, string sscbc_cgccpf_09, string sscbc_dst_10, string sscbc_dst_in_11, int ssnrFolhaIniciar, RCCabecalhoRecord ssCabecalho);

		/// <summary>
		/// . Acrescenta linha referente a registros de Individualizados (tipo 03) .
		/// </summary>
		/// <param name="ssIndividualizado">. Utilizando uma Structure Individualizado em forma de Record List. .</param>
		void MssAddIndividualizado(RLIndividualizadoRecordList ssIndividualizado);

	} // IssBPA

} // OutSystems.NssBPA
