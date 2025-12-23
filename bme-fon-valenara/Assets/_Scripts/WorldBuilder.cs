using System;
using System.Collections.Generic;
using System.Linq;

using Assets._Scripts.Generators;

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
        if (_cells.ContainsKey(position))
        {
            return;
        }

        var worldGeneration = DetermineGenerator(GenerationType.PerlinNoise);

        var generationHeight = worldGeneration.GenerateCellData(position, RandomSeed);

        GenerateCell(position, generationHeight);
    }

    private INoiseGenerator DetermineGenerator(GenerationType type)
    {
        switch (type)
        {
            case GenerationType.PerlinNoise:
                return new PerlinNoiseGenerator();
        }

        return new RandomNoiseGenerator();
    }

    private void GenerateCell(Vector2 position, float height)
    {
        var cellData = cellLibrary.CellDatas.First(x => x.MinHeight < height && x.MaxHeight >= height);
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
