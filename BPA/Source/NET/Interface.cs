using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssBPA {

	public interface IssBPA {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sscbc_mvm_03"></param>
		/// <param name="sscbc_lin_04"></param>
		/// <param name="sscbc_flh_05"></param>
		void MssCreateCabecalho(int sscbc_mvm_03, int sscbc_lin_04, int sscbc_flh_05);

	} // IssBPA

} // OutSystems.NssBPA
