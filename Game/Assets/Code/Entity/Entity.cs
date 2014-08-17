using UnityEngine;
using System.Collections;

public class Entity : Game {


	void Start () {}

	void Update () {}

	protected void takePlayerHealth(int amount) {
		playerHealth = playerHealth - amount;
	}
}
