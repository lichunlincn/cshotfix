using Editor_Mono.Cecil.PE;
using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
namespace Editor_Mono.Cecil
{
	internal static class CryptoService
	{
		public static void StrongName(Stream stream, ImageWriter writer, StrongNameKeyPair key_pair)
		{
			int strong_name_pointer;
			byte[] strong_name = CryptoService.CreateStrongName(key_pair, CryptoService.HashStream(stream, writer, out strong_name_pointer));
			CryptoService.PatchStrongName(stream, strong_name_pointer, strong_name);
		}
		private static void PatchStrongName(Stream stream, int strong_name_pointer, byte[] strong_name)
		{
			stream.Seek((long)strong_name_pointer, SeekOrigin.Begin);
			stream.Write(strong_name, 0, strong_name.Length);
		}
		private static byte[] CreateStrongName(StrongNameKeyPair key_pair, byte[] hash)
		{
			byte[] result;
			using (RSA rSA = key_pair.CreateRSA())
			{
				RSAPKCS1SignatureFormatter rSAPKCS1SignatureFormatter = new RSAPKCS1SignatureFormatter(rSA);
				rSAPKCS1SignatureFormatter.SetHashAlgorithm("SHA1");
				byte[] array = rSAPKCS1SignatureFormatter.CreateSignature(hash);
				Array.Reverse(array);
				result = array;
			}
			return result;
		}
		private static byte[] HashStream(Stream stream, ImageWriter writer, out int strong_name_pointer)
		{
			Section text = writer.text;
			int headerSize = (int)writer.GetHeaderSize();
			int pointerToRawData = (int)text.PointerToRawData;
			DataDirectory strongNameSignatureDirectory = writer.GetStrongNameSignatureDirectory();
			if (strongNameSignatureDirectory.Size == 0u)
			{
				throw new InvalidOperationException();
			}
			strong_name_pointer = (int)((long)pointerToRawData + (long)((ulong)(strongNameSignatureDirectory.VirtualAddress - text.VirtualAddress)));
			int size = (int)strongNameSignatureDirectory.Size;
			SHA1Managed sHA1Managed = new SHA1Managed();
			byte[] buffer = new byte[8192];
			using (CryptoStream cryptoStream = new CryptoStream(Stream.Null, sHA1Managed, CryptoStreamMode.Write))
			{
				stream.Seek(0L, SeekOrigin.Begin);
				CryptoService.CopyStreamChunk(stream, cryptoStream, buffer, headerSize);
				stream.Seek((long)pointerToRawData, SeekOrigin.Begin);
				CryptoService.CopyStreamChunk(stream, cryptoStream, buffer, strong_name_pointer - pointerToRawData);
				stream.Seek((long)size, SeekOrigin.Current);
				CryptoService.CopyStreamChunk(stream, cryptoStream, buffer, (int)(stream.Length - (long)(strong_name_pointer + size)));
			}
			return sHA1Managed.Hash;
		}
		private static void CopyStreamChunk(Stream stream, Stream dest_stream, byte[] buffer, int length)
		{
			while (length > 0)
			{
				int num = stream.Read(buffer, 0, System.Math.Min(buffer.Length, length));
				dest_stream.Write(buffer, 0, num);
				length -= num;
			}
		}
		public static byte[] ComputeHash(string file)
		{
			if (!File.Exists(file))
			{
				return Empty<byte>.Array;
			}
			SHA1Managed sHA1Managed = new SHA1Managed();
			using (FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				byte[] buffer = new byte[8192];
				using (CryptoStream cryptoStream = new CryptoStream(Stream.Null, sHA1Managed, CryptoStreamMode.Write))
				{
					CryptoService.CopyStreamChunk(fileStream, cryptoStream, buffer, (int)fileStream.Length);
				}
			}
			return sHA1Managed.Hash;
		}
	}
}
