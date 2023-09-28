using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace AL.Tools.Template
{

    using AL.Tools.Interface;
    using UniRx;

    public abstract class CharacterTamplate : MonoBehaviour
    {
        #region Attributes

       // [HideInInspector]
        [Inject]
        public IInputs _inputs;

        #region Events 
        public delegate void MydelegateMovement();
        public MydelegateMovement _delegateInputsMovement { get; set; }

        public delegate void MydelegateRotate();
        public MydelegateRotate _delegateInputsRotate { get; set; }

        public delegate void MydelegateJump();
        public MydelegateJump _delegateInputsJump { get; set; }
        #endregion
        #endregion

        #region UnityCalls
        private void Awake()
        {
            Observable.EveryUpdate().Where(_ => _inputs.GetHorizontal() != 0).Subscribe(_ => _delegateInputsMovement?.Invoke());
            _delegateInputsMovement += ToMovement;         
            _delegateInputsMovement += ToRotate;
            Observable.EveryUpdate().Where(_ => _inputs.GetJump() != 0).Subscribe(_ => _delegateInputsJump?.Invoke());
       
        }
        public virtual void Update()
        {
            if ( _inputs.GetJump() != 0 )
            {
                ToJumping();
            }
        }
        private void OnDestroy()
        {
            _delegateInputsMovement -= ToMovement;
            _delegateInputsMovement -= ToRotate;
        }
        #endregion

        #region abstract customs methods
        protected abstract void ToMovement();
        protected abstract void ToJumping();
        protected abstract void ToRotate();
        #endregion
    }
}

