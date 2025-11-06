using UnityEngine;

public class SwordMiddleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //Obtiene la referencia al LogicScript en el objeto con la etiqueta "Logic"
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3) //Si colisiona con un objeto de la capa "Angel"
        {
            logic.addScore(1); //Incrementa la puntuación del jugador en 1
        }
    }
}
