using UnityEngine;
using System.Collections;

public class FrostTowerBulletControl : MonoBehaviour {

	public Transform myBullet;
	public float SlowRate;
	public float BulletSpeed;

	void Update () {

		OnBulletMoving ();

	}

	private void OnTriggerEnter(Collider enterCollider){
		if (enterCollider.gameObject.tag.Equals("Dinosuar")) {
			enterCollider.gameObject.SendMessage ("UnitGetSlow", SlowRate, SendMessageOptions.RequireReceiver);
			Destroy (gameObject);
		}
	}

	private void OnBulletMoving(){
		Vector3 BulletOnMove = myBullet.localPosition;
		BulletOnMove = BulletOnMove + (myBullet.forward * BulletSpeed * Time.deltaTime);
		myBullet.localPosition = BulletOnMove;
	}
}
