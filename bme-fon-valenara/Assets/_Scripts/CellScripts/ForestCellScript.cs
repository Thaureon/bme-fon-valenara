using UnityEngine;

public class ForestCellScript : BaseCellScript
{
    public override Color GroundColor { get; set; } = new (62 / 255.0f, 108 / 255.0f, 96 / 255.0f);

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
