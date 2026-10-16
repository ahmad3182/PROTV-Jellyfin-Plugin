using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using lMK4Bkj7mOTuW7vPIBH;

namespace d4o0g8jSIU6KstF7m61;

internal class cU7dMkjtXsyGty1iGUX
{
	internal class xrI5RgjfsdLADFPcO7s
	{
		private BinaryReader TALAGVqLAx;

		public xrI5RgjfsdLADFPcO7s(Stream P_0)
		{
			TALAGVqLAx = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream xbZZ0pH5U7()
		{
			return TALAGVqLAx.BaseStream;
		}

		internal byte[] Du4AI7g3ft(int P_0)
		{
			return TALAGVqLAx.ReadBytes(P_0);
		}

		internal int hliAVstF0L(byte[] P_0, int P_1, int P_2)
		{
			return TALAGVqLAx.Read(P_0, P_1, P_2);
		}

		internal int ceYAaJkbcZ()
		{
			return TALAGVqLAx.ReadInt32();
		}

		internal void wvFA0snrwG()
		{
			TALAGVqLAx.Close();
		}
	}

	private delegate void jG0BSSjKZE4VN4HjSEy(object o);

	internal class znuxwIjkSnJjvYOaCFe
	{
		internal static string aQFATuFl1F(string P_0, string P_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(P_0);
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = zByuF10avH(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = d0yuRk7sYM();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	internal class emMDJKj8Px1F9y1nJDp : Attribute
	{
		internal class jQlOmHjQ8ADGvMpjG6h<WOZAcPjngtDJPxfRJ2D>
		{
			public jQlOmHjQ8ADGvMpjG6h()
			{
				YB7sLl9goblbeqxsua.D35lls5iF(YB7sLl9goblbeqxsua.wc2DfU0VR);
				base._002Ector();
			}
		}

		[emMDJKj8Px1F9y1nJDp(typeof(jQlOmHjQ8ADGvMpjG6h<object>[]))]
		public emMDJKj8Px1F9y1nJDp(object P_0)
		{
		}
	}

	private static uint[] OPkuzAX5nt;

	private static byte[] RFNAdOMEXo;

	private static Assembly geYA4ijmed;

	private static bool JsrAjATFgQ;

	private byte[] xSxAqt8jYG;

	private static bool uyGAca0olX;

	private static Dictionary<int, int> WsOAvDC5eW;

	private static byte[] rYeAD0Tn35;

	private byte[] iiZAPCBk6Q;

	private static byte[] auiABhyCAJ;

	private static object gkhAWTQMIg;

	static cU7dMkjtXsyGty1iGUX()
	{
		OPkuzAX5nt = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		uyGAca0olX = false;
		JsrAjATFgQ = false;
		WsOAvDC5eW = null;
		gkhAWTQMIg = new object();
		geYA4ijmed = Type.GetTypeFromHandle(Y6FHypjb1bunXIrWwSE.Yy8ChQDHLQv8r(33555071)).Assembly;
		auiABhyCAJ = new byte[0];
		rYeAD0Tn35 = new byte[0];
		RFNAdOMEXo = new byte[0];
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	internal cU7dMkjtXsyGty1iGUX()
	{
	}

	private void VIAChQDDebq6o()
	{
	}

	internal static byte[] AnauuUaVDA(byte[] P_0)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - P_0.Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(P_0.Length + num / 8 + 8);
		ulong num3 = (ulong)P_0.Length * 8uL;
		byte[] array2 = new byte[num2];
		for (int i = 0; i < P_0.Length; i++)
		{
			array2[i] = P_0[i];
		}
		array2[P_0.Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFF);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint num6 = 1732584193u;
		uint num7 = 4023233417u;
		uint num8 = 2562383102u;
		uint num9 = 271733878u;
		for (uint num10 = 0u; num10 < num5 / 16; num10++)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0u; num12 < 61; num12 += 4)
			{
				array[num12 >> 2] = (uint)((array2[num11 + (num12 + 3)] << 24) | (array2[num11 + (num12 + 2)] << 16) | (array2[num11 + (num12 + 1)] << 8) | array2[num11 + num12]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			p6cuA6cZX7(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			p6cuA6cZX7(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			p6cuA6cZX7(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			p6cuA6cZX7(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			p6cuA6cZX7(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			p6cuA6cZX7(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			p6cuA6cZX7(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			p6cuA6cZX7(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			p6cuA6cZX7(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			p6cuA6cZX7(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			p6cuA6cZX7(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			p6cuA6cZX7(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			p6cuA6cZX7(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			p6cuA6cZX7(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			p6cuA6cZX7(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			p6cuA6cZX7(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			OveuN1o6h2(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			OveuN1o6h2(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			OveuN1o6h2(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			OveuN1o6h2(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			OveuN1o6h2(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			OveuN1o6h2(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			OveuN1o6h2(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			OveuN1o6h2(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			OveuN1o6h2(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			OveuN1o6h2(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			OveuN1o6h2(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			OveuN1o6h2(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			OveuN1o6h2(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			OveuN1o6h2(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			OveuN1o6h2(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			OveuN1o6h2(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			dbxuMxlbJ9(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			dbxuMxlbJ9(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			dbxuMxlbJ9(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			dbxuMxlbJ9(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			dbxuMxlbJ9(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			dbxuMxlbJ9(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			dbxuMxlbJ9(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			dbxuMxlbJ9(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			dbxuMxlbJ9(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			dbxuMxlbJ9(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			dbxuMxlbJ9(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			dbxuMxlbJ9(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			dbxuMxlbJ9(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			dbxuMxlbJ9(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			dbxuMxlbJ9(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			dbxuMxlbJ9(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			O5ouCgI1NQ(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			O5ouCgI1NQ(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			O5ouCgI1NQ(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			O5ouCgI1NQ(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			O5ouCgI1NQ(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			O5ouCgI1NQ(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			O5ouCgI1NQ(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			O5ouCgI1NQ(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			O5ouCgI1NQ(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			O5ouCgI1NQ(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			O5ouCgI1NQ(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			O5ouCgI1NQ(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			O5ouCgI1NQ(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			O5ouCgI1NQ(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			O5ouCgI1NQ(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			O5ouCgI1NQ(ref num7, num8, num9, num6, 9u, 21, 64u, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array3, 12, 4);
		return array3;
	}

	private static void p6cuA6cZX7(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + qGJuY8TJm9(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + OPkuzAX5nt[P_6 - 1], P_5);
	}

	private static void OveuN1o6h2(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + qGJuY8TJm9(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + OPkuzAX5nt[P_6 - 1], P_5);
	}

	private static void dbxuMxlbJ9(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + qGJuY8TJm9(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + OPkuzAX5nt[P_6 - 1], P_5);
	}

	private static void O5ouCgI1NQ(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + qGJuY8TJm9(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + OPkuzAX5nt[P_6 - 1], P_5);
	}

	private static uint qGJuY8TJm9(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static byte[] zByuF10avH(byte[] P_0)
	{
		if (!sUouscXSJL())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return AnauuUaVDA(P_0);
	}

	private static void QWJu67r2cD()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	internal static bool sUouscXSJL()
	{
		if (!uyGAca0olX)
		{
			HxUuXHsGQi();
			uyGAca0olX = true;
		}
		return JsrAjATFgQ;
	}

	internal byte[] mqRuxQoct8()
	{
		_ = "{11111-22222-50001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] TQBuyDlfoQ()
	{
		_ = "{11111-22222-50001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	public static void HuXupSDYsZ(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (WsOAvDC5eW == null)
			{
				lock (gkhAWTQMIg)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(Y6FHypjb1bunXIrWwSE.Yy8ChQDHLQv8r(33555071)).Assembly.GetManifestResourceStream("RYpQrEhFPlnpQIBFJL.tugWxwtPOYe5jEaA6c"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[^(1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							uint num11 = 1967905959u;
							uint num12 = 1610652235u;
							uint num13 = 1087730994u;
							uint num14 = num10;
							uint num15 = 1622046629u;
							uint num16 = 35946300u;
							if ((double)num15 == 0.0)
							{
								num15--;
							}
							uint num17 = (uint)(28193.0 / (double)num15 + (double)num15);
							num15 = (uint)((uint)(((short)num11 - 11921) * (int)num17) + (short)num11);
							uint num18 = ((num13 >> 14) | (num13 << 18)) ^ num11;
							uint num19 = num18 & 0xFF00FF;
							num18 &= 0xFF00FF00u;
							num13 = (num18 >> 8) | (num19 << 8);
							num13 = 12043 * (num13 & 0x1FFFF) - (num13 >> 17);
							num15 = 14830 * (num15 & 0x1FFFF) - (num15 >> 17);
							num15 = 64732 * num15 + num13;
							ulong num20 = 18446744071978183513uL;
							num20 |= 1;
							num12 = (uint)(num12 * num12 % num20);
							num16 = num15 - num15 - 1186515892;
							num14 ^= num14 >> 28;
							num14 += num11;
							num14 ^= num14 << 3;
							num14 += num12;
							num14 ^= num14 >> 3;
							num14 += num16;
							num14 = (((num13 << 16) - num13) ^ num12) - num14;
							num3 = num9 + (uint)(double)num14;
							if (i == num2 - 1 && num > 0)
							{
								uint num21 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num21 & num7) >> num8);
								}
							}
							else
							{
								uint num22 = num3 ^ num4;
								array2[num6] = (byte)(num22 & 0xFF);
								array2[num6 + 1] = (byte)((num22 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num22 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num23 = array.Length / 8;
						xrI5RgjfsdLADFPcO7s xrI5RgjfsdLADFPcO7s2 = new xrI5RgjfsdLADFPcO7s(new MemoryStream(array));
						for (int l = 0; l < num23; l++)
						{
							int key = xrI5RgjfsdLADFPcO7s2.ceYAaJkbcZ();
							int value = xrI5RgjfsdLADFPcO7s2.ceYAaJkbcZ();
							dictionary.Add(key, value);
						}
						xrI5RgjfsdLADFPcO7s2.wvFA0snrwG();
					}
					WsOAvDC5eW = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num24 = WsOAvDC5eW[metadataToken];
				bool flag = (num24 & 0x40000000) > 0;
				num24 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(Y6FHypjb1bunXIrWwSE.Yy8ChQDHLQv8r(33555071)).Module.ResolveMethod(num24, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					continue;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num25 = parameters.Length + 1;
				Type[] array3 = new Type[num25];
				if (methodInfo.DeclaringType.IsValueType)
				{
					array3[0] = methodInfo.DeclaringType.MakeByRefType();
				}
				else
				{
					array3[0] = Type.GetTypeFromHandle(Y6FHypjb1bunXIrWwSE.Yy8ChQDHLQv8r(16777276));
				}
				for (int n = 0; n < parameters.Length; n++)
				{
					array3[n + 1] = parameters[n].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num26 = 0; num26 < num25; num26++)
				{
					switch (num26)
					{
					case 0:
						iLGenerator.Emit(OpCodes.Ldarg_0);
						break;
					case 1:
						iLGenerator.Emit(OpCodes.Ldarg_1);
						break;
					case 2:
						iLGenerator.Emit(OpCodes.Ldarg_2);
						break;
					case 3:
						iLGenerator.Emit(OpCodes.Ldarg_3);
						break;
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num26);
						break;
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
			}
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	internal static void zuwu3uBWT1()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	private static int nZRumIhWT9()
	{
		return 5;
	}

	internal static void HxUuXHsGQi()
	{
		try
		{
			JsrAjATFgQ = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static SymmetricAlgorithm d0yuRk7sYM()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (sUouscXSJL())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return new AesCryptoServiceProvider();
		}
	}

	private byte[] buDuwuiTs8()
	{
		_ = "{11111-22222-20001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] by2uEd52mk()
	{
		_ = "{11111-22222-20001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal static bool JMtu9oNkFo(int P_0)
	{
		if (rYeAD0Tn35.Length == 0)
		{
			xrI5RgjfsdLADFPcO7s obj = new xrI5RgjfsdLADFPcO7s(geYA4ijmed.GetManifestResourceStream("{11111-22222-20001-00000}"));
			obj.xbZZ0pH5U7().Position = 0L;
			RSACryptoServiceProvider.UseMachineKeyStore = true;
			byte[] array = obj.Du4AI7g3ft((int)obj.xbZZ0pH5U7().Length);
			byte[] rgbKey = new cU7dMkjtXsyGty1iGUX().by2uEd52mk();
			byte[] array2 = new cU7dMkjtXsyGty1iGUX().buDuwuiTs8();
			byte[] publicKeyToken = geYA4ijmed.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length != 0)
			{
				array2[1] = publicKeyToken[0];
				array2[3] = publicKeyToken[1];
				array2[5] = publicKeyToken[2];
				array2[7] = publicKeyToken[3];
				array2[9] = publicKeyToken[4];
				array2[11] = publicKeyToken[5];
				array2[13] = publicKeyToken[6];
				array2[15] = publicKeyToken[7];
			}
			SymmetricAlgorithm symmetricAlgorithm = d0yuRk7sYM();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, array2);
			Stream stream = hGXueLZygm();
			CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			rYeAD0Tn35 = tvSuHBFb4L(stream);
			stream.Close();
			cryptoStream.Close();
			obj.wvFA0snrwG();
		}
		if (auiABhyCAJ.Length == 0)
		{
			auiABhyCAJ = I6ZuOAQnix(soUurSlr4n(geYA4ijmed).ToString());
		}
		int num = 0;
		try
		{
			num = BitConverter.ToInt32(new byte[4]
			{
				rYeAD0Tn35[P_0],
				rYeAD0Tn35[P_0 + 1],
				rYeAD0Tn35[P_0 + 2],
				rYeAD0Tn35[P_0 + 3]
			}, 0);
		}
		catch
		{
		}
		try
		{
			if (auiABhyCAJ[num] == 128)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static Stream hGXueLZygm()
	{
		return new MemoryStream();
	}

	private static byte[] I6ZuOAQnix(string P_0)
	{
		using FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		int num2 = (int)fileStream.Length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	internal static object soUurSlr4n(object P_0)
	{
		try
		{
			if (File.Exists(((Assembly)P_0).Location))
			{
				return ((Assembly)P_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
				.ToString()))
			{
				return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	private static byte[] tvSuHBFb4L(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal byte[] xQnuoAvweW()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] QdeugRNc5K()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[emMDJKj8Px1F9y1nJDp(typeof(emMDJKj8Px1F9y1nJDp.jQlOmHjQ8ADGvMpjG6h<object>[]))]
	internal static string Vvgu1RVGXo(int P_0)
	{
		int num = 2;
		int num10 = default(int);
		int num12 = default(int);
		string result = default(string);
		int num14 = default(int);
		BinaryReader binaryReader = default(BinaryReader);
		byte[] array = default(byte[]);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		byte[] array5 = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					try
					{
						byte[] array6 = new byte[num10];
						int num11 = 0;
						if (!WGQt7xqnx4Ap1DtZFO())
						{
							num11 = num12;
						}
						while (true)
						{
							switch (num11)
							{
							default:
								QoocVRv297GNNW6ywQ(RFNAdOMEXo, P_0 + 4, array6, 0, num10);
								num11 = 2;
								break;
							case 2:
								result = (string)IP3es1wvITC3SH1Dit(Cre06YOaL1PC57HMMT(), array6, 0, array6.Length);
								num11 = 1;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num11 = 1;
								}
								break;
							case 1:
								return result;
							}
						}
					}
					catch
					{
						int num13 = 0;
						if (!WGQt7xqnx4Ap1DtZFO())
						{
							num13 = num14;
						}
						switch (num13)
						{
						case 0:
							break;
						}
					}
					goto case 5;
				case 4:
					try
					{
						R2dt27kYqtP0QlQemN(adJCDvVDCBUDLpPfie(binaryReader), 0L);
						int num3 = 147;
						while (true)
						{
							switch (num3)
							{
							case 221:
								array[23] = 208;
								num3 = 87;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 206:
								num4 = 217 - 72;
								num3 = 51;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 155:
								array[26] = (byte)num4;
								num3 = 83;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 100;
								}
								continue;
							case 17:
								num5 = 178 - 59;
								num3 = 15;
								continue;
							case 22:
								num4 = 74 + 121;
								num6 = 185;
								goto IL_0130;
							case 182:
								array[26] = 223;
								num3 = 175;
								continue;
							case 21:
								array[27] = 212;
								num3 = 103;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 154:
								array[10] = (byte)num5;
								num3 = 72;
								continue;
							case 88:
								array[22] = (byte)num4;
								num3 = 86;
								continue;
							case 201:
								array[14] = (byte)num4;
								num3 = 158;
								continue;
							case 86:
								array[22] = 104;
								num3 = 210;
								continue;
							case 7:
								array[14] = (byte)num5;
								num3 = 60;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 32:
								num4 = 121 + 12;
								num3 = 83;
								continue;
							case 120:
								array = new byte[32];
								num3 = 126;
								continue;
							case 193:
								array[20] = (byte)num4;
								num3 = 122;
								continue;
							case 42:
								array[5] = (byte)num5;
								num3 = 151;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 198:
								num5 = 175 - 58;
								num3 = 176;
								continue;
							case 132:
								array[4] = 116;
								num3 = 77;
								continue;
							case 191:
								array[13] = (byte)num5;
								num3 = 34;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 39;
								}
								continue;
							case 44:
								num4 = 185 + 0;
								num3 = 4;
								continue;
							case 45:
								array[4] = 161;
								num3 = 132;
								continue;
							case 69:
								num5 = 210 - 70;
								num3 = 7;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 121:
								array[26] = (byte)num4;
								num3 = 182;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 9:
								array[8] = 112;
								num3 = 188;
								if (WLA3tF7jv88kSHenRD() != null)
								{
									num3 = 23;
								}
								continue;
							case 61:
								num5 = 152 - 50;
								num3 = 93;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 95:
								array[5] = (byte)num5;
								num3 = 171;
								continue;
							case 76:
								array[10] = 149;
								num3 = 137;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									num3 = 148;
								}
								continue;
							case 37:
								array[1] = (byte)num5;
								num6 = 206;
								goto IL_0130;
							case 141:
								num4 = 99 + 117;
								num3 = 193;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 150:
								num4 = 69 + 80;
								num3 = 121;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 183:
								array[14] = (byte)num5;
								num3 = 69;
								continue;
							case 174:
								array[2] = (byte)num5;
								num6 = 144;
								goto IL_0130;
							case 162:
								array[1] = 28;
								num3 = 204;
								continue;
							case 63:
								array[4] = (byte)num4;
								num3 = 198;
								continue;
							case 153:
								array[6] = (byte)num4;
								num3 = 79;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 49:
								num5 = 250 - 83;
								num3 = 150;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 161;
								}
								continue;
							case 138:
								num5 = 41 + 23;
								num3 = 115;
								if (!WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 104;
								}
								continue;
							case 8:
								array[2] = (byte)num4;
								num3 = 142;
								continue;
							case 197:
								num4 = 78 + 112;
								num3 = 189;
								continue;
							case 169:
								num4 = 209 - 69;
								num3 = 97;
								continue;
							case 184:
								array[17] = (byte)num4;
								num3 = 190;
								if (!WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 93;
								}
								continue;
							case 28:
								num5 = 98 + 77;
								num6 = 11;
								goto IL_0130;
							case 209:
								num4 = 19 + 85;
								num3 = 42;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 113;
								}
								continue;
							case 135:
								array[5] = 132;
								num3 = 5;
								continue;
							case 65:
								num5 = 236 - 78;
								num3 = 55;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 106:
								num4 = 33 - 17;
								num3 = 213;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 92:
								array[19] = 215;
								num3 = 220;
								continue;
							case 80:
								num4 = 180 - 60;
								num3 = 177;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 56:
								array[16] = (byte)num4;
								num3 = 1;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 158:
								array[14] = 88;
								num3 = 62;
								continue;
							case 196:
								num5 = 183 + 31;
								num3 = 67;
								continue;
							case 34:
								array[30] = 37;
								num6 = 218;
								goto IL_0130;
							case 29:
								array[23] = 101;
								num6 = 217;
								goto IL_0130;
							case 12:
								num5 = 245 - 81;
								num3 = 81;
								continue;
							case 131:
								num4 = 120 + 95;
								num3 = 201;
								continue;
							case 67:
								array[3] = (byte)num5;
								num3 = 124;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 194;
								}
								continue;
							case 6:
								num4 = 96 + 111;
								num6 = 184;
								goto IL_0130;
							case 173:
								num5 = 75 + 78;
								num3 = 59;
								continue;
							case 212:
								num4 = 146 - 48;
								num3 = 30;
								continue;
							case 148:
								num5 = 23 + 110;
								num3 = 154;
								continue;
							case 73:
								num5 = 49 + 23;
								num3 = 130;
								continue;
							case 110:
								array[25] = 128;
								num3 = 140;
								continue;
							case 77:
								array[4] = 119;
								num3 = 203;
								continue;
							case 107:
								array[14] = 182;
								num3 = 131;
								continue;
							case 177:
								array[27] = (byte)num4;
								num3 = 168;
								if (WLA3tF7jv88kSHenRD() != null)
								{
									num3 = 2;
								}
								continue;
							case 74:
								array[6] = 128;
								num3 = 139;
								continue;
							case 89:
								array[9] = 159;
								num3 = 48;
								continue;
							case 207:
								array[21] = (byte)num4;
								num6 = 47;
								goto IL_0130;
							case 99:
								num4 = 151 - 50;
								num3 = 88;
								continue;
							case 203:
								num5 = 103 + 19;
								num3 = 42;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 95;
								}
								continue;
							case 13:
								array[1] = (byte)num4;
								num3 = 162;
								continue;
							case 187:
								array[19] = 134;
								num3 = 109;
								continue;
							case 114:
								array[24] = 7;
								num3 = 197;
								continue;
							case 170:
								array[18] = 169;
								num3 = 44;
								continue;
							case 140:
								num5 = 36 + 26;
								num3 = 159;
								if (WLA3tF7jv88kSHenRD() != null)
								{
									num3 = 127;
								}
								continue;
							case 94:
								num4 = 117 + 92;
								num3 = 102;
								continue;
							case 178:
								array[28] = 108;
								num3 = 211;
								if (!WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 16;
								}
								continue;
							case 172:
								num4 = 104 + 103;
								num3 = 165;
								continue;
							case 108:
								array[12] = (byte)num4;
								num3 = 49;
								continue;
							case 23:
								num4 = 167 - 55;
								num3 = 56;
								if (WLA3tF7jv88kSHenRD() != null)
								{
									num3 = 17;
								}
								continue;
							case 59:
								array[17] = (byte)num5;
								num3 = 6;
								continue;
							case 81:
								array[31] = (byte)num5;
								num3 = 181;
								continue;
							case 123:
								array[18] = (byte)num4;
								num3 = 138;
								continue;
							case 133:
								array[24] = 153;
								num3 = 31;
								continue;
							case 145:
								array[31] = (byte)num4;
								num3 = 4;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 12;
								}
								continue;
							case 18:
								array[16] = 57;
								num3 = 216;
								continue;
							case 103:
								array[27] = 153;
								num3 = 82;
								continue;
							case 10:
								array[17] = (byte)num4;
								num3 = 70;
								continue;
							case 127:
								num4 = 175 - 64;
								num3 = 20;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 25:
								array[9] = 145;
								num3 = 66;
								continue;
							case 219:
								array[25] = 82;
								num3 = 164;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 71:
								array[27] = (byte)num5;
								num3 = 178;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 2:
								num4 = 200 - 66;
								num3 = 202;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 27:
								array[10] = 142;
								num3 = 35;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 172;
								}
								continue;
							case 220:
								array[20] = 115;
								num3 = 212;
								if (WLA3tF7jv88kSHenRD() != null)
								{
									num3 = 191;
								}
								continue;
							case 50:
								array[9] = (byte)num4;
								num3 = 23;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									num3 = 25;
								}
								continue;
							case 93:
								array[29] = (byte)num5;
								num3 = 19;
								if (!WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 2;
								}
								continue;
							case 190:
								num4 = 46 + 87;
								num3 = 123;
								continue;
							case 16:
								num5 = 42 + 66;
								num3 = 205;
								continue;
							case 39:
								array[13] = 220;
								num3 = 68;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 68:
								array[13] = 116;
								num3 = 166;
								continue;
							case 105:
								num5 = 167 - 55;
								num3 = 57;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 152:
								num4 = 177 - 59;
								num3 = 111;
								continue;
							case 146:
								array[3] = 232;
								num3 = 28;
								if (WLA3tF7jv88kSHenRD() != null)
								{
									num3 = 9;
								}
								continue;
							case 213:
								array[12] = (byte)num4;
								num3 = 179;
								if (WLA3tF7jv88kSHenRD() != null)
								{
									num3 = 121;
								}
								continue;
							case 151:
								array[6] = 136;
								num3 = 34;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 125;
								}
								continue;
							case 24:
								array[5] = (byte)num4;
								num6 = 135;
								goto IL_0130;
							case 200:
								array[12] = 100;
								num3 = 209;
								continue;
							case 43:
								array[8] = (byte)num5;
								num3 = 118;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 75:
								array[23] = (byte)num5;
								num3 = 134;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 5:
								num5 = 137 - 46;
								num3 = 42;
								continue;
							case 204:
								num5 = 99 - 5;
								num6 = 54;
								goto IL_0130;
							case 175:
								array[27] = 131;
								num3 = 80;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 48:
								array[9] = 99;
								num3 = 157;
								continue;
							case 97:
								array[7] = (byte)num4;
								num3 = 127;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 139:
								array[6] = 109;
								num3 = 58;
								continue;
							case 35:
								array[16] = (byte)num4;
								num3 = 18;
								continue;
							case 109:
								num5 = 211 - 70;
								num3 = 3;
								continue;
							case 113:
								array[12] = (byte)num4;
								num3 = 106;
								continue;
							case 91:
								num5 = 45 + 58;
								num3 = 37;
								continue;
							case 192:
								array[21] = 107;
								num6 = 22;
								goto IL_0130;
							case 117:
								num4 = 26 + 104;
								num3 = 50;
								continue;
							case 84:
								array[27] = (byte)num5;
								num6 = 21;
								goto IL_0130;
							case 96:
								array[21] = (byte)num5;
								num3 = 99;
								continue;
							case 143:
								array[30] = (byte)num4;
								num3 = 34;
								continue;
							case 115:
								array[18] = (byte)num5;
								num3 = 73;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 170;
								}
								continue;
							case 112:
								array[15] = 168;
								num3 = 23;
								continue;
							case 142:
								num5 = 91 - 33;
								num3 = 174;
								continue;
							case 215:
								num4 = 22 + 2;
								num3 = 143;
								continue;
							case 47:
								num5 = 177 - 90;
								num3 = 75;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 96;
								}
								continue;
							case 181:
								array[31] = 164;
								num3 = 124;
								continue;
							case 85:
								num4 = 66 + 108;
								num6 = 155;
								goto IL_0130;
							case 14:
								num4 = 190 - 63;
								num3 = 8;
								continue;
							case 90:
								array[11] = 87;
								num3 = 214;
								continue;
							case 188:
								num4 = 203 - 67;
								num3 = 0;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									num3 = 36;
								}
								continue;
							default:
								array[4] = 170;
								num3 = 45;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 208:
								array[30] = 49;
								num3 = 215;
								continue;
							case 46:
								num5 = 24 + 61;
								num3 = 49;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									num3 = 119;
								}
								continue;
							case 179:
								num5 = 196 - 65;
								num3 = 191;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 217:
								num5 = 44 + 2;
								num3 = 75;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 78:
								array[17] = 118;
								num3 = 173;
								if (WLA3tF7jv88kSHenRD() != null)
								{
									num3 = 50;
								}
								continue;
							case 144:
								num4 = 125 - 41;
								num3 = 163;
								continue;
							case 70:
								array[17] = 100;
								num3 = 17;
								if (!WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 6;
								}
								continue;
							case 194:
								num4 = 159 - 53;
								num3 = 63;
								continue;
							case 4:
								array[18] = (byte)num4;
								num6 = 187;
								goto IL_0130;
							case 164:
								array[25] = 173;
								num3 = 33;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 186:
								array[15] = 140;
								num3 = 65;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 126:
								num4 = 97 + 32;
								num3 = 222;
								continue;
							case 33:
								array[25] = 150;
								num3 = 85;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 211:
								array[28] = 115;
								num3 = 32;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 57:
								array[11] = (byte)num5;
								num3 = 16;
								continue;
							case 83:
								array[28] = (byte)num4;
								num3 = 137;
								continue;
							case 214:
								array[12] = 222;
								num3 = 38;
								continue;
							case 222:
								array[0] = (byte)num4;
								num3 = 26;
								continue;
							case 66:
								array[10] = 181;
								num3 = 27;
								continue;
							case 129:
								num4 = 101 + 47;
								num3 = 24;
								continue;
							case 53:
								array[26] = 139;
								num3 = 116;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 98:
								array[3] = 167;
								num3 = 196;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 125:
								array[6] = 48;
								num3 = 30;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									num3 = 74;
								}
								continue;
							case 159:
								array[25] = (byte)num5;
								num3 = 219;
								continue;
							case 31:
								num5 = 155 - 51;
								num3 = 101;
								continue;
							case 20:
								array[7] = (byte)num4;
								num3 = 6;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 9;
								}
								continue;
							case 202:
								array[0] = (byte)num4;
								num3 = 46;
								if (WLA3tF7jv88kSHenRD() != null)
								{
									num3 = 8;
								}
								continue;
							case 72:
								array[10] = 215;
								num3 = 105;
								continue;
							case 147:
								array5 = (byte[])TNGe2oL2FRODGELuCT(binaryReader, (int)xOyM2v8016I8a8CHag(adJCDvVDCBUDLpPfie(binaryReader)));
								num3 = 120;
								continue;
							case 64:
								num5 = 240 - 80;
								num3 = 40;
								continue;
							case 38:
								num4 = 55 + 87;
								num3 = 108;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 116:
								num5 = 80 + 54;
								num3 = 167;
								continue;
							case 19:
								array[29] = 73;
								num3 = 18;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 208;
								}
								continue;
							case 205:
								array[11] = (byte)num5;
								num3 = 90;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 167:
								array[26] = (byte)num5;
								num3 = 150;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 216:
								num4 = 204 - 68;
								num3 = 10;
								continue;
							case 199:
								array[3] = 210;
								num3 = 146;
								if (!WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 14;
								}
								continue;
							case 118:
								array[8] = 125;
								num3 = 89;
								continue;
							case 149:
								array[2] = 124;
								num6 = 14;
								goto IL_0130;
							case 82:
								num5 = 152 - 68;
								num6 = 71;
								goto IL_0130;
							case 41:
								num4 = 133 - 44;
								num3 = 207;
								if (!WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 152;
								}
								continue;
							case 160:
								array[15] = 108;
								num3 = 186;
								continue;
							case 36:
								array[8] = (byte)num4;
								num3 = 104;
								continue;
							case 176:
								array[4] = (byte)num5;
								num3 = 0;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 0;
								}
								continue;
							case 3:
								array[19] = (byte)num5;
								num3 = 92;
								continue;
							case 51:
								array[1] = (byte)num4;
								num3 = 156;
								continue;
							case 166:
								array[13] = 102;
								num3 = 152;
								continue;
							case 171:
								array[5] = 82;
								num3 = 129;
								if (!WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 14;
								}
								continue;
							case 58:
								num4 = 148 + 67;
								num3 = 153;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 210:
								array[22] = 10;
								num6 = 29;
								goto IL_0130;
							case 130:
								array[24] = (byte)num5;
								num3 = 133;
								continue;
							case 15:
								array[17] = (byte)num5;
								num3 = 78;
								continue;
							case 111:
								array[13] = (byte)num4;
								num3 = 128;
								continue;
							case 156:
								num4 = 246 - 82;
								num3 = 13;
								continue;
							case 137:
								array[29] = 161;
								num3 = 61;
								continue;
							case 195:
								num4 = 136 - 45;
								num3 = 52;
								continue;
							case 122:
								array[21] = 123;
								num3 = 192;
								continue;
							case 134:
								array[23] = 165;
								num3 = 221;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 26:
								array[0] = 33;
								num3 = 2;
								continue;
							case 102:
								array[0] = (byte)num4;
								num6 = 91;
								goto IL_0130;
							case 79:
								array[7] = 165;
								num3 = 169;
								continue;
							case 185:
								array[21] = (byte)num4;
								num3 = 41;
								continue;
							case 189:
								array[25] = (byte)num4;
								num3 = 110;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 157:
								array[9] = 182;
								num3 = 64;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 52:
								array[15] = (byte)num4;
								num3 = 160;
								continue;
							case 1:
								num4 = 71 + 45;
								num3 = 35;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 54:
								array[1] = (byte)num5;
								num3 = 149;
								continue;
							case 60:
								array[14] = 73;
								num3 = 195;
								continue;
							case 218:
								num4 = 140 - 46;
								num6 = 145;
								goto IL_0130;
							case 101:
								array[24] = (byte)num5;
								num3 = 114;
								continue;
							case 55:
								array[15] = (byte)num5;
								num3 = 112;
								continue;
							case 128:
								array[13] = 137;
								num3 = 107;
								continue;
							case 30:
								array[20] = (byte)num4;
								num3 = 141;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 119:
								array[0] = (byte)num5;
								num3 = 94;
								continue;
							case 165:
								array[10] = (byte)num4;
								num3 = 76;
								continue;
							case 100:
								array[26] = 118;
								num3 = 53;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 180:
								array[24] = (byte)num5;
								num3 = 73;
								continue;
							case 124:
							{
								byte[] array2 = array;
								byte[] array3 = new byte[16];
								int num7 = 97 + 32;
								array3[0] = (byte)num7;
								array3[0] = 33;
								num7 = 200 - 66;
								array3[0] = (byte)num7;
								int num8 = 24 + 61;
								array3[0] = (byte)num8;
								array3[0] = 141;
								num7 = 5 + 45;
								array3[1] = (byte)num7;
								num8 = 100 + 88;
								array3[1] = (byte)num8;
								array3[1] = 91;
								num7 = 172 - 57;
								array3[2] = (byte)num7;
								num8 = 8 + 41;
								array3[2] = (byte)num8;
								num8 = 132 + 87;
								array3[2] = (byte)num8;
								num8 = 219 - 73;
								array3[3] = (byte)num8;
								num7 = 186 - 62;
								array3[3] = (byte)num7;
								array3[3] = 73;
								num7 = 0 + 103;
								array3[4] = (byte)num7;
								array3[4] = 153;
								num7 = 245 - 81;
								array3[4] = (byte)num7;
								array3[4] = 152;
								array3[4] = 232;
								array3[5] = 167;
								num8 = 31 + 71;
								array3[5] = (byte)num8;
								num8 = 174 - 58;
								array3[5] = (byte)num8;
								num8 = 182 - 71;
								array3[5] = (byte)num8;
								num7 = 236 - 78;
								array3[6] = (byte)num7;
								num7 = 219 - 73;
								array3[6] = (byte)num7;
								num7 = 6 + 47;
								array3[6] = (byte)num7;
								array3[6] = 124;
								array3[6] = 216;
								num8 = 43 + 1;
								array3[7] = (byte)num8;
								num7 = 114 + 101;
								array3[7] = (byte)num7;
								array3[7] = 114;
								array3[7] = 60;
								num7 = 192 - 64;
								array3[7] = (byte)num7;
								array3[7] = 36;
								array3[8] = 80;
								array3[8] = 52;
								num8 = 243 - 81;
								array3[8] = (byte)num8;
								num7 = 205 - 68;
								array3[8] = (byte)num7;
								num7 = 78 - 57;
								array3[8] = (byte)num7;
								num7 = 209 - 69;
								array3[9] = (byte)num7;
								num7 = 191 - 63;
								array3[9] = (byte)num7;
								num8 = 40 + 124;
								array3[9] = (byte)num8;
								num7 = 90 - 12;
								array3[9] = (byte)num7;
								array3[10] = 125;
								num7 = 41 + 118;
								array3[10] = (byte)num7;
								num7 = 82 + 17;
								array3[10] = (byte)num7;
								array3[10] = 167;
								num8 = 186 - 62;
								array3[10] = (byte)num8;
								array3[10] = 228;
								array3[11] = 130;
								array3[11] = 136;
								num7 = 199 - 66;
								array3[11] = (byte)num7;
								array3[11] = 232;
								array3[12] = 176;
								array3[12] = 102;
								num8 = 148 - 49;
								array3[12] = (byte)num8;
								num7 = 161 - 53;
								array3[12] = (byte)num7;
								num8 = 168 + 41;
								array3[12] = (byte)num8;
								num8 = 168 - 56;
								array3[13] = (byte)num8;
								array3[13] = 164;
								num7 = 232 - 114;
								array3[13] = (byte)num7;
								num7 = 106 + 55;
								array3[14] = (byte)num7;
								num7 = 144 - 48;
								array3[14] = (byte)num7;
								array3[14] = 158;
								num8 = 92 + 19;
								array3[14] = (byte)num8;
								num7 = 145 + 103;
								array3[14] = (byte)num7;
								num8 = 182 - 60;
								array3[15] = (byte)num8;
								num7 = 152 - 50;
								array3[15] = (byte)num7;
								array3[15] = 86;
								byte[] array4 = array3;
								RFNAdOMEXo = new cU7dMkjtXsyGty1iGUX(array2, array4).y9HuJK2X7V(array5);
								num6 = 136;
								goto IL_0130;
							}
							case 62:
								num5 = 171 - 57;
								num3 = 183;
								continue;
							case 11:
								array[3] = (byte)num5;
								num3 = 98;
								continue;
							case 161:
								array[12] = (byte)num5;
								num6 = 200;
								goto IL_0130;
							case 40:
								array[9] = (byte)num5;
								num3 = 117;
								if (WLA3tF7jv88kSHenRD() == null)
								{
									continue;
								}
								goto IL_0130;
							case 104:
								num5 = 9 + 43;
								num3 = 43;
								if (!WGQt7xqnx4Ap1DtZFO())
								{
									num3 = 35;
								}
								continue;
							case 168:
								num5 = 71 + 91;
								num3 = 84;
								if (WGQt7xqnx4Ap1DtZFO())
								{
									continue;
								}
								goto IL_0130;
							case 87:
								num5 = 133 - 44;
								num3 = 180;
								continue;
							case 163:
								array[3] = (byte)num4;
								num3 = 199;
								continue;
							case 136:
								break;
								IL_0130:
								num3 = num6;
								continue;
							}
							break;
						}
					}
					finally
					{
						if (binaryReader != null)
						{
							int num9 = 0;
							if (WLA3tF7jv88kSHenRD() == null)
							{
								num9 = 0;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									UFxHUCRNOHstvByZDZ(binaryReader);
									num9 = 1;
									if (WLA3tF7jv88kSHenRD() != null)
									{
										num9 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto default;
				case 2:
					if (RFNAdOMEXo.Length != 0)
					{
						num2 = 1;
						if (WGQt7xqnx4Ap1DtZFO())
						{
							continue;
						}
						break;
					}
					goto case 3;
				case 3:
					binaryReader = new BinaryReader((Stream)zpD83IXEgaEMWmYDOC(((Type)vL0vGinELGQMyjeJfF(IxINIFBBCPIJlgbAm0(typeof(cU7dMkjtXsyGty1iGUX).TypeHandle))).Assembly, "vfRB9mRnhub5PNrSjB.fq2DahF657vgaUrbK9"));
					num = 4;
					break;
				default:
					num10 = yUFlY4N0UI7yJCtclr(RFNAdOMEXo, P_0);
					num2 = 6;
					continue;
				case 5:
					return "";
				}
				break;
			}
		}
	}

	private cU7dMkjtXsyGty1iGUX(byte[] P_0, byte[] P_1)
	{
		iiZAPCBk6Q = P_0;
		xSxAqt8jYG = P_1;
	}

	private byte[] y9HuJK2X7V(byte[] P_0)
	{
		if (P_0.Length == 0)
		{
			return new byte[0];
		}
		int num = P_0.Length % 4;
		int num2 = P_0.Length / 4;
		byte[] array = new byte[P_0.Length];
		int num3 = iiZAPCBk6Q.Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((iiZAPCBk6Q[num7 + 3] << 24) | (iiZAPCBk6Q[num7 + 2] << 16) | (iiZAPCBk6Q[num7 + 1] << 8) | iiZAPCBk6Q[num7]);
			if (i == num2 - 1 && num > 0)
			{
				num6 = 0u;
				uint num10 = 255u;
				int num11 = 0;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= P_0[^(1 + j)];
				}
				num4 += num5;
				num4 += UdouhMNY6Y(num4);
				uint num12 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num12 & num10) >> num11);
				}
			}
			else
			{
				num7 = (uint)num9;
				num6 = (uint)((P_0[num7 + 3] << 24) | (P_0[num7 + 2] << 16) | (P_0[num7 + 1] << 8) | P_0[num7]);
				num4 += num5;
				num4 += UdouhMNY6Y(num4);
				uint num13 = num4 ^ num6;
				array[num9] = (byte)(num13 & 0xFF);
				array[num9 + 1] = (byte)((num13 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num13 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num13 & 0xFF000000u) >> 24);
			}
		}
		return array;
	}

	private uint UdouhMNY6Y(uint P_0)
	{
		uint num = P_0;
		uint num2 = 973202305u;
		uint num3 = 1582787682u;
		uint num4 = 1577548636u;
		uint num5 = 332884210u;
		ulong num6 = num4 * 1313243236;
		num6 |= 1;
		num3 = (uint)(num3 * num3 % num6);
		ulong num7 = 1907532890 * num4;
		if (num7 == 0L)
		{
			num7--;
		}
		_ = 698203908u % num7;
		num2 = (uint)(-502326134 - num3);
		ulong num8 = num3 * 183835789;
		num8 |= 1;
		num4 = (uint)(num4 * num4 % num8);
		uint num9 = ((num5 >> 6) | (num5 << 26)) ^ num3;
		uint num10 = num9 & 0xF0F0F0F;
		num5 = ((num9 & 0xF0F0F0F0u) >> 4) | (num10 << 4);
		num ^= num << 3;
		num += num2;
		num ^= num << 11;
		num += num4;
		num ^= num >> 27;
		num += num5;
		return (((num2 << 11) - num3) ^ num4) - num;
	}

	[emMDJKj8Px1F9y1nJDp(typeof(emMDJKj8Px1F9y1nJDp.jQlOmHjQ8ADGvMpjG6h<object>[]))]
	internal static string phouliyoX9(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[emMDJKj8Px1F9y1nJDp(typeof(emMDJKj8Px1F9y1nJDp.jQlOmHjQ8ADGvMpjG6h<object>[]))]
	private static byte[] WeHuUfY49p(byte[] P_0)
	{
		return new cU7dMkjtXsyGty1iGUX(new byte[32]
		{
			123, 5, 74, 12, 244, 156, 221, 154, 121, 221,
			183, 41, 121, 65, 9, 43, 67, 81, 23, 43,
			74, 63, 64, 23, 95, 185, 226, 244, 45, 194,
			211, 43
		}, new byte[16]
		{
			117, 254, 41, 121, 65, 52, 9, 43, 221, 154,
			12, 54, 68, 241, 68, 66
		}).y9HuJK2X7V(P_0);
	}

	private byte[] HafuLeUJKB()
	{
		return null;
	}

	private byte[] sUDu2FdrJH()
	{
		return null;
	}

	internal static Type IxINIFBBCPIJlgbAm0(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object vL0vGinELGQMyjeJfF(Type P_0)
	{
		return P_0.GetTypeInfo();
	}

	internal static object zpD83IXEgaEMWmYDOC(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object adJCDvVDCBUDLpPfie(object P_0)
	{
		return ((BinaryReader)P_0).BaseStream;
	}

	internal static void R2dt27kYqtP0QlQemN(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long xOyM2v8016I8a8CHag(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object TNGe2oL2FRODGELuCT(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void UFxHUCRNOHstvByZDZ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int yUFlY4N0UI7yJCtclr(object P_0, int P_1)
	{
		return BitConverter.ToInt32((byte[])P_0, P_1);
	}

	internal static void QoocVRv297GNNW6ywQ(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
		Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
	}

	internal static object Cre06YOaL1PC57HMMT()
	{
		return Encoding.Unicode;
	}

	internal static object IP3es1wvITC3SH1Dit(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
	}

	internal static bool WGQt7xqnx4Ap1DtZFO()
	{
		return null == null;
	}

	internal static object WLA3tF7jv88kSHenRD()
	{
		return null;
	}
}
