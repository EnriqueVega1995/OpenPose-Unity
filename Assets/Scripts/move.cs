using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Transform per2;

    // Start is called before the first frame update
    void Start()
    {
        per2 = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("f")){
             transform.Translate(0, 100*Time.deltaTime, 0);

        }
    }
}
