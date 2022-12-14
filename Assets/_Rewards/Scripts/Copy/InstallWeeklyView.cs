using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rewards
{
    public class InstallWeeklyView : MonoBehaviour
    {
        [SerializeField] private WeeklyRewardView _weeklyRewardView;

        private WeeklyRewardController _weeklyRewardController;

        private void Awake() =>
            _weeklyRewardController = new WeeklyRewardController(_weeklyRewardView);

        private void Start() =>
            _weeklyRewardController.Init();

        private void OnDestroy() =>
            _weeklyRewardController.Deinit();
    }
}

