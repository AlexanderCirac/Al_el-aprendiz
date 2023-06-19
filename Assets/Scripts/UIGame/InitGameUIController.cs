using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Al.UIGame
{
    public class InitGameUIController : MonoBehaviour
    {
        #region Attributes
        [HideInInspector]
        public float _timeAnimation;
        [HideInInspector]
        public Animator _animatior;
        [HideInInspector]
        public Button _animationButton;
        [HideInInspector]
        public int _level = -1;

        #endregion

        #region Unity Calls
        void Start()
        {
            _animationButton?.onClick.AddListener(ToActiveLevel);
        }

        #endregion

        #region custom privat method
        void ToActiveLevel()
        {
            _animatior.SetBool("isLoading",true);
            Invoke(nameof(LoadLevel) , _timeAnimation);
            Debug.Log("hola");
        }
        void LoadLevel()
        {
            SceneManager.LoadScene(_level);
        }
        #endregion
    }
}
