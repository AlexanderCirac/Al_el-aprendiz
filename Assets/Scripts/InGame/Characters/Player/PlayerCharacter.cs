using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AL.InGame.Character
{
    using AL.Tools.Template;
    public class PlayerCharacter : CharacterTamplate
    {
        #region Attributes

        private Rigidbody rb;
        public SpriteRenderer _spritePlayer;
        #endregion

        #region UnityCalls
        private void Start()
        {
            rb = GetComponent<Rigidbody>();

        }
        #endregion


        #region privat custom method


        public override void Update()
        {
            base.Update();
        }
        protected override void ToJumping()
        {
            rb.AddForce(Vector3.up * _inputs.GetJump() , ForceMode.Impulse);
        }
        protected override void ToMovement()
        {
            rb.AddForce(Vector3.left * _inputs.GetHorizontal());
        }
        protected override void ToRotate()
        {
            if ( this.transform.position.x > 0.1f )
            {
                _spritePlayer.flipX = false;
            }
            else
            {
                _spritePlayer.flipX = true;
            }
        }

        #endregion


    }
}
