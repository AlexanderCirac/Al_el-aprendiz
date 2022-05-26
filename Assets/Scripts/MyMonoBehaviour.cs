using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AL {
 using AL.Data;
  public class MyMonoBehaviour : MonoBehaviour
    {

    protected SC_GameGeneralMannager _gameManager => SC_GameGeneralMannager._instance;
    //protected SC_SettingsDataPersisten _settingData => _gameManager._settingsDataPersisten;
    //protected SC_SaveAndLoadPlayerData _playerData => _gameManager._saveAndLoadPlayerData;
  } 
}

