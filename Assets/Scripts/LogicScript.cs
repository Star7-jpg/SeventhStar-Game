using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    [SerializeField] private int playerScore = 0; //Puntuación del jugador
    public Text scoreText; //Referencia al componente Text que muestra la puntuación
    public GameObject gameOverScreen; //Referencia a la pantalla de Game Over

    [ContextMenu("Incrementa la puntuación")] //Permite llamar a la función desde el menú contextual del componente en el editor
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd; //Incrementa la puntuación del jugador
        scoreText.text = playerScore.ToString(); //Actualiza el texto de la puntuación en pantalla
    }

    public void restarScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Recarga la escena actual
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true); //Muestra la pantalla de Game Over
    }
}
