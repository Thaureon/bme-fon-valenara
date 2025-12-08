using UnityEngine;

public class DesertCellScript : BaseCellScript
{
    public override Color GroundColor { get; set; } = new (253 / 255.0f, 208 / 255.0f, 23 / 255.0f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BaseStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
