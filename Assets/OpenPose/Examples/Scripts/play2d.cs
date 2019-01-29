using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play2d : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeRe=1;
    private const float timerMax = 10f;
    public Slider slider_play;
    public timer tim;
    // Start is called before the first frame update
    void Start()
    {
        //timeRemaining = timerMax;
        timeRe=1;
    }
    // Update is called once per frame
    void Update()
    {
        //slider_play.value = 1;
        if(Input.GetKey(KeyCode.Space)){
            timeRe = timerMax;
            //colliderr scorePointsScript =  scorePointsScript.GetComponent<colliderr>();
            //SceneManager.LoadScene("Test");
        }
        if(slider_play.value == 0){
            tim.PlayGame();
            this.gameObject.SetActive(false);
            slider_play.value=1;
        }
    }    
    void OnTriggerStay(Collider other){
        if(other.gameObject.tag=="Player"){
            Debug.Log("Tocando play");
            //timeRe = timerMax;
            slider_play.value -= 0.5f*Time.deltaTime;
            
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag=="Player"){
            Debug.Log("Tocando play");
            timeRe = 0;
            slider_play.value=1;
        }
    }
    float CalculateSliderValue(){
        return (timeRe/timerMax);
    }
    void hardRestartGame() {
     //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ExitGame(){
        Application.Quit();
        Debug.Log("Exit");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
