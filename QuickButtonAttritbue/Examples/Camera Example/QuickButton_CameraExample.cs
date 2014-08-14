using UnityEngine;
using System.Collections;

public class QuickButton_CameraExample : MonoBehaviour
{
		public enum CameraPosition
		{
				front,
				perspective,
				near,
				far}

		;

		public CameraPosition cameraPosition;



		#if UNITY_EDITOR
		[QuickButton ("Main Camera", "moveCamera", "Move Camera", QuickButtonColour.red)]
		public bool _ignore;
		#endif

		[ExecuteInEditMode]
		public void moveCamera ()
		{
				switch (cameraPosition) {

				case CameraPosition.front:
						move (10,3,0,2,-90,0);
						break;
				case CameraPosition.perspective:
						move (8, 7, 2, 35, -110, 0);
						break;
				case CameraPosition.near:
						move (5,1,-0.5f, -25, -90,0);
						break;
				case CameraPosition.far:
						move (20,7,-0.5f,16,-90,0);
						break;

				}
		}

		[ExecuteInEditMode]
		private void move (float posX, float posY, float posZ, float rotX, float rotY, float rotZ)
		{
				transform.localPosition = new Vector3 (posX, posY, posZ);
				transform.localEulerAngles = new Vector3 (rotX, rotY, rotZ);
		}
}
