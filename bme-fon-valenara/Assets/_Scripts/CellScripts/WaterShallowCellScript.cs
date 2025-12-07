using UnityEngine;

public class WaterShallowCellScript : MonoBehaviour
{
    public Color GroundColor = new Color(133 / 255.0f, 216 / 255.0f, 229 / 255.0f);

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
