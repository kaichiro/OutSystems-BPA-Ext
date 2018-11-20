using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.NewRuntime;

namespace OutSystems.NssBPA {

	/// <summary>
	/// RecordList type <code>RLIndividualizadoRecordList</code> that represents a record list of
	///  <code>Individualizado</code>
	/// </summary>
	[Serializable()]
	public partial class RLIndividualizadoRecordList: GenericRecordList<RCIndividualizadoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCIndividualizadoRecord GetElementDefaultValue() {
			return new RCIndividualizadoRecord("");
		}

		public T[] ToArray<T>(Func<RCIndividualizadoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLIndividualizadoRecordList recordlist, Func<RCIndividualizadoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLIndividualizadoRecordList(RCIndividualizadoRecord[] array) {
			RLIndividualizadoRecordList result = new RLIndividualizadoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLIndividualizadoRecordList ToList<T>(T[] array, Func <T, RCIndividualizadoRecord> converter) {
			RLIndividualizadoRecordList result = new RLIndividualizadoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLIndividualizadoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCIndividualizadoRecord> converter) {
			RLIndividualizadoRecordList result = new RLIndividualizadoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLIndividualizadoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIndividualizadoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLIndividualizadoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLIndividualizadoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCIndividualizadoRecord> NewList() {
			return new RLIndividualizadoRecordList();
		}


	} // RLIndividualizadoRecordList

	/// <summary>
	/// RecordList type <code>RLCabecalhoRecordList</code> that represents a record list of
	///  <code>Cabecalho</code>
	/// </summary>
	[Serializable()]
	public partial class RLCabecalhoRecordList: GenericRecordList<RCCabecalhoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCCabecalhoRecord GetElementDefaultValue() {
			return new RCCabecalhoRecord("");
		}

		public T[] ToArray<T>(Func<RCCabecalhoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLCabecalhoRecordList recordlist, Func<RCCabecalhoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLCabecalhoRecordList(RCCabecalhoRecord[] array) {
			RLCabecalhoRecordList result = new RLCabecalhoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLCabecalhoRecordList ToList<T>(T[] array, Func <T, RCCabecalhoRecord> converter) {
			RLCabecalhoRecordList result = new RLCabecalhoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLCabecalhoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCCabecalhoRecord> converter) {
			RLCabecalhoRecordList result = new RLCabecalhoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLCabecalhoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLCabecalhoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLCabecalhoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLCabecalhoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCCabecalhoRecord> NewList() {
			return new RLCabecalhoRecordList();
		}


	} // RLCabecalhoRecordList
}
