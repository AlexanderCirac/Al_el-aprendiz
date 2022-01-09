using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AL.Data;

namespace AL.UI
{
    public class SC_MainMenuUIController : MonoBehaviour
    {
         #region Attributes
          [Header("Buttons")]
          [SerializeField] private Button _buttonQuit;          
          [SerializeField] private Button _buttonPlay;
          [SerializeField] private Button _buttonDLC;
          [Header("Panels")]
          [SerializeField] private GameObject _panelDLC;
          #endregion

          #region UnityCalls
          private void Awake()
          {
              if(SC_SettingsDataPersisten._instanceData._firstDLC)
                    _panelDLC.SetActive(false);
          }
          private void Start()
          {   
              //Start game
              Time.timeScale = 1;

              // Button OnClick
              _buttonQuit.onClick.AddListener(() => Application.Quit());
              _buttonPlay.onClick.AddListener(() => SceneManager.LoadScene(2));
              _buttonDLC.onClick.AddListener(CerrarDLC);
          }
          #endregion  
    
          #region Methods
          public void CerrarDLC()
          {
              SC_SettingsDataPersisten._instanceData._firstDLC = true;
              _panelDLC.SetActive(false);
          }
          #endregion
    }

}
