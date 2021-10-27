using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public GameObject rotThis;
    public float rotSpeed = 3f; 
    void Start()
    {
        
    }
    void Update()
    {
        rotThis.transform.Rotate(0,0,rotSpeed*Time.deltaTime);
    }
    // code determining where two objects are relative to eachother
    /*var directionToOtherObject =
someOtherObjectPosition - transform.position;
    var differenceFromMyForwardDirection =
    Vector3.Dot(transform.forward, directionToOtherObject);
if (differenceFromMyForwardDirection > 0) {
// The object is in front of us
} else if (differenceFromMyForwardDirection< 0) {
// The object is behind us
} else
{
    // The object neither before or behind us; it's at a perfect right
    // angle to our forward direction.
}*/
}
