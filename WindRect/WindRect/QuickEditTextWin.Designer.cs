namespace WindRect
{
	partial class QuickEditTextWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickEditTextWin));
			this.MainText = new System.Windows.Forms.TextBox();
			this.MainTextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.日付を挿入CtrlDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.日時を挿入CtrlTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.コピーCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.色CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.文字FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.背景BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.サイズSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FontSizeTo10 = new System.Windows.Forms.ToolStripMenuItem();
			this.FontSizeTo20 = new System.Windows.Forms.ToolStripMenuItem();
			this.FontSizeTo30 = new System.Windows.Forms.ToolStripMenuItem();
			this.MainTextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainText
			// 
			this.MainText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainText.ContextMenuStrip = this.MainTextMenu;
			this.MainText.Location = new System.Drawing.Point(12, 12);
			this.MainText.MaxLength = 10000;
			this.MainText.Multiline = true;
			this.MainText.Name = "MainText";
			this.MainText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.MainText.Size = new System.Drawing.Size(460, 437);
			this.MainText.TabIndex = 0;
			this.MainText.TextChanged += new System.EventHandler(this.MainText_TextChanged);
			this.MainText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainText_KeyPress);
			// 
			// MainTextMenu
			// 
			this.MainTextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日付を挿入CtrlDToolStripMenuItem,
            this.日時を挿入CtrlTToolStripMenuItem,
            this.toolStripMenuItem1,
            this.コピーCtrlCToolStripMenuItem,
            this.toolStripMenuItem2,
            this.色CToolStripMenuItem,
            this.サイズSToolStripMenuItem});
			this.MainTextMenu.Name = "MainTextMenu";
			this.MainTextMenu.Size = new System.Drawing.Size(174, 148);
			// 
			// 日付を挿入CtrlDToolStripMenuItem
			// 
			this.日付を挿入CtrlDToolStripMenuItem.Name = "日付を挿入CtrlDToolStripMenuItem";
			this.日付を挿入CtrlDToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.日付を挿入CtrlDToolStripMenuItem.Text = "日付を挿入(Ctrl+D)";
			this.日付を挿入CtrlDToolStripMenuItem.Click += new System.EventHandler(this.日付を挿入CtrlDToolStripMenuItem_Click);
			// 
			// 日時を挿入CtrlTToolStripMenuItem
			// 
			this.日時を挿入CtrlTToolStripMenuItem.Name = "日時を挿入CtrlTToolStripMenuItem";
			this.日時を挿入CtrlTToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.日時を挿入CtrlTToolStripMenuItem.Text = "日時を挿入(Ctrl+T)";
			this.日時を挿入CtrlTToolStripMenuItem.Click += new System.EventHandler(this.日時を挿入CtrlTToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
			// 
			// コピーCtrlCToolStripMenuItem
			// 
			this.コピーCtrlCToolStripMenuItem.Name = "コピーCtrlCToolStripMenuItem";
			this.コピーCtrlCToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.コピーCtrlCToolStripMenuItem.Text = "コピー(Ctrl+C)";
			this.コピーCtrlCToolStripMenuItem.Click += new System.EventHandler(this.コピーCtrlCToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 6);
			// 
			// 色CToolStripMenuItem
			// 
			this.色CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文字FToolStripMenuItem,
            this.背景BToolStripMenuItem});
			this.色CToolStripMenuItem.Name = "色CToolStripMenuItem";
			this.色CToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.色CToolStripMenuItem.Text = "色(&C)";
			// 
			// 文字FToolStripMenuItem
			// 
			this.文字FToolStripMenuItem.Name = "文字FToolStripMenuItem";
			this.文字FToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.文字FToolStripMenuItem.Text = "文字(&F)";
			this.文字FToolStripMenuItem.Click += new System.EventHandler(this.文字FToolStripMenuItem_Click);
			// 
			// 背景BToolStripMenuItem
			// 
			this.背景BToolStripMenuItem.Name = "背景BToolStripMenuItem";
			this.背景BToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.背景BToolStripMenuItem.Text = "背景(&B)";
			this.背景BToolStripMenuItem.Click += new System.EventHandler(this.背景BToolStripMenuItem_Click);
			// 
			// サイズSToolStripMenuItem
			// 
			this.サイズSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontSizeTo10,
            this.FontSizeTo20,
            this.FontSizeTo30});
			this.サイズSToolStripMenuItem.Name = "サイズSToolStripMenuItem";
			this.サイズSToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.サイズSToolStripMenuItem.Text = "サイズ(&S)";
			// 
			// FontSizeTo10
			// 
			this.FontSizeTo10.Name = "FontSizeTo10";
			this.FontSizeTo10.Size = new System.Drawing.Size(152, 22);
			this.FontSizeTo10.Text = "10(&1)";
			this.FontSizeTo10.Click += new System.EventHandler(this.FontSizeTo10_Click);
			// 
			// FontSizeTo20
			// 
			this.FontSizeTo20.Name = "FontSizeTo20";
			this.FontSizeTo20.Size = new System.Drawing.Size(152, 22);
			this.FontSizeTo20.Text = "20(&2)";
			this.FontSizeTo20.Click += new System.EventHandler(this.FontSizeTo20_Click);
			// 
			// FontSizeTo30
			// 
			this.FontSizeTo30.Name = "FontSizeTo30";
			this.FontSizeTo30.Size = new System.Drawing.Size(152, 22);
			this.FontSizeTo30.Text = "30(&3)";
			this.FontSizeTo30.Click += new System.EventHandler(this.FontSizeTo30_Click);
			// 
			// QuickEditTextWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 461);
			this.Controls.Add(this.MainText);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "QuickEditTextWin";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "テキスト (Ctrl+Enterで確定)";
			this.TopMost = true;
			this.Deactivate += new System.EventHandler(this.QuickEditTextWin_Deactivate);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuickEditTextWin_FormClosed);
			this.Load += new System.EventHandler(this.QuickEditTextWin_Load);
			this.Shown += new System.EventHandler(this.QuickEditTextWin_Shown);
			this.MainTextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox MainText;
		private System.Windows.Forms.ContextMenuStrip MainTextMenu;
		private System.Windows.Forms.ToolStripMenuItem 日付を挿入CtrlDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 日時を挿入CtrlTToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem コピーCtrlCToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem 色CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 文字FToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 背景BToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem サイズSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FontSizeTo10;
		private System.Windows.Forms.ToolStripMenuItem FontSizeTo20;
		private System.Windows.Forms.ToolStripMenuItem FontSizeTo30;
	}
}
