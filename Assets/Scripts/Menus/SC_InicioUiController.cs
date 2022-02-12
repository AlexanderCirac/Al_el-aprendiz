using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AL.Data;

namespace AL.UI
{
    public class SC_InicioUiController : MonoBehaviour
    {
          #region Attributes
          [Header("Buttons")]
          [SerializeField] private Button _loadButton;
          [Header("Panels")]
          [SerializeField] private GameObject _panelAnimation;
          [Header("Setting")]
          [SerializeField] private Image _brightness;
          [SerializeField] private AudioSource _music;

          // Main Tools
           [SerializeField] private SC_SettingsDataPersisten _dataPlayer;
          #endregion
    
          #region UnityCalls
          void Start()
          {
              //start game 
              if (Application.targetFrameRate != 60)
              {
                   Application.targetFrameRate = 60;
              }
              //OnClick
              _loadButton.onClick.AddListener(ActiveAnimation);
          }
          private void Update()
          {
              ControlSettings();
          }
          #endregion

          #region Methods
          private void ActiveAnimation()
          {
              _panelAnimation.SetActive(true);
              Invoke(nameof(LoadLevel),1.2f);
          }
          private void LoadLevel()
          {
              SceneManager.LoadScene(1);
          }

          private void ControlSettings()
          {
              _brightness.color = new Color(_brightness.color.r, _brightness.color.g, _brightness.color.b, _dataPlayer._valueBrightness - 0.1f);
              _music.volume = _dataPlayer._valuenMusica;
          }          
          #endregion
    }
}
