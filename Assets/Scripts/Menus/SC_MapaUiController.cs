using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AL.Data;

namespace AL.UI
{
    public class SC_MapaUiController : MonoBehaviour
    {
          #region Attributes
          [Header("Button")]
          [SerializeField] private Button _quitButton;
          [System.Serializable] public class ButtonLevel {
            [SerializeField] private string _name;
            public Button _levelButton;
            public int _iDLevel;
          }
          [SerializeField] private ButtonLevel[] _arryLevel;
          private int _levelDataPlayer;
          [Header("UI Settings")]
          [SerializeField] private Image _brightness;          
          private AudioSource _music;
          [Header("Panel")]
          [SerializeField] private GameObject _loadingPanel;

          //Main Tools
          [HideInInspector] private SC_SettingsDataPersisten _dataPlayer;
          #endregion

          #region UnityCalls
          private void Awake()
          {
              _dataPlayer = SC_SettingsDataPersisten._instanceData;
              _levelDataPlayer = _dataPlayer._levelCurrentSave;
              _music = _dataPlayer.GetComponentInChildren<AudioSource>();
          }
          private void Start()
          {     
              // onClick and show button
              for (int i = 1; i <= _arryLevel.Length; i++)
              {
                  int _count = i;
                  _arryLevel[i-1]._levelButton.onClick.AddListener(() =>LoadingLevel(_count-1));
                  if(_count <= _levelDataPlayer)
                  {
                     _arryLevel[i-1]._levelButton.interactable = true;
                  }
              }
              _quitButton.onClick.AddListener(() => Application.Quit());

          }
          private void Update()
          {
              ApplicateUISettings();
          }
          #endregion

          #region Methods
          private void ApplicateUISettings()
          {
              //brightness intensity controller
              _brightness.color = new Color(_brightness.color.r, _brightness.color.g, _brightness.color.b, _dataPlayer._valueBrightness - 0.1f);
              //Controll volum of music
              _music.volume = _dataPlayer._valuenMusica;
             
          }

          private void LoadingLevel(int _int)
          {
              _loadingPanel.SetActive(true);
              SceneManager.LoadScene(_arryLevel[_int]._iDLevel);
          }
        #endregion
    }
}
