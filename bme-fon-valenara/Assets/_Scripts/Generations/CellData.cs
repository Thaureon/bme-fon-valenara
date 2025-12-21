using UnityEngine;

[CreateAssetMenu(fileName = "CellData", menuName = "Valenara/Cells/CellData")]
public class CellData : ScriptableObject
{
    public GameObject Prefab;

    [SerializeField]
    private Color groundColor; // = new(253 / 255.0f, 208 / 255.0f, 23 / 255.0f);
}
