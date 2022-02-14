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
          [SerializeField] private string _name;
          public Button _loadLevelButton;
          public int _iDLevel;
        }
        [Header("Button")]
        [SerializeField] private ButtonLevel[] _arrayLevel;        
        [Header("UI Settings")]
        [SerializeField] private Image _brightnessPanel;
        private AudioSource _music;
        [Header("Panel")]
        [SerializeField] private GameObject _cinematicaPanel;
        //Main Tools
        [HideInInspector] private SC_SettingsDataPersisten _dataPlayer;

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
          for (int i = 1; i <= _arrayLevel.Length; i++)
          {
            int _count = i;
            _arrayLevel[i - 1]._loadLevelButton.onClick.AddListener(() => ToLoadLevel(_count - 1));
          }

          //Invocke
          Invoke(nameof(ToShowCinematic),.4f);
        }
        private void Update()
        {
            ToUISettings();
        }
        #endregion

        #region Methods
        private void ToUISettings()
        {
          //brightness intensity controller
          _brightnessPanel.color = new Color(_brightnessPanel.color.r, _brightnessPanel.color.g, _brightnessPanel.color.b, _dataPlayer._valueBrightness - 0.1f);
          //Controll volum of music
          _music.volume = _dataPlayer._valuenMusica;

        }

        private void ToLoadLevel(int _iDArray)
        {
          SceneManager.LoadScene(_arrayLevel[_iDArray]._iDLevel);
        }        
        private void ToShowCinematic()
        {
          _cinematicaPanel.SetActive(true);
        }
        #endregion
  
    }
}
