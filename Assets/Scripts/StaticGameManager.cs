using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinCollector
{
    public static class StaticGameManager
    {
        private static int _remainingCoins;

        public static int RemainingCoins
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
    }
}
