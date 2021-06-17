using Editor_Mono.Cecil.Metadata;
using Editor_Mono.Collections.Generic;
using System;
using System.Text;
namespace Editor_Mono.Cecil
{
	public sealed class ArrayType : TypeSpecification
	{
		private Collection<ArrayDimension> dimensions;
		public Collection<ArrayDimension> Dimensions
		{
			get
			{
				if (this.dimensions != null)
				{
					return this.dimensions;
				}
				this.dimensions = new Collection<ArrayDimension>();
				this.dimensions.Add(default(ArrayDimension));
				return this.dimensions;
			}
		}
		public int Rank
		{
			get
			{
				if (this.dimensions != null)
				{
					return this.dimensions.Count;
				}
				return 1;
			}
		}
		public bool IsVector
		{
			get
			{
				return this.dimensions == null || (this.dimensions.Count <= 1 && !this.dimensions[0].IsSized);
			}
		}
		public override bool IsValueType
		{
			get
			{
				return false;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}
		public override string Name
		{
			get
			{
				return base.Name + this.Suffix;
			}
		}
		public override string FullName
		{
			get
			{
				return base.FullName + this.Suffix;
			}
		}
		private string Suffix
		{
			get
			{
				if (this.IsVector)
				{
					return "[]";
				}
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("[");
				for (int i = 0; i < this.dimensions.Count; i++)
				{
					if (i > 0)
					{
						stringBuilder.Append(",");
					}
					stringBuilder.Append(this.dimensions[i].ToString());
				}
				stringBuilder.Append("]");
				return stringBuilder.ToString();
			}
		}
		public override bool IsArray
		{
			get
			{
				return true;
			}
		}
		public ArrayType(TypeReference type) : base(type)
		{
			Mixin.CheckType(type);
			this.etype = Editor_Mono.Cecil.Metadata.ElementType.Array;
		}
		public ArrayType(TypeReference type, int rank) : this(type)
		{
			Mixin.CheckType(type);
			if (rank == 1)
			{
				return;
			}
			this.dimensions = new Collection<ArrayDimension>(rank);
			for (int i = 0; i < rank; i++)
			{
				this.dimensions.Add(default(ArrayDimension));
			}
			this.etype = Editor_Mono.Cecil.Metadata.ElementType.Array;
		}
	}
}
