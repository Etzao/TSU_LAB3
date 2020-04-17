using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBody : MonoBehaviour, IHeavenBody
{
    public BodyType BodyType { get; }
    public BodyType bodyType;
    GameObject sun;

    public void RotateOneDay()
    {
        float days1;
        float days2;
        float RotateAroundSelf;
        float RotateAroundSun;
        if(bodyType == BodyType.Venus)
        {
            days1 = 224.7f;
            days2 = 243;
            RotateAroundSelf = 360/days2;
            RotateAroundSun = 365/days1;
            transform.Rotate(0, RotateAroundSun, 0);
            transform.RotateAround(sun.transform.position, Vector3.up, RotateAroundSun);
        }
    }
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        sun = GameObject.Find("Sun");
        SolarSystem.RegisterBody(this);
    }
}
