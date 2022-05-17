using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    AudioSource audioData;
  private void OnTriggerEnter(Collider other)
  {
      if (other.CompareTag("Player"))
      {
          audioData = GetComponent<AudioSource>();
          audioData.Play(0);
          }
  }
}
