using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//code from https://forum.unity.com/threads/make-text-appear-then-disappear.716453/
public class Fadein : MonoBehaviour{
public TMPro.TMP_Text StartText;
private float timeToAppear = 8f;
private float timeWhenDisappear;

    // Start is called before the first frame update
    void Start()
    {
        StartText = GetComponent<TMPro.TMP_Text>();
        EnableText();
    }

    public void EnableText(){
        StartText.enabled = true;
        timeWhenDisappear = Time.time + timeToAppear;
    }

    // Update is called once per frame
    void Update()
    {
        if (StartText.enabled && (Time.time >= timeWhenDisappear))
        {
            StartText.enabled = false;
        }   
    }
}
