using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class countdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startTime = 10f;
    public float countdown;
    [SerializeField] TMP_Text CountdownDisplay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CountdownToStart()
    {
        while (countdown > 0)
        {
            CountdownDisplay.text = countdown.ToString();

            yield return new WaitForSeconds(1f);
            countdown--;
        }
        CountdownDisplay.text = "GO!";

        yield return new WaitForSeconds(1f);

        CountdownDisplay.gameObject.SetActive(false);
    }
}
