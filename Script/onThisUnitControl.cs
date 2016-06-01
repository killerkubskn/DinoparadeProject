using UnityEngine;
using System.Collections;

public class onThisUnitControl : MonoBehaviour {

	public MoneySystem myMoneySystem;
	public ScoreSystem myScoreSystem;
	//public 

	public int MoneyDrop;
	public int ScoreDrop;

	public float MaximumHealth;
	public float Defense;
	public float Speed;

	public bool FlyAble;
	public bool FrostAble;

	private float Health;
	private float TrueSpeed;

	// Use this for initialization
	void Start () {
		UnitGetHealth ();
	}
	
	// Update is called once per frame
	void Update () {
		UnitDropAndDieEvent ();
	}

	public void UnitGetHealth(){
		this.Health = this.MaximumHealth;
	}

	public void UnitDropAndDieEvent() {
		if (this.Health <= 0) {
			myScoreSystem.ScoreIncrease (ScoreDrop);
			myMoneySystem.MoneyIncrease (MoneyDrop);
			Destroy (gameObject);

			Debug.Log ("Player Money : " + myMoneySystem.GetMoney ());
			Debug.Log ("Player Score : " + myScoreSystem.ScoreGet ());
		}
	}

	public void UnitGetDamage(float Damage) {
		Damage = Damage - this.Defense;
		Health = Health - Damage;
		Debug.Log ("Unit Get Damage : " + Damage);
		Debug.Log ("Unit Health : " + Health);
	}

	public void ApplyBombDamage(float Damage){
		UnitGetDamage (Damage);
	}

	public void UnitGetSlow (float DecreaseSpeed){

		float SlowTimeDebuff = 3.0f;


		if(FrostAble){
			float i = 0;
			bool GetSlow = false;
			while(i<SlowTimeDebuff){
				
				if (GetSlow == false){
					TrueSpeed = TrueSpeed - DecreaseSpeed;
					GetSlow = true;
					Debug.Log ("Unit Get Slow : " + DecreaseSpeed);
				}
				
				i = i * Time.deltaTime;
			}

			TrueSpeed = Speed;
		}

	}
}
