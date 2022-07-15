using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseOutTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Объект вышел из дома");
        other.GetComponent<Rigidbody>().AddForce(new Vector3(0,2,0),ForceMode.VelocityChange);
    }
}
