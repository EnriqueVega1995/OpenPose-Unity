using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collider : MonoBehaviour
{
    Vector3 Rango_obj1;
    Vector3 Rango_obj2;
    Vector3 Rango_obj3;
    public Text puntos;
    int total_puntos = 0;
    public GameObject obj_1;
    public GameObject obj_2;
    public GameObject obj_3;
    public static colliderr ins = null;
    //public Transform cubo_1; 
    // Start is called before the first frame update
    void Start()
    {
        //cubo_1 = GetComponent<Transform>();
        //transform.position = pos;
    }
    void Update()
    {
        Rango_obj1= new Vector3(Random.Range(-450,-40),Random.Range(290,0),0);
        Rango_obj2= new Vector3(Random.Range(40,450),Random.Range(290,0),0);
        Rango_obj3= new Vector3(Random.Range(-450,450),Random.Range(-100,-300),0);
        puntos.text = "Puntos: " + total_puntos;
        if(obj_1.gameObject.tag=="obj" && obj_2.gameObject.tag=="obj" && obj_3.gameObject.tag=="obj"){
            obj_1.gameObject.transform.position = Rango_obj1;
            obj_2.gameObject.transform.position = Rango_obj2;
            obj_3.gameObject.transform.position = Rango_obj3;
            total_puntos ++;
        }
        //cubo_1.transform.Rotate(0,1f,0);
    }
    void OnTriggerStay (Collider other){
		//Debug.Log ("dentro delcollider");
		if (other.gameObject.tag == "Player") {
            //Debug.Log("Colider del Cubo");
            //this.transform.localScale += new Vector3(-150,-150,-150)*Time.deltaTime;
            //Destroy(this.gameObject,1);
            //cubo_1.transform.position=pos;
            this.gameObject.tag="obj";   
            Renderer rend = this.gameObject.GetComponent<Renderer>();
            rend.material.SetColor("_EmissionColor", Color.white);  
        }
	}
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            this.gameObject.tag="Respawn";
            Renderer rend = this.gameObject.GetComponent<Renderer>();
            rend.material.SetColor("_EmissionColor", Color.black); 
        }
    }
    public void points(){
        total_puntos = 0;
    }
}
