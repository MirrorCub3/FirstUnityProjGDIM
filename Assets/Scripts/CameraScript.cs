using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform player;

    public float smoothTime = 0.6f;
    private float xVelocity = 0.0f;

    void Start()
    {
        transform.position = new Vector3(player.transform.position.x, 0, transform.position.z);
    }

    void Update()
    {
        float newPositionx = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref xVelocity, smoothTime); // camera follows the player smoothly
        if (newPositionx + (Camera.main.aspect * Camera.main.orthographicSize) > GeneralScript.right)
        {
            newPositionx = GeneralScript.right - Camera.main.aspect * Camera.main.orthographicSize;
        }
        else if (newPositionx - (Camera.main.aspect * Camera.main.orthographicSize) < GeneralScript.left)
        {
            newPositionx = GeneralScript.left + Camera.main.aspect * Camera.main.orthographicSize;
        }
        transform.position = new Vector3(newPositionx, 0, transform.position.z);
    }
}
