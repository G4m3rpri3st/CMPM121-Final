using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{
    public Material newsky;

    public GameObject light;

    // Update is called once per frame
    void Update()
    {
        changesky();
    }

    void changesky()
    {
        if(CollectibleCount.count == 5){
            RenderSettings.skybox = newsky;
            light.SetActive(true);
            CollectibleCount.count = 0;
        }
    }
}
