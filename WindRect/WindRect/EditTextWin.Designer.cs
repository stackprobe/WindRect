namespace WindRect
{
	partial class EditTextWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTextWin));
			this.TextText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SizeText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ColorRText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ColorGText = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.ColorBText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ResetBtn = new System.Windows.Forms.Button();
			this.FontCombo = new System.Windows.Forms.ComboBox();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TextText
			// 
			this.TextText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextText.Location = new System.Drawing.Point(12, 32);
			this.TextText.MaxLength = 10000;
			this.TextText.Multiline = true;
			this.TextText.Name = "TextText";
			this.TextText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextText.Size = new System.Drawing.Size(560, 352);
			this.TextText.TabIndex = 1;
			this.TextText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextText_KeyPress);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 393);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "フォント名";
			// 
			// SizeText
			// 
			this.SizeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SizeText.Location = new System.Drawing.Point(118, 424);
			this.SizeText.MaxLength = 3;
			this.SizeText.Name = "SizeText";
			this.SizeText.Size = new System.Drawing.Size(100, 27);
			this.SizeText.TabIndex = 5;
			this.SizeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SizeText_KeyPress);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 427);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "フォントサイズ";
			// 
			// ColorRText
			// 
			this.ColorRText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ColorRText.Location = new System.Drawing.Point(118, 457);
			this.ColorRText.MaxLength = 3;
			this.ColorRText.Name = "ColorRText";
			this.ColorRText.Size = new System.Drawing.Size(100, 27);
			this.ColorRText.TabIndex = 7;
			this.ColorRText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColorRText_KeyPress);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 460);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "テキスト色 R";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 493);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "テキスト色 G";
			// 
			// ColorGText
			// 
			this.ColorGText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ColorGText.Location = new System.Drawing.Point(118, 490);
			this.ColorGText.MaxLength = 3;
			this.ColorGText.Name = "ColorGText";
			this.ColorGText.Size = new System.Drawing.Size(100, 27);
			this.ColorGText.TabIndex = 9;
			this.ColorGText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColorGText_KeyPress);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 526);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "テキスト色 B";
			// 
			// ColorBText
			// 
			this.ColorBText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ColorBText.Location = new System.Drawing.Point(118, 523);
			this.ColorBText.MaxLength = 3;
			this.ColorBText.Name = "ColorBText";
			this.ColorBText.Size = new System.Drawing.Size(100, 27);
			this.ColorBText.TabIndex = 11;
			this.ColorBText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColorBText_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(190, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "テキスト (Ctrl + Enterで確定)";
			// 
			// ResetBtn
			// 
			this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ResetBtn.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ResetBtn.Location = new System.Drawing.Point(445, 500);
			this.ResetBtn.Name = "ResetBtn";
			this.ResetBtn.Size = new System.Drawing.Size(127, 50);
			this.ResetBtn.TabIndex = 13;
			this.ResetBtn.Text = "リセット";
			this.ResetBtn.UseVisualStyleBackColor = true;
			this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
			// 
			// FontCombo
			// 
			this.FontCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FontCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FontCombo.FormattingEnabled = true;
			this.FontCombo.Location = new System.Drawing.Point(118, 390);
			this.FontCombo.Name = "FontCombo";
			this.FontCombo.Size = new System.Drawing.Size(454, 28);
			this.FontCombo.TabIndex = 3;
			// 
			// ClearBtn
			// 
			this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearBtn.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ClearBtn.Location = new System.Drawing.Point(419, 424);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(153, 27);
			this.ClearBtn.TabIndex = 12;
			this.ClearBtn.Text = "テキストのクリア";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// EditTextWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 562);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.FontCombo);
			this.Controls.Add(this.ResetBtn);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ColorBText);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ColorGText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ColorRText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SizeText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TextText);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimizeBox = false;
			this.Name = "EditTextWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "テキストの変更";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditTextWin_FormClosed);
			this.Load += new System.EventHandler(this.EditTextWin_Load);
			this.Shown += new System.EventHandler(this.EditTextWin_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SizeText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ColorRText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ColorGText;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox ColorBText;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button ResetBtn;
		private System.Windows.Forms.ComboBox FontCombo;
		private System.Windows.Forms.Button ClearBtn;
	}
}
