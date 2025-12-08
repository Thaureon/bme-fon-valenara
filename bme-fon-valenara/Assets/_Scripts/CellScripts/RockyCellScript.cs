using UnityEngine;

public class RockyCellScript : BaseCellScript
{
    public override Color GroundColor { get; set; } = new (161 / 255.0f, 163 / 255.0f, 165 / 255.0f);

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
