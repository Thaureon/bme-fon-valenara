using UnityEngine;

public class PlainCellScript : BaseCellScript
{
    public override Color GroundColor { get; set; } = new (192 / 255.0f, 255 / 255.0f, 109 / 255.0f);

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
