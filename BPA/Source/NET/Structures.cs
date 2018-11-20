using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssBPA {

	/// <summary>
	/// Structure <code>STIndividualizadoStructure</code> that represents the Service Studio structure
	///  <code>Individualizado</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STIndividualizadoStructure: ISerializable, ITypedRecord<STIndividualizadoStructure>, ISimpleRecord {
		private static readonly GlobalObjectKey Idprd_cnes_02 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*MMDNzrNi9kiQTu8R085NnA");
		private static readonly GlobalObjectKey Idprd_cmp_03 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*JxaFwUBOoE+q+mOJW0EM6Q");
		private static readonly GlobalObjectKey Idprd_cnsmed_04 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*R+z0uGrWLkeJ1qvNz_y7wg");
		private static readonly GlobalObjectKey Idprd_cbo_05 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*f00scPALVk2w35e9sxaHyg");
		private static readonly GlobalObjectKey Idprd_dtaten_06 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*crspeFL5gEWmbrlrrahUtg");
		private static readonly GlobalObjectKey Idprd_pa_09 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*oK0vLgIV30q12xaYRbNAkg");
		private static readonly GlobalObjectKey Idprd_cnspac_10 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*GuvUfTR8uEaDtz9LXKkWGw");
		private static readonly GlobalObjectKey Idprd_sexo_11 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*K1+mwAWg1Emg9vqE85JP9Q");
		private static readonly GlobalObjectKey Idprd_ibge_12 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*AENgnvqKJEGwsKfLw42b4Q");
		private static readonly GlobalObjectKey Idprd_cid_13 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*viqtwh6z50e8dQgUiiTmTQ");
		private static readonly GlobalObjectKey Idprd_qt_15 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*u5kYuVLHIEav48G9mUnIPw");
		private static readonly GlobalObjectKey Idprd_caten_16 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*IU4U3mg2okyqRejB6pKCNA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("prd_cnes_02")]
		public string ssprd_cnes_02;

		[System.Xml.Serialization.XmlElement("prd_cmp_03")]
		public DateTime ssprd_cmp_03;

		[System.Xml.Serialization.XmlElement("prd_cnsmed_04")]
		public string ssprd_cnsmed_04;

		[System.Xml.Serialization.XmlElement("prd_cbo_05")]
		public string ssprd_cbo_05;

		[System.Xml.Serialization.XmlElement("prd_dtaten_06")]
		public DateTime ssprd_dtaten_06;

		[System.Xml.Serialization.XmlElement("prd_pa_09")]
		public string ssprd_pa_09;

		[System.Xml.Serialization.XmlElement("prd_cnspac_10")]
		public string ssprd_cnspac_10;

		[System.Xml.Serialization.XmlElement("prd_sexo_11")]
		public string ssprd_sexo_11;

		[System.Xml.Serialization.XmlElement("prd_ibge_12")]
		public string ssprd_ibge_12;

		[System.Xml.Serialization.XmlElement("prd_cid_13")]
		public string ssprd_cid_13;

		[System.Xml.Serialization.XmlElement("prd_qt_15")]
		public int ssprd_qt_15;

		[System.Xml.Serialization.XmlElement("prd_caten_16")]
		public string ssprd_caten_16;


		public BitArray OptimizedAttributes;

		public STIndividualizadoStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssprd_cnes_02 = "";
			ssprd_cmp_03 = new DateTime(1900, 1, 1, 0, 0, 0);
			ssprd_cnsmed_04 = "";
			ssprd_cbo_05 = "";
			ssprd_dtaten_06 = new DateTime(1900, 1, 1, 0, 0, 0);
			ssprd_pa_09 = "";
			ssprd_cnspac_10 = "";
			ssprd_sexo_11 = "";
			ssprd_ibge_12 = "";
			ssprd_cid_13 = "";
			ssprd_qt_15 = 0;
			ssprd_caten_16 = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssprd_cnes_02 = r.ReadText(index++, "Individualizado.prd_cnes_02", "");
			ssprd_cmp_03 = r.ReadDateTime(index++, "Individualizado.prd_cmp_03", new DateTime(1900, 1, 1, 0, 0, 0));
			ssprd_cnsmed_04 = r.ReadText(index++, "Individualizado.prd_cnsmed_04", "");
			ssprd_cbo_05 = r.ReadText(index++, "Individualizado.prd_cbo_05", "");
			ssprd_dtaten_06 = r.ReadDateTime(index++, "Individualizado.prd_dtaten_06", new DateTime(1900, 1, 1, 0, 0, 0));
			ssprd_pa_09 = r.ReadText(index++, "Individualizado.prd_pa_09", "");
			ssprd_cnspac_10 = r.ReadText(index++, "Individualizado.prd_cnspac_10", "");
			ssprd_sexo_11 = r.ReadText(index++, "Individualizado.prd_sexo_11", "");
			ssprd_ibge_12 = r.ReadText(index++, "Individualizado.prd_ibge_12", "");
			ssprd_cid_13 = r.ReadText(index++, "Individualizado.prd_cid_13", "");
			ssprd_qt_15 = r.ReadInteger(index++, "Individualizado.prd_qt_15", 0);
			ssprd_caten_16 = r.ReadText(index++, "Individualizado.prd_caten_16", "");
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
		public void ReadIM(STIndividualizadoStructure r) {
			this = r;
		}


		public static bool operator == (STIndividualizadoStructure a, STIndividualizadoStructure b) {
			if (a.ssprd_cnes_02 != b.ssprd_cnes_02) return false;
			if (a.ssprd_cmp_03 != b.ssprd_cmp_03) return false;
			if (a.ssprd_cnsmed_04 != b.ssprd_cnsmed_04) return false;
			if (a.ssprd_cbo_05 != b.ssprd_cbo_05) return false;
			if (a.ssprd_dtaten_06 != b.ssprd_dtaten_06) return false;
			if (a.ssprd_pa_09 != b.ssprd_pa_09) return false;
			if (a.ssprd_cnspac_10 != b.ssprd_cnspac_10) return false;
			if (a.ssprd_sexo_11 != b.ssprd_sexo_11) return false;
			if (a.ssprd_ibge_12 != b.ssprd_ibge_12) return false;
			if (a.ssprd_cid_13 != b.ssprd_cid_13) return false;
			if (a.ssprd_qt_15 != b.ssprd_qt_15) return false;
			if (a.ssprd_caten_16 != b.ssprd_caten_16) return false;
			return true;
		}

		public static bool operator != (STIndividualizadoStructure a, STIndividualizadoStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STIndividualizadoStructure)) return false;
			return (this == (STIndividualizadoStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssprd_cnes_02.GetHashCode()
				^ ssprd_cmp_03.GetHashCode()
				^ ssprd_cnsmed_04.GetHashCode()
				^ ssprd_cbo_05.GetHashCode()
				^ ssprd_dtaten_06.GetHashCode()
				^ ssprd_pa_09.GetHashCode()
				^ ssprd_cnspac_10.GetHashCode()
				^ ssprd_sexo_11.GetHashCode()
				^ ssprd_ibge_12.GetHashCode()
				^ ssprd_cid_13.GetHashCode()
				^ ssprd_qt_15.GetHashCode()
				^ ssprd_caten_16.GetHashCode()
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

		public STIndividualizadoStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssprd_cnes_02 = "";
			ssprd_cmp_03 = new DateTime(1900, 1, 1, 0, 0, 0);
			ssprd_cnsmed_04 = "";
			ssprd_cbo_05 = "";
			ssprd_dtaten_06 = new DateTime(1900, 1, 1, 0, 0, 0);
			ssprd_pa_09 = "";
			ssprd_cnspac_10 = "";
			ssprd_sexo_11 = "";
			ssprd_ibge_12 = "";
			ssprd_cid_13 = "";
			ssprd_qt_15 = 0;
			ssprd_caten_16 = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssprd_cnes_02", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_cnes_02' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_cnes_02 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssprd_cmp_03", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_cmp_03' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_cmp_03 = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssprd_cnsmed_04", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_cnsmed_04' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_cnsmed_04 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssprd_cbo_05", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_cbo_05' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_cbo_05 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssprd_dtaten_06", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_dtaten_06' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_dtaten_06 = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssprd_pa_09", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_pa_09' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_pa_09 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssprd_cnspac_10", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_cnspac_10' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_cnspac_10 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssprd_sexo_11", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_sexo_11' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_sexo_11 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssprd_ibge_12", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_ibge_12' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_ibge_12 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssprd_cid_13", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_cid_13' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_cid_13 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssprd_qt_15", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_qt_15' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_qt_15 = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssprd_caten_16", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssprd_caten_16' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssprd_caten_16 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STIndividualizadoStructure Duplicate() {
			STIndividualizadoStructure t;
			t.ssprd_cnes_02 = this.ssprd_cnes_02;
			t.ssprd_cmp_03 = this.ssprd_cmp_03;
			t.ssprd_cnsmed_04 = this.ssprd_cnsmed_04;
			t.ssprd_cbo_05 = this.ssprd_cbo_05;
			t.ssprd_dtaten_06 = this.ssprd_dtaten_06;
			t.ssprd_pa_09 = this.ssprd_pa_09;
			t.ssprd_cnspac_10 = this.ssprd_cnspac_10;
			t.ssprd_sexo_11 = this.ssprd_sexo_11;
			t.ssprd_ibge_12 = this.ssprd_ibge_12;
			t.ssprd_cid_13 = this.ssprd_cid_13;
			t.ssprd_qt_15 = this.ssprd_qt_15;
			t.ssprd_caten_16 = this.ssprd_caten_16;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_cnes_02")) VarValue.AppendAttribute(recordElem, "prd_cnes_02", ssprd_cnes_02, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "prd_cnes_02");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_cmp_03")) VarValue.AppendAttribute(recordElem, "prd_cmp_03", ssprd_cmp_03, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "prd_cmp_03");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_cnsmed_04")) VarValue.AppendAttribute(recordElem, "prd_cnsmed_04", ssprd_cnsmed_04, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "prd_cnsmed_04");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_cbo_05")) VarValue.AppendAttribute(recordElem, "prd_cbo_05", ssprd_cbo_05, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "prd_cbo_05");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_dtaten_06")) VarValue.AppendAttribute(recordElem, "prd_dtaten_06", ssprd_dtaten_06, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "prd_dtaten_06");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_pa_09")) VarValue.AppendAttribute(recordElem, "prd_pa_09", ssprd_pa_09, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "prd_pa_09");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_cnspac_10")) VarValue.AppendAttribute(recordElem, "prd_cnspac_10", ssprd_cnspac_10, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "prd_cnspac_10");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_sexo_11")) VarValue.AppendAttribute(recordElem, "prd_sexo_11", ssprd_sexo_11, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "prd_sexo_11");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_ibge_12")) VarValue.AppendAttribute(recordElem, "prd_ibge_12", ssprd_ibge_12, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "prd_ibge_12");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_cid_13")) VarValue.AppendAttribute(recordElem, "prd_cid_13", ssprd_cid_13, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "prd_cid_13");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_qt_15")) VarValue.AppendAttribute(recordElem, "prd_qt_15", ssprd_qt_15, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "prd_qt_15");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".prd_caten_16")) VarValue.AppendAttribute(recordElem, "prd_caten_16", ssprd_caten_16, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "prd_caten_16");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "prd_cnes_02") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_cnes_02")) variable.Value = ssprd_cnes_02; else variable.Optimized = true;
			} else if (head == "prd_cmp_03") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_cmp_03")) variable.Value = ssprd_cmp_03; else variable.Optimized = true;
			} else if (head == "prd_cnsmed_04") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_cnsmed_04")) variable.Value = ssprd_cnsmed_04; else variable.Optimized = true;
			} else if (head == "prd_cbo_05") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_cbo_05")) variable.Value = ssprd_cbo_05; else variable.Optimized = true;
			} else if (head == "prd_dtaten_06") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_dtaten_06")) variable.Value = ssprd_dtaten_06; else variable.Optimized = true;
			} else if (head == "prd_pa_09") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_pa_09")) variable.Value = ssprd_pa_09; else variable.Optimized = true;
			} else if (head == "prd_cnspac_10") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_cnspac_10")) variable.Value = ssprd_cnspac_10; else variable.Optimized = true;
			} else if (head == "prd_sexo_11") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_sexo_11")) variable.Value = ssprd_sexo_11; else variable.Optimized = true;
			} else if (head == "prd_ibge_12") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_ibge_12")) variable.Value = ssprd_ibge_12; else variable.Optimized = true;
			} else if (head == "prd_cid_13") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_cid_13")) variable.Value = ssprd_cid_13; else variable.Optimized = true;
			} else if (head == "prd_qt_15") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_qt_15")) variable.Value = ssprd_qt_15; else variable.Optimized = true;
			} else if (head == "prd_caten_16") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".prd_caten_16")) variable.Value = ssprd_caten_16; else variable.Optimized = true;
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
			if (key == Idprd_cnes_02) {
				return ssprd_cnes_02;
			} else if (key == Idprd_cmp_03) {
				return ssprd_cmp_03;
			} else if (key == Idprd_cnsmed_04) {
				return ssprd_cnsmed_04;
			} else if (key == Idprd_cbo_05) {
				return ssprd_cbo_05;
			} else if (key == Idprd_dtaten_06) {
				return ssprd_dtaten_06;
			} else if (key == Idprd_pa_09) {
				return ssprd_pa_09;
			} else if (key == Idprd_cnspac_10) {
				return ssprd_cnspac_10;
			} else if (key == Idprd_sexo_11) {
				return ssprd_sexo_11;
			} else if (key == Idprd_ibge_12) {
				return ssprd_ibge_12;
			} else if (key == Idprd_cid_13) {
				return ssprd_cid_13;
			} else if (key == Idprd_qt_15) {
				return ssprd_qt_15;
			} else if (key == Idprd_caten_16) {
				return ssprd_caten_16;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssprd_cnes_02 = (string) other.AttributeGet(Idprd_cnes_02);
			ssprd_cmp_03 = (DateTime) other.AttributeGet(Idprd_cmp_03);
			ssprd_cnsmed_04 = (string) other.AttributeGet(Idprd_cnsmed_04);
			ssprd_cbo_05 = (string) other.AttributeGet(Idprd_cbo_05);
			ssprd_dtaten_06 = (DateTime) other.AttributeGet(Idprd_dtaten_06);
			ssprd_pa_09 = (string) other.AttributeGet(Idprd_pa_09);
			ssprd_cnspac_10 = (string) other.AttributeGet(Idprd_cnspac_10);
			ssprd_sexo_11 = (string) other.AttributeGet(Idprd_sexo_11);
			ssprd_ibge_12 = (string) other.AttributeGet(Idprd_ibge_12);
			ssprd_cid_13 = (string) other.AttributeGet(Idprd_cid_13);
			ssprd_qt_15 = (int) other.AttributeGet(Idprd_qt_15);
			ssprd_caten_16 = (string) other.AttributeGet(Idprd_caten_16);
		}
		public bool IsDefault() {
			STIndividualizadoStructure defaultStruct = new STIndividualizadoStructure(null);
			if (this.ssprd_cnes_02 != defaultStruct.ssprd_cnes_02) return false;
			if (this.ssprd_cmp_03 != defaultStruct.ssprd_cmp_03) return false;
			if (this.ssprd_cnsmed_04 != defaultStruct.ssprd_cnsmed_04) return false;
			if (this.ssprd_cbo_05 != defaultStruct.ssprd_cbo_05) return false;
			if (this.ssprd_dtaten_06 != defaultStruct.ssprd_dtaten_06) return false;
			if (this.ssprd_pa_09 != defaultStruct.ssprd_pa_09) return false;
			if (this.ssprd_cnspac_10 != defaultStruct.ssprd_cnspac_10) return false;
			if (this.ssprd_sexo_11 != defaultStruct.ssprd_sexo_11) return false;
			if (this.ssprd_ibge_12 != defaultStruct.ssprd_ibge_12) return false;
			if (this.ssprd_cid_13 != defaultStruct.ssprd_cid_13) return false;
			if (this.ssprd_qt_15 != defaultStruct.ssprd_qt_15) return false;
			if (this.ssprd_caten_16 != defaultStruct.ssprd_caten_16) return false;
			return true;
		}
	} // STIndividualizadoStructure

	/// <summary>
	/// Structure <code>STCabecalhoStructure</code> that represents the Service Studio structure
	///  <code>Cabecalho</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STCabecalhoStructure: ISerializable, ITypedRecord<STCabecalhoStructure>, ISimpleRecord {
		private static readonly GlobalObjectKey Idcbc_mvm_03 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*AnSlpbiTF0WUDQkf2gfOFg");
		private static readonly GlobalObjectKey Idcbc_rsp_07 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*olOgsK4YkkKM3A5YCwnzFA");
		private static readonly GlobalObjectKey Idcbc_sgl_08 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*3GnKIpAbskeoLWANwT59HQ");
		private static readonly GlobalObjectKey Idcbc_cgccpf_09 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*rAonWQbWfUyRnbbocN1WHQ");
		private static readonly GlobalObjectKey Idcbc_dst_10 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*gxUhv+6Y+kSFSO9EIoYovQ");
		private static readonly GlobalObjectKey Idcbc_dst_in_11 = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*WTx07Hea+EGd93RZe09Ktw");
		private static readonly GlobalObjectKey IdnrFolhaIniciar = GlobalObjectKey.Parse("RrZsQdEyskW70dkuS6BgOQ*aY3NiV_a1USThPJOQcQ4kQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("cbc_mvm_03")]
		public DateTime sscbc_mvm_03;

		[System.Xml.Serialization.XmlElement("cbc_rsp_07")]
		public string sscbc_rsp_07;

		[System.Xml.Serialization.XmlElement("cbc_sgl_08")]
		public string sscbc_sgl_08;

		[System.Xml.Serialization.XmlElement("cbc_cgccpf_09")]
		public string sscbc_cgccpf_09;

		[System.Xml.Serialization.XmlElement("cbc_dst_10")]
		public string sscbc_dst_10;

		[System.Xml.Serialization.XmlElement("cbc_dst_in_11")]
		public string sscbc_dst_in_11;

		[System.Xml.Serialization.XmlElement("nrFolhaIniciar")]
		public int ssnrFolhaIniciar;


		public BitArray OptimizedAttributes;

		public STCabecalhoStructure(params string[] dummy) {
			OptimizedAttributes = null;
			sscbc_mvm_03 = new DateTime(1900, 1, 1, 0, 0, 0);
			sscbc_rsp_07 = "";
			sscbc_sgl_08 = "";
			sscbc_cgccpf_09 = "";
			sscbc_dst_10 = "";
			sscbc_dst_in_11 = "";
			ssnrFolhaIniciar = 0;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			sscbc_mvm_03 = r.ReadDateTime(index++, "Cabecalho.cbc_mvm_03", new DateTime(1900, 1, 1, 0, 0, 0));
			sscbc_rsp_07 = r.ReadText(index++, "Cabecalho.cbc_rsp_07", "");
			sscbc_sgl_08 = r.ReadText(index++, "Cabecalho.cbc_sgl_08", "");
			sscbc_cgccpf_09 = r.ReadText(index++, "Cabecalho.cbc_cgccpf_09", "");
			sscbc_dst_10 = r.ReadText(index++, "Cabecalho.cbc_dst_10", "");
			sscbc_dst_in_11 = r.ReadText(index++, "Cabecalho.cbc_dst_in_11", "");
			ssnrFolhaIniciar = r.ReadInteger(index++, "Cabecalho.nrFolhaIniciar", 0);
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
		public void ReadIM(STCabecalhoStructure r) {
			this = r;
		}


		public static bool operator == (STCabecalhoStructure a, STCabecalhoStructure b) {
			if (a.sscbc_mvm_03 != b.sscbc_mvm_03) return false;
			if (a.sscbc_rsp_07 != b.sscbc_rsp_07) return false;
			if (a.sscbc_sgl_08 != b.sscbc_sgl_08) return false;
			if (a.sscbc_cgccpf_09 != b.sscbc_cgccpf_09) return false;
			if (a.sscbc_dst_10 != b.sscbc_dst_10) return false;
			if (a.sscbc_dst_in_11 != b.sscbc_dst_in_11) return false;
			if (a.ssnrFolhaIniciar != b.ssnrFolhaIniciar) return false;
			return true;
		}

		public static bool operator != (STCabecalhoStructure a, STCabecalhoStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STCabecalhoStructure)) return false;
			return (this == (STCabecalhoStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ sscbc_mvm_03.GetHashCode()
				^ sscbc_rsp_07.GetHashCode()
				^ sscbc_sgl_08.GetHashCode()
				^ sscbc_cgccpf_09.GetHashCode()
				^ sscbc_dst_10.GetHashCode()
				^ sscbc_dst_in_11.GetHashCode()
				^ ssnrFolhaIniciar.GetHashCode()
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

		public STCabecalhoStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			sscbc_mvm_03 = new DateTime(1900, 1, 1, 0, 0, 0);
			sscbc_rsp_07 = "";
			sscbc_sgl_08 = "";
			sscbc_cgccpf_09 = "";
			sscbc_dst_10 = "";
			sscbc_dst_in_11 = "";
			ssnrFolhaIniciar = 0;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("sscbc_mvm_03", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'sscbc_mvm_03' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				sscbc_mvm_03 = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("sscbc_rsp_07", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'sscbc_rsp_07' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				sscbc_rsp_07 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("sscbc_sgl_08", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'sscbc_sgl_08' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				sscbc_sgl_08 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("sscbc_cgccpf_09", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'sscbc_cgccpf_09' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				sscbc_cgccpf_09 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("sscbc_dst_10", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'sscbc_dst_10' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				sscbc_dst_10 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("sscbc_dst_in_11", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'sscbc_dst_in_11' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				sscbc_dst_in_11 = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssnrFolhaIniciar", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssnrFolhaIniciar' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssnrFolhaIniciar = (int) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STCabecalhoStructure Duplicate() {
			STCabecalhoStructure t;
			t.sscbc_mvm_03 = this.sscbc_mvm_03;
			t.sscbc_rsp_07 = this.sscbc_rsp_07;
			t.sscbc_sgl_08 = this.sscbc_sgl_08;
			t.sscbc_cgccpf_09 = this.sscbc_cgccpf_09;
			t.sscbc_dst_10 = this.sscbc_dst_10;
			t.sscbc_dst_in_11 = this.sscbc_dst_in_11;
			t.ssnrFolhaIniciar = this.ssnrFolhaIniciar;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".cbc_mvm_03")) VarValue.AppendAttribute(recordElem, "cbc_mvm_03", sscbc_mvm_03, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "cbc_mvm_03");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".cbc_rsp_07")) VarValue.AppendAttribute(recordElem, "cbc_rsp_07", sscbc_rsp_07, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "cbc_rsp_07");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".cbc_sgl_08")) VarValue.AppendAttribute(recordElem, "cbc_sgl_08", sscbc_sgl_08, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "cbc_sgl_08");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".cbc_cgccpf_09")) VarValue.AppendAttribute(recordElem, "cbc_cgccpf_09", sscbc_cgccpf_09, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "cbc_cgccpf_09");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".cbc_dst_10")) VarValue.AppendAttribute(recordElem, "cbc_dst_10", sscbc_dst_10, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "cbc_dst_10");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".cbc_dst_in_11")) VarValue.AppendAttribute(recordElem, "cbc_dst_in_11", sscbc_dst_in_11, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "cbc_dst_in_11");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".nrFolhaIniciar")) VarValue.AppendAttribute(recordElem, "nrFolhaIniciar", ssnrFolhaIniciar, detailLevel, TypeKind.Integer); else VarValue.AppendOptimizedAttribute(recordElem, "nrFolhaIniciar");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "cbc_mvm_03") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".cbc_mvm_03")) variable.Value = sscbc_mvm_03; else variable.Optimized = true;
			} else if (head == "cbc_rsp_07") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".cbc_rsp_07")) variable.Value = sscbc_rsp_07; else variable.Optimized = true;
			} else if (head == "cbc_sgl_08") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".cbc_sgl_08")) variable.Value = sscbc_sgl_08; else variable.Optimized = true;
			} else if (head == "cbc_cgccpf_09") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".cbc_cgccpf_09")) variable.Value = sscbc_cgccpf_09; else variable.Optimized = true;
			} else if (head == "cbc_dst_10") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".cbc_dst_10")) variable.Value = sscbc_dst_10; else variable.Optimized = true;
			} else if (head == "cbc_dst_in_11") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".cbc_dst_in_11")) variable.Value = sscbc_dst_in_11; else variable.Optimized = true;
			} else if (head == "nrfolhainiciar") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".nrFolhaIniciar")) variable.Value = ssnrFolhaIniciar; else variable.Optimized = true;
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
			if (key == Idcbc_mvm_03) {
				return sscbc_mvm_03;
			} else if (key == Idcbc_rsp_07) {
				return sscbc_rsp_07;
			} else if (key == Idcbc_sgl_08) {
				return sscbc_sgl_08;
			} else if (key == Idcbc_cgccpf_09) {
				return sscbc_cgccpf_09;
			} else if (key == Idcbc_dst_10) {
				return sscbc_dst_10;
			} else if (key == Idcbc_dst_in_11) {
				return sscbc_dst_in_11;
			} else if (key == IdnrFolhaIniciar) {
				return ssnrFolhaIniciar;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			sscbc_mvm_03 = (DateTime) other.AttributeGet(Idcbc_mvm_03);
			sscbc_rsp_07 = (string) other.AttributeGet(Idcbc_rsp_07);
			sscbc_sgl_08 = (string) other.AttributeGet(Idcbc_sgl_08);
			sscbc_cgccpf_09 = (string) other.AttributeGet(Idcbc_cgccpf_09);
			sscbc_dst_10 = (string) other.AttributeGet(Idcbc_dst_10);
			sscbc_dst_in_11 = (string) other.AttributeGet(Idcbc_dst_in_11);
			ssnrFolhaIniciar = (int) other.AttributeGet(IdnrFolhaIniciar);
		}
		public bool IsDefault() {
			STCabecalhoStructure defaultStruct = new STCabecalhoStructure(null);
			if (this.sscbc_mvm_03 != defaultStruct.sscbc_mvm_03) return false;
			if (this.sscbc_rsp_07 != defaultStruct.sscbc_rsp_07) return false;
			if (this.sscbc_sgl_08 != defaultStruct.sscbc_sgl_08) return false;
			if (this.sscbc_cgccpf_09 != defaultStruct.sscbc_cgccpf_09) return false;
			if (this.sscbc_dst_10 != defaultStruct.sscbc_dst_10) return false;
			if (this.sscbc_dst_in_11 != defaultStruct.sscbc_dst_in_11) return false;
			if (this.ssnrFolhaIniciar != defaultStruct.ssnrFolhaIniciar) return false;
			return true;
		}
	} // STCabecalhoStructure

} // OutSystems.NssBPA
