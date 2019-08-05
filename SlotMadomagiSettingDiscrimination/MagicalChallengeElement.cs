using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlotSettingDiscriminationFramework;

namespace SlotMadomagiSettingDiscrimination
{
	/// <summary>
	/// マジカルチャレンジ確率の要素
	/// </summary>
	public class MagicalChallengeElement : IElement
	{
		/// <summary>
		/// 要素名
		/// </summary>
		public static readonly string ElementName = "MagicalChallenge";

		/// <summary>
		/// 要素名
		/// </summary>
		public string Name { get { return ElementName; } }

		/// <summary>
		/// 設定毎の当選率
		/// </summary>
		public float[] WinningRates = { 0.2f, 0.208f, 0.222f, 0.238f, 0.27f, 0.3f };

		/// <summary>
		/// スイカ回数
		/// </summary>
		public int WaterMelonCount { get; private set; }

		/// <summary>
		/// 当選回数
		/// </summary>
		public int WinningCount { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MagicalChallengeElement()
		{
			WaterMelonCount = 0;
			WinningCount = 0;
		}

		/// <summary>
		/// スイカ加算
		/// </summary>
		public void IncrementWaterMelon()
		{
			WaterMelonCount++;
		}

		/// <summary>
		/// スイカ減算
		/// </summary>
		public void DecrementWaterMelon()
		{
			if(WaterMelonCount <= 0) { return; }
			WaterMelonCount--;
		}

		/// <summary>
		/// 当選回数加算
		/// </summary>
		public void IncrementWinningCount()
		{
			WinningCount++;
		}

		/// <summary>
		/// 当選回数減算
		/// </summary>
		public void DecrementWinningCount()
		{
			if(WinningCount <= 0) { return; }
			WinningCount--;
		}

		/// <summary>
		/// 期待値取得
		/// </summary>
		/// <param name="GameCount">ゲーム数</param>
		/// <returns>期待値</returns>
		public float[] GetSettingExpection(int GameCount)
		{
			float[] BinomDists = new float[6];
			for (int i = 0; i < 6; i++)
			{
				BinomDists[i] = Util.CalcBinomDist((ulong) WaterMelonCount, (ulong) WinningCount, WinningRates[i]);
			}

			return Util.BinomDistToExpection(BinomDists);
		}
	}
}
