// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using System.Data.SqlTypes;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.SqlServer.Azure.MI
{
	[Table("MSSQL_TemporalHistoryFor_20195122")]
	public class MssqlTemporalHistoryFor20195122
	{
		[Column("Id"       , DataType = LinqToDB.DataType.Int32    , DbType = "int"                         )] public SqlInt32    Id        { get; set; } // int
		[Column("Name"     , DataType = LinqToDB.DataType.NVarChar , DbType = "nvarchar(10)", Length    = 10)] public SqlString?  Name      { get; set; } // nvarchar(10)
		[Column("ValidFrom", DataType = LinqToDB.DataType.DateTime2, DbType = "datetime2(7)", Precision = 7 )] public SqlDateTime ValidFrom { get; set; } // datetime2(7)
		[Column("ValidTo"  , DataType = LinqToDB.DataType.DateTime2, DbType = "datetime2(7)", Precision = 7 )] public SqlDateTime ValidTo   { get; set; } // datetime2(7)
	}
}
