using UnityEngine;

public class SwordMoveScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5;
    public float deadZone = -32;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; //Mueve la espada hacia la izquierda a la velocidad definida

        if (transform.position.x < deadZone) //Si la espada sale de la pantalla por la izquierda entonces se destruye
        {
            Debug.Log("Espada destruida");
            Destroy(gameObject);
        }
    }
}
