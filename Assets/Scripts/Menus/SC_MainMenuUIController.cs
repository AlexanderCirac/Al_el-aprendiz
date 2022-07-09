using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AL.Data;
using System.Collections;

namespace AL.UI
{
  public class SC_MainMenuUIController : ALBehaviour
  {
    #region Attributes
    [Header("Buttons")]
    [SerializeField] private Button _quitButton;
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _dLCButton;
    [System.Serializable]
    public class ButtonsReturnMenu
    {
      public Button _buttons;
    }
    [Header("Buttons to return to menu")]
    [SerializeField] private ButtonsReturnMenu[] _arrayButtonsMenus;
    [SerializeField] private Button _optionButton;
    [SerializeField] private Button _creditButton;
    [Header("Panels")]
    [SerializeField] private GameObject _dLCPanel;
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _optionPanel;
    [SerializeField] private GameObject _creditPanel;
    [SerializeField] private GameObject _animationForwardPanel;
    [SerializeField] private GameObject _animationBackPanel;
    #endregion

    #region UnityCalls
    void Awake() => Init();
    #endregion

    #region custom private methods
    void Init()
    {
      //Start game
      Time.timeScale = 1;

      // Button OnClick
      _quitButton.onClick.AddListener(() => Application.Quit());
      _playButton.onClick.AddListener(() => SceneManager.LoadScene(2));
      for (int i = 1; i <= _arrayButtonsMenus.Length; i++)
      {
        _arrayButtonsMenus[i - 1]._buttons.onClick.AddListener(() => StartCoroutine(CorrutineHiddenPanel()));
      }
      _optionButton.onClick.AddListener(() => StartCoroutine(CorrutineShowPanel(_optionPanel)));
      _creditButton.onClick.AddListener(() => StartCoroutine(CorrutineShowPanel(_creditPanel)));
      _dLCButton.onClick.AddListener(ToCloseDLC);
    }

    void ToCloseDLC()
    {
      _settingData._isFirstDLC = true;
      _playerData.Save();
      _dLCPanel.SetActive(false);
    }
    IEnumerator CorrutineShowPanel(GameObject _panel)
    {
      _menuPanel.SetActive(false);
      _animationForwardPanel.SetActive(true);
      yield return new WaitForSeconds(.45f);
      _animationForwardPanel.SetActive(false);
      _panel.SetActive(true);
    }
    IEnumerator CorrutineHiddenPanel()
    {
      _optionPanel.SetActive(false);
      _creditPanel.SetActive(false);
      _animationBackPanel.SetActive(true);
      yield return new WaitForSeconds(.45f);
      _animationBackPanel.SetActive(true);
      _menuPanel.SetActive(true);
    }
    #endregion
  }

}
