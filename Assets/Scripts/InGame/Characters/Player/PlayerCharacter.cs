using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AL.InGame.Character
{
    using AL.Tools.Interface;
    using AL.Tools.Template;
    public class PlayerCharacter : CharacterTamplate, ILife
    {
        #region Attributes

        private Rigidbody rb;
        public SpriteRenderer _spritePlayer;
        public float _life;
        public float _currentLife { get => _life; set => _life = value; }
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

        public void DamageLife(float _damge)
        {
            _life -= _damge;
            if (_life < 0)
            {
                _life = 0;
            }
        }

        public void HealLife(float _healing)
        {
             _life += _healing;
            if (_life > 100)
            {
                _life = 1000;
            }
        }

        #endregion


    }
}
