using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gametwister : MonoBehaviour
{
    Vector3 Rango_obj1;
    Vector3 Rango_obj2;
    Vector3 Rango_obj3;
    public Text puntos;
    int total_puntos = 0;
    public GameObject obj_1;
    public GameObject obj_2;
    public GameObject obj_3;
    public timer tim;
    public OpenPose.Example.HumanController2D open;
    public Renderer rend_1;
    public Renderer rend_2;
    public Renderer rend_3;
    ParticleSystem ps;
    
    //public Transform cubo_1;
    // Start is called before the first frame update
    void Start()
    {
        rend_1.gameObject.GetComponent<Renderer>();
        rend_2.gameObject.GetComponent<Renderer>();
        rend_3.gameObject.GetComponent<Renderer>();
        ps = GetComponentInChildren<ParticleSystem>();
        //cubo_1 = GetComponent<Transform>();
        //transform.position = pos;
    }
    void Update()
    {
        if(open.box.gameObject.tag=="Finish"){
            Renderer rend = this.gameObject.GetComponent<Renderer>();
            rend.material.SetColor("_EmissionColor", Color.black);
        } 
        Rango_obj1 = new Vector3(Random.Range(73,480),Random.Range(0,240),0);
        Rango_obj2 = new Vector3(Random.Range(-480,-73),Random.Range(240,0),0);
        Rango_obj3 = new Vector3(Random.Range(-480,480),Random.Range(-70,-277),0);
        if(obj_1.gameObject.tag=="obj" && obj_2.gameObject.tag=="obj" && obj_3.gameObject.tag=="obj"){
            Twister();
        }
        if(tim.timeRemaining <= 0){
            total_puntos = 0;
            Debug.Log(total_puntos + " Fin del juego");
        }
        if(Input.GetKeyDown(KeyCode.E)){
            ps.Play();
        }
        //cubo_1.transform.Rotate(0,1f,0);
    }
    void OnTriggerEnter(Collider other){
		//Debug.Log ("dentro delcollider");
		if (other.gameObject.tag == "Player"){
            //Debug.Log("Colider del Cubo");
            // this.transform.localScale += new Vector3(200*2*Time.deltaTime,0,0);
            //Destroy(this.gameObject,1);
            //cubo_1.transform.position=pos;
            this.gameObject.tag="obj";
            Renderer rend = this.gameObject.GetComponent<Renderer>();
            rend.material.SetColor("_EmissionColor", Color.white);
        }
	}
    void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Player"){
            this.gameObject.tag="Respawn";
            Renderer rend = this.gameObject.GetComponent<Renderer>();
            rend.material.SetColor("_EmissionColor",Color.black);
        }
    }
    public void Twister(){
        this.ps.Play();
        obj_1.gameObject.transform.position = Rango_obj1;
        obj_2.gameObject.transform.position = Rango_obj2;
        obj_3.gameObject.transform.position = Rango_obj3;
        obj_1.gameObject.tag="Respawn";
        obj_2.gameObject.tag="Respawn";
        obj_3.gameObject.tag="Respawn";
        rend_1.material.SetColor("_EmissionColor", Color.black);
        rend_2.material.SetColor("_EmissionColor", Color.black);
        rend_3.material.SetColor("_EmissionColor", Color.black);
        // Renderer rend = this.gameObject.GetComponent<Renderer>();
        // rend.material.SetColor("_EmissionColor", Color.black);
        // total_puntos ++;
        // Debug.Log(total_puntos);
        puntos.text = "Puntos: " + total_puntos;
    }
}
 