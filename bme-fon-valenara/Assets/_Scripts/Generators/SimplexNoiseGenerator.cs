using Unity.Mathematics;

using UnityEngine;

namespace Assets._Scripts.Generators
{
    public class SimplexNoiseGenerator : INoiseGenerator
    {
        public GenerationType GenerationType = GenerationType.SimplexNoise;

        public float GenerateCellData(Vector2 position, int seed)
        {
            var sx = (position.x + seed) / 20.0f;
            var sy = (position.y + seed) / 20.0f;

            var noiseValue = Mathf.Clamp(noise.snoise(new float2(sx, sy)), -1.0f, 1.0f);

            return noiseValue;
        }
    }
}