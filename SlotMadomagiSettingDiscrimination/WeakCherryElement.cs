using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlotSettingDiscriminationFramework;

namespace SlotMadomagiSettingDiscrimination
{
	/// <summary>
	/// 弱チェリー確率の要素
	/// </summary>
	class WeakCherryElement : IElement
	{
		/// <summary>
		/// 要素名
		/// </summary>
		public static readonly string ElementName = "WeakCherry";

		/// <summary>
		/// 設定毎の弱チェリー確率
		/// </summary>
		private static readonly float[] Probabilitys = { 109.23f, 102.4f, 96.38f, 91.02f, 86.23f, 81.92f };

		/// <summary>
		/// 要素名
		/// </summary>
		public string Name { get { return ElementName; } }

		/// <summary>
		/// カウント
		/// </summary>
		public int Count { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public WeakCherryElement()
		{
			Count = 0;
		}

		/// <summary>
		/// 増加
		/// </summary>
		public void Increment()
		{
			Count++;
		}

		/// <summary>
		/// 減算
		/// </summary>
		public void Decrement()
		{
			if(Count <= 0) { return; }
			Count--;
		}

		/// <summary>
		/// 設定期待値を取得
		/// </summary>
		/// <param name="GameCount">ゲーム数</param>
		/// <returns>設定期待値</returns>
		public float[] GetSettingExpection(int GameCount)
		{
			float[] BinomDists = new float[6];
			for(int i = 0; i < 6; i++)
			{
				BinomDists[i] = Util.CalcBinomDist((ulong) GameCount, (ulong) Count, Probabilitys[i]);
			}

			return Util.BinomDistToExpection(BinomDists);
		}
	}
}
