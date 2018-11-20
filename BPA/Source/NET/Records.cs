using System;
using System.Collections;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssBPA {

	/// <summary>
	/// Structure <code>RCIndividualizadoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCIndividualizadoRecord: ISerializable, ITypedRecord<RCIndividualizadoRecord> {
		private static readonly GlobalObjectKey IdIndividualizado = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kZxHHQ_5arai5N6_42SuKw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Individualizado")]
		public STIndividualizadoStructure ssSTIndividualizado;


		public static implicit operator STIndividualizadoStructure(RCIndividualizadoRecord r) {
			return r.ssSTIndividualizado;
		}

		public static implicit operator RCIndividualizadoRecord(STIndividualizadoStructure r) {
			RCIndividualizadoRecord res = new RCIndividualizadoRecord(null);
			res.ssSTIndividualizado = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCIndividualizadoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTIndividualizado = new STIndividualizadoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTIndividualizado.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTIndividualizado.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCIndividualizadoRecord r) {
			this = r;
		}


		public static bool operator == (RCIndividualizadoRecord a, RCIndividualizadoRecord b) {
			if (a.ssSTIndividualizado != b.ssSTIndividualizado) return false;
			return true;
		}

		public static bool operator != (RCIndividualizadoRecord a, RCIndividualizadoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCIndividualizadoRecord)) return false;
			return (this == (RCIndividualizadoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTIndividualizado.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCIndividualizadoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTIndividualizado = new STIndividualizadoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTIndividualizado", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTIndividualizado' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTIndividualizado = (STIndividualizadoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTIndividualizado.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTIndividualizado.InternalRecursiveSave();
		}


		public RCIndividualizadoRecord Duplicate() {
			RCIndividualizadoRecord t;
			t.ssSTIndividualizado = (STIndividualizadoStructure) this.ssSTIndividualizado.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTIndividualizado.ToXml(this, recordElem, "Individualizado", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "individualizado") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Individualizado")) variable.Value = ssSTIndividualizado; else variable.Optimized = true;
				variable.SetFieldName("individualizado");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdIndividualizado) {
				return ssSTIndividualizado;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTIndividualizado.FillFromOther((IRecord) other.AttributeGet(IdIndividualizado));
		}
		public bool IsDefault() {
			RCIndividualizadoRecord defaultStruct = new RCIndividualizadoRecord(null);
			if (this.ssSTIndividualizado != defaultStruct.ssSTIndividualizado) return false;
			return true;
		}
	} // RCIndividualizadoRecord

	/// <summary>
	/// Structure <code>RCCabecalhoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCCabecalhoRecord: ISerializable, ITypedRecord<RCCabecalhoRecord> {
		private static readonly GlobalObjectKey IdCabecalho = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*swQAAg8lCWrz2uZS8G8KAQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Cabecalho")]
		public STCabecalhoStructure ssSTCabecalho;


		public static implicit operator STCabecalhoStructure(RCCabecalhoRecord r) {
			return r.ssSTCabecalho;
		}

		public static implicit operator RCCabecalhoRecord(STCabecalhoStructure r) {
			RCCabecalhoRecord res = new RCCabecalhoRecord(null);
			res.ssSTCabecalho = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCCabecalhoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTCabecalho = new STCabecalhoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTCabecalho.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTCabecalho.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCCabecalhoRecord r) {
			this = r;
		}


		public static bool operator == (RCCabecalhoRecord a, RCCabecalhoRecord b) {
			if (a.ssSTCabecalho != b.ssSTCabecalho) return false;
			return true;
		}

		public static bool operator != (RCCabecalhoRecord a, RCCabecalhoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCCabecalhoRecord)) return false;
			return (this == (RCCabecalhoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTCabecalho.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCCabecalhoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTCabecalho = new STCabecalhoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTCabecalho", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTCabecalho' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTCabecalho = (STCabecalhoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTCabecalho.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTCabecalho.InternalRecursiveSave();
		}


		public RCCabecalhoRecord Duplicate() {
			RCCabecalhoRecord t;
			t.ssSTCabecalho = (STCabecalhoStructure) this.ssSTCabecalho.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTCabecalho.ToXml(this, recordElem, "Cabecalho", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "cabecalho") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Cabecalho")) variable.Value = ssSTCabecalho; else variable.Optimized = true;
				variable.SetFieldName("cabecalho");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdCabecalho) {
				return ssSTCabecalho;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTCabecalho.FillFromOther((IRecord) other.AttributeGet(IdCabecalho));
		}
		public bool IsDefault() {
			RCCabecalhoRecord defaultStruct = new RCCabecalhoRecord(null);
			if (this.ssSTCabecalho != defaultStruct.ssSTCabecalho) return false;
			return true;
		}
	} // RCCabecalhoRecord
}
