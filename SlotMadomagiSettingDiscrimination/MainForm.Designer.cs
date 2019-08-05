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
			this.ExpectionPage = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.StartGameCountUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CurrentGameCountUpDown)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.WeakCherryPage.SuspendLayout();
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
			// ExpectionPage
			// 
			this.ExpectionPage.BackColor = System.Drawing.Color.Transparent;
			this.ExpectionPage.Location = new System.Drawing.Point(4, 25);
			this.ExpectionPage.Name = "ExpectionPage";
			this.ExpectionPage.Padding = new System.Windows.Forms.Padding(3);
			this.ExpectionPage.Size = new System.Drawing.Size(768, 372);
			this.ExpectionPage.TabIndex = 1;
			this.ExpectionPage.Text = "期待値";
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
	}
}

