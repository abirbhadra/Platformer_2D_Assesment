using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject gameOver, youWin;

    public PlayerHealth playerhealth;
    public PlayerController playerController;

    private void Update()
    {
        if (playerhealth.playerDead == true)
        {
            gameOver.SetActive(true);
        }
        if(playerController.playerwin == true)
        {
            youWin.SetActive(true);
        }
    }



}
