using UnityEngine;

namespace Assets._Scripts.Generators
{
    public class RandomNoiseGenerator : INoiseGenerator
    {
        public GenerationType GenerationType = GenerationType.RandomNoise;

        public float GenerateCellData(Vector2 position, int seed)
        {
            var x = (int)position.x;
            var y = (int)position.y;
            var cellPosition = new Vector2(x, y);

            var sx = (x + seed) / 20f;
            var sy = (y + seed) / 20f;

            return Mathf.PerlinNoise(sx, sy);
        }
    }
}