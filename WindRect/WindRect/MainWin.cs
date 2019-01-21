using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Threading;

namespace WindRect
{
	public partial class MainWin : Form
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

		public MainWin()
		{
			InitializeComponent();
		}

		private void MainWin_Load(object sender, EventArgs e)
		{
			// noop
		}

		private bool ActivatedFlag;

		private void MainWin_Activated(object sender, EventArgs e)
		{
			if (this.ActivatedFlag)
				return;

			this.ActivatedFlag = true;
			this.Visible = false;
			Gnd.I.LoadData();

			foreach (Gnd.RectInfo ri in Gnd.I.RectInfoList)
			{
				new RectWin(ri).Show();
			}
			this.TaskIcon.Visible = true;

			Gnd.I.MainWin = this;

			this.UpdateUi();
		}

		private void MainWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.TaskIcon.Visible = false;
			Gnd.I.SaveData(); // ログオフ・シャットダウン時はここも実行されない。(タスクアイコンだからか？)
		}

		private void 追加AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Gnd.RectInfo ri;

			if (Gnd.I.DefRect != null)
				ri = Gnd.I.DefRect.GetClone();
			else
				ri = new Gnd.RectInfo();

			Gnd.I.RectInfoList.Add(ri);
			Gnd.I.SaveData();
			new RectWin(ri).Show();
		}

		private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void 右クリックを抑止するRToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Gnd.I.RightClickOff = Gnd.I.RightClickOff == false;
			this.UpdateUi();
		}

		private void ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Gnd.I.DoubleClickOff = Gnd.I.DoubleClickOff == false;
			this.UpdateUi();
		}

		private void UpdateUi()
		{
			this.右クリックを抑止するRToolStripMenuItem.Checked = Gnd.I.RightClickOff;
			this.ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem.Checked = Gnd.I.DoubleClickOff;
			this.タスクアイコンをダブルクリックで追加AToolStripMenuItem.Checked = Gnd.I.TaskIconDoubleClickAndAddRect;

			foreach (Gnd.RectInfo ri in Gnd.I.RectInfoList)
			{
				ri.Win.UpdateUi_MainWin();
			}
		}

		private void TaskIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (Gnd.I.TaskIconDoubleClickAndAddRect == false)
				return;

			this.追加AToolStripMenuItem_Click(null, null);
		}

		private void タスクアイコンをダブルクリックで追加AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Gnd.I.TaskIconDoubleClickAndAddRect = Gnd.I.TaskIconDoubleClickAndAddRect == false;
			this.UpdateUi();
		}
	}
}
