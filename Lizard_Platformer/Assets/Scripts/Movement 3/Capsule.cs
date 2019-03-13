using UnityEngine;
using System.Collections;
 
public class Capsule : MonoBehaviour {
    private Rigidbody rb;
    public float speed = 100.0F;
    public float raycastLength = 0.52F;
 
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent <Rigidbody> ();
 
    }
 
    void Update ()
    {
        float translation = Input.GetAxis ("Vertical") * speed;
        float straffe = Input.GetAxis ("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
     
        transform.Translate (straffe, 0, translation);
     
        if(Physics.Raycast(transform.position, -transform.up, raycastLength))
     
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 atas = new Vector3 (0,3500,0);
                rb.AddForce(atas, ForceMode.Impulse);
            }
 
 
        if (Input.GetKeyDown ("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
 
 
}
 
 
