using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace DailyrewardSystem
{
    public class DailyReward : MonoBehaviour
    {
        [Header("Main Menu")]
        [SerializeField] Text coinText;

        [Space]

        [Header("Reward UI")]
        [SerializeField] GameObject coinCanvas;
        [SerializeField] Button OpenButton;


        [Space]

        [Header("Reward Database")]
        [SerializeField] RewardDatabase db;
        public struct Reward
        {
            public RewardType type;
            public int Amount;
        }

        private void Start()
        {
            Initalize();
        }
        void Initalize()
        {
            updateCoinTextUI();
            OpenButton.onClick.AddListener(openButton);
        }
        private void updateCoinTextUI()
        {

            coinText.text = GameData.Coins.ToString();
        }

        void openButton()
        {
            coinCanvas.SetActive(true);
        }
    }
}