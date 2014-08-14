#if UNITY_EDITOR
using UnityEngine;
using System.Collections;
using System;
using UnityEditor;

[Serializable]
public class QuickButtonAttribute : PropertyAttribute
{
		public string objName, targetMethod, label;
		public QuickButtonColour col;


		/// <summary>
		/// Add a QuickButton, used to call a method from the inspector panel.
		/// </summary>
		/// <param name="_gameObjectName">The exact name of the gameObject you are targetting. It is CASE SENSITIVE</param>
		/// <param name="_targetMethod">The exact name of the method you wish to call. Again, CASE SENSITIVE</param>
		/// <param name="_label">Text that appears on the button</param>
		/// <param name="_col">Optional: Choose one of the preset QuickButtonColour values to further customise your QuickButton</param>
		public QuickButtonAttribute (string _gameObjectName, string _targetMethod, String _label, QuickButtonColour _col = QuickButtonColour.dark)
		{
				objName = _gameObjectName;
				targetMethod = _targetMethod;
				label = _label;
				col = _col;
		}
}

[CustomPropertyDrawer (typeof(QuickButtonAttribute))]
public class QuickButtonDrawer : PropertyDrawer
{
		private GUIStyle buttonStyle = new GUIStyle (GUI.skin.button);

		QuickButtonAttribute hm {
				get {
						return attribute as QuickButtonAttribute;
				}
		}

		[ExecuteInEditMode]
		public override void OnGUI (Rect position, SerializedProperty property, GUIContent label)
		{
				setButtonColour ();
				if (GUI.Button (position, hm.label, buttonStyle)) {

						try {
								GameObject.Find (hm.objName).SendMessage (hm.targetMethod);
								
						} catch (Exception ex) {
								Debug.LogWarning ("QuickButton cannot find object: '" + hm.objName + "' -->    error: " + ex.Message);
						}
				}
		}

		void setButtonColour ()
		{
				Color guiCol;
				Color txtCol;


				switch (hm.col) {
				default:
						guiCol = Color.white;
						txtCol = Color.black;
						break;

				case QuickButtonColour.dark:
						guiCol = new Color (0.275f, 0.342f, 0.369f);
						txtCol = new Color (0.695f, 0.866f, 0.935f);
						break;

				case QuickButtonColour.medium:
						guiCol = new Color (0.410f, 0.511f, 0.552f);
						txtCol = new Color (0.157f, 0.196f, 0.211f);
						break;

				case QuickButtonColour.light:
						guiCol = new Color (0.584f, 0.727f, 0.786f);
						txtCol = new Color (0.157f, 0.196f, 0.211f);
						break;

				case QuickButtonColour.red:
						guiCol = new Color (0.802f, 0.145f, 0.132f);
						txtCol = new Color (1.000f, 0.773f, 0.766f);
						break;

				case QuickButtonColour.orange:
						guiCol = new Color (1.000f, 0.426f, 0.186f);
						txtCol = new Color (1.000f, 0.854f, 0.792f);
						break;

				case QuickButtonColour.yellow:
						guiCol = new Color (1.000f, 0.738f, 0.235f);
						txtCol = new Color (1.000f, 0.936f, 0.810f);
						break;

				case QuickButtonColour.green:
						guiCol = new Color (0.417f, 0.828f, 0.115f);
						txtCol = new Color (0.879f, 1.000f, 0.786f);
						break;
				}

				buttonStyle.normal.textColor = txtCol;
				GUI.backgroundColor = guiCol;
		}
}





public enum QuickButtonColour
{
		dark,
		medium,
		light,
		red,
		orange,
		yellow,
		green,
		white
}

#endif

