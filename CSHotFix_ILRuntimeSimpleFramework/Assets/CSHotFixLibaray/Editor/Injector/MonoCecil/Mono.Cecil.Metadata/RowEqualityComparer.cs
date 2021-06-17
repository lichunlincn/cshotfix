using System;
using System.Collections.Generic;
namespace Editor_Mono.Cecil.Metadata
{
	internal sealed class RowEqualityComparer : IEqualityComparer<Row<string, string>>, IEqualityComparer<Row<uint, uint>>, IEqualityComparer<Row<uint, uint, uint>>
	{
		public bool Equals(Row<string, string> x, Row<string, string> y)
		{
			return x.Col1 == y.Col1 && x.Col2 == y.Col2;
		}
		public int GetHashCode(Row<string, string> obj)
		{
			string col = obj.Col1;
			string col2 = obj.Col2;
			return ((col != null) ? col.GetHashCode() : 0) ^ ((col2 != null) ? col2.GetHashCode() : 0);
		}
		public bool Equals(Row<uint, uint> x, Row<uint, uint> y)
		{
			return x.Col1 == y.Col1 && x.Col2 == y.Col2;
		}
		public int GetHashCode(Row<uint, uint> obj)
		{
			return (int)(obj.Col1 ^ obj.Col2);
		}
		public bool Equals(Row<uint, uint, uint> x, Row<uint, uint, uint> y)
		{
			return x.Col1 == y.Col1 && x.Col2 == y.Col2 && x.Col3 == y.Col3;
		}
		public int GetHashCode(Row<uint, uint, uint> obj)
		{
			return (int)(obj.Col1 ^ obj.Col2 ^ obj.Col3);
		}
	}
}
