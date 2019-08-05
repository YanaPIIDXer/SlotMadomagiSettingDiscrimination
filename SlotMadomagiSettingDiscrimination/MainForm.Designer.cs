namespace SlotMadomagiSettingDiscrimination
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.label1 = new System.Windows.Forms.Label();
			this.StartGameCountUpDown = new System.Windows.Forms.NumericUpDown();
			this.CurrentGameCountUpDown = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.WeakCherryPage = new System.Windows.Forms.TabPage();
			this.WeakCherryProbabilityLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.WeakCherryCountLabel = new System.Windows.Forms.Label();
			this.WeakCherryIncrementButton = new System.Windows.Forms.Button();
			this.WeakCherryDecrementButton = new System.Windows.Forms.Button();
			this.MagicalChallengePage = new System.Windows.Forms.TabPage();
			this.MagicalChallengeRateLabel = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.MagicalChallengeCountLabel = new System.Windows.Forms.Label();
			this.MagicalChallengeIncrementButton = new System.Windows.Forms.Button();
			this.MagicalChallengeDecrementButton = new System.Windows.Forms.Button();
			this.WaterMelonCountLabel = new System.Windows.Forms.Label();
			this.WaterMelonIncrementButton = new System.Windows.Forms.Button();
			this.WaterMelonDecrementButton = new System.Windows.Forms.Button();
			this.ExpectionPage = new System.Windows.Forms.TabPage();
			this.Setting6ExpectionLabel = new System.Windows.Forms.Label();
			this.Setting6ExpectionBar = new System.Windows.Forms.ProgressBar();
			this.Setting5ExpectionLabel = new System.Windows.Forms.Label();
			this.Setting5ExpectionBar = new System.Windows.Forms.ProgressBar();
			this.Setting4ExpectionLabel = new System.Windows.Forms.Label();
			this.Setting4ExpectionBar = new System.Windows.Forms.ProgressBar();
			this.Setting3ExpectionLabel = new System.Windows.Forms.Label();
			this.Setting3ExpectionBar = new System.Windows.Forms.ProgressBar();
			this.Setting2ExpectionLabel = new System.Windows.Forms.Label();
			this.Setting2ExpectionBar = new System.Windows.Forms.ProgressBar();
			this.Setting1ExpectionLabel = new System.Windows.Forms.Label();
			this.Setting1ExpectionBar = new System.Windows.Forms.ProgressBar();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.StartGameCountUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentGameCountUpDown)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.WeakCherryPage.SuspendLayout();
			this.MagicalChallengePage.SuspendLayout();
			this.ExpectionPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(84, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "開始ゲーム数";
			// 
			// StartGameCountUpDown
			// 
			this.StartGameCountUpDown.Location = new System.Drawing.Point(203, 9);
			this.StartGameCountUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.StartGameCountUpDown.Name = "StartGameCountUpDown";
			this.StartGameCountUpDown.Size = new System.Drawing.Size(120, 22);
			this.StartGameCountUpDown.TabIndex = 1;
			this.StartGameCountUpDown.ValueChanged += new System.EventHandler(this.StartGameCountUpDown_ValueChanged);
			// 
			// CurrentGameCountUpDown
			// 
			this.CurrentGameCountUpDown.Location = new System.Drawing.Point(528, 11);
			this.CurrentGameCountUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.CurrentGameCountUpDown.Name = "CurrentGameCountUpDown";
			this.CurrentGameCountUpDown.Size = new System.Drawing.Size(120, 22);
			this.CurrentGameCountUpDown.TabIndex = 3;
			this.CurrentGameCountUpDown.ValueChanged += new System.EventHandler(this.CurrentGameCountUpDown_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(409, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "現在ゲーム数";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.WeakCherryPage);
			this.tabControl1.Controls.Add(this.MagicalChallengePage);
			this.tabControl1.Controls.Add(this.ExpectionPage);
			this.tabControl1.Location = new System.Drawing.Point(12, 37);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 401);
			this.tabControl1.TabIndex = 4;
			// 
			// WeakCherryPage
			// 
			this.WeakCherryPage.BackColor = System.Drawing.Color.Transparent;
			this.WeakCherryPage.Controls.Add(this.WeakCherryProbabilityLabel);
			this.WeakCherryPage.Controls.Add(this.label4);
			this.WeakCherryPage.Controls.Add(this.label3);
			this.WeakCherryPage.Controls.Add(this.WeakCherryCountLabel);
			this.WeakCherryPage.Controls.Add(this.WeakCherryIncrementButton);
			this.WeakCherryPage.Controls.Add(this.WeakCherryDecrementButton);
			this.WeakCherryPage.Location = new System.Drawing.Point(4, 25);
			this.WeakCherryPage.Name = "WeakCherryPage";
			this.WeakCherryPage.Padding = new System.Windows.Forms.Padding(3);
			this.WeakCherryPage.Size = new System.Drawing.Size(768, 372);
			this.WeakCherryPage.TabIndex = 0;
			this.WeakCherryPage.Text = "弱チェリー";
			// 
			// WeakCherryProbabilityLabel
			// 
			this.WeakCherryProbabilityLabel.AutoSize = true;
			this.WeakCherryProbabilityLabel.Location = new System.Drawing.Point(310, 277);
			this.WeakCherryProbabilityLabel.Name = "WeakCherryProbabilityLabel";
			this.WeakCherryProbabilityLabel.Size = new System.Drawing.Size(31, 15);
			this.WeakCherryProbabilityLabel.TabIndex = 5;
			this.WeakCherryProbabilityLabel.Text = "1/0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(282, 235);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "弱チェリー確率";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(282, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "弱チェリー回数";
			// 
			// WeakCherryCountLabel
			// 
			this.WeakCherryCountLabel.AutoSize = true;
			this.WeakCherryCountLabel.Location = new System.Drawing.Point(318, 145);
			this.WeakCherryCountLabel.Name = "WeakCherryCountLabel";
			this.WeakCherryCountLabel.Size = new System.Drawing.Size(15, 15);
			this.WeakCherryCountLabel.TabIndex = 2;
			this.WeakCherryCountLabel.Text = "0";
			// 
			// WeakCherryIncrementButton
			// 
			this.WeakCherryIncrementButton.Location = new System.Drawing.Point(496, 141);
			this.WeakCherryIncrementButton.Name = "WeakCherryIncrementButton";
			this.WeakCherryIncrementButton.Size = new System.Drawing.Size(32, 23);
			this.WeakCherryIncrementButton.TabIndex = 1;
			this.WeakCherryIncrementButton.Text = "+";
			this.WeakCherryIncrementButton.UseVisualStyleBackColor = true;
			this.WeakCherryIncrementButton.Click += new System.EventHandler(this.WeakCherryIncrementButton_Click);
			// 
			// WeakCherryDecrementButton
			// 
			this.WeakCherryDecrementButton.Location = new System.Drawing.Point(158, 141);
			this.WeakCherryDecrementButton.Name = "WeakCherryDecrementButton";
			this.WeakCherryDecrementButton.Size = new System.Drawing.Size(32, 23);
			this.WeakCherryDecrementButton.TabIndex = 0;
			this.WeakCherryDecrementButton.Text = "-";
			this.WeakCherryDecrementButton.UseVisualStyleBackColor = true;
			this.WeakCherryDecrementButton.Click += new System.EventHandler(this.WeakCherryDecrementButton_Click);
			// 
			// MagicalChallengePage
			// 
			this.MagicalChallengePage.BackColor = System.Drawing.Color.Transparent;
			this.MagicalChallengePage.Controls.Add(this.MagicalChallengeRateLabel);
			this.MagicalChallengePage.Controls.Add(this.label15);
			this.MagicalChallengePage.Controls.Add(this.label14);
			this.MagicalChallengePage.Controls.Add(this.label13);
			this.MagicalChallengePage.Controls.Add(this.MagicalChallengeCountLabel);
			this.MagicalChallengePage.Controls.Add(this.MagicalChallengeIncrementButton);
			this.MagicalChallengePage.Controls.Add(this.MagicalChallengeDecrementButton);
			this.MagicalChallengePage.Controls.Add(this.WaterMelonCountLabel);
			this.MagicalChallengePage.Controls.Add(this.WaterMelonIncrementButton);
			this.MagicalChallengePage.Controls.Add(this.WaterMelonDecrementButton);
			this.MagicalChallengePage.Location = new System.Drawing.Point(4, 25);
			this.MagicalChallengePage.Name = "MagicalChallengePage";
			this.MagicalChallengePage.Size = new System.Drawing.Size(768, 372);
			this.MagicalChallengePage.TabIndex = 2;
			this.MagicalChallengePage.Text = "マジカルチャレンジ";
			// 
			// MagicalChallengeRateLabel
			// 
			this.MagicalChallengeRateLabel.AutoSize = true;
			this.MagicalChallengeRateLabel.Location = new System.Drawing.Point(307, 322);
			this.MagicalChallengeRateLabel.Name = "MagicalChallengeRateLabel";
			this.MagicalChallengeRateLabel.Size = new System.Drawing.Size(23, 15);
			this.MagicalChallengeRateLabel.TabIndex = 12;
			this.MagicalChallengeRateLabel.Text = "0%";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(253, 276);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(169, 15);
			this.label15.TabIndex = 11;
			this.label15.Text = "マジカルチャレンジ当選確率";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(253, 173);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(169, 15);
			this.label14.TabIndex = 10;
			this.label14.Text = "マジカルチャレンジ当選回数";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(295, 63);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(70, 15);
			this.label13.TabIndex = 9;
			this.label13.Text = "スイカ回数";
			// 
			// MagicalChallengeCountLabel
			// 
			this.MagicalChallengeCountLabel.AutoSize = true;
			this.MagicalChallengeCountLabel.Location = new System.Drawing.Point(315, 209);
			this.MagicalChallengeCountLabel.Name = "MagicalChallengeCountLabel";
			this.MagicalChallengeCountLabel.Size = new System.Drawing.Size(15, 15);
			this.MagicalChallengeCountLabel.TabIndex = 8;
			this.MagicalChallengeCountLabel.Text = "0";
			// 
			// MagicalChallengeIncrementButton
			// 
			this.MagicalChallengeIncrementButton.Location = new System.Drawing.Point(493, 205);
			this.MagicalChallengeIncrementButton.Name = "MagicalChallengeIncrementButton";
			this.MagicalChallengeIncrementButton.Size = new System.Drawing.Size(32, 23);
			this.MagicalChallengeIncrementButton.TabIndex = 7;
			this.MagicalChallengeIncrementButton.Text = "+";
			this.MagicalChallengeIncrementButton.UseVisualStyleBackColor = true;
			this.MagicalChallengeIncrementButton.Click += new System.EventHandler(this.MagicalChallengeIncrementButton_Click);
			// 
			// MagicalChallengeDecrementButton
			// 
			this.MagicalChallengeDecrementButton.Location = new System.Drawing.Point(155, 205);
			this.MagicalChallengeDecrementButton.Name = "MagicalChallengeDecrementButton";
			this.MagicalChallengeDecrementButton.Size = new System.Drawing.Size(32, 23);
			this.MagicalChallengeDecrementButton.TabIndex = 6;
			this.MagicalChallengeDecrementButton.Text = "-";
			this.MagicalChallengeDecrementButton.UseVisualStyleBackColor = true;
			this.MagicalChallengeDecrementButton.Click += new System.EventHandler(this.MagicalChallengeDecrementButton_Click);
			// 
			// WaterMelonCountLabel
			// 
			this.WaterMelonCountLabel.AutoSize = true;
			this.WaterMelonCountLabel.Location = new System.Drawing.Point(315, 112);
			this.WaterMelonCountLabel.Name = "WaterMelonCountLabel";
			this.WaterMelonCountLabel.Size = new System.Drawing.Size(15, 15);
			this.WaterMelonCountLabel.TabIndex = 5;
			this.WaterMelonCountLabel.Text = "0";
			// 
			// WaterMelonIncrementButton
			// 
			this.WaterMelonIncrementButton.Location = new System.Drawing.Point(493, 108);
			this.WaterMelonIncrementButton.Name = "WaterMelonIncrementButton";
			this.WaterMelonIncrementButton.Size = new System.Drawing.Size(32, 23);
			this.WaterMelonIncrementButton.TabIndex = 4;
			this.WaterMelonIncrementButton.Text = "+";
			this.WaterMelonIncrementButton.UseVisualStyleBackColor = true;
			this.WaterMelonIncrementButton.Click += new System.EventHandler(this.WaterMelonIncrementButton_Click);
			// 
			// WaterMelonDecrementButton
			// 
			this.WaterMelonDecrementButton.Location = new System.Drawing.Point(155, 108);
			this.WaterMelonDecrementButton.Name = "WaterMelonDecrementButton";
			this.WaterMelonDecrementButton.Size = new System.Drawing.Size(32, 23);
			this.WaterMelonDecrementButton.TabIndex = 3;
			this.WaterMelonDecrementButton.Text = "-";
			this.WaterMelonDecrementButton.UseVisualStyleBackColor = true;
			this.WaterMelonDecrementButton.Click += new System.EventHandler(this.WaterMelonDecrementButton_Click);
			// 
			// ExpectionPage
			// 
			this.ExpectionPage.BackColor = System.Drawing.Color.Transparent;
			this.ExpectionPage.Controls.Add(this.Setting6ExpectionLabel);
			this.ExpectionPage.Controls.Add(this.Setting6ExpectionBar);
			this.ExpectionPage.Controls.Add(this.Setting5ExpectionLabel);
			this.ExpectionPage.Controls.Add(this.Setting5ExpectionBar);
			this.ExpectionPage.Controls.Add(this.Setting4ExpectionLabel);
			this.ExpectionPage.Controls.Add(this.Setting4ExpectionBar);
			this.ExpectionPage.Controls.Add(this.Setting3ExpectionLabel);
			this.ExpectionPage.Controls.Add(this.Setting3ExpectionBar);
			this.ExpectionPage.Controls.Add(this.Setting2ExpectionLabel);
			this.ExpectionPage.Controls.Add(this.Setting2ExpectionBar);
			this.ExpectionPage.Controls.Add(this.Setting1ExpectionLabel);
			this.ExpectionPage.Controls.Add(this.Setting1ExpectionBar);
			this.ExpectionPage.Controls.Add(this.label8);
			this.ExpectionPage.Controls.Add(this.label9);
			this.ExpectionPage.Controls.Add(this.label10);
			this.ExpectionPage.Controls.Add(this.label7);
			this.ExpectionPage.Controls.Add(this.label6);
			this.ExpectionPage.Controls.Add(this.label5);
			this.ExpectionPage.Location = new System.Drawing.Point(4, 25);
			this.ExpectionPage.Name = "ExpectionPage";
			this.ExpectionPage.Padding = new System.Windows.Forms.Padding(3);
			this.ExpectionPage.Size = new System.Drawing.Size(768, 372);
			this.ExpectionPage.TabIndex = 1;
			this.ExpectionPage.Text = "期待値";
			// 
			// Setting6ExpectionLabel
			// 
			this.Setting6ExpectionLabel.AutoSize = true;
			this.Setting6ExpectionLabel.Location = new System.Drawing.Point(630, 307);
			this.Setting6ExpectionLabel.Name = "Setting6ExpectionLabel";
			this.Setting6ExpectionLabel.Size = new System.Drawing.Size(31, 15);
			this.Setting6ExpectionLabel.TabIndex = 17;
			this.Setting6ExpectionLabel.Text = "20%";
			// 
			// Setting6ExpectionBar
			// 
			this.Setting6ExpectionBar.Location = new System.Drawing.Point(207, 299);
			this.Setting6ExpectionBar.Name = "Setting6ExpectionBar";
			this.Setting6ExpectionBar.Size = new System.Drawing.Size(370, 23);
			this.Setting6ExpectionBar.TabIndex = 16;
			this.Setting6ExpectionBar.Value = 20;
			// 
			// Setting5ExpectionLabel
			// 
			this.Setting5ExpectionLabel.AutoSize = true;
			this.Setting5ExpectionLabel.Location = new System.Drawing.Point(630, 258);
			this.Setting5ExpectionLabel.Name = "Setting5ExpectionLabel";
			this.Setting5ExpectionLabel.Size = new System.Drawing.Size(31, 15);
			this.Setting5ExpectionLabel.TabIndex = 15;
			this.Setting5ExpectionLabel.Text = "20%";
			// 
			// Setting5ExpectionBar
			// 
			this.Setting5ExpectionBar.Location = new System.Drawing.Point(207, 250);
			this.Setting5ExpectionBar.Name = "Setting5ExpectionBar";
			this.Setting5ExpectionBar.Size = new System.Drawing.Size(370, 23);
			this.Setting5ExpectionBar.TabIndex = 14;
			this.Setting5ExpectionBar.Value = 20;
			// 
			// Setting4ExpectionLabel
			// 
			this.Setting4ExpectionLabel.AutoSize = true;
			this.Setting4ExpectionLabel.Location = new System.Drawing.Point(630, 211);
			this.Setting4ExpectionLabel.Name = "Setting4ExpectionLabel";
			this.Setting4ExpectionLabel.Size = new System.Drawing.Size(31, 15);
			this.Setting4ExpectionLabel.TabIndex = 13;
			this.Setting4ExpectionLabel.Text = "20%";
			// 
			// Setting4ExpectionBar
			// 
			this.Setting4ExpectionBar.Location = new System.Drawing.Point(207, 203);
			this.Setting4ExpectionBar.Name = "Setting4ExpectionBar";
			this.Setting4ExpectionBar.Size = new System.Drawing.Size(370, 23);
			this.Setting4ExpectionBar.TabIndex = 12;
			this.Setting4ExpectionBar.Value = 20;
			// 
			// Setting3ExpectionLabel
			// 
			this.Setting3ExpectionLabel.AutoSize = true;
			this.Setting3ExpectionLabel.Location = new System.Drawing.Point(630, 167);
			this.Setting3ExpectionLabel.Name = "Setting3ExpectionLabel";
			this.Setting3ExpectionLabel.Size = new System.Drawing.Size(31, 15);
			this.Setting3ExpectionLabel.TabIndex = 11;
			this.Setting3ExpectionLabel.Text = "20%";
			// 
			// Setting3ExpectionBar
			// 
			this.Setting3ExpectionBar.Location = new System.Drawing.Point(207, 159);
			this.Setting3ExpectionBar.Name = "Setting3ExpectionBar";
			this.Setting3ExpectionBar.Size = new System.Drawing.Size(370, 23);
			this.Setting3ExpectionBar.TabIndex = 10;
			this.Setting3ExpectionBar.Value = 20;
			// 
			// Setting2ExpectionLabel
			// 
			this.Setting2ExpectionLabel.AutoSize = true;
			this.Setting2ExpectionLabel.Location = new System.Drawing.Point(630, 118);
			this.Setting2ExpectionLabel.Name = "Setting2ExpectionLabel";
			this.Setting2ExpectionLabel.Size = new System.Drawing.Size(31, 15);
			this.Setting2ExpectionLabel.TabIndex = 9;
			this.Setting2ExpectionLabel.Text = "20%";
			// 
			// Setting2ExpectionBar
			// 
			this.Setting2ExpectionBar.Location = new System.Drawing.Point(207, 110);
			this.Setting2ExpectionBar.Name = "Setting2ExpectionBar";
			this.Setting2ExpectionBar.Size = new System.Drawing.Size(370, 23);
			this.Setting2ExpectionBar.TabIndex = 8;
			this.Setting2ExpectionBar.Value = 20;
			// 
			// Setting1ExpectionLabel
			// 
			this.Setting1ExpectionLabel.AutoSize = true;
			this.Setting1ExpectionLabel.Location = new System.Drawing.Point(630, 71);
			this.Setting1ExpectionLabel.Name = "Setting1ExpectionLabel";
			this.Setting1ExpectionLabel.Size = new System.Drawing.Size(31, 15);
			this.Setting1ExpectionLabel.TabIndex = 7;
			this.Setting1ExpectionLabel.Text = "20%";
			// 
			// Setting1ExpectionBar
			// 
			this.Setting1ExpectionBar.Location = new System.Drawing.Point(207, 63);
			this.Setting1ExpectionBar.Name = "Setting1ExpectionBar";
			this.Setting1ExpectionBar.Size = new System.Drawing.Size(370, 23);
			this.Setting1ExpectionBar.TabIndex = 6;
			this.Setting1ExpectionBar.Value = 20;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(95, 299);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 15);
			this.label8.TabIndex = 5;
			this.label8.Text = "設定６";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(95, 250);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 15);
			this.label9.TabIndex = 4;
			this.label9.Text = "設定５";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(95, 203);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 15);
			this.label10.TabIndex = 3;
			this.label10.Text = "設定４";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(95, 159);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 15);
			this.label7.TabIndex = 2;
			this.label7.Text = "設定３";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(95, 110);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 15);
			this.label6.TabIndex = 1;
			this.label6.Text = "設定２";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(95, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "設定１";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.CurrentGameCountUpDown);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.StartGameCountUpDown);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "初代まどマギ設定判別ツール";
			((System.ComponentModel.ISupportInitialize)(this.StartGameCountUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentGameCountUpDown)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.WeakCherryPage.ResumeLayout(false);
			this.WeakCherryPage.PerformLayout();
			this.MagicalChallengePage.ResumeLayout(false);
			this.MagicalChallengePage.PerformLayout();
			this.ExpectionPage.ResumeLayout(false);
			this.ExpectionPage.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown StartGameCountUpDown;
		private System.Windows.Forms.NumericUpDown CurrentGameCountUpDown;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage WeakCherryPage;
		private System.Windows.Forms.TabPage ExpectionPage;
		private System.Windows.Forms.Label WeakCherryCountLabel;
		private System.Windows.Forms.Button WeakCherryIncrementButton;
		private System.Windows.Forms.Button WeakCherryDecrementButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label WeakCherryProbabilityLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label Setting1ExpectionLabel;
		private System.Windows.Forms.ProgressBar Setting1ExpectionBar;
		private System.Windows.Forms.Label Setting6ExpectionLabel;
		private System.Windows.Forms.ProgressBar Setting6ExpectionBar;
		private System.Windows.Forms.Label Setting5ExpectionLabel;
		private System.Windows.Forms.ProgressBar Setting5ExpectionBar;
		private System.Windows.Forms.Label Setting4ExpectionLabel;
		private System.Windows.Forms.ProgressBar Setting4ExpectionBar;
		private System.Windows.Forms.Label Setting3ExpectionLabel;
		private System.Windows.Forms.ProgressBar Setting3ExpectionBar;
		private System.Windows.Forms.Label Setting2ExpectionLabel;
		private System.Windows.Forms.ProgressBar Setting2ExpectionBar;
		private System.Windows.Forms.TabPage MagicalChallengePage;
		private System.Windows.Forms.Label MagicalChallengeCountLabel;
		private System.Windows.Forms.Button MagicalChallengeIncrementButton;
		private System.Windows.Forms.Button MagicalChallengeDecrementButton;
		private System.Windows.Forms.Label WaterMelonCountLabel;
		private System.Windows.Forms.Button WaterMelonIncrementButton;
		private System.Windows.Forms.Button WaterMelonDecrementButton;
		private System.Windows.Forms.Label MagicalChallengeRateLabel;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
	}
}

