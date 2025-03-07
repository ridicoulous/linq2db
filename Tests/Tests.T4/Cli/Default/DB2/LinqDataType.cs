// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;
using System;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Default.DB2
{
	[Table("LinqDataTypes")]
	public class LinqDataType
	{
		[Column("ID"            )] public int?      Id             { get; set; } // INTEGER
		[Column("MoneyValue"    )] public decimal?  MoneyValue     { get; set; } // DECIMAL(10,4)
		[Column("DateTimeValue" )] public DateTime? DateTimeValue  { get; set; } // TIMESTAMP
		[Column("DateTimeValue2")] public DateTime? DateTimeValue2 { get; set; } // TIMESTAMP
		[Column("BoolValue"     )] public short?    BoolValue      { get; set; } // SMALLINT
		[Column("GuidValue"     )] public byte[]?   GuidValue      { get; set; } // CHAR (16) FOR BIT DATA
		[Column("BinaryValue"   )] public byte[]?   BinaryValue    { get; set; } // BLOB(5000)
		[Column("SmallIntValue" )] public short?    SmallIntValue  { get; set; } // SMALLINT
		[Column("IntValue"      )] public int?      IntValue       { get; set; } // INTEGER
		[Column("BigIntValue"   )] public long?     BigIntValue    { get; set; } // BIGINT
		[Column("StringValue"   )] public string?   StringValue    { get; set; } // VARCHAR(50)
	}
}
