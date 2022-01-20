using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AL.Data;

namespace AL.UI
{
    public class SC_NivelCinematicaUIController : MonoBehaviour
    {
        #region Attributes
        //[SerializeField] private Button _quitGame;
        [System.Serializable]
        public class ButtonLevel
        {
          public string _name;
          public Button _buttonToLevel;
          public int _intLevel;
        }
        [Header("Button")]
        [SerializeField] private ButtonLevel[] _buttonLevel;        
        [Header("UI Settings")]
        [SerializeField] private Image _brightness;
        private AudioSource _music;
        [Header("Panel")]
        [SerializeField] private GameObject _cinematicaPanel;
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
            _buttonLevel[i - 1]._buttonToLevel.onClick.AddListener(() => LoadingLevel(_count - 1));
          }

          //Invocke
          Invoke(nameof(CinematicaLoading),.4f);

          //corrutines
          StartCoroutine(nameof(UpdateCorrutine));
        }
        private void OnDestroy()
        {
          _endCorrutine = true;
        }

        #endregion

        #region Methods
        IEnumerator UpdateCorrutine()
        {
          while (!_endCorrutine)
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
          SceneManager.LoadScene(_buttonLevel[_int]._intLevel);
        }        
        private void CinematicaLoading()
        {
          _cinematicaPanel.SetActive(true);
        }
        #endregion
  
    }
}
