using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AL.InGame.Character
{
    using AL.Tools.Template;
    using AL.Tools;
    using System.Linq;
    using AlexanderCA.Tools.Generics;
    using AL.Tools.Enums;

    public class AnimationController : AnimationTemplate
    {
        #region Attributes
        public Animator _animator;
        public float _posY;
        public float _posX;
        #endregion

        #region UnityCalls
        private void Update()
        {
            ToAnimationIdle();
        }

        private void LateUpdate()
        {
            _posX = transform.position.x;
            _posY = transform.position.y;
        }

        #endregion


        #region privat custom method
        protected override void ToAnimationJumping()
        {
            ToolsAlex.SetNewAnimation(Animations.none , _animator: _animator, _stringBool: "Jumping" , _boolState :true);

        }

        protected override void ToAnimationMovement()
        {
            if( this.transform.position.y == _posY )
            ToAnimation("Movement" , true);
        }

        protected override void ToAnimationIdle()
        {
            if ( this.transform.position.y == _posY && this.transform.position.x == _posX ) 
                ToAnimation("Idle" , true);
        }
        void ToAnimation(string _stringBool = "" , bool _boolState = false)
        {
            if ( _animator.runtimeAnimatorController != null )
            {
                bool parameterExists = _animator.parameters.Any(parameter => parameter.type == AnimatorControllerParameterType.Bool && parameter.name == _stringBool);
                if ( parameterExists )
                {
                    foreach ( var parameter in _animator.parameters) 
                    {
                        int  i = _animator.parameters.ToList().IndexOf( parameter );
                        if ( string.Compare(_animator.GetParameter(i).name.Trim() ,_stringBool.Trim()) == 0)
                        {
                            _animator.SetBool(_animator.GetParameter(i).name , false);
                        }
                    }
                    _animator.SetBool(_stringBool.ToString() , _boolState);
                }
            }
        }
    }
    #endregion
}

