
using UnityEngine;

namespace wizardscode.environment
{
    [CreateAssetMenu(fileName = "Spawnable Dancer", menuName = "Wizards Code/Environment/Spawnable Dancer")]
    public class SpawnableDancer : SpawnableObject
    {
        [Header("Dancer configuration")]
        [Tooltip("Minimum Tempo of the beat these dancers are dancing to. Make this the same as the maxTempo if you want your dancers to be perfectly in time.")]
        [Range(0.3f, 1.4f)]
        public float minTempo = 1f;
        [Tooltip("Maximum Tempo of the beat these dancers are dancing to. Make this the same as the minTempo if you want your dancers to be perfectly in time.")]
        [Range(0.3f, 1.4f)]
        public float maxTempo = 1f;
        [Tooltip("Minimum Energy of the dancers, the higher this is the more they will move. Make this the same as the maxEnergy if you want your dancers to be consistent.")]
        [Range(0.75f, 1.25f)]
        public float minEnergy = 1f;
        [Tooltip("Maximum Tempo of the beat these dancers are dancing to. Make this the same as the minTempo if you want your dancers to be perfectly in time.")]
        [Range(0.75f, 1.25f)]
        public float maxEnergy = 1f;
    }
}
