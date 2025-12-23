using UnityEngine;

namespace Assets._Scripts.Generators
{
    public class PerlinNoiseGenerator : INoiseGenerator
    {
        public GenerationType GenerationType = GenerationType.PerlinNoise;

        public float GenerateCellData(Vector2 position, int seed)
        {
            var sx = (position.x + seed) / 20f;
            var sy = (position.y + seed) / 20f;

            var noiseValue = Mathf.Clamp(Mathf.PerlinNoise(sx, sy), 0.0f, 1.0f) * 2.0f - 1.0f;

            return noiseValue;
        }
    }
}