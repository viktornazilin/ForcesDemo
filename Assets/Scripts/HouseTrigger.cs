using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Объект вошел в дом");
        other.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,6),ForceMode.VelocityChange);
    }
}
