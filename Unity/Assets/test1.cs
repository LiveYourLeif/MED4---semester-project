using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class test1 : MonoBehaviour
{

    //public TextAsset test;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("ReadString", 2.0f, 1.0f);
    }
   
     public void ReadString()
   {
       string path = Application.persistentDataPath + "/test.txt";
       //Read the text directly from the test.txt file
       StreamReader reader = new StreamReader(path);
       Debug.Log(reader.ReadToEnd());
       reader.Close();

   }

  /* public void Update()
   {
        if (reader == 'w')
            rb.AddForce(Vector3.up);
   }
  */  // Update is called once per frame
}
