using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using G1GUeqNF9DiIFSfPRi;

namespace b0g062nTBvnZICggKs;

internal class Ybx8jijSnk3I55iKRF
{
	internal class C773OysFwdgaxaBTWd
	{
		private BinaryReader cfYBDJs4HE;

		public C773OysFwdgaxaBTWd(Stream P_0)
		{
			cfYBDJs4HE = new BinaryReader(P_0);
		}

		[SpecialName]
		internal Stream xbZZ0pH5U7()
		{
			return cfYBDJs4HE.BaseStream;
		}

		internal byte[] QmmB1EuLUq(int P_0)
		{
			return cfYBDJs4HE.ReadBytes(P_0);
		}

		internal int INQB8nkK5p(byte[] P_0, int P_1, int P_2)
		{
			return cfYBDJs4HE.Read(P_0, P_1, P_2);
		}

		internal int wR1BEJE81q()
		{
			return cfYBDJs4HE.ReadInt32();
		}

		internal void He6BY4BU93()
		{
			cfYBDJs4HE.Close();
		}
	}

	private delegate void F9P27RiGHJ699ESKQJ(object o);

	internal class jE35bvpJNtm8RETyKb
	{
		internal static string D4XB4xgyVw(string P_0, string P_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(P_0);
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = Axb2nZ50NC(Encoding.Unicode.GetBytes(P_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = qL72Zw4Cql();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	internal class eGeKW5vORmoBSsP1jJ : Attribute
	{
		internal class JGGRv8MRj693WAAauH<pO8O4EwsQYffoaBp7E>
		{
			public JGGRv8MRj693WAAauH()
			{
				uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
				base._002Ector();
			}
		}

		[eGeKW5vORmoBSsP1jJ(typeof(JGGRv8MRj693WAAauH<object>[]))]
		public eGeKW5vORmoBSsP1jJ(object P_0)
		{
		}
	}

	private static Assembly aabB5QRG0A;

	private byte[] GsVBBoQpWV;

	private static byte[] fM4B2MKrhe;

	private byte[] opqBULfSkO;

	private static byte[] VPcBlrev16;

	private static bool ceUBaXkM0E;

	private static Dictionary<int, int> FYiBtjTDcg;

	private static uint[] HlIBcXjB60;

	private static object KftBj2dipu;

	private static byte[] T0vBhVRtOc;

	private static bool mI0BPIBaNH;

	static Ybx8jijSnk3I55iKRF()
	{
		HlIBcXjB60 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		ceUBaXkM0E = false;
		mI0BPIBaNH = false;
		FYiBtjTDcg = null;
		KftBj2dipu = new object();
		aabB5QRG0A = Type.GetTypeFromHandle(MQXsldxQej7WGVBxqW.APkEVRHpdjSMK(33554731)).Assembly;
		VPcBlrev16 = new byte[0];
		T0vBhVRtOc = new byte[0];
		fM4B2MKrhe = new byte[0];
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	internal Ybx8jijSnk3I55iKRF()
	{
	}

	private void zPUEVRHHh80L7()
	{
	}

	internal static byte[] BR32QiFaqU(byte[] P_0)
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
			Lto2LDOrNJ(ref num6, num7, num8, num9, 0u, 7, 1u, array);
			Lto2LDOrNJ(ref num9, num6, num7, num8, 1u, 12, 2u, array);
			Lto2LDOrNJ(ref num8, num9, num6, num7, 2u, 17, 3u, array);
			Lto2LDOrNJ(ref num7, num8, num9, num6, 3u, 22, 4u, array);
			Lto2LDOrNJ(ref num6, num7, num8, num9, 4u, 7, 5u, array);
			Lto2LDOrNJ(ref num9, num6, num7, num8, 5u, 12, 6u, array);
			Lto2LDOrNJ(ref num8, num9, num6, num7, 6u, 17, 7u, array);
			Lto2LDOrNJ(ref num7, num8, num9, num6, 7u, 22, 8u, array);
			Lto2LDOrNJ(ref num6, num7, num8, num9, 8u, 7, 9u, array);
			Lto2LDOrNJ(ref num9, num6, num7, num8, 9u, 12, 10u, array);
			Lto2LDOrNJ(ref num8, num9, num6, num7, 10u, 17, 11u, array);
			Lto2LDOrNJ(ref num7, num8, num9, num6, 11u, 22, 12u, array);
			Lto2LDOrNJ(ref num6, num7, num8, num9, 12u, 7, 13u, array);
			Lto2LDOrNJ(ref num9, num6, num7, num8, 13u, 12, 14u, array);
			Lto2LDOrNJ(ref num8, num9, num6, num7, 14u, 17, 15u, array);
			Lto2LDOrNJ(ref num7, num8, num9, num6, 15u, 22, 16u, array);
			kv720VYWsG(ref num6, num7, num8, num9, 1u, 5, 17u, array);
			kv720VYWsG(ref num9, num6, num7, num8, 6u, 9, 18u, array);
			kv720VYWsG(ref num8, num9, num6, num7, 11u, 14, 19u, array);
			kv720VYWsG(ref num7, num8, num9, num6, 0u, 20, 20u, array);
			kv720VYWsG(ref num6, num7, num8, num9, 5u, 5, 21u, array);
			kv720VYWsG(ref num9, num6, num7, num8, 10u, 9, 22u, array);
			kv720VYWsG(ref num8, num9, num6, num7, 15u, 14, 23u, array);
			kv720VYWsG(ref num7, num8, num9, num6, 4u, 20, 24u, array);
			kv720VYWsG(ref num6, num7, num8, num9, 9u, 5, 25u, array);
			kv720VYWsG(ref num9, num6, num7, num8, 14u, 9, 26u, array);
			kv720VYWsG(ref num8, num9, num6, num7, 3u, 14, 27u, array);
			kv720VYWsG(ref num7, num8, num9, num6, 8u, 20, 28u, array);
			kv720VYWsG(ref num6, num7, num8, num9, 13u, 5, 29u, array);
			kv720VYWsG(ref num9, num6, num7, num8, 2u, 9, 30u, array);
			kv720VYWsG(ref num8, num9, num6, num7, 7u, 14, 31u, array);
			kv720VYWsG(ref num7, num8, num9, num6, 12u, 20, 32u, array);
			N8b2Tl6aC7(ref num6, num7, num8, num9, 5u, 4, 33u, array);
			N8b2Tl6aC7(ref num9, num6, num7, num8, 8u, 11, 34u, array);
			N8b2Tl6aC7(ref num8, num9, num6, num7, 11u, 16, 35u, array);
			N8b2Tl6aC7(ref num7, num8, num9, num6, 14u, 23, 36u, array);
			N8b2Tl6aC7(ref num6, num7, num8, num9, 1u, 4, 37u, array);
			N8b2Tl6aC7(ref num9, num6, num7, num8, 4u, 11, 38u, array);
			N8b2Tl6aC7(ref num8, num9, num6, num7, 7u, 16, 39u, array);
			N8b2Tl6aC7(ref num7, num8, num9, num6, 10u, 23, 40u, array);
			N8b2Tl6aC7(ref num6, num7, num8, num9, 13u, 4, 41u, array);
			N8b2Tl6aC7(ref num9, num6, num7, num8, 0u, 11, 42u, array);
			N8b2Tl6aC7(ref num8, num9, num6, num7, 3u, 16, 43u, array);
			N8b2Tl6aC7(ref num7, num8, num9, num6, 6u, 23, 44u, array);
			N8b2Tl6aC7(ref num6, num7, num8, num9, 9u, 4, 45u, array);
			N8b2Tl6aC7(ref num9, num6, num7, num8, 12u, 11, 46u, array);
			N8b2Tl6aC7(ref num8, num9, num6, num7, 15u, 16, 47u, array);
			N8b2Tl6aC7(ref num7, num8, num9, num6, 2u, 23, 48u, array);
			cCW26qmIvv(ref num6, num7, num8, num9, 0u, 6, 49u, array);
			cCW26qmIvv(ref num9, num6, num7, num8, 7u, 10, 50u, array);
			cCW26qmIvv(ref num8, num9, num6, num7, 14u, 15, 51u, array);
			cCW26qmIvv(ref num7, num8, num9, num6, 5u, 21, 52u, array);
			cCW26qmIvv(ref num6, num7, num8, num9, 12u, 6, 53u, array);
			cCW26qmIvv(ref num9, num6, num7, num8, 3u, 10, 54u, array);
			cCW26qmIvv(ref num8, num9, num6, num7, 10u, 15, 55u, array);
			cCW26qmIvv(ref num7, num8, num9, num6, 1u, 21, 56u, array);
			cCW26qmIvv(ref num6, num7, num8, num9, 8u, 6, 57u, array);
			cCW26qmIvv(ref num9, num6, num7, num8, 15u, 10, 58u, array);
			cCW26qmIvv(ref num8, num9, num6, num7, 6u, 15, 59u, array);
			cCW26qmIvv(ref num7, num8, num9, num6, 13u, 21, 60u, array);
			cCW26qmIvv(ref num6, num7, num8, num9, 4u, 6, 61u, array);
			cCW26qmIvv(ref num9, num6, num7, num8, 11u, 10, 62u, array);
			cCW26qmIvv(ref num8, num9, num6, num7, 2u, 15, 63u, array);
			cCW26qmIvv(ref num7, num8, num9, num6, 9u, 21, 64u, array);
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

	private static void Lto2LDOrNJ(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + FwB271T87F(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + HlIBcXjB60[P_6 - 1], P_5);
	}

	private static void kv720VYWsG(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + FwB271T87F(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + HlIBcXjB60[P_6 - 1], P_5);
	}

	private static void N8b2Tl6aC7(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + FwB271T87F(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + HlIBcXjB60[P_6 - 1], P_5);
	}

	private static void cCW26qmIvv(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
	{
		P_0 = P_1 + FwB271T87F(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + HlIBcXjB60[P_6 - 1], P_5);
	}

	private static uint FwB271T87F(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	internal static byte[] Axb2nZ50NC(byte[] P_0)
	{
		if (!sPw2Xc4wbT())
		{
			return new MD5CryptoServiceProvider().ComputeHash(P_0);
		}
		return BR32QiFaqU(P_0);
	}

	private static void vVp2ClSA6F()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	internal static bool sPw2Xc4wbT()
	{
		if (!ceUBaXkM0E)
		{
			oY22Gs50nu();
			ceUBaXkM0E = true;
		}
		return mI0BPIBaNH;
	}

	internal byte[] ahy2mh3DxS()
	{
		_ = "{11111-22222-50001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] qOo2w1uA0D()
	{
		_ = "{11111-22222-50001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	public static void Yew2MLZI2f(RuntimeTypeHandle P_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(P_0);
			if (FYiBtjTDcg == null)
			{
				lock (KftBj2dipu)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(MQXsldxQej7WGVBxqW.APkEVRHpdjSMK(33554731)).Assembly.GetManifestResourceStream("25hI24cSMAZZlpNS3K.y9XR070XmAljGHrTxr"));
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
						C773OysFwdgaxaBTWd c773OysFwdgaxaBTWd = new C773OysFwdgaxaBTWd(new MemoryStream(array));
						for (int l = 0; l < num23; l++)
						{
							int key = c773OysFwdgaxaBTWd.wR1BEJE81q();
							int value = c773OysFwdgaxaBTWd.wR1BEJE81q();
							dictionary.Add(key, value);
						}
						c773OysFwdgaxaBTWd.He6BY4BU93();
					}
					FYiBtjTDcg = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num24 = FYiBtjTDcg[metadataToken];
				bool flag = (num24 & 0x40000000) > 0;
				num24 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(MQXsldxQej7WGVBxqW.APkEVRHpdjSMK(33554731)).Module.ResolveMethod(num24, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(MQXsldxQej7WGVBxqW.APkEVRHpdjSMK(16777243));
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

	internal static void F2G2VZHHLn()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	private static int bjR2dRO8Xi()
	{
		return 5;
	}

	internal static void oY22Gs50nu()
	{
		try
		{
			mI0BPIBaNH = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static SymmetricAlgorithm qL72Zw4Cql()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (sPw2Xc4wbT())
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

	private byte[] npI2pSXKhG()
	{
		_ = "{11111-22222-20001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	private byte[] OvO29TFqN0()
	{
		_ = "{11111-22222-20001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal static bool Qjw2RM5R8m(int P_0)
	{
		if (T0vBhVRtOc.Length == 0)
		{
			C773OysFwdgaxaBTWd c773OysFwdgaxaBTWd = new C773OysFwdgaxaBTWd(aabB5QRG0A.GetManifestResourceStream("{11111-22222-20001-00000}"));
			c773OysFwdgaxaBTWd.xbZZ0pH5U7().Position = 0L;
			RSACryptoServiceProvider.UseMachineKeyStore = true;
			byte[] array = c773OysFwdgaxaBTWd.QmmB1EuLUq((int)c773OysFwdgaxaBTWd.xbZZ0pH5U7().Length);
			byte[] rgbKey = new Ybx8jijSnk3I55iKRF().OvO29TFqN0();
			byte[] array2 = new Ybx8jijSnk3I55iKRF().npI2pSXKhG();
			byte[] publicKeyToken = aabB5QRG0A.GetName().GetPublicKeyToken();
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
			SymmetricAlgorithm symmetricAlgorithm = qL72Zw4Cql();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, array2);
			Stream stream = ON02swDPII();
			CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			T0vBhVRtOc = pce2KvDtw0(stream);
			stream.Close();
			cryptoStream.Close();
			c773OysFwdgaxaBTWd.He6BY4BU93();
		}
		if (VPcBlrev16.Length == 0)
		{
			VPcBlrev16 = hBr2k3oCTS(LQZ2omOCY0(aabB5QRG0A).ToString());
		}
		int num = 0;
		try
		{
			num = BitConverter.ToInt32(new byte[4]
			{
				T0vBhVRtOc[P_0],
				T0vBhVRtOc[P_0 + 1],
				T0vBhVRtOc[P_0 + 2],
				T0vBhVRtOc[P_0 + 3]
			}, 0);
		}
		catch
		{
		}
		try
		{
			if (VPcBlrev16[num] == 128)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static Stream ON02swDPII()
	{
		return new MemoryStream();
	}

	private static byte[] hBr2k3oCTS(string P_0)
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

	internal static object LQZ2omOCY0(object P_0)
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

	private static byte[] pce2KvDtw0(Stream P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal byte[] HR02g06JfJ()
	{
		_ = "{11111-22222-30001-00001}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	internal byte[] qU72Wms33G()
	{
		_ = "{11111-22222-30001-00002}".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[eGeKW5vORmoBSsP1jJ(typeof(eGeKW5vORmoBSsP1jJ.JGGRv8MRj693WAAauH<object>[]))]
	internal static string zRc2f7gjGt(int P_0)
	{
		int num = 4;
		int num2 = num;
		int num11 = default(int);
		int num13 = default(int);
		string result = default(string);
		int num15 = default(int);
		BinaryReader binaryReader = default(BinaryReader);
		byte[] array = default(byte[]);
		int num6 = default(int);
		int num5 = default(int);
		byte[] array2 = default(byte[]);
		int num10 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					byte[] array6 = new byte[num11];
					int num12 = 0;
					if (!edmaAyyS6Ro0HjERai())
					{
						goto IL_005a;
					}
					goto IL_005e;
					IL_005a:
					num12 = num13;
					goto IL_005e;
					IL_005e:
					do
					{
						IL_005e_2:
						switch (num12)
						{
						default:
							fpO1UhNA15ThumSk7y(fM4B2MKrhe, P_0 + 4, array6, 0, num11);
							num12 = 2;
							goto IL_005e_2;
						case 2:
							break;
						case 1:
							return result;
						}
						result = (string)z4RvxmGLEFTXKQkTuY(p4SVX3VwxA1JbCbFJf(), array6, 0, array6.Length);
						num12 = 1;
					}
					while (edmaAyyS6Ro0HjERai());
					goto IL_005a;
				}
				catch
				{
					int num14 = 0;
					if (R7fE3pe3off0nALecR() != null)
					{
						num14 = num15;
					}
					switch (num14)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 2:
				try
				{
					SPdBDtsYi5pivsJAl9(O6JVuEAfM9nRuLTh4d(binaryReader), 0L);
					int num3 = 85;
					while (true)
					{
						IL_0121:
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 43:
								array[1] = (byte)num6;
								num4 = 96;
								continue;
							case 23:
								num5 = 235 - 78;
								num4 = 25;
								continue;
							case 102:
								num6 = 91 + 53;
								num4 = 68;
								continue;
							case 51:
								num6 = 85 + 18;
								num4 = 187;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 159:
								array[0] = (byte)num6;
								num4 = 12;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 15;
								}
								continue;
							case 204:
								array[8] = 150;
								num4 = 95;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 201:
								array[16] = (byte)num5;
								num3 = 50;
								break;
							case 106:
								array[17] = (byte)num5;
								num4 = 34;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 42:
								num5 = 63 + 93;
								num4 = 188;
								continue;
							case 89:
								num5 = 42 + 21;
								num4 = 156;
								continue;
							case 124:
								num6 = 143 - 47;
								num4 = 138;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 26:
								array[12] = (byte)num6;
								num4 = 33;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 177:
								array[25] = 38;
								num4 = 200;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 40:
								num5 = 0 + 1;
								num4 = 212;
								continue;
							case 170:
								array[4] = 170;
								num4 = 57;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 94:
								array[13] = 115;
								num4 = 71;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 37;
								}
								continue;
							case 5:
								array[7] = 56;
								num4 = 163;
								continue;
							case 53:
								num6 = 146 + 61;
								num4 = 133;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 211:
								array[21] = (byte)num5;
								num3 = 179;
								break;
							case 105:
								array[9] = (byte)num5;
								num4 = 102;
								continue;
							case 158:
								array[11] = (byte)num6;
								num4 = 88;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 207:
								array[2] = (byte)num5;
								num4 = 62;
								if (!edmaAyyS6Ro0HjERai())
								{
									num4 = 17;
								}
								continue;
							case 6:
								num5 = 121 + 37;
								num4 = 146;
								continue;
							case 13:
								array[11] = (byte)num6;
								num4 = 74;
								continue;
							case 59:
								array[28] = 195;
								num4 = 89;
								continue;
							case 210:
								array[18] = 81;
								num4 = 108;
								continue;
							case 72:
								array[13] = (byte)num6;
								num4 = 47;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 47;
								}
								continue;
							case 222:
								num5 = 17 + 4;
								num4 = 39;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 105;
								}
								continue;
							case 113:
								num5 = 251 - 83;
								num4 = 121;
								continue;
							case 62:
								num6 = 164 - 54;
								num4 = 147;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 101:
								num5 = 152 - 50;
								num4 = 39;
								continue;
							case 186:
								array[22] = 154;
								num4 = 55;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 78:
								array[27] = 80;
								num4 = 53;
								continue;
							case 99:
								array[26] = (byte)num6;
								num4 = 137;
								continue;
							case 198:
								num5 = 196 - 65;
								num3 = 27;
								break;
							case 138:
								array[15] = (byte)num6;
								num4 = 130;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 208:
								array[28] = 120;
								num3 = 59;
								break;
							case 196:
								array[23] = (byte)num5;
								num4 = 136;
								continue;
							case 123:
								num5 = 245 - 81;
								num4 = 46;
								continue;
							case 164:
								array[27] = (byte)num5;
								num4 = 155;
								continue;
							case 126:
								array[7] = 122;
								num4 = 5;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 202:
								num6 = 71 + 41;
								num4 = 141;
								continue;
							case 28:
								num6 = 138 - 63;
								num4 = 61;
								continue;
							case 185:
								array[29] = 96;
								num4 = 206;
								continue;
							case 166:
								num6 = 140 - 46;
								num4 = 151;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 36:
								array[4] = (byte)num6;
								num4 = 1;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 0;
								}
								continue;
							case 58:
								num5 = 166 - 55;
								num4 = 103;
								continue;
							case 139:
								array = new byte[32];
								num4 = 51;
								continue;
							case 86:
								num5 = 140 - 46;
								num4 = 207;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 155:
								array[27] = 124;
								num4 = 199;
								continue;
							case 147:
								array[2] = (byte)num6;
								num4 = 183;
								continue;
							case 168:
								array[9] = 134;
								num4 = 23;
								continue;
							case 109:
								array[4] = 118;
								num4 = 170;
								continue;
							case 192:
								array[18] = (byte)num6;
								num4 = 104;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 129:
								num5 = 166 - 62;
								num4 = 29;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 161;
								}
								continue;
							case 34:
								num6 = 117 + 61;
								num4 = 7;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 122;
								}
								continue;
							case 191:
								array[31] = 213;
								num4 = 152;
								continue;
							case 73:
								num5 = 178 - 59;
								num4 = 140;
								continue;
							case 76:
								array[14] = (byte)num6;
								num4 = 101;
								continue;
							case 82:
								array[10] = (byte)num5;
								num4 = 131;
								continue;
							case 110:
								array[19] = (byte)num5;
								num4 = 40;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 5;
								}
								continue;
							case 136:
								array[23] = 141;
								num4 = 35;
								continue;
							case 115:
								num5 = 11 + 0;
								num4 = 223;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 135:
								array[7] = 117;
								num4 = 126;
								continue;
							case 21:
								array[7] = 174;
								num4 = 135;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 112:
								array[20] = 166;
								num4 = 205;
								continue;
							case 144:
								array[30] = (byte)num5;
								num4 = 31;
								continue;
							case 200:
								num6 = 2 + 37;
								num4 = 118;
								continue;
							case 98:
								array[30] = (byte)num5;
								num4 = 171;
								continue;
							case 57:
								num6 = 141 + 53;
								num4 = 26;
								if (R7fE3pe3off0nALecR() == null)
								{
									num4 = 36;
								}
								continue;
							case 194:
								num6 = 46 + 50;
								num4 = 197;
								continue;
							case 91:
								num6 = 140 - 46;
								num4 = 63;
								continue;
							case 217:
								num6 = 183 + 17;
								num4 = 72;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 38:
								num5 = 114 - 13;
								num4 = 157;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 150;
								}
								continue;
							case 25:
								array[9] = (byte)num5;
								num4 = 222;
								continue;
							case 64:
								array[3] = 142;
								num4 = 214;
								continue;
							case 171:
								num5 = 110 + 3;
								num4 = 144;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 4;
								}
								continue;
							case 181:
								num6 = 9 + 13;
								num4 = 43;
								continue;
							case 111:
								num5 = 153 - 47;
								num3 = 213;
								break;
							case 121:
								array[24] = (byte)num5;
								num4 = 67;
								continue;
							case 80:
								array[23] = (byte)num6;
								num4 = 56;
								continue;
							case 107:
								array[10] = 130;
								num3 = 58;
								break;
							case 180:
								array[5] = 94;
								num4 = 174;
								if (R7fE3pe3off0nALecR() == null)
								{
									num4 = 189;
								}
								continue;
							default:
								num5 = 143 - 47;
								num4 = 91;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 154;
								}
								continue;
							case 215:
								num5 = 36 + 63;
								num4 = 125;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 119:
								num5 = 238 - 79;
								num4 = 201;
								continue;
							case 145:
								num5 = 158 - 52;
								num4 = 98;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 60:
								array[1] = 99;
								num4 = 181;
								continue;
							case 45:
								array[6] = (byte)num5;
								num4 = 116;
								continue;
							case 153:
								array[14] = (byte)num5;
								num4 = 81;
								continue;
							case 167:
								num5 = 117 + 118;
								num3 = 65;
								break;
							case 55:
								num5 = 110 + 84;
								num4 = 69;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 120:
								array[25] = 184;
								num4 = 177;
								continue;
							case 161:
								array[14] = (byte)num5;
								num4 = 148;
								continue;
							case 77:
								num6 = 161 - 53;
								num4 = 159;
								continue;
							case 137:
								array[26] = 111;
								num4 = 150;
								continue;
							case 70:
								num5 = 216 - 115;
								num3 = 149;
								break;
							case 160:
								num6 = 83 + 35;
								num4 = 63;
								if (R7fE3pe3off0nALecR() == null)
								{
									num4 = 66;
								}
								continue;
							case 7:
								num5 = 32 + 10;
								num4 = 203;
								continue;
							case 95:
								array[9] = 204;
								num4 = 168;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 25;
								}
								continue;
							case 165:
							{
								byte[] array3 = array;
								byte[] array4 = new byte[16]
								{
									103, 0, 0, 0, 0, 0, 0, 0, 0, 0,
									0, 0, 0, 0, 0, 0
								};
								int num7 = 34 + 0;
								array4[0] = (byte)num7;
								array4[0] = 99;
								num7 = 9 + 13;
								array4[0] = (byte)num7;
								int num8 = 164 - 54;
								array4[0] = (byte)num8;
								array4[0] = 157;
								array4[1] = 124;
								array4[1] = 126;
								array4[1] = 129;
								array4[1] = 115;
								array4[1] = 162;
								num8 = 104 + 45;
								array4[1] = (byte)num8;
								array4[2] = 114;
								num8 = 194 - 64;
								array4[2] = (byte)num8;
								array4[2] = 244;
								num8 = 163 - 54;
								array4[3] = (byte)num8;
								array4[3] = 164;
								num8 = 122 + 124;
								array4[3] = (byte)num8;
								num7 = 53 + 14;
								array4[3] = (byte)num7;
								num8 = 107 + 83;
								array4[3] = (byte)num8;
								array4[4] = 129;
								array4[4] = 98;
								num8 = 207 - 69;
								array4[4] = (byte)num8;
								array4[4] = 86;
								num7 = 120 - 10;
								array4[4] = (byte)num7;
								num8 = 42 + 72;
								array4[5] = (byte)num8;
								array4[5] = 115;
								array4[5] = 92;
								num7 = 218 - 117;
								array4[5] = (byte)num7;
								array4[6] = 14;
								num7 = 133 - 44;
								array4[6] = (byte)num7;
								array4[6] = 168;
								array4[6] = 136;
								num8 = 158 - 43;
								array4[6] = (byte)num8;
								array4[7] = 157;
								array4[7] = 133;
								num8 = 85 + 121;
								array4[7] = (byte)num8;
								num7 = 186 - 119;
								array4[7] = (byte)num7;
								num7 = 201 - 67;
								array4[8] = (byte)num7;
								num8 = 235 - 78;
								array4[8] = (byte)num8;
								array4[8] = 96;
								array4[8] = 128;
								num8 = 209 + 17;
								array4[8] = (byte)num8;
								array4[9] = 103;
								array4[9] = 76;
								array4[9] = 50;
								num8 = 166 - 55;
								array4[10] = (byte)num8;
								num7 = 32 + 12;
								array4[10] = (byte)num7;
								num7 = 95 + 106;
								array4[10] = (byte)num7;
								num7 = 140 - 71;
								array4[10] = (byte)num7;
								array4[11] = 86;
								array4[11] = 152;
								array4[11] = 96;
								num8 = 187 - 62;
								array4[11] = (byte)num8;
								array4[11] = 132;
								array4[11] = 231;
								array4[12] = 168;
								num7 = 133 - 44;
								array4[12] = (byte)num7;
								array4[12] = 228;
								num8 = 142 - 47;
								array4[12] = (byte)num8;
								array4[12] = 20;
								num8 = 218 - 72;
								array4[13] = (byte)num8;
								num8 = 219 - 73;
								array4[13] = (byte)num8;
								num7 = 143 - 47;
								array4[13] = (byte)num7;
								num8 = 200 - 66;
								array4[13] = (byte)num8;
								array4[13] = 145;
								array4[13] = 72;
								num8 = 184 - 61;
								array4[14] = (byte)num8;
								num8 = 80 + 41;
								array4[14] = (byte)num8;
								array4[14] = 97;
								num7 = 54 + 80;
								array4[14] = (byte)num7;
								array4[14] = 80;
								num7 = 46 + 77;
								array4[15] = (byte)num7;
								num7 = 237 - 79;
								array4[15] = (byte)num7;
								array4[15] = 155;
								array4[15] = 120;
								array4[15] = 165;
								byte[] array5 = array4;
								fM4B2MKrhe = new Ybx8jijSnk3I55iKRF(array3, array5).bIw2zD5oGX(array2);
								num4 = 218;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							}
							case 219:
								array[24] = (byte)num6;
								num4 = 38;
								if (!edmaAyyS6Ro0HjERai())
								{
									num4 = 5;
								}
								continue;
							case 128:
								array[12] = (byte)num6;
								num3 = 221;
								break;
							case 134:
								array[29] = (byte)num5;
								num4 = 87;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 209:
								num5 = 78 + 12;
								num4 = 164;
								continue;
							case 29:
								num5 = 149 - 49;
								num3 = 82;
								break;
							case 103:
								array[10] = (byte)num5;
								num4 = 1;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 32;
								}
								continue;
							case 61:
								array[23] = (byte)num6;
								num4 = 75;
								continue;
							case 9:
								array[19] = 172;
								num4 = 48;
								if (!edmaAyyS6Ro0HjERai())
								{
									num4 = 10;
								}
								continue;
							case 132:
								array[22] = 137;
								num4 = 175;
								continue;
							case 68:
								array[9] = (byte)num6;
								num4 = 29;
								continue;
							case 2:
								array[18] = (byte)num5;
								num4 = 70;
								continue;
							case 133:
								array[27] = (byte)num6;
								num4 = 208;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 31:
								array[30] = 63;
								num4 = 96;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 191;
								}
								continue;
							case 19:
								array[22] = (byte)num6;
								num4 = 30;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 18;
								}
								continue;
							case 10:
								array[6] = 166;
								num4 = 97;
								continue;
							case 37:
								array[6] = (byte)num5;
								num4 = 172;
								continue;
							case 152:
								array[31] = 154;
								num3 = 8;
								break;
							case 114:
								array[31] = (byte)num5;
								num4 = 111;
								continue;
							case 56:
								array[23] = 155;
								num4 = 28;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 23;
								}
								continue;
							case 175:
								num6 = 172 - 57;
								num3 = 19;
								break;
							case 49:
								array[15] = (byte)num6;
								num4 = 142;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 3:
								array[27] = (byte)num5;
								num4 = 78;
								continue;
							case 14:
								array[15] = (byte)num6;
								num4 = 119;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 119;
								}
								continue;
							case 150:
								array[26] = 45;
								num4 = 209;
								continue;
							case 108:
								num6 = 48 + 71;
								num4 = 192;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 220:
								array[16] = 62;
								num4 = 6;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 18:
								array[11] = 224;
								num4 = 194;
								if (!edmaAyyS6Ro0HjERai())
								{
									num4 = 100;
								}
								continue;
							case 142:
								num6 = 66 + 124;
								num4 = 14;
								continue;
							case 33:
								num6 = 39 + 122;
								num3 = 128;
								break;
							case 156:
								array[28] = (byte)num5;
								num3 = 16;
								break;
							case 12:
								num6 = 123 + 108;
								num4 = 49;
								continue;
							case 223:
								array[2] = (byte)num5;
								num4 = 86;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 4:
								array[14] = (byte)num6;
								num4 = 44;
								continue;
							case 97:
								array[6] = 240;
								num4 = 92;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 16:
								array[28] = 112;
								num4 = 54;
								continue;
							case 17:
								array[4] = (byte)num5;
								num3 = 215;
								break;
							case 87:
								num5 = 37 + 117;
								num4 = 93;
								continue;
							case 93:
								array[30] = (byte)num5;
								num4 = 128;
								if (R7fE3pe3off0nALecR() == null)
								{
									num4 = 145;
								}
								continue;
							case 163:
								array[8] = 157;
								num4 = 104;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 202;
								}
								continue;
							case 212:
								array[19] = (byte)num5;
								num4 = 100;
								if (!edmaAyyS6Ro0HjERai())
								{
									num4 = 29;
								}
								continue;
							case 214:
								array[3] = 182;
								num4 = 22;
								continue;
							case 35:
								num6 = 148 - 49;
								num4 = 80;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 176:
								array[16] = (byte)num5;
								num4 = 220;
								continue;
							case 216:
								num5 = 138 - 46;
								num4 = 12;
								if (R7fE3pe3off0nALecR() == null)
								{
									num4 = 106;
								}
								continue;
							case 104:
								num5 = 54 + 81;
								num4 = 2;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 151:
								array[17] = (byte)num6;
								num4 = 182;
								if (R7fE3pe3off0nALecR() == null)
								{
									num4 = 216;
								}
								continue;
							case 183:
								array[2] = 249;
								num4 = 47;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 64;
								}
								continue;
							case 157:
								array[24] = (byte)num5;
								num3 = 52;
								break;
							case 48:
								num5 = 214 - 71;
								num4 = 110;
								if (!edmaAyyS6Ro0HjERai())
								{
									num4 = 31;
								}
								continue;
							case 44:
								num6 = 134 - 44;
								num4 = 76;
								continue;
							case 32:
								array[10] = 106;
								num4 = 167;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 173:
								num5 = 66 + 1;
								num4 = 17;
								continue;
							case 100:
								array[19] = 153;
								num4 = 112;
								continue;
							case 90:
								num6 = 197 - 65;
								num4 = 28;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 99;
								}
								continue;
							case 197:
								array[12] = (byte)num6;
								num4 = 182;
								continue;
							case 149:
								array[18] = (byte)num5;
								num4 = 160;
								continue;
							case 127:
								array[29] = 149;
								num4 = 91;
								continue;
							case 88:
								num6 = 220 - 73;
								num4 = 9;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 13;
								}
								continue;
							case 174:
								array[14] = 112;
								num4 = 129;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 30:
								array[22] = 113;
								num4 = 186;
								continue;
							case 39:
								array[14] = (byte)num5;
								num4 = 174;
								continue;
							case 184:
								num6 = 172 - 57;
								num4 = 190;
								continue;
							case 205:
								array[20] = 161;
								num4 = 41;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 79:
								array[3] = 54;
								num4 = 173;
								continue;
							case 213:
								array[31] = (byte)num5;
								num4 = 165;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 169:
								array[21] = 173;
								num4 = 7;
								continue;
							case 27:
								array[5] = (byte)num5;
								num4 = 73;
								continue;
							case 154:
								array[21] = (byte)num5;
								num4 = 20;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 63:
								array[29] = (byte)num6;
								num4 = 69;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 185;
								}
								continue;
							case 92:
								num5 = 12 + 2;
								num4 = 45;
								continue;
							case 75:
								array[24] = 172;
								num4 = 113;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 46:
								array[29] = (byte)num5;
								num4 = 127;
								continue;
							case 8:
								array[31] = 103;
								num4 = 162;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 117:
								array[11] = (byte)num5;
								num4 = 18;
								continue;
							case 130:
								array[15] = 116;
								num4 = 12;
								continue;
							case 65:
								array[10] = (byte)num5;
								num4 = 84;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 22:
								array[3] = 55;
								num4 = 79;
								continue;
							case 69:
								array[22] = (byte)num5;
								num4 = 24;
								if (!edmaAyyS6Ro0HjERai())
								{
									num4 = 4;
								}
								continue;
							case 148:
								array[15] = 122;
								num4 = 124;
								continue;
							case 50:
								num5 = 197 - 65;
								num4 = 176;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 24:
								num5 = 151 - 50;
								num4 = 196;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 143:
								array[6] = (byte)num5;
								num4 = 4;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 10;
								}
								continue;
							case 162:
								num5 = 193 - 64;
								num4 = 114;
								continue;
							case 81:
								num6 = 109 + 36;
								num4 = 4;
								continue;
							case 66:
								array[19] = (byte)num6;
								num3 = 9;
								break;
							case 199:
								num5 = 194 - 64;
								num4 = 3;
								continue;
							case 190:
								array[25] = (byte)num6;
								num4 = 120;
								continue;
							case 67:
								num6 = 56 + 107;
								num4 = 37;
								if (R7fE3pe3off0nALecR() == null)
								{
									num4 = 219;
								}
								continue;
							case 195:
								num5 = 108 + 10;
								num4 = 37;
								continue;
							case 206:
								num5 = 123 + 110;
								num4 = 76;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 134;
								}
								continue;
							case 11:
								num6 = 69 + 68;
								num4 = 26;
								if (!edmaAyyS6Ro0HjERai())
								{
									num4 = 11;
								}
								continue;
							case 54:
								array[28] = 6;
								num4 = 123;
								continue;
							case 20:
								num5 = 1 + 64;
								num4 = 43;
								if (edmaAyyS6Ro0HjERai())
								{
									num4 = 211;
								}
								continue;
							case 146:
								array[17] = (byte)num5;
								num4 = 166;
								continue;
							case 182:
								array[12] = 125;
								num4 = 9;
								if (R7fE3pe3off0nALecR() == null)
								{
									num4 = 11;
								}
								continue;
							case 188:
								array[21] = (byte)num5;
								num4 = 0;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 74:
								num5 = 28 + 79;
								num4 = 117;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 52;
								}
								continue;
							case 118:
								array[26] = (byte)num6;
								num4 = 90;
								continue;
							case 203:
								array[21] = (byte)num5;
								num3 = 42;
								break;
							case 83:
								array[13] = 116;
								num4 = 217;
								continue;
							case 71:
								array[13] = 20;
								num4 = 83;
								continue;
							case 85:
								array2 = (byte[])tOLrrowDoUYl0S3OV5(binaryReader, (int)mBbW0YL5RuXkggM3v8(O6JVuEAfM9nRuLTh4d(binaryReader)));
								num4 = 139;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 96;
								}
								continue;
							case 178:
								array[21] = (byte)num5;
								num4 = 132;
								if (R7fE3pe3off0nALecR() == null)
								{
									continue;
								}
								break;
							case 193:
								array[5] = (byte)num6;
								num4 = 195;
								continue;
							case 1:
								array[5] = 106;
								num4 = 198;
								continue;
							case 140:
								array[5] = (byte)num5;
								num4 = 43;
								if (R7fE3pe3off0nALecR() == null)
								{
									num4 = 180;
								}
								continue;
							case 84:
								num6 = 106 + 73;
								num4 = 158;
								if (R7fE3pe3off0nALecR() != null)
								{
									num4 = 101;
								}
								continue;
							case 52:
								array[25] = 107;
								num4 = 184;
								continue;
							case 189:
								num6 = 104 - 20;
								num4 = 193;
								continue;
							case 179:
								num5 = 74 + 114;
								num4 = 178;
								if (!edmaAyyS6Ro0HjERai())
								{
									num4 = 3;
								}
								continue;
							case 187:
								array[0] = (byte)num6;
								num3 = 77;
								break;
							case 47:
								num5 = 200 - 66;
								num4 = 153;
								continue;
							case 116:
								array[6] = 99;
								num4 = 21;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 221:
								array[13] = 49;
								num4 = 94;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 122:
								array[17] = (byte)num6;
								num4 = 210;
								continue;
							case 15:
								array[0] = 146;
								num3 = 60;
								break;
							case 172:
								num5 = 42 + 72;
								num4 = 143;
								continue;
							case 141:
								array[8] = (byte)num6;
								num4 = 48;
								if (R7fE3pe3off0nALecR() == null)
								{
									num4 = 204;
								}
								continue;
							case 96:
								array[1] = 188;
								num4 = 115;
								if (edmaAyyS6Ro0HjERai())
								{
									continue;
								}
								break;
							case 125:
								array[4] = (byte)num5;
								num4 = 109;
								continue;
							case 131:
								array[10] = 89;
								num4 = 107;
								continue;
							case 41:
								array[20] = 147;
								num4 = 169;
								continue;
							case 218:
								goto end_IL_0125;
							}
							goto IL_0121;
							continue;
							end_IL_0125:
							break;
						}
						break;
					}
				}
				finally
				{
					int num9;
					if (binaryReader == null)
					{
						num9 = 1;
						if (!edmaAyyS6Ro0HjERai())
						{
							num9 = num10;
						}
						goto IL_28b2;
					}
					goto IL_28e2;
					IL_28b2:
					switch (num9)
					{
					case 1:
						goto end_IL_2892;
					case 2:
						goto end_IL_2892;
					}
					goto IL_28e2;
					IL_28e2:
					ewcWXLFarc1ZR4ghLE(binaryReader);
					num9 = 2;
					if (!edmaAyyS6Ro0HjERai())
					{
						num9 = 0;
					}
					goto IL_28b2;
					end_IL_2892:;
				}
				break;
			case 3:
				binaryReader = new BinaryReader((Stream)rkZyLAQITNlnL1f3DM(((Type)LyVxfm6hbs2PYSopS6(gHVcVbIC2XoBAojUfY(typeof(Ybx8jijSnk3I55iKRF).TypeHandle))).Assembly, "6rGYlkPQYdr65Za59f.ZQlJyaECxVdx7PGPhJ"));
				num2 = 2;
				continue;
			case 4:
				if (fM4B2MKrhe.Length == 0)
				{
					num2 = 3;
					continue;
				}
				break;
			default:
				return "";
			case 5:
				break;
			}
			num11 = QPR35NHLgOHhKTcrPY(fM4B2MKrhe, P_0);
			num2 = 0;
			if (R7fE3pe3off0nALecR() == null)
			{
				num2 = 1;
			}
		}
	}

	private Ybx8jijSnk3I55iKRF(byte[] P_0, byte[] P_1)
	{
		GsVBBoQpWV = P_0;
		opqBULfSkO = P_1;
	}

	private byte[] bIw2zD5oGX(byte[] P_0)
	{
		if (P_0.Length == 0)
		{
			return new byte[0];
		}
		int num = P_0.Length % 4;
		int num2 = P_0.Length / 4;
		byte[] array = new byte[P_0.Length];
		int num3 = GsVBBoQpWV.Length / 4;
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
			num5 = (uint)((GsVBBoQpWV[num7 + 3] << 24) | (GsVBBoQpWV[num7 + 2] << 16) | (GsVBBoQpWV[num7 + 1] << 8) | GsVBBoQpWV[num7]);
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
				num4 += EgNBN5fHVT(num4);
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
				num4 += EgNBN5fHVT(num4);
				uint num13 = num4 ^ num6;
				array[num9] = (byte)(num13 & 0xFF);
				array[num9 + 1] = (byte)((num13 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num13 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num13 & 0xFF000000u) >> 24);
			}
		}
		return array;
	}

	private uint EgNBN5fHVT(uint P_0)
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

	[eGeKW5vORmoBSsP1jJ(typeof(eGeKW5vORmoBSsP1jJ.JGGRv8MRj693WAAauH<object>[]))]
	internal static string fH8BI8UsWU(string P_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[eGeKW5vORmoBSsP1jJ(typeof(eGeKW5vORmoBSsP1jJ.JGGRv8MRj693WAAauH<object>[]))]
	private static byte[] LBDB33eCjg(byte[] P_0)
	{
		return new Ybx8jijSnk3I55iKRF(new byte[32]
		{
			123, 5, 74, 12, 244, 156, 221, 154, 121, 221,
			183, 41, 121, 65, 9, 43, 67, 81, 23, 43,
			74, 63, 64, 23, 95, 185, 226, 244, 45, 194,
			211, 43
		}, new byte[16]
		{
			117, 254, 41, 121, 65, 52, 9, 43, 221, 154,
			12, 54, 68, 241, 68, 66
		}).bIw2zD5oGX(P_0);
	}

	private byte[] WvqByPMkH6()
	{
		return null;
	}

	private byte[] zLBBFFvlL0()
	{
		return null;
	}

	internal static Type gHVcVbIC2XoBAojUfY(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object LyVxfm6hbs2PYSopS6(Type P_0)
	{
		return P_0.GetTypeInfo();
	}

	internal static object rkZyLAQITNlnL1f3DM(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	internal static object O6JVuEAfM9nRuLTh4d(object P_0)
	{
		return ((BinaryReader)P_0).BaseStream;
	}

	internal static void SPdBDtsYi5pivsJAl9(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	internal static long mBbW0YL5RuXkggM3v8(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object tOLrrowDoUYl0S3OV5(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void ewcWXLFarc1ZR4ghLE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int QPR35NHLgOHhKTcrPY(object P_0, int P_1)
	{
		return BitConverter.ToInt32((byte[])P_0, P_1);
	}

	internal static void fpO1UhNA15ThumSk7y(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
		Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
	}

	internal static object p4SVX3VwxA1JbCbFJf()
	{
		return Encoding.Unicode;
	}

	internal static object z4RvxmGLEFTXKQkTuY(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Encoding)P_0).GetString((byte[])P_1, P_2, P_3);
	}

	internal static bool edmaAyyS6Ro0HjERai()
	{
		return null == null;
	}

	internal static object R7fE3pe3off0nALecR()
	{
		return null;
	}
}
