﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindRect
{
	public partial class QuickEditTextWin : Form
	{
		private RectWin ParentWin;

		public QuickEditTextWin(RectWin parentWin, string text)
		{
			InitializeComponent();

			this.ParentWin = parentWin;

			if (text != null)
			{
				text = text.Replace(Gnd.I.ESC_NEW_LINE, "\r\n");
				this.MainText.Text = text;
			}
		}

		private void QuickEditTextWin_Load(object sender, EventArgs e)
		{
			// noop
		}

		private void QuickEditTextWin_Shown(object sender, EventArgs e)
		{
			this.Left = this.ParentWin.Left;
			this.Top = this.ParentWin.Top;
			this.Width = Math.Max(300, this.ParentWin.Width + 50);
			this.Height = Math.Max(300, this.ParentWin.Height + 50);

			Tools.PostShown(this);
		}

		private void MainText_TextChanged(object sender, EventArgs e)
		{
			// noop
		}

		private void MainText_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)1) // ctrl_a
			{
				this.MainText.SelectAll();
				e.Handled = true;
			}
			else if (e.KeyChar == (char)10) // ctrl_enter
			{
				this.Close();
				e.Handled = true;
			}
		}

		public string RetText;

		private void QuickEditTextWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			string text = this.MainText.Text;

			text = text.Trim();

			text = text.Replace("\r", "");
			text = text.Replace("\n", Gnd.I.ESC_NEW_LINE);

			this.RetText = text;
		}
	}
}