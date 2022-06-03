using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using AL.UI.Interface;
using AL.Data;

namespace AL.UI
{
  public class SC_InGameUiController : MyMonoBehaviour
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

    #endregion

    #region UnityCalls
    void Start()
    {
      //Buttons
      _winButton.onClick.AddListener(ToWin);
      for (int i = 1; i <= _buttonsToCancelMenu._button.Length; i++)
      {
        _buttonsToCancelMenu._button[i - 1].GetComponent<SC_Touch>().OnHold.AddListener(ToShowMenu);
        _buttonsToCancelMenu._button[i - 1].GetComponent<SC_Touch>().OnRealise.AddListener(ToHiddenMenu);
      }

    }
    #endregion

    #region Methods
    private void ToWin()
    {
      if (_currentLevel > _settingData._levelCurrentSave)
      {
        _settingData._levelCurrentSave++;
        _playerData.Save();
      }
      _loadingPanel.SetActive(true);
      SceneManager.LoadScene(2);
    }
    private void ToShowMenu()
    {
      _menuButtonPanel.SetActive(true);
    }
    private void ToHiddenMenu()
    {
      _menuButtonPanel.SetActive(false);
    }
    #endregion
  }

}