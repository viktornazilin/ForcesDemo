using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceComponent : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public Vector3 Force;

    private void FixedUpdate() 
    {
        Rigidbody.AddForce(Force, ForceMode.Force);
    }

}
