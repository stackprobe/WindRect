using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WindRect
{
	public partial class PosColorWin : Form
	{
		private Gnd.RectInfo RI;
		private string ImageFile;

		public PosColorWin(Gnd.RectInfo ri)
		{
			this.RI = ri;

			InitializeComponent();

			this.LoadData();
		}

		private void PosColorWin_Load(object sender, EventArgs e)
		{
			// noop
		}

		private void PosColorWin_Shown(object sender, EventArgs e)
		{
			Tools.PostShown(this);
		}

		private void PosWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.SaveData();
			Gnd.I.SaveData();
		}

		private void LoadData()
		{
			this.XPos.Text = "" + this.RI.XPos;
			this.YPos.Text = "" + this.RI.YPos;
			this.WinW.Text = "" + this.RI.WinW;
			this.WinH.Text = "" + this.RI.WinH;
			this.WinColorR.Text = "" + this.RI.WinColorR;
			this.WinColorG.Text = "" + this.RI.WinColorG;
			this.WinColorB.Text = "" + this.RI.WinColorB;
			this.ImageFile = this.RI.ImageFile;
			this._タイリングChk.Checked = this.RI.ImageStretchFlag == false;
			this._透明度Pct.Value = this.RI.透明度Pct;

			this.UpdateUi();
		}

		private void UpdateUi()
		{
			this.ImageBtn.Text = this.ImageFile == "" ? "画像なし" : this.GetBtnNameByImageFile(this.ImageFile);
			this._画像サイズBtn.Enabled = this.ImageFile != "";
		}

		private string GetBtnNameByImageFile(string file)
		{
			string name = Path.GetFileName(file);
			const int LENMAX = 40;

			if (LENMAX < name.Length)
			{
				name = name.Substring(0, LENMAX) + "...";
			}
			return name;
		}

		private void SaveData()
		{
			this.RI.XPos = Tools.ParseInt(this.XPos.Text, Gnd.I.RI_MINPOS, Gnd.I.RI_MAXPOS, 0);
			this.RI.YPos = Tools.ParseInt(this.YPos.Text, Gnd.I.RI_MINPOS, Gnd.I.RI_MAXPOS, 0);
			this.RI.WinW = Tools.ParseInt(this.WinW.Text, 1, Gnd.I.RI_MAXPOS, 300);
			this.RI.WinH = Tools.ParseInt(this.WinH.Text, 1, Gnd.I.RI_MAXPOS, 300);
			this.RI.WinColorR = Tools.ParseInt(this.WinColorR.Text, 0, 255, 0);
			this.RI.WinColorG = Tools.ParseInt(this.WinColorG.Text, 0, 255, 0);
			this.RI.WinColorB = Tools.ParseInt(this.WinColorB.Text, 0, 255, 0);
			this.RI.ImageFile = this.ImageFile;
			this.RI.ImageStretchFlag = this._タイリングChk.Checked == false;
			this.RI.透明度Pct = this._透明度Pct.Value;
		}

		private void ResetBtn_Click(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void KeyPressCommon(KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				this.Close();
			}
		}

		private void XPos_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void WinW_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void YPos_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void WinH_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void WinColorR_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void WinColorG_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void WinColorB_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void ImageBtn_Click(object sender, EventArgs e)
		{
			string file = SaveLoadDialogs.LoadFile(
				"画像ファイルを選択して下さい",
				"",
				this.ImageFile == "" ? "" : Path.GetDirectoryName(this.ImageFile),
				this.ImageFile == "" ? "*.bmp;*.gif;*.jpg;*.jpeg;*.png" : this.ImageFile,
				dlg =>
				{
					dlg.Filter = "画像ファイル(*.bmp;*.gif;*.jpg;*.jpeg;*.png)|*.bmp;*.gif;*.jpg;*.jpeg;*.png|すべてのファイル(*.*)|*.*";
				});

			if (file != null)
				this.ImageFile = Path.GetFullPath(file);
			else
				this.ImageFile = "";

			this.UpdateUi();
		}

		private void _画像サイズBtn_Click(object sender, EventArgs e)
		{
			try
			{
				Bitmap bmp = new Bitmap(this.ImageFile);

				int w = bmp.Width;
				int h = bmp.Height;

				this.WinW.Text = "" + w;
				this.WinH.Text = "" + h;
			}
			catch
			{ }
		}

		private void _画面サイズBtn_Click(object sender, EventArgs e)
		{
			try
			{
				this.XPos.Text = "" + 0;
				this.YPos.Text = "" + 0;
				this.WinW.Text = "" + Screen.PrimaryScreen.Bounds.Width;
				this.WinH.Text = "" + Screen.PrimaryScreen.Bounds.Height;
			}
			catch
			{ }
		}

		private void EditTextBtn_Click(object sender, EventArgs e)
		{
			using (EditTextWin f = new EditTextWin(this.RI))
			{
				f.ShowDialog();
			}
		}

		private void _テキストサイズBtn_Click(object sender, EventArgs e)
		{
			Gnd.I.AdjustToTextSize = true;
			this.Close();
		}

		private void 色Btn_Click(object sender, EventArgs e)
		{
			TextBox tbR = this.WinColorR;
			TextBox tbG = this.WinColorG;
			TextBox tbB = this.WinColorB;

			// sync > @ _WindRect_SelectColorDlg

			try
			{
				int[] defColors = new int[16];

				for (int index = 0; index < 16; index++)
					defColors[index] = index * 0x081008 + 0x800000;

				Color color;

				{
					int r = int.Parse(tbR.Text) & 0xff;
					int g = int.Parse(tbG.Text) & 0xff;
					int b = int.Parse(tbB.Text) & 0xff;

					color = Color.FromArgb(r, g, b);
				}

				if (SaveLoadDialogs.SelectColor(ref color, defColors))
				{
					int r = color.R;
					int g = color.G;
					int b = color.B;

					tbR.Text = "" + r;
					tbG.Text = "" + g;
					tbB.Text = "" + b;
				}
			}
			catch
			{ }

			// < sync
		}

		private void これをデフォルトにするBtn_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveData();
				Gnd.I.DefRect = this.RI.GetClone();
			}
			catch
			{ }
		}
	}
}
