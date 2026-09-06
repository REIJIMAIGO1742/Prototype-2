using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerConrollerB : MonoBehaviour
{
    public InputAction moveAction;
    public InputAction fireAction;
    public Vector2 moveInput;
    public float moveSpeed = 10.0f;
    public float xRange = 10.0f;
    public float zRange = 16.0f;
    public float zRange2 = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Keep player in bound
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRange2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange2);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        moveInput = moveAction.ReadValue<Vector2>();

        transform.Translate(Vector3.forward * moveInput.y * Time.deltaTime * moveSpeed);
        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * moveSpeed);

        if (fireAction.triggered)
        {
            // Luah Projectile From Player
            GameObject pooletProjectile = ObjectPooler.SharedInstance.GetPooledObject();
            if (pooletProjectile != null)
            {
                pooletProjectile.SetActive(true);
                pooletProjectile.transform.position = transform.position;
            }
        }

    }

    
}
