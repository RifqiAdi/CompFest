﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	PlayerInputAction InputActions;

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;

    void Awake()
    {
        InputActions = new PlayerInputAction();
    }
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 120;
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
        //InputActions.Player.Damage.performed += HandleDamage =>
        //{
        //    Debug.Log("ADUH");
        //    TakeDamage(20);
            
        //};
    }


    private void OnEnable()
    {
        InputActions.Player.Damage.Enable();
    }

    private void OnDisable()
    {

        InputActions.Player.Damage.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void TakeDamage(int damage)
	{
        Debug.Log("ADUH");
        currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
}
