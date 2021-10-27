﻿using System;

namespace LinqToDB
{
	public partial class Sql
	{
		public static class QueryExtensionID
		{
			public const int TableHint = 1000;
			public const int JoinHint  = 1001;

			// SqlServer table hint IDs.
			//
			public const int SqlServerForceSeekTableHintID = 2001;
		}
	}
}
