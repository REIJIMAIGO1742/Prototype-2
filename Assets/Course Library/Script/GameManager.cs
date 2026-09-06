using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    private int nowScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        { 
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Score || " + nowScore);
    }

    public void AddScore(int newScore)
    {
        nowScore += newScore;
        Debug.Log("Score || " + nowScore);
        
    }

}
