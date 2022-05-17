using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text2Speech : MonoBehaviour
{
/*
    definerer vores Audioclips som skal indeholde text2speech.
*/
    public AudioClip toiletRoom;
    public AudioClip cafeRoom;
    public AudioClip changingRoom;
    public AudioClip fitnessRoom;
    public AudioClip poolRoom;
    public AudioClip jacuzziRoom;
    public AudioClip yogaRoom;
    public AudioClip shopRoom;
    public AudioClip receptionRoom;
    public AudioClip saunaRoom;
    public AudioClip barRoom;
    
    private AudioSource ap;

    void Start()
    {
       ap = gameObject.GetComponent<AudioSource>();  //Objekt der gør det muligt at tilgå audiofilen.
    }


    void Update()
    {

        /*
            Initialisere vores lyd via. ap objektet. Man kan styre hvilken lyd der afspilles ved at taste 1-0 og p.
        */    
    
        if (Input.GetKeyDown("1")) // toilets room.
        {
            ap.clip = toiletRoom;
            ap.Play();
        }

        if (Input.GetKeyDown("2")) // Cafe room.
        {
            ap.clip = cafeRoom;
            ap.Play();
        }

        if (Input.GetKeyDown("3")) //Changing room.
        {
            ap.clip = changingRoom;
            ap.Play();
        }

        if (Input.GetKeyDown("4")) //Fitness room.
        {
           ap.clip = fitnessRoom;
           ap.Play();
        }
        
        if (Input.GetKeyDown("5")) // Pool room.
        {
            ap.clip = poolRoom;
            ap.Play();
        }

        if (Input.GetKeyDown("6")) // Jacuzzi room.
        {
            ap.clip = jacuzziRoom;
            ap.Play();
        }

        if (Input.GetKeyDown("7")) // Yoga room
        {
            ap.clip = yogaRoom;
            ap.Play();
        }

        if (Input.GetKeyDown("8")) // Shop room
        {
            ap.clip = shopRoom;
            ap.Play();
        }

        if (Input.GetKeyDown("9")) // Reception room
        {
            ap.clip = receptionRoom;
            ap.Play();
        }

        if (Input.GetKeyDown("0")) // Sauna room
        {
            ap.clip = saunaRoom;
            ap.Play();
        }

        if (Input.GetKeyDown("p")) // Sauna room
        {
            ap.clip = barRoom;
            ap.Play();
        }
    }
}
