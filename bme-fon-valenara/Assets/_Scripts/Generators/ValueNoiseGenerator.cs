using UnityEngine;

namespace Assets._Scripts.Generators
{
    public class ValueNoiseGenerator : INoiseGenerator
    {
        public GenerationType GenerationType = GenerationType.ValueNoise;

        public float GenerateCellData(Vector2 position, int seed)
        {

            var noiseValue = 0.0f;

            for(var counter = 0; counter < 25; counter++)
            {
                var sx = ((counter % 5 - 2) + position.x + seed);
                var sy = ((counter / 5 - 2) + position.y + seed);

                noiseValue += GetNoiseValue(sx, sy, seed) * 2.0f;
            }

            noiseValue /= 9;

            noiseValue = Mathf.Clamp(noiseValue, -1.0f, 1.0f);

            return noiseValue;
        }

        private float GetNoiseValue(float x, float y, int seed)
        {
            Random.InitState(x.GetHashCode() + y.GetHashCode() + seed);
            return Random.Range(-1.0f, 1.0f);
        }
    }
}