using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WallMovementRatt : MonoBehaviour

{

 // Player Movement Variables/....
 public static int movespeed = 1;
 public Vector3 userDirection = Vector3.right;

 public void FixedUpdate()
 {
     transform.Translate(userDirection * movespeed * Time.deltaTime); 
 }
}
