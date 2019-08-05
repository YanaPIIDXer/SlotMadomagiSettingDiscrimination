using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMadomagiSettingDiscrimination
{
	/// <summary>
	/// メインフォーム
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// 台情報
		/// </summary>
		private MadomagiMachine MachineInfo;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MainForm()
		{
			MachineInfo = new MadomagiMachine();
			MachineInfo.OnExpectionChanged = OnExpectionUpdated;
			InitializeComponent();
		}

		// 開始ゲーム数が変動した。
		private void StartGameCountUpDown_ValueChanged(object sender, EventArgs e)
		{
			// 現在ゲーム数が開始ゲーム数を超えないようにする。
			if(CurrentGameCountUpDown.Value < StartGameCountUpDown.Value)
			{
				CurrentGameCountUpDown.Value = StartGameCountUpDown.Value;
			}
			CurrentGameCountUpDown.Minimum = StartGameCountUpDown.Value;

			MachineInfo.StartGameCount = (int) StartGameCountUpDown.Value;
		}

		// 現在ゲーム数が変動した。
		private void CurrentGameCountUpDown_ValueChanged(object sender, EventArgs e)
		{
			MachineInfo.CurrentGameCount = (int)CurrentGameCountUpDown.Value;

			UpdateWeakCherryLabels();
		}

		/// <summary>
		/// 期待値更新時の処理
		/// </summary>
		private void OnExpectionUpdated()
		{
			UpdateExpectionControls(MachineInfo.GetExpection(1), Setting1ExpectionBar, Setting1ExpectionLabel);
			UpdateExpectionControls(MachineInfo.GetExpection(2), Setting2ExpectionBar, Setting2ExpectionLabel);
			UpdateExpectionControls(MachineInfo.GetExpection(3), Setting3ExpectionBar, Setting3ExpectionLabel);
			UpdateExpectionControls(MachineInfo.GetExpection(4), Setting4ExpectionBar, Setting4ExpectionLabel);
			UpdateExpectionControls(MachineInfo.GetExpection(5), Setting5ExpectionBar, Setting5ExpectionLabel);
			UpdateExpectionControls(MachineInfo.GetExpection(6), Setting6ExpectionBar, Setting6ExpectionLabel);
		}

		/// <summary>
		/// 期待値コントロールの更新
		/// </summary>
		/// <param name="Expection">期待値</param>
		/// <param name="ExpectionBar">期待値バー</param>
		/// <param name="ExpectionLabel">期待値ラベル</param>
		private void UpdateExpectionControls(float Expection, ProgressBar ExpectionBar, Label ExpectionLabel)
		{
			ExpectionBar.Value = (int)Expection;
			ExpectionLabel.Text = string.Format("{0}%", Expection);
		}
	}
}
