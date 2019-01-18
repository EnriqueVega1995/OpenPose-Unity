using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private float timeRemaining;
    private const float timerMax = 50f;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        slider.value = CalculateSliderValue();
        if(Input.GetKey(KeyCode.Space)){
            timeRemaining = timerMax;
        }
        if(timeRemaining <= 0){
            timeRemaining = 0;
            
        }else if(timeRemaining > 0){
            timeRemaining -= Time.deltaTime;
            Debug.Log(timeRemaining);
        }
    }
    float CalculateSliderValue(){
        return (timeRemaining/timerMax);
    }
}
