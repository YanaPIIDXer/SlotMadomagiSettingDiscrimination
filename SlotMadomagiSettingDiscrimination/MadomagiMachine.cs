using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlotSettingDiscriminationFramework;

namespace SlotMadomagiSettingDiscrimination
{
	/// <summary>
	/// まどマギの台
	/// </summary>
	public class MadomagiMachine : Machine
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MadomagiMachine()
		{
			AddElement(new WeakCherryElement());
		}
	}
}
