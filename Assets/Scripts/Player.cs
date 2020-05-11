using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private bool lose = false;
    public int maxHealth;
    public int currentHealth;

    public HealthBar healthBar;

    Material originalMaterial;
    bool flashing;
    public Material flashMaterial;

    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<SpriteRenderer>().material != null)
            originalMaterial = GetComponent<SpriteRenderer>().material;

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

    public void FlashWrapper()
    {
        if (!flashing)
            StartCoroutine("Flash");
    }

    IEnumerator Flash()
    {
        flashing = true;
        for (int i = 1; i < 5; i++)
        {
            GetComponent<SpriteRenderer>().material = flashMaterial;
            yield
            return new WaitForSeconds(.2f);
            GetComponent<SpriteRenderer>().material = originalMaterial;
            yield
            return new WaitForSeconds(.2f);
        }
        flashing = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (currentHealth <= 0)
        {
            lose = true;
        }

        if (lose)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
            FlashWrapper();
        }
    }
}
