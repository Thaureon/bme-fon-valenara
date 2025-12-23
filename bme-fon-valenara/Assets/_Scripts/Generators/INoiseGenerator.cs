using UnityEngine;

namespace Assets._Scripts.Generators
{
    public interface INoiseGenerator
    {
        public float GenerateCellData(Vector2 position, int seed);
    }
}