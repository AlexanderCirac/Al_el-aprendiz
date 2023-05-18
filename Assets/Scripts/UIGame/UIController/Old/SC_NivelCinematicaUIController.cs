using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AL.Data;

namespace AL.UI
{
  public class SC_NivelCinematicaUIController : ALBehaviour
  {
    #region Attributes
    //[SerializeField] private Button _quitGame;
    [System.Serializable]
    public class ButtonLevel
    {
      [SerializeField] private string _name;
      public Button _button;
      public int _iDLevel;
    }
    [Header("Button")]
    [SerializeField] private ButtonLevel[] _arrayLevelButton;
    [SerializeField] private Button _creditButton;
    [Header("UI Settings")]
    [SerializeField] private Image _brightnessPanel;
    private AudioSource _music;
    [Header("Panel")]
    [SerializeField] private GameObject _cinematicaPanel;


    #endregion

    #region UnityCalls
    private void Start()
    {
      _music = _settingData.GetComponentInChildren<AudioSource>();

      //Applying button onClick 
      for (int i = 1; i <= _arrayLevelButton.Length; i++)
      {
        int _count = i;
        _arrayLevelButton[i - 1]._button.onClick.AddListener(() => ToLoadLevel(_count - 1));
      }
      _creditButton.onClick.AddListener(() => SceneManager.LoadScene(1));
      //Invocke
      Invoke(nameof(ToShowCinematic), .4f);
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
      _brightnessPanel.color = new Color(_brightnessPanel.color.r, _brightnessPanel.color.g, _brightnessPanel.color.b, _settingData._valueBrightness - 0.1f);
      //Controll volum of music
      _music.volume = _settingData._valuenMusica;

    }

    private void ToLoadLevel(int _iDArray)
    {
      SceneManager.LoadScene(_arrayLevelButton[_iDArray]._iDLevel);
    }
    private void ToShowCinematic()
    {
      _cinematicaPanel.SetActive(true);
    }
    #endregion

  }
}