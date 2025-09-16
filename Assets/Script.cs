using UnityEngine;

[CreateAssetMenu(fileName = "Script", menuName = "Scriptable Objects/Script")]
public class Script : ScriptableObject
{
    public GameObject prefab;
    public int cantidad = 5;
    public float distancia = 2f;
    public Vector3 direccion = Vector3.right;

}
