using UnityEngine;

[CreateAssetMenu(fileName = "Script", menuName = "Scriptable Objects/Script")]
public class Script : ScriptableObject
{
    public GameObject prefab;
    public int cantidad ;
    public float distancia ;
    public Vector3 direccion;

}
