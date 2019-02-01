using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class character : MonoBehaviour {

	private Vector3 playerPos = new Vector3(0,-9.5f,0);
    public GameObject head;
    public float rot;
    Vector3 playerRot;
    //public Transform target;
    //NavMeshAgent agent;
    //public GameObject leftWrist;
	void Start(){
        
    }
	// Update is called once per frame
	void Update () {
        	

        if (head == null)
        {
            head = GameObject.FindWithTag("Wrist");
        }
        else
        {
            float xPos = head.transform.position.x;
            float yPos = head.transform.position.y;
            playerPos = new Vector3(Mathf.Clamp(xPos, -5f, 25f), (Mathf.Clamp(yPos, 80f, 100f)), -73);
            transform.position = playerPos;
        }
        //float xPos = transform.position.x + (Input.GetAxis("Horizontal") * 10);
        //playerPos = new Vector3(Mathf.Clamp(xPos, -520f, 520f), -9.5f, 0);
        //transform.position = playerPos;
        //agent.SetDestination(target.position);
        // if (head == null)
        // {
        //     head = GameObject.FindWithTag("head");
        // }
        // else
        // {
        //     float xPos = head.transform.position.x;
        //     float yPos = head.transform.position.y;
        //     float yRot = head.transform.rotation.y;
        //     float xRot = head.transform.rotation.x;
        //     playerPos = new Vector3((Mathf.Clamp(xPos, 100f,100f)), (Mathf.Clamp(yPos, 80, 100F)), -70);
        //     //transform.Rotate(playerRot.y, Time.deltaTime, 0);
        //     transform.position = playerPos;
        //     //head.transform.Rotate(rot,0,0);
        //     //transform.Rotate(0, Time.deltaTime, 0, Space.World);
        // }
        //float xPos = transform.position.x + (Input.GetAxis("Horizontal") * 10);
        //playerPos = new Vector3(Mathf.Clamp(xPos, -520f, 520f), -9.5f, 0);
        //transform.position = playerPos;
    }

    //      float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
    //playerPos = new Vector3 (Mathf.Clamp (xPos, -450f, 450f), -9.5f, 0);
    //transform.position = playerPos;
}