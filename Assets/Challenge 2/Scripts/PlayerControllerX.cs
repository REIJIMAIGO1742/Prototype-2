using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public InputAction fireAction;

    public float cooldown = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        fireAction.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (fireAction.triggered)
        {
            StartCoroutine(SpawnDog());
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }

        
    }

    IEnumerator SpawnDog()
    {
        fireAction.Disable();
        yield return new WaitForSeconds(cooldown);
        fireAction.Enable();
    }

}
