using System;
using System.Collections.Generic;
using System.Linq;

using TMPro;

using UnityEngine;

using Random = UnityEngine.Random;

public class WorldBuilder : MonoBehaviour
{
    public int BaseRadius;
    private Dictionary<Vector2, GameObject> _cells;

    public int RandomSeed;
    public TMP_InputField SeedInputField;
    public GameObject CellParent;

    public PlayerMovementScript PlayerMovementScript;

    public CellLibrary cellLibrary;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _cells = new Dictionary<Vector2, GameObject>();
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

        var totalArea = BaseRadius * 2 + 1;

        for (var x = -BaseRadius; x < totalArea - BaseRadius; x++)
        {
            for (var y = -BaseRadius; y < totalArea - BaseRadius; y++)
            {
                var position = new Vector2(x, y);
                AddCell(position);
            }
        }
    }

    public void GenerateWorld(Vector2 newPosition, int visionLength)
    {
        var totalArea = visionLength * 2 + 1;

        var startPositionX = newPosition.x - visionLength;
        var startPositionY = newPosition.y - visionLength;

        for (var x = startPositionX; x < totalArea + startPositionX; x++)
        {
            for (var y = startPositionY; y < totalArea + startPositionY; y++)
            {
                var position = new Vector2(x, y);
                AddCell(position);
            }
        }
    }

    private void AddCell(Vector2 position)
    {
        var x = (int)position.x;
        var y = (int)position.y;
        var cellPosition = new Vector2(x, y);

        if (_cells.ContainsKey(cellPosition))
        {
            return;
        }

        var sx = (x + RandomSeed) / 20f;
        var sy = (y + RandomSeed) / 20f;

        var perlinValue = Math.Clamp(Mathf.PerlinNoise(sx, sy), 0.0f, 1.0f);

        var cellType = (int)Math.Floor(perlinValue * 7.0f);

        DetermineCell(position, cellType);
    }

    private void DetermineCell(Vector2 position, int cellType)
    {
        var cellData = cellLibrary.CellDatas[cellType];
        var newCell = Instantiate(cellData.Prefab, new Vector3(position.x, position.y, 0), cellData.Prefab.transform.localRotation);

        newCell.transform.SetParent(CellParent.transform);

        newCell.AddComponent<BaseCellScript>();
        newCell.GetComponent<BaseCellScript>().CellData = cellData;

        _cells.Add(position, newCell);
    }

    private void ClearCellHolder()
    {
        foreach (var cell in _cells)
        {
            Destroy(cell.Value);
        }
        _cells.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
