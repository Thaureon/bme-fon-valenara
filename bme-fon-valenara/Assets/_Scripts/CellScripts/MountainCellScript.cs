using UnityEngine;

public class MountainCellScript : BaseCellScript
{
    public override Color GroundColor { get; set; } = new (106 / 255.0f, 90 / 255.0f, 93 / 255.0f);

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
