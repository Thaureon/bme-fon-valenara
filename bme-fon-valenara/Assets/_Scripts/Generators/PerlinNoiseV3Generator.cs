using Unity.Mathematics;
using UnityEngine;

namespace Assets._Scripts.Generators
{
    public class PerlinNoiseV3Generator : INoiseGenerator
    {
        public GenerationType GenerationType = GenerationType.PerlinNoiseV2;

        public float GenerateCellData(Vector2 position, int seed)
        {
            var sx = (position.x + seed) / 20.0f;
            var sy = (position.y + seed) / 20.0f;

            var noiseValue = Mathf.Clamp(noise.pnoise(new float2(sx, sy), new float2(sx * 20, sy * 20)), -1.0f, 1.0f);

            return noiseValue;
        }
    }
}