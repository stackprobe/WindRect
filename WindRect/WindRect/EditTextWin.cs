﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WindRect
{
	public partial class EditTextWin : Form
	{
		private Gnd.RectInfo RI;

		public EditTextWin(Gnd.RectInfo ri)
		{
			this.RI = ri;

			InitializeComponent();

			this.MinimumSize = this.Size;
		}

		private void EditTextWin_Load(object sender, EventArgs e)
		{
			this.FontCombo.Items.Clear();

			foreach (FontFamily ff in new InstalledFontCollection().Families)
			{
				this.FontCombo.Items.Add(ff.Name);
			}
		}

		private void LoadData()
		{
			string text = this.RI.Text;

			text = Utils2.Unescape(text);
			text = text.Replace("\n", "\r\n");

			this.TextText.Text = text;
			this.FontCombo.Text = this.RI.TextFont;
			this.SizeText.Text = "" + this.RI.TextSize;
			this.ColorRText.Text = "" + this.RI.TextColorR;
			this.ColorGText.Text = "" + this.RI.TextColorG;
			this.ColorBText.Text = "" + this.RI.TextColorB;
		}

		private void SaveData()
		{
			{
				string text = this.TextText.Text;

				text = text.Trim();
				text = text.Replace("\r", "");
				text = Utils2.Escape(text);

				this.RI.Text = text;
			}

			this.RI.TextFont = Tools.FontFilter(this.FontCombo.Text);
			this.RI.TextSize = Tools.ParseInt(this.SizeText.Text, 1, 300, 10);
			this.RI.TextColorR = Tools.ParseInt(this.ColorRText.Text, 0, 255, 255);
			this.RI.TextColorG = Tools.ParseInt(this.ColorGText.Text, 0, 255, 255);
			this.RI.TextColorB = Tools.ParseInt(this.ColorBText.Text, 0, 255, 255);
		}

		private void EditTextWin_Shown(object sender, EventArgs e)
		{
			this.LoadData();

			Tools.PostShown(this);
		}

		private void EditTextWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.SaveData();
		}

		private void ResetBtn_Click(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void TextText_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)1) // Ctrl + A
			{
				this.TextText.SelectAll();
				e.Handled = true;
			}
			else if (e.KeyChar == (char)10) // Ctrl + Enter
			{
				e.Handled = true;
				this.Close();
			}
		}

		private void KeyPressCommon(KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
				this.Close();
			}
		}

		private void FontText_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void SizeText_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void ColorRText_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void ColorGText_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void ColorBText_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.KeyPressCommon(e);
		}

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			this.TextText.Text = "";
		}

		private void 色Btn_Click(object sender, EventArgs e)
		{
			TextBox tbR = this.ColorRText;
			TextBox tbG = this.ColorGText;
			TextBox tbB = this.ColorBText;

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
	}
}
