using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindRect
{
	public struct I4Rect
	{
		public int L;
		public int T;
		public int W;
		public int H;

		public int R
		{
			get
			{
				return this.L + this.W;
			}
		}

		public int B
		{
			get
			{
				return this.T + this.H;
			}
		}
	}
}
