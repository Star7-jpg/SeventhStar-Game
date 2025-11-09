using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicioScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private string gameSceneName = "SampleScene"; //Nombre de la escena del juego
    
    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName); //Carga la escena del juego al iniciar el menú
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit(); //Cierra el juego
    }
}
