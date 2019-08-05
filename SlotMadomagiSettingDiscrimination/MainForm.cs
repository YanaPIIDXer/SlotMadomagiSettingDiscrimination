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
	}
}
