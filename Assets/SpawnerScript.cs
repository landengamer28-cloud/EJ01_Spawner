using Unity.VisualScripting;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public Script spawnerData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Si no hay spawnerData o prefab, salir
        if (spawnerData == null || spawnerData.prefab == null)
        {
            Debug.LogWarning("Spawner o prefab no asignado.");
            return;
        }

        SpawnLinea();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnLinea()
    {
        // Instanciar los prefabs en linea segun los datos del spawner
        for (int i = 0; i < spawnerData.cantidad; i++)
        {
            Vector3 posicion = transform.position + spawnerData.direccion.normalized * spawnerData.distancia * i;
            Instantiate(spawnerData.prefab, posicion, Quaternion.identity);
        }
    }
}
