using UnityEngine;
using System.Collections;

public class GunTowerBulletControl : MonoBehaviour {

	public float BulletSpeed;
	public float Damage;
	
	// Update is called once per frame
	void Update () {

		OnBulletMoving ();
	
	}

	private void OnTriggerEnter(Collider enterCollider){
		if (enterCollider.gameObject.tag.Equals("Dinosuar")) {
			enterCollider.gameObject.SendMessage ("UnitGetDamage", Damage, SendMessageOptions.RequireReceiver);
			Destroy (gameObject);
		}
	}

	private void OnBulletMoving(){
		Vector3 BulletOnMove = transform.localPosition;
		BulletOnMove = BulletOnMove + (transform.forward * BulletSpeed * Time.deltaTime);
		transform.localPosition = BulletOnMove;
	}
		
}
