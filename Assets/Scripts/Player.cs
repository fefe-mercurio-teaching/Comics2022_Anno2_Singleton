using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CoinCollector
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _walkSpeed;

        private void Update()
        {
            float speed = _walkSpeed * Time.deltaTime;

            float vertical = Input.GetAxis("Vertical") * speed;
            float horizontal = Input.GetAxis("Horizontal") * speed;
            
            transform.Translate(horizontal, 0f, vertical);
        }
    }
}