using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Controller : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
     [SerializeField] float turnSpeed = 20f;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

         /*
         * GetAxis returns a value between -1 and 1 (and not zero) when a left or right arrow key (or 'A' or 'D')
         * is pressed.  For simplicity and readability, I'm storing that value in a variable called 'horizontalInput'
         */
        float horizontalInput = Input.GetAxis("Horizontal");
 
        /*
         * Here we use 'Vector3.up' since using it here is equivalent to rotating around the y axis (0, 1, 0).
         * Also, because 'horizontalInput' can be negative when the 'left' arrow or 'A' is pressed, it will
         * make the Y rotation negative, thus rotating the player to the left.  A positive value rotates to the
         * right.
         */
         if (Input.GetKeyDown(KeyCode.D)){
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime,90);
       // transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
         }

         if (Input.GetKeyDown(KeyCode.A)){
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime,90);
       // transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
         }

        

        // Move forward / backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);

        if(Input.GetKeyDown(KeyCode.Escape)){
          quit();
        }

    
    }

    void quit(){
      Application.Quit(); 
      Debug.Log("Quit");
    }
}