using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindRect
{
	public class Tools
	{
		public static int IntRange(int value, int minval, int maxval)
		{
			if (value < minval)
				return minval;

			if (maxval < value)
				return maxval;

			return value;
		}

		public static int ParseInt(string str, int minval, int maxval, int defval)
		{
			try
			{
				return Tools.IntRange(int.Parse(str), minval, maxval);
			}
			catch
			{
				return defval;
			}
		}

		public static string ToHexToken(byte[] block)
		{
			StringBuilder sb = new StringBuilder();

			foreach (byte chr in block)
			{
				sb.Append(chr.ToString("x2"));
			}
			return "{" + sb + "}";
		}

		public static string EraseDq(string str)
		{
			while (str.StartsWith("\""))
				str = str.Substring(1);

			while (str.EndsWith("\""))
				str = str.Substring(0, str.Length - 1);

			return str;
		}

		public static string FontFilter(string font)
		{
			try
			{
				if (font == "")
					throw null;

				string tmp = new Font(font, 10, FontStyle.Regular).Name;

				if (font != tmp)
					throw null;
			}
			catch
			{
				font = Gnd.I.DEF_FONT;
			}
			return font;
		}
	}
}
