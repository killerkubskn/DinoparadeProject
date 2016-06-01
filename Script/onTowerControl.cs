using UnityEngine;
using System.Collections;

public class onTowerControl : MonoBehaviour {

	public float TowerReattackTime { set; get; }
	public float TowerRotationSpeed { set; get; } 
	public float TowerAttckAngle { set; get; }
	public float TrackingRange { set; get; }
	public GameObject TowerBullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TowerRotationControl(){
		
		GameObject TrackingTarget = null;
		float MaximumRang = float.MaxValue;
		Collider[] Cols = Physics.OverlapSphere (transform.position,TrackingRange);

		foreach(Collider col in Cols){
			GameObject Target = col.gameObject;
			if (Target != gameObject && Target.CompareTag ("Dinosuar")) {
				Vector3 dir = Target.transform.position - transform.position;
				float Rang = dir.magnitude;
				float Angle = Vector3.Angle (dir, transform.forward);

				if (Rang <= MaximumRang) {
					MaximumRang = Rang;
					TrackingTarget = Target;
				}
			}
		}

	}
}
