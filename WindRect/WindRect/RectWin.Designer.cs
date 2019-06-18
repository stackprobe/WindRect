namespace WindRect
{
	partial class RectWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectWin));
			this.RClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.位置と色PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.常に手前に表示TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ドラッグで移動MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.追加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.複製DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.剥がすCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.その他OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.テキストをファイルに保存するSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.アプリケーションAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.終了XToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.RectText = new System.Windows.Forms.Label();
			this.RClickMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// RClickMenu
			// 
			this.RClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.位置と色PToolStripMenuItem,
            this.toolStripMenuItem1,
            this.常に手前に表示TToolStripMenuItem,
            this.ドラッグで移動MToolStripMenuItem,
            this.toolStripMenuItem2,
            this.追加AToolStripMenuItem,
            this.複製DToolStripMenuItem,
            this.終了XToolStripMenuItem,
            this.toolStripMenuItem4,
            this.その他OToolStripMenuItem,
            this.toolStripMenuItem3,
            this.アプリケーションAToolStripMenuItem});
			this.RClickMenu.Name = "TaskMenu";
			this.RClickMenu.Size = new System.Drawing.Size(206, 204);
			// 
			// 位置と色PToolStripMenuItem
			// 
			this.位置と色PToolStripMenuItem.Name = "位置と色PToolStripMenuItem";
			this.位置と色PToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.位置と色PToolStripMenuItem.Text = "位置とサイズと色の変更(&P)";
			this.位置と色PToolStripMenuItem.Click += new System.EventHandler(this.位置と色PToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 6);
			// 
			// 常に手前に表示TToolStripMenuItem
			// 
			this.常に手前に表示TToolStripMenuItem.Name = "常に手前に表示TToolStripMenuItem";
			this.常に手前に表示TToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.常に手前に表示TToolStripMenuItem.Text = "常に手前に表示(&T)";
			this.常に手前に表示TToolStripMenuItem.Click += new System.EventHandler(this.常に手前に表示TToolStripMenuItem_Click);
			// 
			// ドラッグで移動MToolStripMenuItem
			// 
			this.ドラッグで移動MToolStripMenuItem.Name = "ドラッグで移動MToolStripMenuItem";
			this.ドラッグで移動MToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.ドラッグで移動MToolStripMenuItem.Text = "ドラッグで移動(&M)";
			this.ドラッグで移動MToolStripMenuItem.Click += new System.EventHandler(this.ドラッグで移動MToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(202, 6);
			// 
			// 追加AToolStripMenuItem
			// 
			this.追加AToolStripMenuItem.Name = "追加AToolStripMenuItem";
			this.追加AToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.追加AToolStripMenuItem.Text = "追加(&A)";
			this.追加AToolStripMenuItem.Click += new System.EventHandler(this.追加AToolStripMenuItem_Click);
			// 
			// 複製DToolStripMenuItem
			// 
			this.複製DToolStripMenuItem.Name = "複製DToolStripMenuItem";
			this.複製DToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.複製DToolStripMenuItem.Text = "複製(&D)";
			this.複製DToolStripMenuItem.Click += new System.EventHandler(this.複製DToolStripMenuItem_Click);
			// 
			// 終了XToolStripMenuItem
			// 
			this.終了XToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剥がすCToolStripMenuItem});
			this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
			this.終了XToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.終了XToolStripMenuItem.Text = "剥がす(&C)";
			// 
			// 剥がすCToolStripMenuItem
			// 
			this.剥がすCToolStripMenuItem.Name = "剥がすCToolStripMenuItem";
			this.剥がすCToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.剥がすCToolStripMenuItem.Text = "剥がす(&C)";
			this.剥がすCToolStripMenuItem.Click += new System.EventHandler(this.閉じるCToolStripMenuItem_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(202, 6);
			// 
			// その他OToolStripMenuItem
			// 
			this.その他OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.テキストをファイルに保存するSToolStripMenuItem});
			this.その他OToolStripMenuItem.Name = "その他OToolStripMenuItem";
			this.その他OToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.その他OToolStripMenuItem.Text = "その他(&O)";
			// 
			// テキストをファイルに保存するSToolStripMenuItem
			// 
			this.テキストをファイルに保存するSToolStripMenuItem.Name = "テキストをファイルに保存するSToolStripMenuItem";
			this.テキストをファイルに保存するSToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.テキストをファイルに保存するSToolStripMenuItem.Text = "テキストの内容をファイルに保存する(&S)";
			this.テキストをファイルに保存するSToolStripMenuItem.Click += new System.EventHandler(this.テキストをファイルに保存するSToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(202, 6);
			// 
			// アプリケーションAToolStripMenuItem
			// 
			this.アプリケーションAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了XToolStripMenuItem1});
			this.アプリケーションAToolStripMenuItem.Name = "アプリケーションAToolStripMenuItem";
			this.アプリケーションAToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.アプリケーションAToolStripMenuItem.Text = "アプリケーション(&X)";
			// 
			// 終了XToolStripMenuItem1
			// 
			this.終了XToolStripMenuItem1.Name = "終了XToolStripMenuItem1";
			this.終了XToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
			this.終了XToolStripMenuItem1.Text = "終了(&X)";
			this.終了XToolStripMenuItem1.Click += new System.EventHandler(this.終了XToolStripMenuItem1_Click);
			// 
			// RectText
			// 
			this.RectText.AutoSize = true;
			this.RectText.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.RectText.Location = new System.Drawing.Point(10, 10);
			this.RectText.Name = "RectText";
			this.RectText.Size = new System.Drawing.Size(115, 20);
			this.RectText.TabIndex = 1;
			this.RectText.Text = "準備しています...";
			this.RectText.DoubleClick += new System.EventHandler(this.RectText_DoubleClick);
			this.RectText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RectText_MouseDown);
			this.RectText.MouseEnter += new System.EventHandler(this.RectText_MouseEnter);
			this.RectText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RectText_MouseMove);
			this.RectText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RectText_MouseUp);
			// 
			// RectWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 300);
			this.ContextMenuStrip = this.RClickMenu;
			this.Controls.Add(this.RectText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "RectWin";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "WindRect";
			this.Activated += new System.EventHandler(this.RectWin_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RectWin_FormClosed);
			this.Load += new System.EventHandler(this.RectWin_Load);
			this.DoubleClick += new System.EventHandler(this.RectWin_DoubleClick);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RectWin_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RectWin_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RectWin_MouseUp);
			this.RClickMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip RClickMenu;
		private System.Windows.Forms.ToolStripMenuItem 位置と色PToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 常に手前に表示TToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ドラッグで移動MToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem アプリケーションAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 剥がすCToolStripMenuItem;
		private System.Windows.Forms.Label RectText;
		private System.Windows.Forms.ToolStripMenuItem 複製DToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 追加AToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem その他OToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem テキストをファイルに保存するSToolStripMenuItem;
	}
}
