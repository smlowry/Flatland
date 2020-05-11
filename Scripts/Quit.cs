using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class quits the application as soon as a key is pressed.
 * TODO: this only works with a build. How do I make it work in the editor?
 */
public class Quit : MonoBehaviour
{
 

    void Update()
    {
        if(Input.anyKey)
        {
            Application.Quit();
        }
    }
}
