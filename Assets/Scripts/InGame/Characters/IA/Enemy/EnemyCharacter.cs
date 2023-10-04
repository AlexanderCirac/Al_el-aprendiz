using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AL.InGame.Character
{
    using AL.Tools.Template;
   // using Zenject;

    public class EnemyCharacter : IATemplate
    {
        #region Attributes
        public SpriteRenderer _imageAnimation;
        #endregion


        #region UnityCalls
        public override void Update()
        {
            base.Update();
            Movement();
        }
        #endregion

        #region privat custom method



        protected override void Attack()
        {
            Vector3 extens = new Vector3(this.transform.position.x + 10,this.transform.position.y+10,this.transform.position.z);
            Collider[]  _isPlayer = Physics.OverlapBox(this.transform.position,transform.localScale / 2,Quaternion.identity, LayerMask.NameToLayer("Player"));
            if ( _isPlayer.Length > 0)
            {
                //do damage
            }
        }

        protected override void Dead()
        {
            throw new System.NotImplementedException();
        }

        protected override void Movement()
        {
            this.transform.position = new Vector3(this.transform.position.x + inputs.GetHorizontal() , this.transform.position.y , this.transform.position.z);

            _imageAnimation.flipX = inputs.GetHorizontal() > 1 ? true : false;

        }


        #endregion


    }
}

