using UnityEngine;
using UnityEngine.UI;

namespace AL.Player
{
    public class SC_DuckController : SC_PlayerBehaviour
    {

        #region Attributes
        //Bools for control Ducking
        bool _isDucking;
        bool _isCantDucking;
          
        //Buttons controller
        [SerializeField] Button _duckLeft;
        [SerializeField] Button _duckRight;        
        
        //Player animation
        [SerializeField] GameObject _duckAnimation;
        [SerializeField] GameObject _unduckAnimation;

        //normalize Scale
        private float m_normalX;
        private float m_normalY;
        private float m_normalZ;
        #endregion

        #region Unity Calls
        void Awake() => Init();
        #endregion

        #region custom private methods
        void Init()
        {
            m_normalX = this.transform.localScale.x;
            m_normalY = this.transform.localScale.y;
            m_normalZ = this.transform.localScale.z;
            
            _duckLeft.onClick.AddListener(AnimacionAgachar);
            _duckRight.onClick.AddListener(AnimacionAgachar);
        }
        void AnimacionAgachar()
        {
            if (!_isCantDucking)
            {
                if (_isDucking)
                {
                  _duckAnimation.SetActive(true);
                  _unduckAnimation.SetActive(false);
                  this.transform.localScale = new Vector3((m_normalY / 3), (m_normalY / 3), (m_normalY / 3));
                }
                else
                {
                  _duckAnimation.SetActive(true);
                  _unduckAnimation.SetActive(false);
                  this.transform.localScale = new Vector3(m_normalY, m_normalY, m_normalZ);
                }
                _isDucking =!_isDucking;
            }

        }

        void OnTriggerEnter(Collider coll)
        {
          if (coll.CompareTag("Agachado"))
          {
              _isCantDucking = true;
          } 
        }
        void OnTriggerExit(Collider coll)
        {
          if (coll.CompareTag("Agachado"))
          {
              _isCantDucking = false;
          }
        }
        #endregion

    }
}
