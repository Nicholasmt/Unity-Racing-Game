using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 [System.Serializable]

public class BenzCarinfo
{
    public WheelCollider leftWheel;
    public GameObject LeftWheelMesh;
    public WheelCollider rightWheel;
    public GameObject rightWheelMesh;
    public bool motor;   // is the wheel attacked to motor?
    public bool steering; // does this wheel steer angle?
       

}
public class BenzCarController : MonoBehaviour {

    public List<BenzCarinfo> benzinfos;  // list of all wheel pairs
    public float Maxmotortorque;
    public float MaxSteeringAngle;

    public void Update()
    {

    }
	 
	 
	 
    public void ApplyLocalPositionVisuals(BenzCarinfo wheelpair)
    {
        wheelpair.LeftWheelMesh.transform.Rotate(Vector3.right, Time.deltaTime * wheelpair.leftWheel.rpm * 10, Space.Self);
        wheelpair.rightWheelMesh.transform.Rotate(Vector3.right, Time.deltaTime * wheelpair.rightWheel.rpm * 10, Space.Self);

    }


    public void FixedUpdate()
    {
        float motor = Maxmotortorque * Input.GetAxis("Vertical");
        float steering = MaxSteeringAngle * Input.GetAxis("Horizontal");

        foreach(BenzCarinfo benzinfo in benzinfos)
        {
  //Check the steering 
           if(benzinfo.steering == true)
            {
                benzinfo.leftWheel.steerAngle = steering;
                benzinfo.rightWheel.steerAngle = steering;
            }

           //Set the Motor
           if(benzinfo.motor == true)
            {
                benzinfo.leftWheel.motorTorque = motor;
                benzinfo.rightWheel.motorTorque = motor;

            }

            ApplyLocalPositionVisuals(benzinfo);

        }


    }
}
