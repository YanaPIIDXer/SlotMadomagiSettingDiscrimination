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
	}
}
