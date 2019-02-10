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
	public partial class その他の設定Dlg : Form
	{
		public その他の設定Dlg()
		{
			InitializeComponent();
		}

		private void その他の設定Dlg_Load(object sender, EventArgs e)
		{
			// noop
		}

		private void その他の設定Dlg_Shown(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void その他の設定Dlg_FormClosing(object sender, FormClosingEventArgs e)
		{
			// noop
		}

		private void その他の設定Dlg_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.SaveData();
			Gnd.I.SaveData();
		}

		private void LoadData()
		{
			this.CBBootDelaySecond.SelectedIndex = BDSecondToIndex(Gnd.I.BootDelaySecond);
		}

		private void SaveData()
		{
			Gnd.I.BootDelaySecond = IndexToBDSecond(this.CBBootDelaySecond.SelectedIndex);
		}

		// ---- BDSecondList ----

		private static readonly int[] BDSecondList = new int[]
		{
			0,
			30,
			60,
			120,
			180,
		};

		private static int BDSecondToIndex(int sec)
		{
			for (int index = 0; ; index++)
				if (BDSecondList[index] == sec)
					return index;
		}

		private static int IndexToBDSecond(int index)
		{
			return BDSecondList[index];
		}

		// ----
	}
}
