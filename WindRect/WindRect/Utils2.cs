using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ^ sync @ Utils2

namespace WindRect
{
	// sync > @ Utils2

	public static class Utils2
	{
		public static string Escape(string str)
		{
			StringBuilder buff = new StringBuilder();

			foreach (char chr in str)
			{
				if (chr <= 0x1f || chr == '$' || (0x7f <= chr && chr <= 0xff))
				{
					buff.Append('$');
					buff.Append(((int)chr).ToString("x2"));
				}
				else
					buff.Append(chr);
			}
			return buff.ToString();
		}

		public static string Unescape(string str)
		{
			StringBuilder buff = new StringBuilder();

			for (int index = 0; index < str.Length; index++)
			{
				if (str[index] == '$')
				{
					buff.Append((char)Convert.ToInt32(str.Substring(index + 1, 2), 16));
					index += 2;
				}
				else
					buff.Append(str[index]);
			}
			return buff.ToString();
		}
	}

	// < sync
}
