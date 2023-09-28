using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace AL.InGame.Inputs
{
    using AL.Tools.Interface;
    using AL.Tools.Enums;
    using UnityEngine.EventSystems;

    [System.Serializable]
    public class Buttons1
    {
        public eButtonAction _iD;
        public Button _buttonActionLefthand;
        public Button _buttonActionRightHand;
        public float Velocity;
    }

    public class PlayerInputs : MonoBehaviour, IInputs
    {
        #region Attributes

        public Buttons1[] _controllsInputs;

        public float GetHorizontal()
        {
            float _currentVelocity = 0;
            for ( int i = 0 ; i < _controllsInputs.Length ; i++ )
            {
                if ( _controllsInputs[i]._iD == eButtonAction.ButtonMoveRight )
                {
                    if ( _controllsInputs[i]._buttonActionLefthand.GetComponent<IButtonHandle>() != null && _controllsInputs[i]._buttonActionLefthand.GetComponent<IButtonHandle>().IsDown == true )
                        _currentVelocity = _controllsInputs[i].Velocity;


                    if ( _controllsInputs[i]._buttonActionRightHand.GetComponent<IButtonHandle>() != null && _controllsInputs[i]._buttonActionRightHand.GetComponent<IButtonHandle>().IsDown == true )
                        _currentVelocity = _controllsInputs[i].Velocity;
                }
            }
            return _currentVelocity;
        }
        public float velocity;
        public float GetJump()
        {
            float velocity = 0;

            velocity = this.velocity;
            Invoke(nameof(RestartVelocityJump) , 0.1f);
            return velocity;
        }

        public float GetVertical()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region UnityCalls

        void Start()
        {
            for ( int i = 0 ; i < _controllsInputs.Length ; i++ )
            {
                if ( _controllsInputs[i]._iD == eButtonAction.ButtonJump )
                {
                    int id = i;
                    _controllsInputs[i]._buttonActionLefthand.onClick.AddListener(() => velocity = _controllsInputs[id].Velocity);
                    _controllsInputs[i]._buttonActionRightHand.onClick.AddListener(() => velocity = _controllsInputs[id].Velocity);
                }
            }
        }
        #endregion


        #region privat custom method
        void RestartVelocityJump()
        {
            velocity = 0;
        }
        #endregion

    }
}
