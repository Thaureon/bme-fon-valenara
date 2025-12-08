using UnityEngine;

public class BaseCellScript : MonoBehaviour
{
    public virtual Color GroundColor { get; set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected void BaseStart()
    {
        var groundRender = gameObject.GetComponentInChildren<MeshRenderer>();
        groundRender.material.color = GroundColor;
    }

    // Update is called once per frame
    protected void BaseUpdate()
    {
        
    }
}
