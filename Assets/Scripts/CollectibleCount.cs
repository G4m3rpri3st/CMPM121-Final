using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleCount : MonoBehaviour
{
    // Start is called before the first frame update
    TMPro.TMP_Text text;
    int count;

    void Awake(){
        text = GetComponent<TMPro.TMP_Text>();
    }
    void Start() => UpdateCount();

    void OnEnable() => collector.OnCollected += OnCollectibleCollected;
    void OnDisable() => collector.OnCollected -= OnCollectibleCollected;

    void OnCollectibleCollected(){
        text.text = (++count).ToString();
        UpdateCount();
    }

    void UpdateCount(){
        text.text = $"{count} / {collector.total}";
    }

}
