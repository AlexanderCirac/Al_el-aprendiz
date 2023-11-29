using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace AL.InGame.Inputs
{
    using AL.Tools.Interface;
    using AL.Tools.Enums;
    using UnityEngine.EventSystems;
    using System.Linq;

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

       public List<Buttons1> _controllsInputs;
       public Buttons1[] _controllsInputs2;
        

        public float GetHorizontal()
        {
         
            float _currentVelocity = 0;
            foreach (var item in _controllsInputs)
            {
                int index = _controllsInputs.IndexOf(item);


                if (_controllsInputs[index]._iD == eButtonAction.ButtonMoveRight)
                {
                    if (_controllsInputs[index]._buttonActionLefthand.GetComponent<IButtonHandle>() != null && _controllsInputs[index]._buttonActionLefthand.GetComponent<IButtonHandle>().IsDown == true)
                        _currentVelocity = _controllsInputs[index].Velocity;


                    if (_controllsInputs[index]._buttonActionRightHand.GetComponent<IButtonHandle>() != null && _controllsInputs[index]._buttonActionRightHand.GetComponent<IButtonHandle>().IsDown == true)
                        _currentVelocity = _controllsInputs[index].Velocity;
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
            foreach (var item in _controllsInputs)
            {
                int index = _controllsInputs.IndexOf(item);
                if (_controllsInputs[index]._iD == eButtonAction.ButtonJump)
                {
                    _controllsInputs[index]._buttonActionLefthand.onClick.AddListener(() => velocity = _controllsInputs[index].Velocity);
                    _controllsInputs[index]._buttonActionRightHand.onClick.AddListener(() => velocity = _controllsInputs[index].Velocity);
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
