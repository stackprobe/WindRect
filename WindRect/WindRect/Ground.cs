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

		public readonly string RECT_STARTER = "/WIND-RECT/s";
		public readonly string RECT_ENDER = "/WIND-RECT/e";
		public readonly string DEF_FONT = "メイリオ";

		// CommonSetting {

		public bool RightClickOff = false;
		public bool DoubleClickOff = false;
		public bool TaskIconDoubleClickAndAddRect = false;
		public bool Reserved_0001 = false; // 使っていない。

		// }

		// CommonSetting_2 {

		public int BootDelaySecond = 0;
		public bool TaskIconClickAndShowAllRectOff = false;
		public bool QuickEditTextFocusOutEditEnd = false;

		// }

		public RectInfo DefRect = null; // null == 無効

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
			public int 透明度Pct;

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
				this.WinColorB = 48;
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
				this.透明度Pct = 0;

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
				dest.透明度Pct = this.透明度Pct;

				// RectInfo.*

				return dest;
			}
		};

		public List<RectInfo> RectInfoList = new List<RectInfo>();

		public void LoadData()
		{
			this.RectInfoList.Clear();
			this.DefRect = null;

			try
			{
				string[] lines = File.ReadAllLines(this.DATA_FILE, Encoding.GetEncoding(932));
				int i = 0;

				// CommonSetting {

				this.RightClickOff = Tools.ParseInt(lines[i++], 0, 1, 0) == 1;
				this.DoubleClickOff = Tools.ParseInt(lines[i++], 0, 1, 0) == 1;
				this.TaskIconDoubleClickAndAddRect = Tools.ParseInt(lines[i++], 0, 1, 0) == 1;
				this.Reserved_0001 = Tools.ParseInt(lines[i++], 0, 1, 0) == 1;

				// }

				while (i < lines.Length)
				{
					if (lines[i++] != Gnd.I.RECT_STARTER)
						break;

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
					ri.透明度Pct = Tools.ParseInt(lines[i++], 0, 95, 0);

					// RectInfo.*

					this.RectInfoList.Add(ri);
				}
				if (Tools.ParseInt(lines[i++], 0, 1, 0) == 1)
				{
					int li = this.RectInfoList.Count - 1;

					this.DefRect = this.RectInfoList[li];
					this.RectInfoList.RemoveAt(li);
				}

				// CommonSetting_2 {

				this.BootDelaySecond = Tools.ParseInt(lines[i++], 0, 600, 0);
				this.TaskIconClickAndShowAllRectOff = Tools.ParseInt(lines[i++], 0, 1, 0) == 1;
				this.QuickEditTextFocusOutEditEnd = Tools.ParseInt(lines[i++], 0, 1, 0) == 1;

				// }
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

				// CommonSetting {

				lines.Add("" + (this.RightClickOff ? 1 : 0));
				lines.Add("" + (this.DoubleClickOff ? 1 : 0));
				lines.Add("" + (this.TaskIconDoubleClickAndAddRect ? 1 : 0));
				lines.Add("" + (this.Reserved_0001 ? 1 : 0));

				// }

				bool dre = this.DefRect != null;

				if (dre)
					this.RectInfoList.Add(this.DefRect);

				foreach (RectInfo ri in this.RectInfoList)
				{
					lines.Add(Gnd.I.RECT_STARTER);

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
					lines.Add("" + ri.透明度Pct);

					// RectInfo.*
				}
				lines.Add(Gnd.I.RECT_ENDER);

				if (dre)
				{
					lines.Add("" + 1);
					this.RectInfoList.RemoveAt(this.RectInfoList.Count - 1);
				}
				else
					lines.Add("" + 0);

				// CommonSetting_2 {

				lines.Add("" + this.BootDelaySecond);
				lines.Add("" + (this.TaskIconClickAndShowAllRectOff ? 1 : 0));
				lines.Add("" + (this.QuickEditTextFocusOutEditEnd ? 1 : 0));

				// }

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
