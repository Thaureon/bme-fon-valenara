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
    private Dictionary<(int x, int y), GameObject> _cells;

    public int RandomSeed;
    public TMP_InputField SeedInputField;
    public GameObject CellParent;

    public PlayerMovementScript PlayerMovementScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _cells = new Dictionary<(int x, int y), GameObject>();
        GenerateWorldWithNewSeed();
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

    public void GenerateWorldWithNewSeed()
    {
        SetSeed();
        GenerateWorld();

        PlayerMovementScript.MovePlayer(new Vector2(0, 0));
    }

    public void GenerateWorld()
    {
        ClearCellHolder();

        for (var w = 0; w < Width; w++)
        {
            for (var h = 0; h < Height; h++)
            {
                var position = new Vector2(w, h);
                AddCell(position);
            }
        }
    }

    public void GenerateWorld(Vector2 newPosition)
    {
        ClearCellHolder();
        
        for (var w = 0; w < Width; w++)
        {
            for (var h = 0; h < Height; h++)
            {
                var position = new Vector2(w + newPosition.x, h + newPosition.y);
                AddCell(position);
            }
        }
    }

    private void AddCell(Vector2 position)
    {
        var x = (int)position.x;
        var y = (int)position.y;

        var newCell = Instantiate(CellPrefab, new Vector3(x - Width / 2f, y - Height / 2f, 0), CellPrefab.transform.localRotation);

        newCell.transform.SetParent(CellParent.transform);

        var sx = (x + RandomSeed) / 20f;
        var sy = (y + RandomSeed) / 20f;
        //-477571
        var perlinValue = Math.Clamp(Mathf.PerlinNoise(sx, sy), 0.0f, 1.0f);

        var cellType = (int)Math.Floor(perlinValue * 7.0f);

        DetermineCell(newCell, cellType);

        _cells.Add((x, y), newCell);
    }

    private void DetermineCell(GameObject cell, int cellType)
    {
        switch (cellType)
        {
            case 0:
                cell.AddComponent<PlainCellScript>();
                break;
            case 1:
                cell.AddComponent<ForestCellScript>();
                break;
            case 2:
                cell.AddComponent<WaterShallowCellScript>();
                break;
            case 3:
                cell.AddComponent<WaterDeepCellScript>();
                break;
            case 4:
                cell.AddComponent<DesertCellScript>();
                break;
            case 5:
                cell.AddComponent<RockyCellScript>();
                break;
            case 6:
                cell.AddComponent<MountainCellScript>();
                break;
            default:
                Debug.Log($"CellType not one of possible cases: {cellType}");
                break;
        }
    }

    private void ClearCellHolder()
    {
        foreach (Transform child in CellParent.transform)
        {
            Destroy(child.gameObject);
        }
        _cells.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
