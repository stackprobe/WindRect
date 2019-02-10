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
			this.設定SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.右クリックを抑止するRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.タスクアイコンをダブルクリックで追加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.その他OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.全部整列SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.全部整列Item = new System.Windows.Forms.ToolStripMenuItem();
			this.全部剥がすCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.全部剥がすItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.その他の設定SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TaskMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// TaskIcon
			// 
			this.TaskIcon.ContextMenuStrip = this.TaskMenu;
			this.TaskIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TaskIcon.Icon")));
			this.TaskIcon.Text = "WindRect";
			this.TaskIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskIcon_MouseDoubleClick);
			// 
			// TaskMenu
			// 
			this.TaskMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.追加AToolStripMenuItem,
            this.設定SToolStripMenuItem,
            this.その他OToolStripMenuItem,
            this.toolStripMenuItem2,
            this.終了XToolStripMenuItem});
			this.TaskMenu.Name = "TaskMenu";
			this.TaskMenu.Size = new System.Drawing.Size(153, 120);
			// 
			// 追加AToolStripMenuItem
			// 
			this.追加AToolStripMenuItem.Name = "追加AToolStripMenuItem";
			this.追加AToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.追加AToolStripMenuItem.Text = "追加(&A)";
			this.追加AToolStripMenuItem.Click += new System.EventHandler(this.追加AToolStripMenuItem_Click);
			// 
			// 設定SToolStripMenuItem
			// 
			this.設定SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.右クリックを抑止するRToolStripMenuItem,
            this.ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem,
            this.toolStripMenuItem1,
            this.タスクアイコンをダブルクリックで追加AToolStripMenuItem,
            this.toolStripMenuItem3,
            this.その他の設定SToolStripMenuItem});
			this.設定SToolStripMenuItem.Name = "設定SToolStripMenuItem";
			this.設定SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.設定SToolStripMenuItem.Text = "設定(&S)";
			// 
			// 右クリックを抑止するRToolStripMenuItem
			// 
			this.右クリックを抑止するRToolStripMenuItem.Name = "右クリックを抑止するRToolStripMenuItem";
			this.右クリックを抑止するRToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
			this.右クリックを抑止するRToolStripMenuItem.Text = "右クリックメニューを抑止する(&R)";
			this.右クリックを抑止するRToolStripMenuItem.Click += new System.EventHandler(this.右クリックを抑止するRToolStripMenuItem_Click);
			// 
			// ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem
			// 
			this.ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem.Name = "ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem";
			this.ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
			this.ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem.Text = "ダブルクリックによるテキスト編集を抑止する(&D)";
			this.ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem.Click += new System.EventHandler(this.ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(287, 6);
			// 
			// タスクアイコンをダブルクリックで追加AToolStripMenuItem
			// 
			this.タスクアイコンをダブルクリックで追加AToolStripMenuItem.Name = "タスクアイコンをダブルクリックで追加AToolStripMenuItem";
			this.タスクアイコンをダブルクリックで追加AToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
			this.タスクアイコンをダブルクリックで追加AToolStripMenuItem.Text = "タスクアイコンをダブルクリックで追加(&A)";
			this.タスクアイコンをダブルクリックで追加AToolStripMenuItem.Click += new System.EventHandler(this.タスクアイコンをダブルクリックで追加AToolStripMenuItem_Click);
			// 
			// その他OToolStripMenuItem
			// 
			this.その他OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部整列SToolStripMenuItem,
            this.全部剥がすCToolStripMenuItem});
			this.その他OToolStripMenuItem.Name = "その他OToolStripMenuItem";
			this.その他OToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.その他OToolStripMenuItem.Text = "その他(&O)";
			// 
			// 全部整列SToolStripMenuItem
			// 
			this.全部整列SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部整列Item});
			this.全部整列SToolStripMenuItem.Name = "全部整列SToolStripMenuItem";
			this.全部整列SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.全部整列SToolStripMenuItem.Text = "全部整列(&S)";
			this.全部整列SToolStripMenuItem.Click += new System.EventHandler(this.全部整列SToolStripMenuItem_Click);
			// 
			// 全部整列Item
			// 
			this.全部整列Item.Name = "全部整列Item";
			this.全部整列Item.Size = new System.Drawing.Size(152, 22);
			this.全部整列Item.Text = "全部整列(&S)";
			this.全部整列Item.Click += new System.EventHandler(this.全部整列Item_Click);
			// 
			// 全部剥がすCToolStripMenuItem
			// 
			this.全部剥がすCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部剥がすItem});
			this.全部剥がすCToolStripMenuItem.Name = "全部剥がすCToolStripMenuItem";
			this.全部剥がすCToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.全部剥がすCToolStripMenuItem.Text = "全部剥がす(&C)";
			this.全部剥がすCToolStripMenuItem.Click += new System.EventHandler(this.全部剥がすCToolStripMenuItem_Click);
			// 
			// 全部剥がすItem
			// 
			this.全部剥がすItem.Name = "全部剥がすItem";
			this.全部剥がすItem.Size = new System.Drawing.Size(152, 22);
			this.全部剥がすItem.Text = "全部剥がす(&C)";
			this.全部剥がすItem.Click += new System.EventHandler(this.全部剥がすItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
			// 
			// 終了XToolStripMenuItem
			// 
			this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
			this.終了XToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.終了XToolStripMenuItem.Text = "終了(&X)";
			this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(287, 6);
			// 
			// その他の設定SToolStripMenuItem
			// 
			this.その他の設定SToolStripMenuItem.Name = "その他の設定SToolStripMenuItem";
			this.その他の設定SToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
			this.その他の設定SToolStripMenuItem.Text = "その他の設定(&S)";
			this.その他の設定SToolStripMenuItem.Click += new System.EventHandler(this.その他の設定SToolStripMenuItem_Click);
			// 
			// MainWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 300);
			this.ContextMenuStrip = this.TaskMenu;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
		private System.Windows.Forms.ToolStripMenuItem ダブルクリックによるテキスト編集を抑止するDToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem タスクアイコンをダブルクリックで追加AToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem その他OToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 全部整列SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 全部剥がすCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 全部整列Item;
		private System.Windows.Forms.ToolStripMenuItem 全部剥がすItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem その他の設定SToolStripMenuItem;
	}
}

