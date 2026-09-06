using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider hungerBar;

    public void SetMaxHealth(float maxHunGer)
    { 
        hungerBar.maxValue = maxHunGer;
        hungerBar.value = 0;
    }

    public void UpdateHungerBar(float currenHunger)
    { 
        hungerBar.value = currenHunger;
    }
}
