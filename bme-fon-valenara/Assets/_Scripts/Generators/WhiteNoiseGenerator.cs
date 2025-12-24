using UnityEngine;

namespace Assets._Scripts.Generators
{
    public class WhiteNoiseGenerator : INoiseGenerator
    {
        public GenerationType GenerationType = GenerationType.WhiteNoise;

        public float GenerateCellData(Vector2 position, int seed)
        {
            return Random.Range(-1.0f, 1.0f);
        }
    }
}