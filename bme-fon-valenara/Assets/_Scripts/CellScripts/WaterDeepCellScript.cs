using UnityEngine;

public class WaterDeepCellScript : MonoBehaviour
{
    public Color GroundColor = new Color(0 / 255.0f, 89 / 255.0f, 179 / 255.0f);

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
