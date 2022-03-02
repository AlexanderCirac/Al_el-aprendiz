using UnityEngine;

namespace AL.Data
{
    public class SC_SettingsDataPersisten : MyMonoBehaviour
  {
          #region Attributes
          //Data Settings
          [HideInInspector] public int _levelCurrentSave;
          [HideInInspector] public float _valueBrightness;
          [HideInInspector] public float _valuenMusica;
          [HideInInspector] public bool _handLeft;
          [HideInInspector] public bool _ad; 
          [HideInInspector] public bool _firstDLC;
          [HideInInspector] public bool _isRetorno1;  
          [HideInInspector] public bool _isRetorno2; 
          [HideInInspector] public bool _isRetorno3;
          //main Tools
          [SerializeField ] private SC_SaveData _scriptable;
          #endregion

          #region Singleton
          [HideInInspector]
          public static SC_SettingsDataPersisten _instanceData;
          #endregion

          #region UnityCalls
          private void Awake()
          {
                if (_instanceData != null)
                {
                    Destroy(gameObject);
                }
                else 
                { 
                    _instanceData = this;
                    DontDestroyOnLoad(gameObject);
                }
          }
          void Start()
          {
              LoadSetting();
          }
          #endregion          

          #region Methods
          private void LoadSetting()
          {
              _levelCurrentSave = _scriptable._savedLevel;
              _valueBrightness = _scriptable._saveValueBrighnesst;
              _valuenMusica = _scriptable._saveValueMusic;
              _handLeft = _scriptable._saveHandLeft;

          }
          #endregion
    }
}
