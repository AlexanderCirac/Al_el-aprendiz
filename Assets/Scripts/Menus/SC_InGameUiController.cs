using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using AL.UI.Settings;
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
          [Header("Panels")]
          [SerializeField] private GameObject _loadingPanel;

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
          }

          private void OnDestroy()
          {

          }

          private void Update()
          {
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
          #endregion
    }

}
