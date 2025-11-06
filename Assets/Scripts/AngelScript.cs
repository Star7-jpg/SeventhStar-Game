using UnityEngine;

public class AngelScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Rigidbody2D myRigidbody; //Referencia al Rigidbody2D del ángel
    [SerializeField] private float flapStrength = 18; //Fuerza del aleteo
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength; //Aplica una fuerza hacia arriba al Rigidbody2D cuando se presiona la barra espaciadora
        }
    }
}
