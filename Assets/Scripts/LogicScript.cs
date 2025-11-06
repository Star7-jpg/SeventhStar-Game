using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    [SerializeField] private int playerScore = 0; //Puntuación del jugador
    public Text scoreText; //Referencia al componente Text que muestra la puntuación

    [ContextMenu("Incrementa la puntuación")] //Permite llamar a la función desde el menú contextual del componente en el editor
    public void addScore( int scoreToAdd ) 
    {
        playerScore = playerScore + scoreToAdd; //Incrementa la puntuación del jugador
        scoreText.text = playerScore.ToString(); //Actualiza el texto de la puntuación en pantalla
    }
}
