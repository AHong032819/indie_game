using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	[SerializeField]GameObject deathmenu;
	[SerializeField]GameObject pausebutton;
	public int maxHealth = 5;
	public int currentHealth;

	public HealthBar healthBar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
	}

	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Spike")
		{
			TakeDamage(1);
		}
		if (other.gameObject.tag == "DeathLine")
		{
			TakeDamage(5);
		}
		if (currentHealth <= 0)
		{
			Time.timeScale = 0;
			deathmenu.SetActive(true);
			pausebutton.SetActive(false);
		}
		
	
	}
	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
	
}
