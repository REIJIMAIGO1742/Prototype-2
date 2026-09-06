using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public int maxHP = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("HP || " + maxHP);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (maxHP <= 1)
        {
            Debug.Log("Game Over!!!");
        }
        else
        {
            maxHP -= 1;
            Debug.Log("HP || " + maxHP);
        }
    }
}
