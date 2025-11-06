using UnityEngine;

public class AngelScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Rigidbody2D myRigidbody; //Referencia al Rigidbody2D del ángel
    [SerializeField] private float flapStrength = 18; //Fuerza del aleteo
    public LogicScript logic; //Referencia al LogicScript

    public bool angelIsAlive = true; //Indica si el ángel está vivo
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && angelIsAlive == true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength; //Aplica una fuerza hacia arriba al Rigidbody2D cuando se presiona la barra espaciadora
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver(); //Llama a la función gameOver del LogicScript cuando el ángel colisiona con otro objeto
        angelIsAlive = false; //Indica que el ángel ha muerto
    }
}
