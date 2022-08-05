using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rewards
{
    [CreateAssetMenu(fileName = nameof(RewardSO), menuName = "Configs/"+nameof(RewardSO))]
    internal class RewardSO : ScriptableObject
    {
        [SerializeField] private List<Reward> _reawards;        
    }
}
