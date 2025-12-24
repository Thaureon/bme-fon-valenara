using UnityEngine;

namespace Assets._Scripts.Generators
{
    public class RandomNoiseGenerator : INoiseGenerator
    {
        public GenerationType GenerationType = GenerationType.RandomNoise;

        public float GenerateCellData(Vector2 position, int seed)
        {
            var randX = Random.Range(-1.0f, 1.0f) / 2.0f;

            var randY = Random.Range(-1.0f, 1.0f) / 2.0f;

            return randX + randY;
        }
    }
}