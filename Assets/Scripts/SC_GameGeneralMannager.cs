namespace AL
{
  using AL.Data;
  public class SC_GameGeneralMannager : MyMonoBehaviour
  {
    #region Attributes
    internal SC_SettingsDataPersisten1 _settingsDataPersisten;
    internal SC_SaveAndLoadPlayerData1 _saveAndLoadPlayerData;
    internal int i;
    internal static SC_GameGeneralMannager _instance;

    #endregion

    #region UnityCalls
    void Awake() => Init();
    #endregion

    #region custom private methods
    void Init()
    {
      _gameManager.i = 0;
      _instance = this;
      _settingsDataPersisten = FindObjectOfType<SC_SettingsDataPersisten1>();
      _saveAndLoadPlayerData = FindObjectOfType<SC_SaveAndLoadPlayerData1>();
    }
    #endregion
  }
}
