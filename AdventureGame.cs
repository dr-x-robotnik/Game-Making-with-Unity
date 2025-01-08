using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AdventureGame : MonoBehaviour
{
	private int health = 50;
	private int energy = 30;
	private bool hasWeapon = false;
	private bool isEnemyVisible = true;	
	private string enemyType = "Dragon";
	private int enemyHealth = 70;

	void Start()
	{
		Debug.Log("Game started! Initial player and enemy settings are applied.");
		Debug.Log($"Player Health: {health}, Energy: {energy}, Has Weapon: {hasWeapon}, Enemy Visible: {isEnemyVisible}");
		Debug.Log($"Enemy Type: {enemyType}, Enemy Health: {enemyHealth}");

		if (hasWeapon && energy > 20)
		{
			AttackEnemy();
		}
		else if (!hasWeapon)
		{
			Debug.Log("You cannot attack without a weapon!");
		}

		if (isEnemyVisible && energy < 20)
		{
			Escape();
		}
		
  		if (!isEnemyVisible && energy < 10)
    		{
        		Debug.Log("You found an energy potion!");
        		energy += 20;
    		}
	}

	void Update()
	{
		// Nothing in here ostad :)
	}
	
	void AttackEnemy()
	{	
		switch (enemyType)
		{	
			case "Goblin":
				enemyHealth -= 30;
				break;
			case "Orc":
				enemyHealth -= 20;
				break;
			case "Dragon":
				enemyHealth -= 10;
				break;
			default:
				Debug.Log("Unknown enemy type!");
				break;
		}

		Debug.Log($"Attacked the {enemyType}! Enemy health is now {enemyHealth}.");

		if (enemyHealth <= 0)
		{
			Debug.Log("Enemy defeated!");
		}
	}

	void Escape()
	{
		if (enemyType == "Dragon")
    	{
			Debug.Log("You cannot escape from the Dragon!");
    	}
    	else
    	{
        	Debug.Log("You escaped successfully!");
    	}
	}

}

