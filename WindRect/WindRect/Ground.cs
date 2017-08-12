using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace WindRect
{
	public class Gnd
	{
		private Gnd()
		{ }

		public static Gnd I = new Gnd();

		public readonly string DATA_FILE = "WindRect.dat";

		public readonly int RI_MINPOS = -99999;
		public readonly int RI_MAXPOS = 99999;

		public enum TextAlign_e
		{
			LEFT,
			CENTER,
			RIGHT,
		}

		public readonly string ESC_NEW_LINE = "${NEW-LINE}";
		public readonly string RECT_ENDER = "/RECT/e";
		public readonly string DEF_FONT = "メイリオ";

		// Common {
		public bool RightClickOff = false;
		public bool AutoReupdateUi = false; // 隠し設定
		// }

		public class RectInfo
		{
			public int XPos;
			public int YPos;
			public int WinW;
			public int WinH;
			public int WinColorR;
			public int WinColorG;
			public int WinColorB;
			public bool MostTop;
			public bool MovableFlag;
			public string ImageFile;
			public bool ImageStretchFlag;
			public string Text;
			public TextAlign_e TextAlign;
			public string TextFont;
			public int TextSize;
			public int TextColorR;
			public int TextColorG;
			public int TextColorB;

			// RectInfo.*

			public RectWin Win = null;

			public RectInfo()
			{
				this.ClearDefault();
			}

			public void ClearDefault()
			{
				this.XPos = 0;
				this.YPos = 0;
				this.WinW = 300;
				this.WinH = 300;
				this.WinColorR = 0;
				this.WinColorG = 0;
				this.WinColorB = 0;
				this.MostTop = true;
				this.MovableFlag = true;
				this.ImageFile = "";
				this.ImageStretchFlag = false;
				this.Text = "";
				this.TextAlign = TextAlign_e.LEFT;
				this.TextFont = Gnd.I.DEF_FONT;
				this.TextSize = 10;
				this.TextColorR = 255;
				this.TextColorG = 255;
				this.TextColorB = 255;

				// RectInfo.*
			}

			public RectInfo GetClone()
			{
				RectInfo dest = new RectInfo();

				dest.XPos = this.XPos;
				dest.YPos = this.YPos;
				dest.WinW = this.WinW;
				dest.WinH = this.WinH;
				dest.WinColorR = this.WinColorR;
				dest.WinColorG = this.WinColorG;
				dest.WinColorB = this.WinColorB;
				dest.MostTop = this.MostTop;
				dest.MovableFlag = this.MovableFlag;
				dest.ImageFile = this.ImageFile;
				dest.ImageStretchFlag = this.ImageStretchFlag;
				dest.Text = this.Text;
				dest.TextAlign = this.TextAlign;
				dest.TextFont = this.TextFont;
				dest.TextSize = this.TextSize;
				dest.TextColorR = this.TextColorR;
				dest.TextColorG = this.TextColorG;
				dest.TextColorB = this.TextColorB;

				// RectInfo.*

				return dest;
			}
		};

		public List<RectInfo> RectInfoList = new List<RectInfo>();

		public void LoadData()
		{
			this.RectInfoList.Clear();

			try
			{
				string[] lines = File.ReadAllLines(this.DATA_FILE, Encoding.GetEncoding(932));
				int i = 0;

				// Common {
				this.RightClickOff = Tools.ParseInt(lines[i++], 0, 1, 0) == 1;
				this.AutoReupdateUi = Tools.ParseInt(lines[i++], 0, 1, 0) == 1;
				// }

				while (i < lines.Length)
				{
					RectInfo ri = new RectInfo();

					ri.XPos = Tools.ParseInt(lines[i++], this.RI_MINPOS, this.RI_MAXPOS, 0);
					ri.YPos = Tools.ParseInt(lines[i++], this.RI_MINPOS, this.RI_MAXPOS, 0);
					ri.WinW = Tools.ParseInt(lines[i++], 1, this.RI_MAXPOS, 300);
					ri.WinH = Tools.ParseInt(lines[i++], 1, this.RI_MAXPOS, 300);
					ri.WinColorR = Tools.ParseInt(lines[i++], 0, 255, 0);
					ri.WinColorG = Tools.ParseInt(lines[i++], 0, 255, 0);
					ri.WinColorB = Tools.ParseInt(lines[i++], 0, 255, 0);
					ri.MostTop = Tools.ParseInt(lines[i++], 0, 1, 0) == 1;
					ri.MovableFlag = Tools.ParseInt(lines[i++], 0, 1, 0) == 1;
					ri.ImageFile = Tools.EraseDq(lines[i++]);
					ri.ImageStretchFlag = Tools.ParseInt(lines[i++], 0, 1, 0) == 1;
					ri.Text = Tools.EraseDq(lines[i++]);
					ri.TextAlign = (TextAlign_e)int.Parse(lines[i++]);
					ri.TextFont = Tools.FontFilter(lines[i++]);
					ri.TextSize = Tools.ParseInt(lines[i++], 1, 300, 10);
					ri.TextColorR = Tools.ParseInt(lines[i++], 0, 255, 0);
					ri.TextColorG = Tools.ParseInt(lines[i++], 0, 255, 0);
					ri.TextColorB = Tools.ParseInt(lines[i++], 0, 255, 0);

					// RectInfo.*

					if (lines[i++] != Gnd.I.RECT_ENDER)
						throw null;

					this.RectInfoList.Add(ri);
				}
			}
			catch
			{
				//this.RectInfoList.Clear();
			}
		}

		public void SaveData()
		{
			try
			{
				//System.Windows.Forms.MessageBox.Show("Saved"); // test

				List<string> lines = new List<string>();

				// Common {
				lines.Add("" + (this.RightClickOff ? 1 : 0));
				lines.Add("" + (this.AutoReupdateUi ? 1 : 0));
				// }

				foreach (RectInfo ri in this.RectInfoList)
				{
					lines.Add("" + ri.XPos);
					lines.Add("" + ri.YPos);
					lines.Add("" + ri.WinW);
					lines.Add("" + ri.WinH);
					lines.Add("" + ri.WinColorR);
					lines.Add("" + ri.WinColorG);
					lines.Add("" + ri.WinColorB);
					lines.Add("" + (ri.MostTop ? 1 : 0));
					lines.Add("" + (ri.MovableFlag ? 1 : 0));
					lines.Add("\"" + ri.ImageFile + "\"");
					lines.Add("" + (ri.ImageStretchFlag ? 1 : 0));
					lines.Add("\"" + ri.Text + "\"");
					lines.Add("" + (int)ri.TextAlign);
					lines.Add("" + ri.TextFont);
					lines.Add("" + ri.TextSize);
					lines.Add("" + ri.TextColorR);
					lines.Add("" + ri.TextColorG);
					lines.Add("" + ri.TextColorB);

					// RectInfo.*

					lines.Add(Gnd.I.RECT_ENDER);
				}

				File.WriteAllLines(this.DATA_FILE, lines, Encoding.GetEncoding(932));
			}
			catch
			{ }
		}

		public void Remove(RectInfo ri)
		{
			this.RectInfoList.Remove(ri);
		}

		public MainWin MainWin = null;

		public void TryClose()
		{
			if (this.MainWin != null)
			{
				this.MainWin.Close();
				this.MainWin = null;
			}
		}

		public bool AdjustToTextSize = false; // 一時的なフラグ
	}
}
