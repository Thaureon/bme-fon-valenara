using UnityEngine;

public class ForestCellScript : MonoBehaviour
{
    public Color GroundColor = new Color(62 / 255.0f, 108/ 255.0f, 96 / 255.0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var groundRender = gameObject.GetComponentInChildren<MeshRenderer>();
        groundRender.material.color = GroundColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
