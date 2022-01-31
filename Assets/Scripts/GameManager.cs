using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinCollector
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject gameManagerObject = new GameObject("# Game Manager");
                    _instance = gameManagerObject.AddComponent<GameManager>();
                }
                
                return _instance;
            }
        }
        
        private int _remainingCoins;

        public int RemainingCoins
        {
            get => _remainingCoins;
            set
            {
                _remainingCoins = value;
                
                UIManager.Instance.UpdateCoinsAmount(_remainingCoins);

                if (_remainingCoins <= 0)
                {
                    //Debug.Log("Hai completato il livello.");
                    UIManager.Instance.WinMessageTextEnabled = true;
                }
            }
        }

        private void Awake()
        {
            _instance = this;
        }
        
/*
        public void AddCoin() => _remainingCoins++;

        public void RemoveCoin()
        {
            _remainingCoins--;
            if (_remainingCoins <= 0)
            {
                Debug.Log("Hai completato il livello.");
            }
        }*/
    }
}
