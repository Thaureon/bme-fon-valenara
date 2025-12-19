using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CellData", menuName = "Scriptable Objects/CellData")]
public class CellLibrary : ScriptableObject
{
    public List<CellData> CellDatas;
}
