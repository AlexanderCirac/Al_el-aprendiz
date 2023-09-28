using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace AL.Tools.Template
{
    using AL.Tools.Interface;
    public abstract class IATemplate : MonoBehaviour
    {
        #region Attributes
        [Inject]
        public IInputs inputs;
        #endregion

        #region UnityCalls
        public virtual void Awake()
        {
          //  TryGetComponent(out inputs);

        }
        public virtual void Update()
        {

        }

        #endregion

        #region abstract customs methods
        protected abstract void Movement();
        protected abstract void Attack();
        protected abstract void Dead();
        #endregion
    }
}
