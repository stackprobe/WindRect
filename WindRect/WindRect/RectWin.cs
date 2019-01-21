﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;

namespace WindRect
{
	public partial class RectWin : Form
	{
		#region [X] ALT+F4 抑止

		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m)
		{
			const int WM_SYSCOMMAND = 0x112;
			const long SC_CLOSE = 0xF060L;

			if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt64() & 0xFFF0L) == SC_CLOSE)
			{
				return;
			}
			base.WndProc(ref m);
		}

		#endregion

		private Gnd.RectInfo RI;

		public RectWin(Gnd.RectInfo ri)
		{
			this.RI = ri;
			this.RI.Win = this;

			InitializeComponent();
		}

		private void RectWin_Load(object sender, EventArgs e)
		{
			// noop
		}

		private bool ActivatedFlag;

		private void RectWin_Activated(object sender, EventArgs e)
		{
			if (this.ActivatedFlag)
				return;

			this.ActivatedFlag = true;
			this.UpdateUi();
			this.UpdateUi_MainWin();

			this.MT_Enabled = true;
			this.MainTimer.Interval = 20;
			this.MainTimer.Enabled = true;
		}

		private void RectWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.MT_Enabled = false;
			this.MainTimer.Interval = 100; // 2bs
			this.MainTimer.Enabled = false;
		}

		private void UpdateUi()
		{
			this.Location = new Point(this.RI.XPos, this.RI.YPos);
			this.Size = new Size(this.RI.WinW, this.RI.WinH);
			this.BackColor = Color.FromArgb(this.RI.WinColorR, this.RI.WinColorG, this.RI.WinColorB);

			this.ドラッグで移動MToolStripMenuItem.Checked = this.RI.MovableFlag;

			this.常に手前に表示TToolStripMenuItem.Checked = this.RI.MostTop;
			this.TopMost = this.RI.MostTop;

			try
			{
				if (this.RI.ImageFile != "")
				{
					this.BackgroundImage = new Bitmap(this.RI.ImageFile);
					this.BackgroundImageLayout = this.RI.ImageStretchFlag ? ImageLayout.Stretch : ImageLayout.Tile;
				}
				else
				{
					this.BackgroundImage = null;
				}
			}
			catch
			{
				try
				{
					this.BackgroundImage = null;
				}
				catch
				{ }
			}

			try
			{
				if (string.IsNullOrEmpty(this.RI.Text))
					throw null;

				string text = this.RI.Text;

				text = text.Replace(Gnd.I.ESC_NEW_LINE, "\r\n");

				this.RectText.Text = text;
				this.RectText.Font = new Font(this.RI.TextFont, this.RI.TextSize, FontStyle.Regular);
				this.RectText.ForeColor = Color.FromArgb(this.RI.TextColorR, this.RI.TextColorG, this.RI.TextColorB);
				//this.RectText.BackColor = this.BackColor;
				this.RectText.Visible = true;

				if (Gnd.I.AdjustToTextSize)
				{
					Gnd.I.AdjustToTextSize = false;

					int mgn = this.RectText.Left;
					int w = this.RectText.Width;
					int h = this.RectText.Height;

					this.RI.WinW = mgn + w + mgn;
					this.RI.WinH = mgn + h + mgn;

					this.Size = new Size(this.RI.WinW, this.RI.WinH);
				}
			}
			catch
			{
				try
				{
					this.RectText.Visible = false;
				}
				catch
				{ }
			}

			GC.Collect();
		}

		private void 位置と色PToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.MT_Enabled)
				return;

			using (Form f = new PosColorWin(this.RI))
			{
				f.ShowDialog(this);
			}
			this.UpdateUi();
		}

		private void 常に手前に表示TToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.MT_Enabled)
				return;

			this.RI.MostTop = this.RI.MostTop == false;
			this.UpdateUi();
			Gnd.I.SaveData();
		}

		private void ドラッグで移動MToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.MT_Enabled)
				return;

			this.RI.MovableFlag = this.RI.MovableFlag == false;
			this.UpdateUi();
			Gnd.I.SaveData();
		}

		private void 閉じるCToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.MT_Enabled)
				return;

			Gnd.I.Remove(this.RI);
			Gnd.I.SaveData();
			this.Close();
		}

		private Point WinMoveDiff;
		private bool WMD_Enabled = false;

		private void RectWin_MouseDown(object sender, MouseEventArgs e)
		{
			if (this.RI.MovableFlag == false)
				return;

			try
			{
				if (this.MT_Enabled)
					return;

				if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
				{
					this.WinMoveDiff = new Point(e.X, e.Y);
					this.WMD_Enabled = true;
				}
			}
			catch
			{ }
		}

		private void RectWin_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.RI.MovableFlag == false)
				return;

			try
			{
				if (this.MT_Enabled)
					return;

				if ((e.Button & MouseButtons.Left) == MouseButtons.Left && this.WMD_Enabled)
				{
					this.Location = new Point(
						this.Location.X + e.X - this.WinMoveDiff.X,
						this.Location.Y + e.Y - this.WinMoveDiff.Y
						);

					this.RI.XPos = this.Location.X;
					this.RI.YPos = this.Location.Y;
				}
			}
			catch
			{ }
		}

		private void RectWin_MouseUp(object sender, MouseEventArgs e)
		{
			if (this.RI.MovableFlag == false)
				return;

			try
			{
				if (this.MT_Enabled)
					return;

				if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
				{
					this.WMD_Enabled = false;
					Gnd.I.SaveData();
				}
			}
			catch
			{ }
		}

		private void RectText_MouseDown(object sender, MouseEventArgs e)
		{
			this.RectWin_MouseDown(null, e);
		}

		private void RectText_MouseMove(object sender, MouseEventArgs e)
		{
			this.RectWin_MouseMove(null, e);
		}

		private void RectText_MouseUp(object sender, MouseEventArgs e)
		{
			this.RectWin_MouseUp(null, e);
		}

		private bool MT_Enabled;
		private bool MT_Busy;
		private long MT_Count;

		private void MainTimer_Tick(object sender, EventArgs e)
		{
			if (this.MT_Enabled == false || this.MT_Busy)
				return;

			this.MT_Busy = true;

			try
			{
				switch (this.MT_Count)
				{
					case 2:
						this.TopMost = false; // 2bs 一旦リセット
						break;

					case 3:
						this.UpdateUi(); // 2bs 再設定
						break;

					case 4:
						this.UpdateUi_MainWin(); // 2bs 再設定
						break;

					case 5:
						this.MT_Enabled = false;
						this.MainTimer.Interval = 100; // 2bs
						this.MainTimer.Enabled = false;
						break;
				}
			}
			finally
			{
				this.MT_Busy = false;
				this.MT_Count++;
			}
		}

		private void 終了XToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Gnd.I.TryClose();
		}

		private void 追加AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Gnd.RectInfo ri = new Gnd.RectInfo();
			Gnd.I.RectInfoList.Add(ri);
			Gnd.I.SaveData();
			new RectWin(ri).Show();
		}

		private void 複製DToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Gnd.RectInfo ri = this.RI.GetClone();
			ri.XPos += 10;
			ri.YPos += 10;
			Gnd.I.RectInfoList.Add(ri);
			Gnd.I.SaveData();
			new RectWin(ri).Show();
		}

		private ContextMenuStrip BkContextMenuStrip = null;

		public void UpdateUi_MainWin()
		{
			if (this.BkContextMenuStrip == null)
				this.BkContextMenuStrip = this.ContextMenuStrip;

			if (Gnd.I.RightClickOff)
				this.ContextMenuStrip = null;
			else
				this.ContextMenuStrip = this.BkContextMenuStrip;
		}

		private void RectWin_DoubleClick(object sender, EventArgs e)
		{
			if (this.MT_Enabled)
				return;

			if (Gnd.I.DoubleClickOff)
				return;

			using (QuickEditTextWin f = new QuickEditTextWin(this, this.RI.Text))
			{
				f.ShowDialog();

				string text = f.RetText;

				if (text != this.RI.Text)
				{
					text = text.Trim();

					this.RI.Text = text;
					Gnd.I.SaveData();
					Gnd.I.AdjustToTextSize = true;
					this.UpdateUi();
				}
			}
		}

		private void RectText_DoubleClick(object sender, EventArgs e)
		{
			this.RectWin_DoubleClick(null, null);
		}
	}
}
