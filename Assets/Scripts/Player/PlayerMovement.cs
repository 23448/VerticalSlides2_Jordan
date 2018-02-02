using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {



    public float speed = 5;
    private CameraMovement1 cameraMovement;
    private Vector3 playerRotation;
    [SerializeField]
    private Transform bodyparts;


    void Awake()
    {
        cameraMovement = GetComponent<CameraMovement1>();
    }
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, transform.localEulerAngles.z);
        //bodyparts.transform.localEulerAngles = new Vector3(Camera.main.transform.localEulerAngles.x, Camera.main.transform.localEulerAngles.y, transform.localEulerAngles.z);

        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0,Input.GetAxisRaw("Vertical"));
        Vector3 inputDir = input.normalized;
        transform.Translate(inputDir * Time.deltaTime * speed);



    }
}
