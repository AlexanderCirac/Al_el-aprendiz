using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AL.Data;
using System.Collections;

namespace AL.UI
{
    public class SC_MainMenuUIController : MonoBehaviour
    {
         #region Attributes
          [Header("Buttons")]
          [SerializeField] private Button _buttonQuit;          
          [SerializeField] private Button _buttonPlay;
          [SerializeField] private Button _buttonDLC;
          [System.Serializable] public class ButtonsReturnMenu 
          {
               public Button _buttons;
          }
          [Header("Buttons to return to menu")]
          [SerializeField] private ButtonsReturnMenu[] _buttonsReturnMenu;
          [SerializeField] private Button _buttonOptions;
          [SerializeField] private Button _buttonCredits;
          [Header("Panels")]
          [SerializeField] private GameObject _panelDLC;
          [SerializeField] private GameObject _panelMenu;
          [SerializeField] private GameObject _panelOptions;
          [SerializeField] private GameObject _panelCredits;
          [SerializeField] private GameObject _panelAnimationForward;
          [SerializeField] private GameObject _panelAnimationBack;
          #endregion

          #region UnityCalls
          private void Awake()
          {
              //if(SC_SettingsDataPersisten._instanceData._firstDLC)
              //      _panelDLC.SetActive(false);
          }
          private void Start()
          {   
              //Start game
              Time.timeScale = 1;

              // Button OnClick
              _buttonQuit.onClick.AddListener(() => Application.Quit());
              _buttonPlay.onClick.AddListener(() => SceneManager.LoadScene(2));
              for (int i = 1; i <= _buttonsReturnMenu.Length; i++)
              {
                  _buttonsReturnMenu[i-1]._buttons.onClick.AddListener(() => StartCoroutine(DesactivatePanel()));
              }
              _buttonOptions.onClick.AddListener(() => StartCoroutine(ActivatePanelAnimation(_panelOptions)));
              _buttonCredits.onClick.AddListener(() => StartCoroutine(ActivatePanelAnimation(_panelCredits)));
              _buttonDLC.onClick.AddListener(CerrarDLC);
          }
          #endregion  
    
          #region Methods
          public void CerrarDLC()
          {
              SC_SettingsDataPersisten._instanceData._firstDLC = true;
              SC_SaveAndLoadPlayerData._instance.Save();
              _panelDLC.SetActive(false);
          }          
          IEnumerator ActivatePanelAnimation( GameObject _panel)
          {
              _panelMenu.SetActive(false);
              _panelAnimationForward.SetActive(true);
              yield return new WaitForSeconds(.45f);
              _panelAnimationForward.SetActive(false);
              _panel.SetActive(true);
          }          
          IEnumerator DesactivatePanel()
          {
             _panelOptions.SetActive(false);
             _panelCredits.SetActive(false);
             _panelAnimationBack.SetActive(true);
             yield return new WaitForSeconds(.45f);
             _panelAnimationBack.SetActive(true);
             _panelMenu.SetActive(true);
          }
          #endregion
    }

}
