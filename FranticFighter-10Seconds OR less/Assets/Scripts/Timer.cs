using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Image countDown;

    bool changeColour = true;
    float currentTime;
    float startTime = 10f;
    string gameOver = "Game Over";
    public Color red;
    public Color white;
    public Color black;
    

    void Start()
    {
        currentTime = startTime;
        countDown.fillAmount = (startTime/10);
        
    }

    void Update()
    {
        if (currentTime >= 0.01)
        {
            currentTime -= 1 * Time.deltaTime;
            timerText.text = currentTime.ToString("F2");

            countDown.fillAmount = (currentTime / 10);

            if (currentTime <= 3f)
            {
                StartCoroutine(boolSwitch());
            }
        }
        else
        {
            timerText.color = red;
            timerText.text = gameOver;
        }
       


    }

    IEnumerator boolSwitch()
    {       

        if (changeColour == true)
        {
            timerText.color = red;
            countDown.color = white;
            yield return new WaitForSeconds(.5f);
            changeColour = false;
        }
        else
        {
            timerText.color = white;
            countDown.color = red;
            yield return new WaitForSeconds(.5f);
            changeColour = true;
        }       
        StartCoroutine(boolSwitch());
    }
}

