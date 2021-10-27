using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubeScript : MonoBehaviour
{
    public Material myMat;
    public GameObject player;
    void Start()
    {
        myMat.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Color pColor = player.GetComponent<ColorChangeScript>().currCol;
            myMat.color = new Color(pColor.r, pColor.g, pColor.b);
        }
    }
}
