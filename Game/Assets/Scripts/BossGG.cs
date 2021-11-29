using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossGG : MonoBehaviour
{
	public int maxHealth = 3;
	public int currentHealth;

	//public HealthBar healthbar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		
	}

	// Update is called once per frame
	/*void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(20);
		}
	}*/
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Enemy"))
		{
			Destroy(other.gameObject);
			TakeDamage(1);
		}
		//try
		if (other.CompareTag("Player"))
		{
			
			FindObjectOfType<Manager>().Pause();
			
		}

	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		//healthbar.SetHealth(currentHealth);

		if (currentHealth <= 0)
		{
			gameObject.SetActive(false);
			//Destroy(gameObject);
		}

		
	}
}


