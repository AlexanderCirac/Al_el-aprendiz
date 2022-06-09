using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AL.Data;

namespace AL.UI
{
    public class SC_InicioUiController : MyMonoBehaviour
    {
          #region Attributes
          [Header("Buttons")]
          [SerializeField] private Button _loadButton;
          [Header("Panels")]
          [SerializeField] private GameObject _panelAnimation;
          [Header("Setting")]
          [SerializeField] private Image _brightness;
          [SerializeField] private AudioSource _music;
          #endregion
    
          #region UnityCalls
          void Awake() => Init();
          void Update() => ToSettings();
          #endregion

          #region custom private methods
          void Init()
          {
              //start game 
              if (Application.targetFrameRate != 60)
              {
                   Application.targetFrameRate = 60;
              }
              //OnClick
              _loadButton.onClick.AddListener(ToAnimationButton);
          }
          void ToAnimationButton()
          {
              _panelAnimation.SetActive(true);
              Invoke(nameof(ToLoadLevel),1.2f);
          }
          void ToLoadLevel()
          {
              SceneManager.LoadScene(1);
          }

          void ToSettings()
          {
              _brightness.color = new Color(_brightness.color.r, _brightness.color.g, _brightness.color.b, _settingData._valueBrightness - 0.1f);
              _music.volume = _settingData._valuenMusica;
          }          
          #endregion
    }
}
