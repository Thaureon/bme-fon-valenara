using Unity.Mathematics;

using UnityEngine;

namespace Assets._Scripts.Generators
{
    public class CellularNoiseGenerator : INoiseGenerator
    {
        public GenerationType GenerationType = GenerationType.CellularNoise;

        public float GenerateCellData(Vector2 position, int seed)
        {
            var sx = (position.x + seed) / 20.0f;
            var sy = (position.y + seed) / 20.0f;

            var cellularNoise = noise.cellular(new float2(sx, sy));

            var noiseValue = Mathf.Clamp(cellularNoise.x + cellularNoise.y - 1.0f, -1.0f, 1.0f);

            return noiseValue;
        }
    }
}