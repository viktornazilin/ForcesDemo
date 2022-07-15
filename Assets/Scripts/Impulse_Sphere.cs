using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse_Sphere : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public Vector3 Force;

    private void Start() 
    {

      Rigidbody.AddForce(Force, ForceMode.Impulse); 
    } 
}
