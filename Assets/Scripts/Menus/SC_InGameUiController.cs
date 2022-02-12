using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using AL.UI.Interface;
using AL.Data;

namespace AL.UI
{
    public class SC_InGameUiController : MonoBehaviour
    {
          #region Attributes
          [Header("int")]
          [SerializeField] private int _currentLevel;
          [Header("Buttons")]
          [SerializeField] private Button _winButton;
          [System.Serializable]
          public class ButtonsToCancelMenu
          { 
             public Button[] _button;
          }
          [SerializeField] private ButtonsToCancelMenu _buttonsToCancelMenu;  
          [Header("Panels")]
          [SerializeField] private GameObject _loadingPanel;          
          [SerializeField] private GameObject _menuButtonPanel;
          // private bool _loadingPanel;

          //main tools
          SC_SettingsDataPersisten  _settingsData;
          SC_SaveAndLoadPlayerData  _saveLoadData;
          #endregion

          #region UnityCalls
          private void Awake()
          {
               _settingsData = SC_SettingsDataPersisten._instanceData;
               _saveLoadData = SC_SaveAndLoadPlayerData._instance;
          }
          void Start()
          {
              //Buttons
              _winButton.onClick.AddListener(Win);
              for (int i = 1; i <= _buttonsToCancelMenu._button.Length; i++)
                {
                    _buttonsToCancelMenu._button[i - 1].GetComponent<SC_Touch>().OnHold.AddListener(CancelMenuButton);
                    _buttonsToCancelMenu._button[i - 1].GetComponent<SC_Touch>().OnRealise.AddListener(ActivateMenuButton);
                }              
                    
          }
          #endregion

          #region Methods
          private void Win()
          {
               if (_currentLevel > _settingsData._levelCurrentSave)
               {
                    _settingsData._levelCurrentSave++;
                    _saveLoadData.Save();
               }
               _loadingPanel.SetActive(true);
               SceneManager.LoadScene(2);
          }          
          private void CancelMenuButton()
          {
              _menuButtonPanel.SetActive(true);
          }          
          private void ActivateMenuButton()
          {
              _menuButtonPanel.SetActive(false);
          }
          #endregion
    }

}
