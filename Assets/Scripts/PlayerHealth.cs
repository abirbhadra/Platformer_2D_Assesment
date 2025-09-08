using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    public float health = 20;
    [SerializeField]
    private Image healthBar;
    public bool playerDead;

    public void ReduceHealth()
    {
        health -= 5;
        Debug.Log(health);
        healthBar.fillAmount -= 0.2f;

        if (health == 0)
        {
            playerDead = true;
            
        }
    }

}
