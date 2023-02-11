using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CAMERA SET UP



public class CameraMove : MonoBehaviour
{

    private Vector3 playerPos;
    Vector3 newPos;
    [SerializeField]
    [Range(10, 150f)]
    float maxSpeed = 5f;
    [SerializeField]
    [Range(0.0001f, 1.5f)]
    float smoothTime = 0.5f;
    Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 playerPos = GameObject.Find("torso").transform.position;
        newPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        //update playerpos, then smoothdamp towards the position

        float playerPosX = GameObject.Find("torso").transform.position.x;
        float playerPosY = GameObject.Find("torso").transform.position.y;
        playerPos = new Vector3(playerPosX, playerPosY, transform.position.z);
        newPos = transform.position;
        Vector3 smoothPos = Vector3.SmoothDamp(newPos, playerPos, ref velocity, smoothTime, maxSpeed);
        transform.position = smoothPos;
    }
}
