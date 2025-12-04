using System.Collections.Generic;

using UnityEngine;

public class WorldBuilder : MonoBehaviour
{
    public GameObject CellPrefab;
    public int Width;
    public int Height;
    private List<GameObject> Cells;
        

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cells = new List<GameObject>();
        for (var w = 0; w < Width; w++)
        {
            for (var h = 0; h < Height; h++)
            {
                var newCell = Instantiate(CellPrefab, new Vector3(w - (Width / 2f), h - (Height / 2f), 0), CellPrefab.transform.localRotation);

                var renderered = newCell.GetComponent<MeshRenderer>();
                renderered.material.color = new Color(w * 1.0f / Width, h * 1.0f / Height, 1.0f);

                Cells.Add(newCell);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
