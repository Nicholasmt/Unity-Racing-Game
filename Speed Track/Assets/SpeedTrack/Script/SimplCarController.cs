using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplCarController : MonoBehaviour {
    private float DirHorzontal;
    private float DirVertical;
    private float steeringAngle;

    public WheelCollider wheel_front_right;
    public WheelCollider wheel_front_left;
    public WheelCollider wheel_Back_right;
    public WheelCollider wheel_Back_left;

    public Transform wheel_front_Rt;
    public Transform wheel_front_LT;
    public Transform wheel_Back_Rt;
    public Transform wheel_Back_LT;


    public float MaxSteeringAngle = 25;
    public float MotorForce = 300;
    public float Brakes = 0;

    public void DirectionInput()
    {
        DirHorzontal = Input.GetAxis("Horizontal");
       DirVertical = Input.GetAxis("Vertical");

    }

    public void SteerControl()
    {
        steeringAngle = MaxSteeringAngle * DirHorzontal;
        wheel_front_right.steerAngle = steeringAngle;
        wheel_front_left.steerAngle = steeringAngle;
        
    }

    public void speedControl()
    {
  if(DirVertical == 0 || Input.GetKey(KeyCode.Space))
        {
            Brakes = 300;
        }
        else
        {
            Brakes = 0;
            wheel_front_right.motorTorque = DirVertical* MotorForce;
            wheel_front_left.motorTorque = DirVertical * MotorForce;
            wheel_Back_right.motorTorque = DirVertical * MotorForce;
            wheel_Back_left.motorTorque = DirVertical* MotorForce;
        }

        wheel_front_right.brakeTorque = Brakes;
        wheel_front_left.brakeTorque = Brakes;
        wheel_Back_right.brakeTorque = Brakes;
        wheel_Back_left.brakeTorque = Brakes;

    }

    public void WheelpositionControl()
    {
        WheelpositionControls(wheel_front_right, wheel_front_Rt);
        WheelpositionControls(wheel_front_left, wheel_front_LT);
        WheelpositionControls(wheel_Back_right, wheel_Back_Rt);
        WheelpositionControls(wheel_Back_left, wheel_Back_LT);
    }

    public void WheelpositionControls(WheelCollider collider, Transform trans)
    {
        Vector3 Wheelposition = trans.position;
        Quaternion WheelQuant = trans.rotation;

        collider.GetWorldPose(out Wheelposition, out WheelQuant);

        trans.position = Wheelposition;
        trans.rotation = WheelQuant;


    }


    public void FixedUpdate()
    {

        DirectionInput();
        SteerControl();
        speedControl();
        WheelpositionControl();

    }

}
