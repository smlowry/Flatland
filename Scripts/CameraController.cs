using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float yOffset = 0f;
    public float xOffset = 0f;
    private float zOffset = 0f;
    private Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        playerTransform = player.transform;
        zOffset = gameObject.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        // Move to player position absolute
        Vector3 playerPosition = playerTransform.position;
        gameObject.transform.position = new Vector3(playerPosition.x + xOffset,
            playerPosition.y + yOffset, zOffset);
    }
}
