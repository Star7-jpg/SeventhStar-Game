using UnityEngine;

public class SwordSpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject sword; //Referencia al prefab de la espada
    public float spawnRate = 2;
    private float timer = 0;

    void Start()
    {
        SpawnSword();
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
        Instantiate(sword, transform.position, transform.rotation);
    }
}
