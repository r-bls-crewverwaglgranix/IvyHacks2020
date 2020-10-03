using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Player {
    public class PlayerMovement : MonoBehaviour
    {
        public float speed = 5f; //Floating point variable to store the player's movement speed.
        
        private Rigidbody2D _rb2d; //Store a reference to the Rigidbody2D component required to use 2D Physics.
        private Vector2 _movement;

        // Use this for initialization
        void Start()
        {
            _rb2d = GetComponent<Rigidbody2D>(); // Get attached RigidBody2D
        }

        private void Update()
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");
        }

        //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
        void FixedUpdate()
        {
            _rb2d.MovePosition(_rb2d.position + _movement * (speed * Time.fixedDeltaTime));
        }
    }
}