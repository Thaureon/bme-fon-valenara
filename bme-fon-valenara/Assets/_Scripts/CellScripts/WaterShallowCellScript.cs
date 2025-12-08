using UnityEngine;

public class WaterShallowCellScript : BaseCellScript
{
    public override Color GroundColor { get; set; } = new (133 / 255.0f, 216 / 255.0f, 229 / 255.0f);

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
