using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class steps : MonoBehaviour
{
    private AudioSource audioData;
     public AudioClip walking;
     Controller pw;

     public float posx; //var for player x position
     public float posz; //var for player z position
    public float oldposx; //var for keeping track of old/new position on x axis
    public float oldposz; //var for keeping track of old/new position on z axis
    public Transform player1; //Make players position accesible 
     
 
    void Start()
    {
        audioData = gameObject.GetComponent<AudioSource>(); //Create audio object
        pw = new Controller(); //instantiate object pw from Controller
   }

    void Update()
   {
        posx = player1.transform.position.x; //Set posx to players x pos
        posz = player1.transform.position.z; //Set posx to players z pos
    
        if(oldposx != posx || oldposz != posz){ //Check if movement is happening
            Debug.Log("Walking");
            oldposz = posz;
            oldposx = posx;
        }
        else{
            Debug.Log("Not Walking"); // if oldpos and pos are the same, not walking
            audioData.clip=walking; //Why here tho, audioclip have to be in not walking, dunno why. 
            audioData.Play();
        }

       
   }
}

