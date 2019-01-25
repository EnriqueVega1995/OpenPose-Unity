using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public GameObject gameover;
    public GameObject obj_1;
    public GameObject obj_2;
    public GameObject obj_3;
    public float timeRemaining;
    private const float timerMax = 50f;
    public Slider slider;
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
}
