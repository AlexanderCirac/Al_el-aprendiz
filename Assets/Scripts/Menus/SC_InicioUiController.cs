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
          [SerializeField] private Button _loadLevel;
          [Header("Panels")]
          [SerializeField] private GameObject _panelAnimation;
          [Header("Setting")]
          [SerializeField] private Image _brightness;
          [SerializeField] private AudioSource _music;
           private bool _endSettingCorrutine;
          // Main Tools
           [SerializeField] private SC_DataPlayerPersisten _dataPlayer;
          #endregion
    
          #region UnityCalls
          // Start is called before the first frame update
          void Start()
          {
              _loadLevel.onClick.AddListener(ActiveAnimation);
              StartCoroutine(nameof(CorrutineSettings));
              FrameRate();
          }

          // Update is called once per frame
          private void OnDestroy()
          {
                _endSettingCorrutine = true;
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
          IEnumerator CorrutineSettings()
          {
                while(!_endSettingCorrutine)
                {
                  ControlSettings();
                  yield return null;
                }
          }
          private void ControlSettings()
          {
              _brightness.color = new Color(_brightness.color.r, _brightness.color.g, _brightness.color.b, _dataPlayer.m_Numero_Brillo - 0.1f);
              _music.volume = _dataPlayer.m_volumenMusica;
          }          
          private void FrameRate()
          {
              if (Application.targetFrameRate != 60)
              {
                   Application.targetFrameRate = 60;
              }
          }
          #endregion
    }
}
