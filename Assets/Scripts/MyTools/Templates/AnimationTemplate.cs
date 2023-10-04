using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Zenject;

namespace AL.Tools.Template
{
using AL.Tools.Interface;
    public abstract class AnimationTemplate : MonoBehaviour
    {

        #region Attributes

        // [HideInInspector]
       // [Inject]
        private CharacterTamplate _characterMovements;
       
        #endregion

        #region UnityCalls
        private void Awake()
        {

            _characterMovements._delegateInputsJump += ToAnimationJumping;
            _characterMovements._delegateInputsMovement += ToAnimationMovement;
        }
     
        private void OnDestroy()
        {
            _characterMovements._delegateInputsJump -= ToAnimationJumping;
            _characterMovements._delegateInputsMovement -= ToAnimationMovement;
        }
        #endregion

        #region abstract customs methods
        protected abstract void ToAnimationMovement();
        protected abstract void ToAnimationJumping();
        protected abstract void ToAnimationIdle();
        #endregion
    }
}
