using Unity.VisualScripting;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public Script spawnerData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
        for (int i = 0; i < spawnerData.cantidad; i++)
        {
            Vector3 posicion = transform.position + spawnerData.direccion.normalized * spawnerData.distancia * i;
            Instantiate(spawnerData.prefab, posicion, Quaternion.identity);
        }
    }
}
