using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//used code from here https://www.youtube.com/watch?v=bzZeUI-HDq8
public class LightFlicker : MonoBehaviour
{
    public float flickerIntensity = 20;
    public float flickersPerSecond = 0.05f;
    public float speedRandomness = 7.0f;
 
    private float time;
    private float startingIntensity;
    private Light light;
 
    void Start()
    {
        light = GetComponent<Light>();
        startingIntensity = light.intensity;
    }
    
    void Update()
    {
        time += Time.deltaTime * (1 - Random.Range(-speedRandomness, speedRandomness)) * Mathf.PI;
        Debug.Log("Sin is ");
        Debug.Log(Mathf.Sin(time * flickersPerSecond) * 20);
        light.intensity = 15 * Mathf.Sin(time * flickersPerSecond) * flickerIntensity;
    }
}