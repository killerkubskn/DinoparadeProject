using UnityEngine;
using System.Collections;

public class onThisTowerControl : MonoBehaviour {

	public int TowerDamage;
	public int TowerPrice;
	public int TowerRange;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider Col) {
		if(gameObject.tag == "Dinosuar"){
			//Col.GetComponent.onThisUnitControl.Health;
		}
	}
}
