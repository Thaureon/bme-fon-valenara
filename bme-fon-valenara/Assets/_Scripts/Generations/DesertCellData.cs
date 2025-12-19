using UnityEngine;

[CreateAssetMenu(fileName = "DesertCellData", menuName = "Scriptable Objects/DesertCellData")]
public class DesertCellData : CellData
{
    public Color GroundColor { get; set; } = new(253 / 255.0f, 208 / 255.0f, 23 / 255.0f);
}
