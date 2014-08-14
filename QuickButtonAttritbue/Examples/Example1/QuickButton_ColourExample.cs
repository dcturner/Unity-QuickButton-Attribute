using UnityEngine;
using System.Collections;

public class QuickButton_ColourExample : MonoBehaviour {


		#if UNITY_EDITOR
		[QuickButton ("null", "null", "Dark", QuickButtonColour.dark)]
		public bool _ignoreThis1;

		[QuickButton ("null", "null", "Medium", QuickButtonColour.medium)]
		public bool _ignoreThis2;

		[QuickButton ("null", "null", "Light", QuickButtonColour.light)]
		public bool _ignoreThis3;

		[QuickButton ("null", "null", "Red", QuickButtonColour.red)]
		public bool _ignoreThis4;

		[QuickButton ("null", "null", "Orange", QuickButtonColour.orange)]
		public bool _ignoreThis5;

		[QuickButton ("null", "null", "Yellow", QuickButtonColour.yellow)]
		public bool _ignoreThis6;

		[QuickButton ("null", "null", "Green", QuickButtonColour.green)]
		public bool _ignoreThis7;

		[QuickButton ("null", "null", "White", QuickButtonColour.white)]
		public bool _ignoreThis8;
		#endif
}
