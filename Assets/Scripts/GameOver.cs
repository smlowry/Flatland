using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This script will detect if the player has fallen from the environment.
 */
public class GameOver : MonoBehaviour
{
    // "readonly" prevents a variable from being changed at runtime.
    public readonly int winArea = -101   ;
    public bool win = false;
    public Transform target;
    public int currentHealth;

    public HealthBar healthBar;

    // Update is called once per frame

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (target.position.x < winArea)
        {
            win = true;
        }

        if (win)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}


