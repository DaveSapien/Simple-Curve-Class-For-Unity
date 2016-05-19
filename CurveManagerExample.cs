using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class MouthController : MonoBehaviour {
		private float percentageAlongTheCurve = 0f;
		private float returnedCurve = 0f;
		// Use this for initialization
		void Start () {
		}

		// Update is called once per frame
		void Update () {
			if(percentageAlongTheCurve<=1.0f){
				SapienTools.CurveManager[] curvmans = GetComponents<SapienTools.CurveManager>();
				foreach(SapienTools.CurveManager curve in curvmans){
					if(curve.name == "your curve name"){
						returnedCurve = curve.getCurve(percentageAlongTheCurve);
					}
				}
				percentageAlongTheCurve += 0.1f;
				Debug.Log("returned Curve Value " + returnedCurve);
			}
			//or you can call direclty like so:
			//float value = GetComponent<SapienTools.CurveManager>().getCurve(percentageAlongTheCurve);
		}
}