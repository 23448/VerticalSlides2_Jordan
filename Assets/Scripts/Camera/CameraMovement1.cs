using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement1 : MonoBehaviour {
    [SerializeField]
    private Transform firstPersonView;

    public Transform target;
    private float TargetDistanceMax = 5;
    private float TargetDistanceMin = 2;
    public float verticalMovementMin = -45;
    public float verticalMovementMax = 90;

    public float mouseSensitivity = 5;
    public Vector3 currentRotation;
    public float horizontalMovement;
    public float verticalMovement;

    private float TargetDistanceCurrent;


    // Use this for initialization
    void Start () {
        TargetDistanceCurrent = TargetDistanceMax;
    }


    // Update is called once per frame
    void Update () {
        horizontalMovement += Input.GetAxis("Mouse X") * mouseSensitivity;
        verticalMovement += Input.GetAxis("Mouse Y") * mouseSensitivity;
        Quaternion currentRotation = Quaternion.Euler(verticalMovement, horizontalMovement, 0);

        verticalMovement = Mathf.Clamp(verticalMovement, verticalMovementMin, verticalMovementMax);
        TargetDistanceCurrent = Mathf.Clamp(TargetDistanceCurrent, TargetDistanceMin, TargetDistanceMax);

        transform.position = target.position - transform.forward * TargetDistanceCurrent;
        transform.rotation = Quaternion.Lerp(transform.rotation, currentRotation, Time.deltaTime * 10);

        float distanceIncrease = verticalMovementMin;
        TargetDistanceCurrent = (verticalMovement / 100) * -distanceIncrease;


    }
}
