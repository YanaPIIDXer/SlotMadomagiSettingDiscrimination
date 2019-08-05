using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMadomagiSettingDiscrimination
{
	/// <summary>
	/// メインフォーム
	/// 弱チェリー確率関係。
	/// </summary>
	public partial class MainForm
	{
		/// <summary>
		/// 弱チェリー回数
		/// </summary>
		private int WeakCherryCount = 0;

		// 弱チェリー回数加算ボタンが押された。
		private void WeakCherryIncrementButton_Click(object sender, EventArgs e)
		{
			MachineInfo.GetElementAndUpdatePercentage(WeakCherryElement.ElementName, (Element) =>
			{
				var Elem = (WeakCherryElement)Element;
				Elem.Increment();
				WeakCherryCount = Elem.Count;
				UpdateWeakCherryLabels();
			});
		}

		// 弱チェリー回数減算ボタンが押された。
		private void WeakCherryDecrementButton_Click(object sender, EventArgs e)
		{
			MachineInfo.GetElementAndUpdatePercentage(WeakCherryElement.ElementName, (Element) =>
			{
				var Elem = (WeakCherryElement)Element;
				Elem.Decrement();
				WeakCherryCount = Elem.Count;
				UpdateWeakCherryLabels();
			});
		}

		/// <summary>
		/// 弱チェリー確率関係ラベル更新
		/// </summary>
		private void UpdateWeakCherryLabels()
		{
			WeakCherryCountLabel.Text = WeakCherryCount.ToString();

			if(MachineInfo.GameCount == 0)
			{
				WeakCherryProbabilityLabel.Text = "1/0";
				return;
			}
			WeakCherryProbabilityLabel.Text = string.Format("1/{0}", (float)MachineInfo.GameCount / WeakCherryCount);
		}
	}
}
