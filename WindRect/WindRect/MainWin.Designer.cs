namespace WindRect
{
	partial class MainWin
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
			this.TaskIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.TaskMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.追加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.設定SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.右クリックを抑止するRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TaskMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// TaskIcon
			// 
			this.TaskIcon.ContextMenuStrip = this.TaskMenu;
			this.TaskIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TaskIcon.Icon")));
			this.TaskIcon.Text = "WindRect";
			// 
			// TaskMenu
			// 
			this.TaskMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.追加AToolStripMenuItem,
            this.設定SToolStripMenuItem,
            this.toolStripMenuItem2,
            this.終了XToolStripMenuItem});
			this.TaskMenu.Name = "TaskMenu";
			this.TaskMenu.Size = new System.Drawing.Size(119, 76);
			// 
			// 追加AToolStripMenuItem
			// 
			this.追加AToolStripMenuItem.Name = "追加AToolStripMenuItem";
			this.追加AToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.追加AToolStripMenuItem.Text = "追加(&A)";
			this.追加AToolStripMenuItem.Click += new System.EventHandler(this.追加AToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(115, 6);
			// 
			// 終了XToolStripMenuItem
			// 
			this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
			this.終了XToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.終了XToolStripMenuItem.Text = "終了(&X)";
			this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
			// 
			// 設定SToolStripMenuItem
			// 
			this.設定SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.右クリックを抑止するRToolStripMenuItem});
			this.設定SToolStripMenuItem.Name = "設定SToolStripMenuItem";
			this.設定SToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.設定SToolStripMenuItem.Text = "設定(&S)";
			// 
			// 右クリックを抑止するRToolStripMenuItem
			// 
			this.右クリックを抑止するRToolStripMenuItem.Name = "右クリックを抑止するRToolStripMenuItem";
			this.右クリックを抑止するRToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
			this.右クリックを抑止するRToolStripMenuItem.Text = "右クリックメニューを抑止する(&R)";
			this.右クリックを抑止するRToolStripMenuItem.Click += new System.EventHandler(this.右クリックを抑止するRToolStripMenuItem_Click);
			// 
			// MainWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 300);
			this.ContextMenuStrip = this.TaskMenu;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(-400, -400);
			this.Name = "MainWin";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "WindRect";
			this.Activated += new System.EventHandler(this.MainWin_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWin_FormClosed);
			this.Load += new System.EventHandler(this.MainWin_Load);
			this.TaskMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon TaskIcon;
		private System.Windows.Forms.ContextMenuStrip TaskMenu;
		private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem 追加AToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 設定SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 右クリックを抑止するRToolStripMenuItem;
	}
}

