using UnityEngine;
using System.Collections;

public class force : MonoBehaviour
{
    public float hoverForce;

    
    void OnTriggerStay (Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
    }
}
