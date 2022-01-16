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
          [SerializeField] private Button _quitGame;
          [System.Serializable] public class ButtonLevel {
            public string _name;
            public Button _buttonToLevel;
            public int _intLevel;
          }
          [SerializeField] private ButtonLevel[] _buttonLevel;
          [System.Serializable] public class ShowButtons {
            public string _name;
            public Button _buttonToShow;
          }
          [SerializeField] private ShowButtons[] _showButtons;
          private int _levelDataPlayer;
          [Header("UI Settings")]
          [SerializeField] private Image _brightness;          
          private AudioSource _music;
          [Header("Panel")]
          [SerializeField] private GameObject _panelLoading;

          //Main Tools
          [HideInInspector] private SC_SettingsDataPersisten _dataPlayer;
          //bools
          private bool _endCorrutine;
          #endregion

          #region UnityCalls
          private void Awake()
          {
              _dataPlayer = SC_SettingsDataPersisten._instanceData;
          }
          private void Start()
          {     
              _music = _dataPlayer.GetComponentInChildren<AudioSource>();

              //Applying button onClick 
              for (int i = 1; i <= _buttonLevel.Length; i++)
              {
                  int _count = i;
                  _buttonLevel[i-1]._buttonToLevel.onClick.AddListener(() =>LoadingLevel(_count-1));
              }
              _quitGame.onClick.AddListener(() => Application.Quit());

              //Invoke 
              Invoke(nameof(ShowButtonsDataPlayer),.2f);
              
              //corrutines
              StartCoroutine(nameof(UpdateCorrutine));
          }
          private void OnDestroy()
          {
              _endCorrutine = true;
          }
         
          #endregion

          #region Methods
          private void ShowButtonsDataPlayer()
          {
              //Activate Buttons Level
              _levelDataPlayer = _dataPlayer._levelCurrentSave;
              for (int i = 1 ; i<= _levelDataPlayer; i++ )
              {
                  _showButtons[i-1]._buttonToShow.interactable = true;
              }
          }

          IEnumerator UpdateCorrutine()
          {
              while(!_endCorrutine)
              {   
                  ApplicateUISettings();
                  yield return null;
              }
          }
          private void ApplicateUISettings()
          {
              //brightness intensity controller
              _brightness.color = new Color(_brightness.color.r, _brightness.color.g, _brightness.color.b, _dataPlayer._valueBrightness - 0.1f);
              //Controll volum of music
              _music.volume = _dataPlayer._valuenMusica;
             
          }

          private void LoadingLevel(int _int)
          {
              _panelLoading.SetActive(true);
              SceneManager.LoadScene(_buttonLevel[_int]._intLevel);
          }
        #endregion
    }
}
