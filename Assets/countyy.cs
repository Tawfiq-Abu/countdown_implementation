using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class countyy : MonoBehaviour
{

    float currentTime = 0f;
    float startTime = 10f;

    [SerializeField] TMP_Text CountdownDisplay;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1* Time.deltaTime;
        CountdownDisplay.text =currentTime.ToString("0");

        if (currentTime<=0){
            currentTime = 0;
            CountdownDisplay.text = "GO!";
            // new WaitForSeconds(2f);
            // CountdownDisplay.gameObject.SetActive(false);
        }
    }
}
