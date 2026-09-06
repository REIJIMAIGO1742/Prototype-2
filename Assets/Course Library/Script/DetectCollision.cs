using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class DetectCollision : MonoBehaviour
{
    public HealthBar hungerBar;

    public float maxHunger;
    public float currenHunger;

    private void Start()
    {
        currenHunger = 0;
        hungerBar.SetMaxHealth(maxHunger);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            FeedTheFood(1);
            other.gameObject.SetActive(false);
        }
        
    }

    public void FeedTheFood(float feed)
    {
        currenHunger += feed;
        currenHunger = Mathf.Clamp(currenHunger, 0, maxHunger);
        hungerBar.UpdateHungerBar(currenHunger);
        
        if (currenHunger >= maxHunger)
        {
            GetComponent<Collider>().enabled = false;
            GameManager.instance.AddScore(1);
            Destroy(gameObject,0.2f);
        }
    }
}
