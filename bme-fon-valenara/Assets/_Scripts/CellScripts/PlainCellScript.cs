using UnityEngine;

public class PlainCellScript : MonoBehaviour
{
    public Color GroundColor = new Color(192 / 255.0f, 255 / 255.0f, 109 / 255.0f);

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
