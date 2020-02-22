using System;
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
				text = Utils2.Unescape(text);
				text = text.Replace("\n", "\r\n");
				this.MainText.Text = text;
			}
		}

		private void QuickEditTextWin_Load(object sender, EventArgs e)
		{
			// noop
		}

		private void QuickEditTextWin_Shown(object sender, EventArgs e)
		{
			{
				I4Rect win = new I4Rect()
				{
					L = this.ParentWin.Left,
					T = this.ParentWin.Top,
					W = Math.Max(300, this.ParentWin.Width + 50),
					H = Math.Max(300, this.ParentWin.Height + 50),
				};

				foreach (I4Rect screen in Tools.GetAllScreen().Where(screen => Tools.IsCrashed(screen, win)))
				{
					win = Tools.IntoScreen(screen, win);
					break;
				}

				this.Left = win.L;
				this.Top = win.T;
				this.Width = win.W;
				this.Height = win.H;
			}

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
			else if (e.KeyChar == (char)4) // ctrl_d
			{
				this.日付を挿入CtrlDToolStripMenuItem_Click(null, null);
				e.Handled = true;
			}
			else if (e.KeyChar == (char)20) // ctrl_t
			{
				this.日時を挿入CtrlTToolStripMenuItem_Click(null, null);
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
			text = Utils2.Escape(text);

			this.RetText = text;
		}

		private void 日付を挿入CtrlDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.InsertToMainText(DateTime.Now.ToString("yyyy/MM/dd"));
		}

		private void 日時を挿入CtrlTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.InsertToMainText(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
		}

		private void InsertToMainText(string str)
		{
			this.MainText.SelectedText = str + "\r\n";
		}

		private void QuickEditTextWin_Deactivate(object sender, EventArgs e)
		{
			if (Gnd.I.QuickEditTextFocusOutEditEnd)
			{
				this.Close();
			}
		}

		private void コピーCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MainText.Copy();
		}

		private void 文字FToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SelectColor(
				ref this.ParentWin.GetRI().TextColorR,
				ref this.ParentWin.GetRI().TextColorG,
				ref this.ParentWin.GetRI().TextColorB
				);
		}

		private void 背景BToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SelectColor(
				ref this.ParentWin.GetRI().WinColorR,
				ref this.ParentWin.GetRI().WinColorG,
				ref this.ParentWin.GetRI().WinColorB
				);
		}

		private void SelectColor(ref int intR, ref int intG, ref int intB)
		{
			TextBox tbR = new TextBox();
			TextBox tbG = new TextBox();
			TextBox tbB = new TextBox();

			tbR.Text = "" + intR;
			tbG.Text = "" + intG;
			tbB.Text = "" + intB;

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

			intR = int.Parse(tbR.Text);
			intG = int.Parse(tbG.Text);
			intB = int.Parse(tbB.Text);

			this.SomethingModified = true;
		}

		public bool SomethingModified = false;
	}
}
