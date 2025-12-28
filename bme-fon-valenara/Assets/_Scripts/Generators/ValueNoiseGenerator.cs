using Unity.Mathematics;

using UnityEngine;

using Random = UnityEngine.Random;

namespace Assets._Scripts.Generators
{
    public class ValueNoiseGenerator : INoiseGenerator
    {
        public GenerationType GenerationType = GenerationType.ValueNoise;

        public float GenerateCellData(Vector2 position, int seed)
        {
            return Random.Range(-1.0f, 1.0f);
        }
    }
}