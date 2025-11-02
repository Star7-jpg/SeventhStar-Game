using UnityEngine;

public class SwordSpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject sword; //Referencia al prefab de la espada
    public float spawnRate = 3.3f; //Tasa de aparición en segundos
    private float timer = 0;

    public float heightOffset = 10;

    void Start()
    {
        SpawnSword(); //Llama a la función para instanciar la espada al inicio
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)  //Si el tiempo es menor que la tasa de aparición entonces comienza a contar el tiempo
        {
            timer += Time.deltaTime;
        }
        else //Si el tiempo es mayor o igual a la tasa de aparición entonces aparece la espada y reinicia el contador
        {
            SpawnSword();
            timer = 0;
        }
    }
    
    void SpawnSword() //Función para instanciar la espada
    {
        float lowestPoint = transform.position.y - heightOffset; //Define los puntos más alto y más bajo para la posición Y aleatoria
        float highestPoint = transform.position.y + heightOffset; 

        Instantiate(sword, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); //Instancia la espada en una posición aleatoria dentro del rango definido
    }
}
