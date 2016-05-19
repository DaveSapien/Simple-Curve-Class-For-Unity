	using UnityEngine;
	using System.Collections;
	using UnityEditor;

namespace SapienTools{
[CustomEditor(typeof(CurveManager))]
	public class CurveManagerEditor : Editor 
	{
		public override void OnInspectorGUI()
		{
		CurveManager t = (CurveManager)target;
			t.name = EditorGUILayout.TextField("Curve Name", t.name);
			t.MoveInToTileHeightAnimationCurve = EditorGUILayout.CurveField("Move In Curve:", t.MoveInToTileHeightAnimationCurve, GUILayout.Height(150));

		}
	}
}