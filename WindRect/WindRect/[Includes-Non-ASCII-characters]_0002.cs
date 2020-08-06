namespace WindRect
{
	partial class その他の設定Dlg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(その他の設定Dlg));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.CBBootDelaySecond = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.CBQuickEditTextFocusOutEditEnd = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.CBBootDelaySecond);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(570, 150);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "遅延起動";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(6, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(514, 68);
			this.label1.TabIndex = 1;
			this.label1.Text = "本プログラムを起動してからアイコンとウィンドウを表示するまで一定時間待ちます。\r\n(Windows7で)WindRectをスタートアップに登録するなどしてログオン" +
    "時に起動したとき、\r\nウィンドウが正しい位置に表示されなかったり、『常に手前に表示』が適用されないことがあります。\r\nその場合、これを有効にすると解消するかもし" +
    "れません。";
			// 
			// CBBootDelaySecond
			// 
			this.CBBootDelaySecond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CBBootDelaySecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CBBootDelaySecond.FormattingEnabled = true;
			this.CBBootDelaySecond.Items.AddRange(new object[] {
            "無効",
            "有効(10秒)",
            "有効(20秒)",
            "有効(30秒)",
            "有効(1分)",
            "有効(2分)",
            "有効(3分)"});
			this.CBBootDelaySecond.Location = new System.Drawing.Point(6, 26);
			this.CBBootDelaySecond.Name = "CBBootDelaySecond";
			this.CBBootDelaySecond.Size = new System.Drawing.Size(558, 28);
			this.CBBootDelaySecond.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.CBQuickEditTextFocusOutEditEnd);
			this.groupBox2.Location = new System.Drawing.Point(12, 168);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(570, 121);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Quickテキスト編集";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(6, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(470, 34);
			this.label2.TabIndex = 1;
			this.label2.Text = "矩形をダブルクリックして開始したテキスト編集について、\r\nテキスト編集ウィンドウがフォーカスを失ったときに、編集を終了するかどうか設定します。";
			// 
			// CBQuickEditTextFocusOutEditEnd
			// 
			this.CBQuickEditTextFocusOutEditEnd.AutoSize = true;
			this.CBQuickEditTextFocusOutEditEnd.Location = new System.Drawing.Point(6, 26);
			this.CBQuickEditTextFocusOutEditEnd.Name = "CBQuickEditTextFocusOutEditEnd";
			this.CBQuickEditTextFocusOutEditEnd.Size = new System.Drawing.Size(197, 24);
			this.CBQuickEditTextFocusOutEditEnd.TabIndex = 0;
			this.CBQuickEditTextFocusOutEditEnd.Text = "フォーカスアウトで編集終了";
			this.CBQuickEditTextFocusOutEditEnd.UseVisualStyleBackColor = true;
			// 
			// その他の設定Dlg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 301);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "その他の設定Dlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "その他の設定";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.その他の設定Dlg_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.その他の設定Dlg_FormClosed);
			this.Load += new System.EventHandler(this.その他の設定Dlg_Load);
			this.Shown += new System.EventHandler(this.その他の設定Dlg_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CBBootDelaySecond;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox CBQuickEditTextFocusOutEditEnd;
		private System.Windows.Forms.Label label2;
	}
}
