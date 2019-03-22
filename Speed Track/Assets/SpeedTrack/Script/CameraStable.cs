using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

    public GameObject Thecar;
    public float carX;
    public float CarY;
    public float CarZ;
 
	 public void Update () {
        carX = Thecar.transform.eulerAngles.x;
        CarY = Thecar.transform.eulerAngles.y;
        CarZ = Thecar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(carX - carX, CarY, CarZ - CarZ);
    }
}
