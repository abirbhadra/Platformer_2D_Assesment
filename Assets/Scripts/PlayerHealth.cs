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
        health -= 5*Time.deltaTime;
        Debug.Log(health);
        healthBar.fillAmount -= 0.2f * Time.deltaTime;

        if (health <= 0)
        {
            playerDead = true;
            
        }
    }

}
