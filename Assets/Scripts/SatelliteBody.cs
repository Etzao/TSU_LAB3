using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteBody : MonoBehaviour
{
    public GameObject venus;
    Vector3 axis;
    Vector3 nextAxis;
    public float angle = 1.5f;
    float anglePassed = 0;
    float oneCornerX = 0;
    float oneCornerY = 0;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        axis = new Vector3(Random.Range(-1f,1f),Random.Range(-1f,1f),0); 
        venus = GameObject.Find("Venus");
         
    }
    
    // Update is called once per frame
    void Update()
    {
        anglePassed += angle;
        axis.x -= oneCornerX * angle;
        axis.y -= oneCornerY * angle;
        transform.RotateAround(venus.transform.position, axis, angle);

        if (anglePassed >= 360)
        {
            nextAxis = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);

            float difX = axis.x - nextAxis.x;
            float difY = axis.y - nextAxis.y;

            oneCornerX = difX / 360;
            oneCornerY = difY / 360;

            anglePassed = 0;
        }
    }
}
