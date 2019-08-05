using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMadomagiSettingDiscrimination
{
	/// <summary>
	/// メインフォーム
	/// マジカルチャレンジ関係
	/// </summary>
	public partial class MainForm
	{
		// スイカ加算ボタンが押された。
		private void WaterMelonIncrementButton_Click(object sender, EventArgs e)
		{
			MachineInfo.GetElementAndUpdatePercentage(MagicalChallengeElement.ElementName, (Element) =>
			{
				var Elem = (MagicalChallengeElement)Element;
				Elem.IncrementWaterMelon();
				UpdateMagicalChallengeLabels(Elem);
			});
		}

		// スイカ減算ボタンが押された。
		private void WaterMelonDecrementButton_Click(object sender, EventArgs e)
		{
			MachineInfo.GetElementAndUpdatePercentage(MagicalChallengeElement.ElementName, (Element) =>
			{
				var Elem = (MagicalChallengeElement)Element;
				Elem.DecrementWaterMelon();
				UpdateMagicalChallengeLabels(Elem);
			});
		}

		// マジカルチャレンジ当選回数加算ボタンが押された。
		private void MagicalChallengeIncrementButton_Click(object sender, EventArgs e)
		{
			MachineInfo.GetElementAndUpdatePercentage(MagicalChallengeElement.ElementName, (Element) =>
			{
				var Elem = (MagicalChallengeElement)Element;
				Elem.IncrementWinningCount();
				UpdateMagicalChallengeLabels(Elem);
			});
		}

		// マジカルチャレンジ当選回数減算ボタンが押された。
		private void MagicalChallengeDecrementButton_Click(object sender, EventArgs e)
		{
			MachineInfo.GetElementAndUpdatePercentage(MagicalChallengeElement.ElementName, (Element) =>
			{
				var Elem = (MagicalChallengeElement)Element;
				Elem.DecrementWinningCount();
				UpdateMagicalChallengeLabels(Elem);
			});
		}

		/// <summary>
		/// マジカルチャレンジ関係ラベル更新
		/// </summary>
		/// <param name="Element">要素</param>
		private void UpdateMagicalChallengeLabels(MagicalChallengeElement Element)
		{
			WaterMelonCountLabel.Text = Element.WaterMelonCount.ToString();
			MagicalChallengeCountLabel.Text = Element.WinningCount.ToString();
			MagicalChallengeRateLabel.Text = string.Format("{0}%", (float)Element.WinningCount / Element.WaterMelonCount * 100.0f);
		}
	}
}
