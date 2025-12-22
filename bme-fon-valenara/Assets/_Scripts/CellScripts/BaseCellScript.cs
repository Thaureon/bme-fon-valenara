using UnityEngine;

public class BaseCellScript : MonoBehaviour
{
    public CellData CellData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected void Start()
    {
        var groundRender = gameObject.GetComponentInChildren<MeshRenderer>();
        groundRender.material.color = CellData.GroundColor;
    }

    // Update is called once per frame
    protected void Update()
    {
        
    }
}
