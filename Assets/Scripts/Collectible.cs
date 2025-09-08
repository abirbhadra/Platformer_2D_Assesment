using UnityEngine;
using TMPro;
public class Collectible : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;
    [SerializeField]
    private int score = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("coin"))
        {
            collision.gameObject.SetActive(false);
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }

}
