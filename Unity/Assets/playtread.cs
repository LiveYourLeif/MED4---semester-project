using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class playtread : MonoBehaviour
{
    AudioSource audioData;

    void Start()
    {
        
        audioData = GetComponent<AudioSource>();
        StartCoroutine(exampleCoroutine());
        
        Debug.Log("started");
   }

   IEnumerator exampleCoroutine()
   {
       
        Debug.Log("delayed" + Time.time);
        yield return new WaitForSeconds(Random.Range(1,10));
        audioData.Play(0);
        Debug.Log("finish" + Time.time);
       
   }
}
