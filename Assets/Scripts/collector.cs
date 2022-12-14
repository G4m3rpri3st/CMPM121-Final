using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class collector : MonoBehaviour
{
    public static event Action OnCollected;
    public AudioSource gemSound;
    public static int total;

    void Awake() => total++;



    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            OnCollected?.Invoke();
            Destroy(gameObject);
            gemSound.Play();
        }
    }
}
