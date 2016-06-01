using UnityEngine;
using System.Collections;

public class BombTowerBulletControl : MonoBehaviour {

	private Vector3 Center;
	private SphereCollider mySphereCollider;
	private int getDamageCount;
	private bool CalculateDamagePass = false;

	public float Vector3X;
	public float Vector3Y;
	public float Vector3Z;

	public float ActiveAreaRadius;
	public float DamageRadius;

	public float Damage;

	// Use this for initialization
	void Start () {

		Center.x = transform.localPosition.x + Vector3X;
		Center.y = transform.localPosition.y + Vector3Y;
		Center.z = transform.localPosition.z + Vector3Z;

		mySphereCollider = transform.GetComponent<SphereCollider>();
		mySphereCollider.radius = ActiveAreaRadius;

		getDamageCount = -1;
	}

	private void OnTriggerEnter(Collider enterCollider) {

		if (enterCollider.gameObject.tag.Equals ("Dinosuar")){
			ExplosionDamage (Center, ActiveAreaRadius,enterCollider);
			Destroy (gameObject);
		}
			
	
	}

	private void ExplosionDamage(Vector3 Center,float DamageRadius,Collider enterCollider) {

		Collider[] HitCollider = Physics.OverlapSphere (Center, DamageRadius);

		float RealDamage;

		for (int i = 0; i < HitCollider.Length && CalculateDamagePass == false; i++) {
			getDamageCount += 1;
		}

		CalculateDamagePass = true;

		Debug.Log ("Get Damage Count : " + getDamageCount);
			
		RealDamage = Damage / getDamageCount;

		if (RealDamage <= 0)
			RealDamage = Damage;

		Debug.Log ("Real Damage : " + RealDamage);

		for (int i = 0; i < HitCollider.Length; i++) {
			HitCollider [i].gameObject.SendMessage ("ApplyBombDamage", RealDamage, SendMessageOptions.DontRequireReceiver);
		}
			
	}
}
