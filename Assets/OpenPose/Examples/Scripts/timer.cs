using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public GameObject gameover;
    public GameObject play_2d;
    public GameObject obj_1;
    public GameObject obj_2;
    public GameObject obj_3;
    public Renderer rend_1;
    public Renderer rend_2;
    public Renderer rend_3;
    public float timeRemaining;
    private const float timerMax = 5f;
    public Slider slider;
    public play2d play;
    //public gametwister gt;
    // Start is called before the first frame update
    void Start()
    {
        //timeRemaining = timerMax;
    }
    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateSliderValue();
        if(Input.GetKey(KeyCode.Space)){
            timeRemaining = timerMax;
            gameover.SetActive(false);
            obj_1.SetActive(true);
            obj_2.SetActive(true);
            obj_3.SetActive(true);
            //colliderr scorePointsScript =  scorePointsScript.GetComponent<colliderr>();
            //SceneManager.LoadScene("Test");   
        }
        if(timeRemaining <= 0){
            timeRemaining = 0;
            gameover.SetActive(true);
            obj_1.SetActive(false);
            obj_2.SetActive(false);
            obj_3.SetActive(false);
            play_2d.SetActive(true);
        }else if(timeRemaining > 0){
            timeRemaining -= Time.deltaTime;
            //Debug.Log(timeRemaining);
        }
    }
    float CalculateSliderValue(){
        return (timeRemaining/timerMax);
    }
    void hardRestartGame() {
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ExitGame(){
        Application.Quit();
        Debug.Log("Exit");
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void PlayGame(){
        timeRemaining = timerMax;
        rend_1.material.SetColor("_EmissionColor", Color.black);
        rend_2.material.SetColor("_EmissionColor", Color.black);
        rend_3.material.SetColor("_EmissionColor", Color.black);
        obj_1.gameObject.tag="Respawn";
        obj_2.gameObject.tag="Respawn";
        obj_3.gameObject.tag="Respawn";
        gameover.SetActive(false);
        obj_1.SetActive(true);
        obj_2.SetActive(true);
        obj_3.SetActive(true);
        //gt.rend_1.material.SetColor("_EmissionColor", Color.black);
    }
    public void GameOver(){
        timeRemaining = 0;
        gameover.SetActive(true);
        obj_1.SetActive(false);
        obj_2.SetActive(false);
        obj_3.SetActive(false);
    }
}
