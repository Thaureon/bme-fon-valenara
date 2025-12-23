using UnityEngine;

[CreateAssetMenu(fileName = "CellData", menuName = "Valenara/Cells/CellData")]
public class CellData : ScriptableObject
{
    public GameObject Prefab;

    [SerializeField]
    public Color GroundColor;

    public float MinHeight;
    public float MaxHeight;
}
