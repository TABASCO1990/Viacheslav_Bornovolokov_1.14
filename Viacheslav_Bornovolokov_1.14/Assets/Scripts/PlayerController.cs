using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;
    private float horizontalInput;
    private float vetrticalInput;
    
    private float xRange = 19.5f;
    private float yRange = 10.2f;
   
    
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        vetrticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * vetrticalInput * Time.deltaTime * speed);
        
        if (transform.position.x < -xRange)
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        
        if (transform.position.x > xRange)
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
     
        if (transform.position.z < -yRange)
            transform.position = new Vector3(transform.position.x, transform.position.y, -yRange);
        
        if (transform.position.z > yRange)
            transform.position = new Vector3(transform.position.x, transform.position.y, yRange);
        
    }
}
