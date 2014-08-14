using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

		[ExecuteInEditMode]
		public void rotateThisCube ()
		{
				transform.Rotate(new Vector3(0,0,Random.Range(0,360)));
				Debug.Log ("rotating");
		}
}
