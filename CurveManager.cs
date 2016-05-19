using UnityEngine;
using System.Collections;

namespace SapienTools{
public class CurveManager : MonoBehaviour {
		public string name;
		public AnimationCurve MoveInToTileHeightAnimationCurve = new AnimationCurve();
		public float getCurve(float percentage){
			percentage = (percentage<0f) ? 0f : (percentage>1f) ? 1f : percentage;//gate the curve to 0 to 1 (can be taken out without breaking anything)
			return MoveInToTileHeightAnimationCurve.Evaluate(percentage);
		}
	}
}