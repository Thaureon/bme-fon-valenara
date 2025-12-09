using System;
using System.Collections.Generic;

using UnityEngine;

using Random = UnityEngine.Random;

public class WorldBuilder : MonoBehaviour
{
    public GameObject CellPrefab;
    public int Width;
    public int Height;
    private List<GameObject> Cells;

    public int RandomSeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (RandomSeed == 0)
        {
            RandomSeed = Random.Range(-1000000, 1000000);
        }

        Cells = new List<GameObject>();
        for (var w = 0; w < Width; w++)
        {
            for (var h = 0; h < Height; h++)
            {
                var newCell = Instantiate(CellPrefab, new Vector3(w - Width / 2f, h - Height / 2f, 0), CellPrefab.transform.localRotation);

                var sx = (w + RandomSeed) / 20f;
                var sy = (h + RandomSeed) / 20f;

                var cellType = Math.Floor(Mathf.PerlinNoise(sx, sy) * 7.0f);

                Debug.Log(cellType);

                Debug.Log(Mathf.PerlinNoise((w + RandomSeed) / 20.0f, (h + RandomSeed) / 20.0f));

                switch (cellType)
                {
                    case 0:
                        newCell.AddComponent<PlainCellScript>();
                        break;
                    case 1:
                        newCell.AddComponent<ForestCellScript>();
                        break;
                    case 2:
                        newCell.AddComponent<WaterShallowCellScript>();
                        break;
                    case 3:
                        newCell.AddComponent<WaterDeepCellScript>();
                        break;
                    case 4:
                        newCell.AddComponent<DesertCellScript>();
                        break;
                    case 5:
                        newCell.AddComponent<RockyCellScript>();
                        break;
                    case 6:
                        newCell.AddComponent<MountainCellScript>();
                        break;
                    default:
                        Debug.Log($"CellType not one of possible cases: {cellType}");
                        break;
                }

                Cells.Add(newCell);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
