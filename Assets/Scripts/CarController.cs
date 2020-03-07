using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public List<WheelCollider> steer;
    public List<WheelCollider> throttle;

    public float forwardSpeed = 20000;

    public float steerSpeed = 20;

    // Update is called once per frame
    void Update()
    {
        float imT = Input.GetAxis("Vertical");
        float imS = Input.GetAxis("Horizontal");

        foreach (var s in throttle)
        {
            s.motorTorque = imT * forwardSpeed;
        }

        foreach (var s in steer)
        {
            s.steerAngle = imT * steerSpeed;
        }
    }
}
