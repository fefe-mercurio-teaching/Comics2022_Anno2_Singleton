using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinCollector
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed;

        private void Start()
        {
            //GameManager.Instance.RemainingCoins++;
            StaticGameManager.RemainingCoins++;
        }

        private void Update()
        {
            transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime, Space.World);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(gameObject);
                //GameManager.Instance.RemainingCoins--;
                StaticGameManager.RemainingCoins--;
            }
        }
    }
}