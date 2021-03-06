using UnityEngine;

namespace AL.Data
{
  public class SC_SettingsDataPersisten : ALBehaviour
  {
    #region Attributes
    //Data Settings
    internal int _levelCurrentSave;
    internal float _valueBrightness;
    internal float _valuenMusica;
    internal bool _ishandLeft;
    internal bool _isAd;
    internal bool _isFirstDLC;
    internal bool _isRetorno1;
    internal bool _isRetorno2;
    internal bool _isRetorno3;
    //main Tools
    [SerializeField] private SC_SaveData _scriptable;
    #endregion

    #region Singleton
    internal SC_SettingsDataPersisten _instancePersisentData;
    #endregion

    #region UnityCalls
    void Awake() => Init();
    void Start() => LoadSetting();
    #endregion

    #region custom private methods
    void LoadSetting()
    {
      _levelCurrentSave = _scriptable._savedLevel;
      _valueBrightness = _scriptable._saveValueBrighnesst;
      _valuenMusica = _scriptable._saveValueMusic;
      _ishandLeft = _scriptable._saveHandLeft;
    }
    void Init()
    {
      if (_instancePersisentData != null)
        Destroy(gameObject);
      else
      {
        _instancePersisentData = this;
        DontDestroyOnLoad(gameObject);
      }
    }
    #endregion
  }
}