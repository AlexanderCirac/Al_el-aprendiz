namespace AL 
{
    using AL.Data;
    public class SC_GameGeneralMannager : MyMonoBehaviour
    {
          #region Attributes
          internal SC_SettingsDataPersisten _settingsDataPersisten;
          internal SC_SaveAndLoadPlayerData _saveAndLoadPlayerData;

          public static SC_GameGeneralMannager _instance;

          #endregion

          #region UnityCalls
          void Awake() => Init();
          #endregion

          #region custom private methods
          void Init()
          {
              _instance = this;
              _settingsDataPersisten = FindObjectOfType<SC_SettingsDataPersisten>();
              _saveAndLoadPlayerData = FindObjectOfType<SC_SaveAndLoadPlayerData>();
          }
          #endregion
    }
}

