using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScript : MonoBehaviour
{
    public Material myMat;
    public Color[] colors = new Color[3];
    public Color currCol;
    void Start()
    {
        currCol = colors[0];
        myMat.color = colors[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColor(int index)
    {
        myMat.color = colors[index];
        currCol = myMat.color;
    }
}
