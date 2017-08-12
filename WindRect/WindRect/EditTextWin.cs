using System;
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

			text = text.Replace(Gnd.I.ESC_NEW_LINE, "\r\n");

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
				text = text.Replace("\n", Gnd.I.ESC_NEW_LINE);

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
			if (e.KeyChar == (char)10) // Ctrl + Enter
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
	}
}
