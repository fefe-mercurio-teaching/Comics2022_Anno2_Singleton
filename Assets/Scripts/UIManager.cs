using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CoinCollector
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager _instance;

        public static UIManager Instance => _instance;

        [SerializeField] private Text remainingCoinsText;
        [SerializeField] private Text winMessageText;

        public bool WinMessageTextEnabled
        {
            get => winMessageText.gameObject.activeSelf;
            set => winMessageText.gameObject.SetActive(value);
        }

        private void Awake()
        {
            _instance = this;
            WinMessageTextEnabled = false;
        }

        public void UpdateCoinsAmount(int amount)
        {
            remainingCoinsText.text = $"Monete rimanenti: {amount}";
        }
    }
}
