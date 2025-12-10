using System;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

using Random = UnityEngine.Random;

public class WorldBuilder : MonoBehaviour
{
    public GameObject CellPrefab;
    public int Width;
    public int Height;
    private List<GameObject> Cells;


    public int RandomSeed;
    public TMP_InputField SeedInputField;
    public GameObject CellParent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateWorld();
    }

    public void SetSeed()
    {
        var randomSeedValue = SeedInputField.text;

        var hasSeed = int.TryParse(randomSeedValue, out RandomSeed);

        if (!hasSeed)
        {
            RandomSeed = Random.Range(-1000000, 1000000);
        }

        if (string.IsNullOrEmpty(SeedInputField.text))
        {
            SeedInputField.text = $"{RandomSeed}";
        }
    }

    public void GenerateWorld()
    {
        ClearCellHolder();
        SetSeed();

        Cells = new List<GameObject>();
        for (var w = 0; w < Width; w++)
        {
            for (var h = 0; h < Height; h++)
            {
                var newCell = Instantiate(CellPrefab, new Vector3(w - Width / 2f, h - Height / 2f, 0), CellPrefab.transform.localRotation);

                newCell.transform.SetParent(CellParent.transform);

                var sx = (w + RandomSeed) / 20f;
                var sy = (h + RandomSeed) / 20f;
                //-477571
                var perlinValue = Math.Clamp(Mathf.PerlinNoise(sx, sy), 0.0f, 1.0f);

                var cellType = Math.Floor(perlinValue * 7.0f);

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

    private void ClearCellHolder()
    {
        foreach (Transform child in CellParent.transform)
        {
            Destroy(child.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
