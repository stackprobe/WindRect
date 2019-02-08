namespace WindRect
{
	partial class PosColorWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosColorWin));
			this.label1 = new System.Windows.Forms.Label();
			this.XPos = new System.Windows.Forms.TextBox();
			this.YPos = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.WinH = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.WinW = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.WinColorR = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.WinColorG = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.WinColorB = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.ResetBtn = new System.Windows.Forms.Button();
			this.ImageBtn = new System.Windows.Forms.Button();
			this._画像サイズBtn = new System.Windows.Forms.Button();
			this._画面サイズBtn = new System.Windows.Forms.Button();
			this._タイリングChk = new System.Windows.Forms.CheckBox();
			this.EditTextBtn = new System.Windows.Forms.Button();
			this._テキストサイズBtn = new System.Windows.Forms.Button();
			this.これをデフォルトにするBtn = new System.Windows.Forms.Button();
			this.色Btn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(7, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "X座標";
			// 
			// XPos
			// 
			this.XPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.XPos.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.XPos.Location = new System.Drawing.Point(59, 28);
			this.XPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.XPos.MaxLength = 6;
			this.XPos.Name = "XPos";
			this.XPos.Size = new System.Drawing.Size(232, 27);
			this.XPos.TabIndex = 1;
			this.XPos.Text = "-99999";
			this.XPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.XPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XPos_KeyPress);
			// 
			// YPos
			// 
			this.YPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.YPos.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.YPos.Location = new System.Drawing.Point(59, 65);
			this.YPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.YPos.MaxLength = 6;
			this.YPos.Name = "YPos";
			this.YPos.Size = new System.Drawing.Size(232, 27);
			this.YPos.TabIndex = 3;
			this.YPos.Text = "-99999";
			this.YPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.YPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YPos_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(7, 68);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Y座標";
			// 
			// WinH
			// 
			this.WinH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WinH.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.WinH.Location = new System.Drawing.Point(59, 139);
			this.WinH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.WinH.MaxLength = 5;
			this.WinH.Name = "WinH";
			this.WinH.Size = new System.Drawing.Size(232, 27);
			this.WinH.TabIndex = 7;
			this.WinH.Text = "99999";
			this.WinH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.WinH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WinH_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(7, 141);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "高さ";
			// 
			// WinW
			// 
			this.WinW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WinW.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.WinW.Location = new System.Drawing.Point(59, 102);
			this.WinW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.WinW.MaxLength = 5;
			this.WinW.Name = "WinW";
			this.WinW.Size = new System.Drawing.Size(232, 27);
			this.WinW.TabIndex = 5;
			this.WinW.Text = "99999";
			this.WinW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.WinW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WinW_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(7, 105);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(22, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "幅";
			// 
			// WinColorR
			// 
			this.WinColorR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WinColorR.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.WinColorR.Location = new System.Drawing.Point(33, 28);
			this.WinColorR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.WinColorR.MaxLength = 3;
			this.WinColorR.Name = "WinColorR";
			this.WinColorR.Size = new System.Drawing.Size(110, 27);
			this.WinColorR.TabIndex = 1;
			this.WinColorR.Text = "255";
			this.WinColorR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.WinColorR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WinColorR_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(7, 31);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "R";
			// 
			// WinColorG
			// 
			this.WinColorG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WinColorG.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.WinColorG.Location = new System.Drawing.Point(33, 65);
			this.WinColorG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.WinColorG.MaxLength = 3;
			this.WinColorG.Name = "WinColorG";
			this.WinColorG.Size = new System.Drawing.Size(110, 27);
			this.WinColorG.TabIndex = 3;
			this.WinColorG.Text = "255";
			this.WinColorG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.WinColorG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WinColorG_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(7, 68);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "G";
			// 
			// WinColorB
			// 
			this.WinColorB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WinColorB.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.WinColorB.Location = new System.Drawing.Point(33, 102);
			this.WinColorB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.WinColorB.MaxLength = 3;
			this.WinColorB.Name = "WinColorB";
			this.WinColorB.Size = new System.Drawing.Size(110, 27);
			this.WinColorB.TabIndex = 5;
			this.WinColorB.Text = "255";
			this.WinColorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.WinColorB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WinColorB_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.Location = new System.Drawing.Point(7, 105);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(18, 20);
			this.label7.TabIndex = 4;
			this.label7.Text = "B";
			// 
			// ResetBtn
			// 
			this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ResetBtn.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ResetBtn.Location = new System.Drawing.Point(453, 503);
			this.ResetBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ResetBtn.Name = "ResetBtn";
			this.ResetBtn.Size = new System.Drawing.Size(169, 54);
			this.ResetBtn.TabIndex = 5;
			this.ResetBtn.Text = "リセット";
			this.ResetBtn.UseVisualStyleBackColor = true;
			this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
			// 
			// ImageBtn
			// 
			this.ImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImageBtn.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ImageBtn.Location = new System.Drawing.Point(7, 28);
			this.ImageBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ImageBtn.Name = "ImageBtn";
			this.ImageBtn.Size = new System.Drawing.Size(596, 40);
			this.ImageBtn.TabIndex = 0;
			this.ImageBtn.Text = "画像なし";
			this.ImageBtn.UseVisualStyleBackColor = true;
			this.ImageBtn.Click += new System.EventHandler(this.ImageBtn_Click);
			// 
			// _画像サイズBtn
			// 
			this._画像サイズBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._画像サイズBtn.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this._画像サイズBtn.Location = new System.Drawing.Point(7, 250);
			this._画像サイズBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this._画像サイズBtn.Name = "_画像サイズBtn";
			this._画像サイズBtn.Size = new System.Drawing.Size(284, 27);
			this._画像サイズBtn.TabIndex = 9;
			this._画像サイズBtn.Text = "画像サイズに合わせる";
			this._画像サイズBtn.UseVisualStyleBackColor = true;
			this._画像サイズBtn.Click += new System.EventHandler(this._画像サイズBtn_Click);
			// 
			// _画面サイズBtn
			// 
			this._画面サイズBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._画面サイズBtn.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this._画面サイズBtn.Location = new System.Drawing.Point(7, 213);
			this._画面サイズBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this._画面サイズBtn.Name = "_画面サイズBtn";
			this._画面サイズBtn.Size = new System.Drawing.Size(284, 27);
			this._画面サイズBtn.TabIndex = 8;
			this._画面サイズBtn.Text = "画面サイズに合わせる";
			this._画面サイズBtn.UseVisualStyleBackColor = true;
			this._画面サイズBtn.Click += new System.EventHandler(this._画面サイズBtn_Click);
			// 
			// _タイリングChk
			// 
			this._タイリングChk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._タイリングChk.AutoSize = true;
			this._タイリングChk.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this._タイリングChk.Location = new System.Drawing.Point(510, 78);
			this._タイリングChk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this._タイリングChk.Name = "_タイリングChk";
			this._タイリングChk.Size = new System.Drawing.Size(93, 24);
			this._タイリングChk.TabIndex = 1;
			this._タイリングChk.Text = "タイリング";
			this._タイリングChk.UseVisualStyleBackColor = true;
			// 
			// EditTextBtn
			// 
			this.EditTextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.EditTextBtn.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.EditTextBtn.Location = new System.Drawing.Point(7, 28);
			this.EditTextBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.EditTextBtn.Name = "EditTextBtn";
			this.EditTextBtn.Size = new System.Drawing.Size(136, 27);
			this.EditTextBtn.TabIndex = 0;
			this.EditTextBtn.Text = "テキスト";
			this.EditTextBtn.UseVisualStyleBackColor = true;
			this.EditTextBtn.Click += new System.EventHandler(this.EditTextBtn_Click);
			// 
			// _テキストサイズBtn
			// 
			this._テキストサイズBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._テキストサイズBtn.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this._テキストサイズBtn.Location = new System.Drawing.Point(7, 287);
			this._テキストサイズBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this._テキストサイズBtn.Name = "_テキストサイズBtn";
			this._テキストサイズBtn.Size = new System.Drawing.Size(284, 27);
			this._テキストサイズBtn.TabIndex = 10;
			this._テキストサイズBtn.Text = "テキストサイズに合わせて『閉じる』";
			this._テキストサイズBtn.UseVisualStyleBackColor = true;
			this._テキストサイズBtn.Click += new System.EventHandler(this._テキストサイズBtn_Click);
			// 
			// これをデフォルトにするBtn
			// 
			this.これをデフォルトにするBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.これをデフォルトにするBtn.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.これをデフォルトにするBtn.Location = new System.Drawing.Point(12, 530);
			this.これをデフォルトにするBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.これをデフォルトにするBtn.Name = "これをデフォルトにするBtn";
			this.これをデフォルトにするBtn.Size = new System.Drawing.Size(298, 27);
			this.これをデフォルトにするBtn.TabIndex = 4;
			this.これをデフォルトにするBtn.Text = "この設定をデフォルトにする";
			this.これをデフォルトにするBtn.UseVisualStyleBackColor = true;
			this.これをデフォルトにするBtn.Click += new System.EventHandler(this.これをデフォルトにするBtn_Click);
			// 
			// 色Btn
			// 
			this.色Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.色Btn.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.色Btn.Location = new System.Drawing.Point(7, 176);
			this.色Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.色Btn.Name = "色Btn";
			this.色Btn.Size = new System.Drawing.Size(136, 27);
			this.色Btn.TabIndex = 6;
			this.色Btn.Text = "色Dlg";
			this.色Btn.UseVisualStyleBackColor = true;
			this.色Btn.Click += new System.EventHandler(this.色Btn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this._テキストサイズBtn);
			this.groupBox1.Controls.Add(this._画像サイズBtn);
			this.groupBox1.Controls.Add(this._画面サイズBtn);
			this.groupBox1.Controls.Add(this.XPos);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.YPos);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.WinW);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.WinH);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(298, 350);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "位置とサイズ";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.WinColorR);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.色Btn);
			this.groupBox2.Controls.Add(this.WinColorG);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.WinColorB);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(316, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(150, 250);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "色";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.EditTextBtn);
			this.groupBox3.Location = new System.Drawing.Point(472, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(150, 80);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "テキスト";
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.ImageBtn);
			this.groupBox4.Controls.Add(this._タイリングChk);
			this.groupBox4.Location = new System.Drawing.Point(12, 368);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(610, 127);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "画像";
			// 
			// PosColorWin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 571);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.これをデフォルトにするBtn);
			this.Controls.Add(this.ResetBtn);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PosColorWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "位置とサイズと色と画像とテキストの変更";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PosWin_FormClosed);
			this.Load += new System.EventHandler(this.PosColorWin_Load);
			this.Shown += new System.EventHandler(this.PosColorWin_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox XPos;
		private System.Windows.Forms.TextBox YPos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox WinH;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox WinW;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox WinColorR;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox WinColorG;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox WinColorB;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button ResetBtn;
		private System.Windows.Forms.Button ImageBtn;
		private System.Windows.Forms.Button _画像サイズBtn;
		private System.Windows.Forms.Button _画面サイズBtn;
		private System.Windows.Forms.CheckBox _タイリングChk;
		private System.Windows.Forms.Button EditTextBtn;
		private System.Windows.Forms.Button _テキストサイズBtn;
		private System.Windows.Forms.Button これをデフォルトにするBtn;
		private System.Windows.Forms.Button 色Btn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
	}
}
