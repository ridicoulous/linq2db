﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/linq2db).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------

#pragma warning disable 1573, 1591
#nullable enable

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace AccessDataContext
{
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<AllType>             AllTypes             { get { return this.GetTable<AllType>(); } }
		public ITable<Child>               Children             { get { return this.GetTable<Child>(); } }
		public ITable<DataTypeTest>        DataTypeTests        { get { return this.GetTable<DataTypeTest>(); } }
		public ITable<Doctor>              Doctors              { get { return this.GetTable<Doctor>(); } }
		public ITable<Dual>                Duals                { get { return this.GetTable<Dual>(); } }
		public ITable<GrandChild>          GrandChildren        { get { return this.GetTable<GrandChild>(); } }
		public ITable<InheritanceChild>    InheritanceChildren  { get { return this.GetTable<InheritanceChild>(); } }
		public ITable<InheritanceParent>   InheritanceParents   { get { return this.GetTable<InheritanceParent>(); } }
		public ITable<LinqDataType>        LinqDataTypes        { get { return this.GetTable<LinqDataType>(); } }
		public ITable<LinqDataTypesQuery>  LinqDataTypesQueries { get { return this.GetTable<LinqDataTypesQuery>(); } }
		public ITable<LinqDataTypesQuery1> LinqDataTypesQuery1  { get { return this.GetTable<LinqDataTypesQuery1>(); } }
		public ITable<LinqDataTypesQuery2> LinqDataTypesQuery2  { get { return this.GetTable<LinqDataTypesQuery2>(); } }
		public ITable<Parent>              Parents              { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>             Patients             { get { return this.GetTable<Patient>(); } }
		public ITable<PatientSelectAll>    PatientSelectAll     { get { return this.GetTable<PatientSelectAll>(); } }
		public ITable<Person>              People               { get { return this.GetTable<Person>(); } }
		public ITable<PersonSelectAll>     PersonSelectAll      { get { return this.GetTable<PersonSelectAll>(); } }
		public ITable<ScalarDataReader>    ScalarDataReaders    { get { return this.GetTable<ScalarDataReader>(); } }
		public ITable<TestIdentity>        TestIdentities       { get { return this.GetTable<TestIdentity>(); } }
		public ITable<TestMerge1>          TestMerge1           { get { return this.GetTable<TestMerge1>(); } }
		public ITable<TestMerge2>          TestMerge2           { get { return this.GetTable<TestMerge2>(); } }

		public TestDataDB()
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(LinqToDBConnectionOptions options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		public TestDataDB(LinqToDBConnectionOptions<TestDataDB> options)
			: base(options)
		{
			InitDataContext();
			InitMappingSchema();
		}

		partial void InitDataContext  ();
		partial void InitMappingSchema();
	}

	[Table("AllTypes")]
	public partial class AllType
	{
		[Column(                            DbType="Long",           DataType=LinqToDB.DataType.Int32),                            NotNull    ] public int       ID                       { get; set; } // Long
		[Column("bitDataType",              DbType="Bit",            DataType=LinqToDB.DataType.Boolean),                          NotNull    ] public bool      BitDataType              { get; set; } // Bit
		[Column("smallintDataType",         DbType="Short",          DataType=LinqToDB.DataType.Int16),                               Nullable] public short?    SmallintDataType         { get; set; } // Short
		[Column("decimalDataType",          DbType="Decimal(18, 0)", DataType=LinqToDB.DataType.Decimal,   Precision=18, Scale=0),    Nullable] public decimal?  DecimalDataType          { get; set; } // Decimal(18, 0)
		[Column("intDataType",              DbType="Long",           DataType=LinqToDB.DataType.Int32),                               Nullable] public int?      IntDataType              { get; set; } // Long
		[Column("tinyintDataType",          DbType="Byte",           DataType=LinqToDB.DataType.Byte),                                Nullable] public byte?     TinyintDataType          { get; set; } // Byte
		[Column("moneyDataType",            DbType="Currency",       DataType=LinqToDB.DataType.Money),                               Nullable] public decimal?  MoneyDataType            { get; set; } // Currency
		[Column("floatDataType",            DbType="Double",         DataType=LinqToDB.DataType.Double),                              Nullable] public double?   FloatDataType            { get; set; } // Double
		[Column("realDataType",             DbType="Single",         DataType=LinqToDB.DataType.Single),                              Nullable] public float?    RealDataType             { get; set; } // Single
		[Column("datetimeDataType",         DbType="DateTime",       DataType=LinqToDB.DataType.DateTime),                            Nullable] public DateTime? DatetimeDataType         { get; set; } // DateTime
		[Column("charDataType",             DbType="CHAR(1)",        DataType=LinqToDB.DataType.Char,      Length=1),                 Nullable] public char?     CharDataType             { get; set; } // CHAR(1)
		[Column("char20DataType",           DbType="CHAR(20)",       DataType=LinqToDB.DataType.Char,      Length=20),                Nullable] public string?   Char20DataType           { get; set; } // CHAR(20)
		[Column("varcharDataType",          DbType="VarChar(20)",    DataType=LinqToDB.DataType.VarChar,   Length=20),                Nullable] public string?   VarcharDataType          { get; set; } // VarChar(20)
		[Column("textDataType",             DbType="LongText",       DataType=LinqToDB.DataType.NText),                               Nullable] public string?   TextDataType             { get; set; } // LongText
		[Column("ncharDataType",            DbType="CHAR(20)",       DataType=LinqToDB.DataType.Char,      Length=20),                Nullable] public string?   NcharDataType            { get; set; } // CHAR(20)
		[Column("nvarcharDataType",         DbType="VarChar(20)",    DataType=LinqToDB.DataType.VarChar,   Length=20),                Nullable] public string?   NvarcharDataType         { get; set; } // VarChar(20)
		[Column("ntextDataType",            DbType="LongText",       DataType=LinqToDB.DataType.NText),                               Nullable] public string?   NtextDataType            { get; set; } // LongText
		[Column("binaryDataType",           DbType="VARBINARY(10)",  DataType=LinqToDB.DataType.VarBinary, Length=10),                Nullable] public byte[]?   BinaryDataType           { get; set; } // VARBINARY(10)
		[Column("varbinaryDataType",        DbType="VARBINARY(510)", DataType=LinqToDB.DataType.VarBinary, Length=510),               Nullable] public byte[]?   VarbinaryDataType        { get; set; } // VARBINARY(510)
		[Column("imageDataType",            DbType="LongBinary",     DataType=LinqToDB.DataType.Image),                               Nullable] public byte[]?   ImageDataType            { get; set; } // LongBinary
		[Column("oleObjectDataType",        DbType="LongBinary",     DataType=LinqToDB.DataType.Image),                               Nullable] public byte[]?   OleObjectDataType        { get; set; } // LongBinary
		[Column("uniqueidentifierDataType", DbType="GUID",           DataType=LinqToDB.DataType.Guid),                                Nullable] public Guid?     UniqueidentifierDataType { get; set; } // GUID
	}

	[Table("Child")]
	public partial class Child
	{
		[Column(DbType="Long", DataType=LinqToDB.DataType.Int32), Nullable] public int? ParentID { get; set; } // Long
		[Column(DbType="Long", DataType=LinqToDB.DataType.Int32), Nullable] public int? ChildID  { get; set; } // Long
	}

	[Table("DataTypeTest")]
	public partial class DataTypeTest
	{
		[Column(             DbType="Long",        DataType=LinqToDB.DataType.Int32),               PrimaryKey,  NotNull] public int       DataTypeID { get; set; } // Long
		[Column("Binary_",   DbType="LongBinary",  DataType=LinqToDB.DataType.Image),                  Nullable         ] public byte[]?   Binary     { get; set; } // LongBinary
		[Column("Boolean_",  DbType="Long",        DataType=LinqToDB.DataType.Int32),                  Nullable         ] public int?      Boolean    { get; set; } // Long
		[Column("Byte_",     DbType="Byte",        DataType=LinqToDB.DataType.Byte),                   Nullable         ] public byte?     Byte       { get; set; } // Byte
		[Column("Bytes_",    DbType="LongBinary",  DataType=LinqToDB.DataType.Image),                  Nullable         ] public byte[]?   Bytes      { get; set; } // LongBinary
		[Column("Char_",     DbType="VarChar(1)",  DataType=LinqToDB.DataType.VarChar,  Length=1),     Nullable         ] public char?     Char       { get; set; } // VarChar(1)
		[Column("DateTime_", DbType="DateTime",    DataType=LinqToDB.DataType.DateTime),               Nullable         ] public DateTime? DateTime   { get; set; } // DateTime
		[Column("Decimal_",  DbType="Currency",    DataType=LinqToDB.DataType.Money),                  Nullable         ] public decimal?  Decimal    { get; set; } // Currency
		[Column("Double_",   DbType="Double",      DataType=LinqToDB.DataType.Double),                 Nullable         ] public double?   Double     { get; set; } // Double
		[Column("Guid_",     DbType="GUID",        DataType=LinqToDB.DataType.Guid),                   Nullable         ] public Guid?     Guid       { get; set; } // GUID
		[Column("Int16_",    DbType="Short",       DataType=LinqToDB.DataType.Int16),                  Nullable         ] public short?    Int16      { get; set; } // Short
		[Column("Int32_",    DbType="Long",        DataType=LinqToDB.DataType.Int32),                  Nullable         ] public int?      Int32      { get; set; } // Long
		[Column("Int64_",    DbType="Long",        DataType=LinqToDB.DataType.Int32),                  Nullable         ] public int?      Int64      { get; set; } // Long
		[Column("Money_",    DbType="Currency",    DataType=LinqToDB.DataType.Money),                  Nullable         ] public decimal?  Money      { get; set; } // Currency
		[Column("SByte_",    DbType="Byte",        DataType=LinqToDB.DataType.Byte),                   Nullable         ] public byte?     SByte      { get; set; } // Byte
		[Column("Single_",   DbType="Single",      DataType=LinqToDB.DataType.Single),                 Nullable         ] public float?    Single     { get; set; } // Single
		[Column("Stream_",   DbType="LongBinary",  DataType=LinqToDB.DataType.Image),                  Nullable         ] public byte[]?   Stream     { get; set; } // LongBinary
		[Column("String_",   DbType="VarChar(50)", DataType=LinqToDB.DataType.VarChar,  Length=50),    Nullable         ] public string?   String     { get; set; } // VarChar(50)
		[Column("UInt16_",   DbType="Short",       DataType=LinqToDB.DataType.Int16),                  Nullable         ] public short?    UInt16     { get; set; } // Short
		[Column("UInt32_",   DbType="Long",        DataType=LinqToDB.DataType.Int32),                  Nullable         ] public int?      UInt32     { get; set; } // Long
		[Column("UInt64_",   DbType="Long",        DataType=LinqToDB.DataType.Int32),                  Nullable         ] public int?      UInt64     { get; set; } // Long
		[Column("Xml_",      DbType="LongText",    DataType=LinqToDB.DataType.NText),                  Nullable         ] public string?   Xml        { get; set; } // LongText
	}

	[Table("Doctor")]
	public partial class Doctor
	{
		[Column(DbType="Long",        DataType=LinqToDB.DataType.Int32),              PrimaryKey, NotNull] public int    PersonID { get; set; } // Long
		[Column(DbType="VarChar(50)", DataType=LinqToDB.DataType.VarChar, Length=50),             NotNull] public string Taxonomy { get; set; } = null!; // VarChar(50)

		#region Associations

		/// <summary>
		/// PersonDoctor (Person)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table("Dual")]
	public partial class Dual
	{
		[Column(DbType="VarChar(10)", DataType=LinqToDB.DataType.VarChar, Length=10), Nullable] public string? Dummy { get; set; } // VarChar(10)
	}

	[Table("GrandChild")]
	public partial class GrandChild
	{
		[Column(DbType="Long", DataType=LinqToDB.DataType.Int32), Nullable] public int? ParentID     { get; set; } // Long
		[Column(DbType="Long", DataType=LinqToDB.DataType.Int32), Nullable] public int? ChildID      { get; set; } // Long
		[Column(DbType="Long", DataType=LinqToDB.DataType.Int32), Nullable] public int? GrandChildID { get; set; } // Long
	}

	[Table("InheritanceChild")]
	public partial class InheritanceChild
	{
		[Column(DbType="Long",        DataType=LinqToDB.DataType.Int32),              PrimaryKey,  NotNull] public int     InheritanceChildId  { get; set; } // Long
		[Column(DbType="Long",        DataType=LinqToDB.DataType.Int32),                           NotNull] public int     InheritanceParentId { get; set; } // Long
		[Column(DbType="Long",        DataType=LinqToDB.DataType.Int32),                 Nullable         ] public int?    TypeDiscriminator   { get; set; } // Long
		[Column(DbType="VarChar(50)", DataType=LinqToDB.DataType.VarChar, Length=50),    Nullable         ] public string? Name                { get; set; } // VarChar(50)
	}

	[Table("InheritanceParent")]
	public partial class InheritanceParent
	{
		[Column(DbType="Long",        DataType=LinqToDB.DataType.Int32),              PrimaryKey,  NotNull] public int     InheritanceParentId { get; set; } // Long
		[Column(DbType="Long",        DataType=LinqToDB.DataType.Int32),                 Nullable         ] public int?    TypeDiscriminator   { get; set; } // Long
		[Column(DbType="VarChar(50)", DataType=LinqToDB.DataType.VarChar, Length=50),    Nullable         ] public string? Name                { get; set; } // VarChar(50)
	}

	[Table("LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column(DbType="Long",           DataType=LinqToDB.DataType.Int32),                              Nullable] public int?      ID             { get; set; } // Long
		[Column(DbType="Decimal(10, 4)", DataType=LinqToDB.DataType.Decimal,  Precision=10, Scale=4),    Nullable] public decimal?  MoneyValue     { get; set; } // Decimal(10, 4)
		[Column(DbType="DateTime",       DataType=LinqToDB.DataType.DateTime),                           Nullable] public DateTime? DateTimeValue  { get; set; } // DateTime
		[Column(DbType="DateTime",       DataType=LinqToDB.DataType.DateTime),                           Nullable] public DateTime? DateTimeValue2 { get; set; } // DateTime
		[Column(DbType="Bit",            DataType=LinqToDB.DataType.Boolean),                         NotNull    ] public bool      BoolValue      { get; set; } // Bit
		[Column(DbType="GUID",           DataType=LinqToDB.DataType.Guid),                               Nullable] public Guid?     GuidValue      { get; set; } // GUID
		[Column(DbType="LongBinary",     DataType=LinqToDB.DataType.Image),                              Nullable] public byte[]?   BinaryValue    { get; set; } // LongBinary
		[Column(DbType="Short",          DataType=LinqToDB.DataType.Int16),                              Nullable] public short?    SmallIntValue  { get; set; } // Short
		[Column(DbType="Long",           DataType=LinqToDB.DataType.Int32),                              Nullable] public int?      IntValue       { get; set; } // Long
		[Column(DbType="Long",           DataType=LinqToDB.DataType.Int32),                              Nullable] public int?      BigIntValue    { get; set; } // Long
		[Column(DbType="VarChar(50)",    DataType=LinqToDB.DataType.VarChar,  Length=50),                Nullable] public string?   StringValue    { get; set; } // VarChar(50)
	}

	[Table("LinqDataTypes Query", IsView=true)]
	public partial class LinqDataTypesQuery
	{
		[Column(DbType="DateTime", DataType=LinqToDB.DataType.DateTime), Nullable] public DateTime? DateTimeValue { get; set; } // DateTime
	}

	[Table("LinqDataTypes Query1", IsView=true)]
	public partial class LinqDataTypesQuery1
	{
		[Column(DbType="Long", DataType=LinqToDB.DataType.Int32), Nullable] public int? ID { get; set; } // Long
	}

	[Table("LinqDataTypes Query2", IsView=true)]
	public partial class LinqDataTypesQuery2
	{
		[Column(DbType="Long", DataType=LinqToDB.DataType.Int32), Nullable] public int? ID { get; set; } // Long
	}

	[Table("Parent")]
	public partial class Parent
	{
		[Column(DbType="Long", DataType=LinqToDB.DataType.Int32), Nullable] public int? ParentID { get; set; } // Long
		[Column(DbType="Long", DataType=LinqToDB.DataType.Int32), Nullable] public int? Value1   { get; set; } // Long
	}

	[Table("Patient")]
	public partial class Patient
	{
		[Column(DbType="Long",         DataType=LinqToDB.DataType.Int32),               PrimaryKey, NotNull] public int    PersonID  { get; set; } // Long
		[Column(DbType="VarChar(255)", DataType=LinqToDB.DataType.VarChar, Length=255),             NotNull] public string Diagnosis { get; set; } = null!; // VarChar(255)

		#region Associations

		/// <summary>
		/// PersonPatient (Person)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public Person Person { get; set; } = null!;

		#endregion
	}

	[Table("Patient_SelectAll", IsView=true)]
	public partial class PatientSelectAll
	{
		[Column(DbType="Long",         DataType=LinqToDB.DataType.Int32),               NotNull    ] public int     PersonID   { get; set; } // Long
		[Column(DbType="VarChar(50)",  DataType=LinqToDB.DataType.VarChar, Length=50),     Nullable] public string? FirstName  { get; set; } // VarChar(50)
		[Column(DbType="VarChar(50)",  DataType=LinqToDB.DataType.VarChar, Length=50),     Nullable] public string? LastName   { get; set; } // VarChar(50)
		[Column(DbType="VarChar(50)",  DataType=LinqToDB.DataType.VarChar, Length=50),     Nullable] public string? MiddleName { get; set; } // VarChar(50)
		[Column(DbType="VarChar(1)",   DataType=LinqToDB.DataType.VarChar, Length=1),      Nullable] public char?   Gender     { get; set; } // VarChar(1)
		[Column(DbType="VarChar(255)", DataType=LinqToDB.DataType.VarChar, Length=255),    Nullable] public string? Diagnosis  { get; set; } // VarChar(255)
	}

	[Table("Person")]
	public partial class Person
	{
		[Column(DbType="Long",        DataType=LinqToDB.DataType.Int32),              PrimaryKey,  NotNull] public int     PersonID   { get; set; } // Long
		[Column(DbType="VarChar(50)", DataType=LinqToDB.DataType.VarChar, Length=50),              NotNull] public string  FirstName  { get; set; } = null!; // VarChar(50)
		[Column(DbType="VarChar(50)", DataType=LinqToDB.DataType.VarChar, Length=50),              NotNull] public string  LastName   { get; set; } = null!; // VarChar(50)
		[Column(DbType="VarChar(50)", DataType=LinqToDB.DataType.VarChar, Length=50),    Nullable         ] public string? MiddleName { get; set; } // VarChar(50)
		[Column(DbType="VarChar(1)",  DataType=LinqToDB.DataType.VarChar, Length=1),               NotNull] public char    Gender     { get; set; } // VarChar(1)

		#region Associations

		/// <summary>
		/// PersonDoctor_BackReference (Doctor)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true)]
		public Doctor? PersonDoctor { get; set; }

		/// <summary>
		/// PersonPatient_BackReference (Patient)
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true)]
		public Patient? PersonPatient { get; set; }

		#endregion
	}

	[Table("Person_SelectAll", IsView=true)]
	public partial class PersonSelectAll
	{
		[Column(DbType="Long",        DataType=LinqToDB.DataType.Int32),              NotNull    ] public int     PersonID   { get; set; } // Long
		[Column(DbType="VarChar(50)", DataType=LinqToDB.DataType.VarChar, Length=50),    Nullable] public string? FirstName  { get; set; } // VarChar(50)
		[Column(DbType="VarChar(50)", DataType=LinqToDB.DataType.VarChar, Length=50),    Nullable] public string? LastName   { get; set; } // VarChar(50)
		[Column(DbType="VarChar(50)", DataType=LinqToDB.DataType.VarChar, Length=50),    Nullable] public string? MiddleName { get; set; } // VarChar(50)
		[Column(DbType="VarChar(1)",  DataType=LinqToDB.DataType.VarChar, Length=1),     Nullable] public char?   Gender     { get; set; } // VarChar(1)
	}

	[Table("Scalar_DataReader", IsView=true)]
	public partial class ScalarDataReader
	{
		[Column("intField",    DbType="Long",     DataType=LinqToDB.DataType.Int32), Nullable] public int?    IntField    { get; set; } // Long
		[Column("stringField", DbType="LongText", DataType=LinqToDB.DataType.NText), Nullable] public string? StringField { get; set; } // LongText
	}

	[Table("TestIdentity")]
	public partial class TestIdentity
	{
		[Column(DbType="Long", DataType=LinqToDB.DataType.Int32), PrimaryKey, NotNull] public int ID { get; set; } // Long
	}

	[Table("TestMerge1")]
	public partial class TestMerge1
	{
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                             PrimaryKey,  NotNull] public int       Id              { get; set; } // Long
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      Field1          { get; set; } // Long
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      Field2          { get; set; } // Long
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      Field3          { get; set; } // Long
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      Field4          { get; set; } // Long
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      Field5          { get; set; } // Long
		[Column(DbType="Bit",             DataType=LinqToDB.DataType.Boolean),                                        NotNull] public bool      FieldBoolean    { get; set; } // Bit
		[Column(DbType="VarChar(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable         ] public string?   FieldString     { get; set; } // VarChar(20)
		[Column(DbType="VarChar(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable         ] public string?   FieldNString    { get; set; } // VarChar(20)
		[Column(DbType="CHAR(1)",         DataType=LinqToDB.DataType.Char,      Length=1),                  Nullable         ] public char?     FieldChar       { get; set; } // CHAR(1)
		[Column(DbType="CHAR(1)",         DataType=LinqToDB.DataType.Char,      Length=1),                  Nullable         ] public char?     FieldNChar      { get; set; } // CHAR(1)
		[Column(DbType="Single",          DataType=LinqToDB.DataType.Single),                               Nullable         ] public float?    FieldFloat      { get; set; } // Single
		[Column(DbType="Double",          DataType=LinqToDB.DataType.Double),                               Nullable         ] public double?   FieldDouble     { get; set; } // Double
		[Column(DbType="DateTime",        DataType=LinqToDB.DataType.DateTime),                             Nullable         ] public DateTime? FieldDateTime   { get; set; } // DateTime
		[Column(DbType="VARBINARY(20)",   DataType=LinqToDB.DataType.VarBinary, Length=20),                 Nullable         ] public byte[]?   FieldBinary     { get; set; } // VARBINARY(20)
		[Column(DbType="GUID",            DataType=LinqToDB.DataType.Guid),                                 Nullable         ] public Guid?     FieldGuid       { get; set; } // GUID
		[Column(DbType="Decimal(24, 10)", DataType=LinqToDB.DataType.Decimal,   Precision=24, Scale=10),    Nullable         ] public decimal?  FieldDecimal    { get; set; } // Decimal(24, 10)
		[Column(DbType="DateTime",        DataType=LinqToDB.DataType.DateTime),                             Nullable         ] public DateTime? FieldDate       { get; set; } // DateTime
		[Column(DbType="DateTime",        DataType=LinqToDB.DataType.DateTime),                             Nullable         ] public DateTime? FieldTime       { get; set; } // DateTime
		[Column(DbType="VarChar(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable         ] public string?   FieldEnumString { get; set; } // VarChar(20)
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      FieldEnumNumber { get; set; } // Long
	}

	[Table("TestMerge2")]
	public partial class TestMerge2
	{
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                             PrimaryKey,  NotNull] public int       Id              { get; set; } // Long
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      Field1          { get; set; } // Long
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      Field2          { get; set; } // Long
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      Field3          { get; set; } // Long
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      Field4          { get; set; } // Long
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      Field5          { get; set; } // Long
		[Column(DbType="Bit",             DataType=LinqToDB.DataType.Boolean),                                        NotNull] public bool      FieldBoolean    { get; set; } // Bit
		[Column(DbType="VarChar(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable         ] public string?   FieldString     { get; set; } // VarChar(20)
		[Column(DbType="VarChar(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable         ] public string?   FieldNString    { get; set; } // VarChar(20)
		[Column(DbType="CHAR(1)",         DataType=LinqToDB.DataType.Char,      Length=1),                  Nullable         ] public char?     FieldChar       { get; set; } // CHAR(1)
		[Column(DbType="CHAR(1)",         DataType=LinqToDB.DataType.Char,      Length=1),                  Nullable         ] public char?     FieldNChar      { get; set; } // CHAR(1)
		[Column(DbType="Single",          DataType=LinqToDB.DataType.Single),                               Nullable         ] public float?    FieldFloat      { get; set; } // Single
		[Column(DbType="Double",          DataType=LinqToDB.DataType.Double),                               Nullable         ] public double?   FieldDouble     { get; set; } // Double
		[Column(DbType="DateTime",        DataType=LinqToDB.DataType.DateTime),                             Nullable         ] public DateTime? FieldDateTime   { get; set; } // DateTime
		[Column(DbType="VARBINARY(20)",   DataType=LinqToDB.DataType.VarBinary, Length=20),                 Nullable         ] public byte[]?   FieldBinary     { get; set; } // VARBINARY(20)
		[Column(DbType="GUID",            DataType=LinqToDB.DataType.Guid),                                 Nullable         ] public Guid?     FieldGuid       { get; set; } // GUID
		[Column(DbType="Decimal(24, 10)", DataType=LinqToDB.DataType.Decimal,   Precision=24, Scale=10),    Nullable         ] public decimal?  FieldDecimal    { get; set; } // Decimal(24, 10)
		[Column(DbType="DateTime",        DataType=LinqToDB.DataType.DateTime),                             Nullable         ] public DateTime? FieldDate       { get; set; } // DateTime
		[Column(DbType="DateTime",        DataType=LinqToDB.DataType.DateTime),                             Nullable         ] public DateTime? FieldTime       { get; set; } // DateTime
		[Column(DbType="VarChar(20)",     DataType=LinqToDB.DataType.VarChar,   Length=20),                 Nullable         ] public string?   FieldEnumString { get; set; } // VarChar(20)
		[Column(DbType="Long",            DataType=LinqToDB.DataType.Int32),                                Nullable         ] public int?      FieldEnumNumber { get; set; } // Long
	}

	public static partial class TestDataDBStoredProcedures
	{
		#region AddIssue792Record

		public static int AddIssue792Record(this TestDataDB dataConnection)
		{
			return dataConnection.ExecuteProc("[AddIssue792Record]");
		}

		#endregion

		#region PatientSelectByName

		public static IEnumerable<PatientSelectAll> PatientSelectByName(this TestDataDB dataConnection, string? @firstName, string? @lastName)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", @firstName, LinqToDB.DataType.NText)
				{
					Size = 50
				},
				new DataParameter("@lastName",  @lastName,  LinqToDB.DataType.NText)
				{
					Size = 50
				}
			};

			return dataConnection.QueryProc<PatientSelectAll>("[Patient_SelectByName]", parameters);
		}

		#endregion

		#region PersonDelete

		public static int PersonDelete(this TestDataDB dataConnection, int? @PersonID)
		{
			var parameters = new []
			{
				new DataParameter("@PersonID", @PersonID, LinqToDB.DataType.Int32)
			};

			return dataConnection.ExecuteProc("[Person_Delete]", parameters);
		}

		#endregion

		#region PersonInsert

		public static int PersonInsert(this TestDataDB dataConnection, string? @FirstName, string? @MiddleName, string? @LastName, char? @Gender)
		{
			var parameters = new []
			{
				new DataParameter("@FirstName",  @FirstName,  LinqToDB.DataType.NText)
				{
					Size = 50
				},
				new DataParameter("@MiddleName", @MiddleName, LinqToDB.DataType.NText)
				{
					Size = 50
				},
				new DataParameter("@LastName",   @LastName,   LinqToDB.DataType.NText)
				{
					Size = 50
				},
				new DataParameter("@Gender",     @Gender,     LinqToDB.DataType.NText)
				{
					Size = 1
				}
			};

			return dataConnection.ExecuteProc("[Person_Insert]", parameters);
		}

		#endregion

		#region PersonSelectByKey

		public static IEnumerable<Person> PersonSelectByKey(this TestDataDB dataConnection, int? @id)
		{
			var parameters = new []
			{
				new DataParameter("@id", @id, LinqToDB.DataType.Int32)
			};

			return dataConnection.QueryProc<Person>("[Person_SelectByKey]", parameters);
		}

		#endregion

		#region PersonSelectByName

		public static IEnumerable<Person> PersonSelectByName(this TestDataDB dataConnection, string? @firstName, string? @lastName)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", @firstName, LinqToDB.DataType.NText)
				{
					Size = 50
				},
				new DataParameter("@lastName",  @lastName,  LinqToDB.DataType.NText)
				{
					Size = 50
				}
			};

			return dataConnection.QueryProc<Person>("[Person_SelectByName]", parameters);
		}

		#endregion

		#region PersonSelectListByName

		public static IEnumerable<Person> PersonSelectListByName(this TestDataDB dataConnection, string? @firstName, string? @lastName)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", @firstName, LinqToDB.DataType.NText)
				{
					Size = 50
				},
				new DataParameter("@lastName",  @lastName,  LinqToDB.DataType.NText)
				{
					Size = 50
				}
			};

			return dataConnection.QueryProc<Person>("[Person_SelectListByName]", parameters);
		}

		#endregion

		#region PersonUpdate

		public static int PersonUpdate(this TestDataDB dataConnection, int? @id, int? @PersonID, string? @FirstName, string? @MiddleName, string? @LastName, char? @Gender)
		{
			var parameters = new []
			{
				new DataParameter("@id",         @id,         LinqToDB.DataType.Int32),
				new DataParameter("@PersonID",   @PersonID,   LinqToDB.DataType.Int32),
				new DataParameter("@FirstName",  @FirstName,  LinqToDB.DataType.NText)
				{
					Size = 50
				},
				new DataParameter("@MiddleName", @MiddleName, LinqToDB.DataType.NText)
				{
					Size = 50
				},
				new DataParameter("@LastName",   @LastName,   LinqToDB.DataType.NText)
				{
					Size = 50
				},
				new DataParameter("@Gender",     @Gender,     LinqToDB.DataType.NText)
				{
					Size = 1
				}
			};

			return dataConnection.ExecuteProc("[Person_Update]", parameters);
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static DataTypeTest? Find(this ITable<DataTypeTest> table, int DataTypeID)
		{
			return table.FirstOrDefault(t =>
				t.DataTypeID == DataTypeID);
		}

		public static Doctor? Find(this ITable<Doctor> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, int InheritanceChildId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceChildId == InheritanceChildId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, int InheritanceParentId)
		{
			return table.FirstOrDefault(t =>
				t.InheritanceParentId == InheritanceParentId);
		}

		public static Patient? Find(this ITable<Patient> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static Person? Find(this ITable<Person> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static TestIdentity? Find(this ITable<TestIdentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}
	}
}
