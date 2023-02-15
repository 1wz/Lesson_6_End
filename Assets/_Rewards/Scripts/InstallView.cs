using UnityEngine;

namespace Rewards
{
    internal class InstallView : MonoBehaviour
    {
        [SerializeField] private DailyRewardView _dailyRewardView;
        [SerializeField] private DailyRewardView _weeklyRewardView;

        private DailyRewardController _dailyRewardController;
        private DailyRewardController _weeklyRewardController;


        private void Awake()
        {
            _dailyRewardController = new DailyRewardController(_dailyRewardView);
            _weeklyRewardController = new DailyRewardController(_weeklyRewardView);
        }
        private void Start()
        {
            _dailyRewardController.Init();
            _weeklyRewardController.Init();
        }
        private void OnDestroy()
        {
            _dailyRewardController.Deinit();
            _weeklyRewardController.Deinit();
        }
    }
}
