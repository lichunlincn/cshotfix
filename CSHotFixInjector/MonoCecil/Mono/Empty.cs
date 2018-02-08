using System;
namespace Mono
{
	internal static class Empty<T>
	{
		public static readonly T[] Array = new T[0];
	}
}
