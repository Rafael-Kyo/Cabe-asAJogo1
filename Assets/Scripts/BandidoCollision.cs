using UnityEngine;
using UnityEngine.SceneManagement; // Necess�rio para trocar de cena

public class BandidoCollision : MonoBehaviour
{
    [SerializeField]
    private string gameOverSceneName = "GameOver"; // Nome da cena de Game Over

    // Fun��o chamada automaticamente quando h� uma colis�o
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto colidido possui a tag "Player" ou outra relevante
        if (collision.gameObject.CompareTag("Player"))
        {
            // Carrega a cena de Game Over
            SceneManager.LoadScene(gameOverSceneName);
        }
    }
}
