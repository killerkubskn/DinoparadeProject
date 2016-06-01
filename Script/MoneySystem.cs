using UnityEngine;
using System.Collections;

public class MoneySystem : MonoBehaviour {

	private int Money;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MoneyIncrease(int IncreaseMoney) {
		this.Money += IncreaseMoney;
	}

	public void MoneyDecrease(int DecreaseMoney) {
		this.Money -= DecreaseMoney;
	}

	public void MoneyReset() {
		Money = 0;
	}

	public int GetMoney() {
		return this.Money;
	}
}
