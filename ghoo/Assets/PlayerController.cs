using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
        public float playerSpeed = 10f;
        public Rigidbody2D playerRb;

        private Vector2 _movement;

        public Animator playerAnimator;
        private Vector2 _previousPosition;

        private void Start()
        {
            _previousPosition = playerRb.position;
        }


        void Update()
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");
        }

        private void FixedUpdate()
        {
             playerRb.MovePosition(playerRb.position + _movement * playerSpeed);
            
        //animation
        if (playerRb.position == _previousPosition)
        {

        }
        }

}
