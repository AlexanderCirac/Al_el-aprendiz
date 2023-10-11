using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AL.InGame.Inputs
{
    using AL.Tools.Interface;
    using AL.Tools.Enums;
    using UnityEngine.EventSystems;

    public class EnemyImputs : MonoBehaviour, IInputs
    {
        #region Attributes
        public float _velocity;
        public float _rangeMax;
        public float _currentPositionX;
        public bool  _isIgnoreGround;
        public bool  _isGroundAgain;
        public float GetHorizontal()
        {
            float _velocity = this._velocity;
            if (  this.transform.position.x < ( _currentPositionX - _rangeMax )/* "-6"*/  && this._velocity  < 1)
            {
                _velocity = this._velocity * -1;
                this._velocity = _velocity;
            }
            else if (  this.transform.position.x > ( _currentPositionX + _rangeMax )/* "6"*/&& this._velocity > 1)
            {
                _velocity = -this._velocity;
                this._velocity = _velocity;
            }

            if ( !_isIgnoreGround )
            {
                RaycastHit hit;
                Vector3 center = transform.position;

                // Calcula la mitad del tamaño del objeto
                Vector3 halfSize = transform.localScale / 2f;
                Vector3 rayOrigin = center - halfSize;
                Vector3 rayDirection = (_velocity < 1f) ? new Vector3(rayOrigin.x-10,rayOrigin.y-5,rayOrigin.z)  :new Vector3(rayOrigin.x+10,rayOrigin.y-5,rayOrigin.z)  ;

                if ( Physics.Raycast(rayOrigin , rayDirection    , out hit) )
                {
                    if ( hit.collider.gameObject.CompareTag("Ground") )
                    {
                        _isGroundAgain = true;
                    }
                    else
                    {
                        if ( _isGroundAgain &&  hit.collider == null)
                        {
                            if ( this._velocity < 1 )
                            {
                                _velocity = this._velocity * -1;
                                this._velocity = _velocity;
                            }
                            else if ( this._velocity > 1 )
                            {
                                _velocity = -this._velocity;
                                this._velocity = _velocity;

                            }
                            _isGroundAgain = false;
                        }

                    }
                }
            }

            return _velocity * Time.deltaTime;
        }
        public float GetJump()
        {
            return 0;
        }

        public float GetVertical()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Attrbutes
        void Awake()
        {
            _currentPositionX = transform.position.x;
        }
        #endregion
    }
}
