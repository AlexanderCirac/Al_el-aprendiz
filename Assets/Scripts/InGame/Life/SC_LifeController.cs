using UnityEngine;
using System;

namespace AL.Life
{
    public class SC_LifeController : MonoBehaviour
    {

      #region Attribute
      [SerializeField] GameObject[] _lifeSprite;
      [SerializeField] int _lifeMax = 3;
      internal int _lifeCurrent => _lifeMax;
      internal static event Action _lifeEvent;
      #endregion

      #region Unity Calls

      // Start is called before the first frame update
      void Start() => Init();


      // Update is called once per frame
      #endregion

      #region custom private methods
      void Init()
      {
          _lifeEvent?.Invoke();
          
      }
      void ControladorSprite()
      {
            for (int i = 0; i < (_lifeCurrent - _lifeMax ) ; i++)
            {
                _lifeSprite[1].SetActive(false);
            }

            if (0 == _lifeCurrent)
            {
                _lifeEvent -= ControladorSprite;
            }
      }
      #endregion
    }
}


