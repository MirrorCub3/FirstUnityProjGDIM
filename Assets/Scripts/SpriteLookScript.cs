using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLookScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (player.transform.position.x < transform.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
    }
}
