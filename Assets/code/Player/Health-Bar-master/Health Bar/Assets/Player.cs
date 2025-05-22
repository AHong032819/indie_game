using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	[SerializeField] GameObject deathmenu;
	[SerializeField] GameObject pausebutton;
	[SerializeField] GameObject Apple;
	[SerializeField] GameObject banana;

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
		if (other.gameObject.tag == "Saw")
		{
			TakeDamage(3);
		}
		if (currentHealth <= 0)
		{
			Time.timeScale = 0;
			deathmenu.SetActive(true);
			pausebutton.SetActive(false);
		}
		if (other.gameObject.tag == "Apple")
		{
			AddDealth(1);
			Apple.SetActive(false);
		}
		if (other.gameObject.tag == "banana")
		{
			AddDealth(1);
			banana.SetActive(false);
		}
		if (other.gameObject.tag == "Finish flag")
		{
			SceneManager.LoadSceneAsync("level2");
		}
		if (other.gameObject.tag == "Finish flag2")
		{
			SceneManager.LoadSceneAsync("level1");
		}


	}
	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
	void AddDealth(int Health)
	{
		currentHealth += Health;

		healthBar.SetHealth(currentHealth);
	}
	
}
