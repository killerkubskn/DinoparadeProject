using UnityEngine;
using System.Collections;

public class ScoreSystem : MonoBehaviour {

	private int Score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ScoreIncrease (int Score) {
		this.Score += Score;
	}

	public void ScoreReset() {
		this.Score = 0;
	}

	public int ScoreGet() {
		return this.Score;
	}
}
