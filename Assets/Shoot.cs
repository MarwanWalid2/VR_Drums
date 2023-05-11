using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
  public GameObject ball;
  //Vector3 ballPos;
public float handPower;
  Collider ballCol;
  Rigidbody ballRb;
  Camera cam;

  void Start(){
    //ballPos = ball.transform.position;
    ballCol = ball.GetComponent<SphereCollider>();
    ballRb = ball.GetComponent<Rigidbody>();
    cam = GetComponentInChildren<Camera>();
  } 
  public void shoot(){
    ballRb.velocity = cam.transform.rotation * Vector3.forward * handPower;
  }

}
