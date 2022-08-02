using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer_points : MonoBehaviour
{
    public GameObject clock;
    private float countdownButton, buttonPushed, dieLoad;
    public bool countDownGo;
    //public AudioSource AS, PTB1, PTB2, PTB3, PTB4, soHappy, bye;
    
   p ublic Text countdownText;

    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text countdowntext;


    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
    }
}
