using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AL.UI.Interface
{
    public class SC_ButtonOptionMap : MonoBehaviour
    {   
        #region Attribute
        //esta script es para controlar la animacion 
        [Header("Panels")]
        [SerializeField] private GameObject _openAnimScroll;
        [SerializeField] private GameObject _closeAnimScroll;          
        [SerializeField] private GameObject _panelOptions;          
        [Header("Buttons")]
        [SerializeField] private Button _openButtonScroll;
        [SerializeField] private Button _closeButtonScroll;
        [Header("Int")]
        [SerializeField] private int _currentLevel;
        #endregion

        #region UnityCalls
        // Start is called before the first frame update
        void Start()
        {
              //buttons on click
              _openButtonScroll.onClick.AddListener(FunctionMapButton);
        }
        #endregion

        #region Methods
        private void FunctionMapButton()
        {
            //Funtion for  map level
            if (_currentLevel == 2)
            {
                _openAnimScroll.SetActive(true);
                _closeAnimScroll.SetActive(false);
                Invoke(nameof(LoadLevel),.5f);
            }
            //Function for other level
            else
            {

            }
        }
        private void LoadLevel ()
        {
            SceneManager.LoadScene(1);
        }
        #endregion
    }
}
