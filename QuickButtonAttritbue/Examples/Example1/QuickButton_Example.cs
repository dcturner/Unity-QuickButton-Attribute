using UnityEngine;
using System.Collections;

public class QuickButton_Example1 : MonoBehaviour
{
		#if UNITY_EDITOR

		[QuickButton ("Cube1", "rotateThisCube", "Rotate Cube 1", QuickButtonColour.red)]
		public bool _ignoreThis1 = false;

		[QuickButton ("Cube2", "rotateThisCube", "Rotate Cube 2", QuickButtonColour.yellow)]
		public bool _ignoreThis2 = false;

		[QuickButton ("Cube3", "rotateThisCube", "Rotate Cube 3", QuickButtonColour.green)]
		public bool _ignoreThis3 = false;

		[QuickButton ("QuickButton examples", "rotateAllCubes", "Rotate ALL cubes", QuickButtonColour.dark)]
		public bool _ignoreThis4 = false;


		[ExecuteInEditMode]
		public void rotateAllCubes ()
		{
				GameObject.Find ("Cube1").SendMessage ("rotateThisCube");
				GameObject.Find ("Cube2").SendMessage ("rotateThisCube");
				GameObject.Find ("Cube3").SendMessage ("rotateThisCube");
		}
		#endif
}
