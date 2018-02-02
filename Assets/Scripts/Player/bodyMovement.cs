using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyMovement : MonoBehaviour {

    Vector2 armsRotation;
    private CameraMovement1 cameraScript;
    // Use this for initialization
    void Start () {
        cameraScript = GetComponent<CameraMovement1>();
	}
	
	// Update is called once per frame
	void Update () {
        armsRotation.y = Mathf.Lerp(-45, 90, cameraScript.verticalMovement);

        transform.localRotation = Quaternion.AngleAxis(-Input.GetAxis("Mouse Y"), Vector3.down);
        transform.localRotation = Quaternion.AngleAxis(+Input.GetAxis("Mouse Y"), Vector3.up);
    }
}
