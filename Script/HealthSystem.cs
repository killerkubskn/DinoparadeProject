using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {

	public int MaximumHealth;
	private int Health;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void HealthDecrease(int Health) {
		this.Health -= Health;
	}

	public void HealthReset() {
		this.Health = this.MaximumHealth;
	}

	public int GetHealth() {
		return this.Health;
	}
}
