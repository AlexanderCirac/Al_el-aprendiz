using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AL
{
  using AL.Data;
  public class ALBehaviour : MonoBehaviour
  {

    protected SC_GameGeneralManager _gameManager => SC_GameGeneralManager._instance;
    protected SC_SettingsDataPersisten _settingData => _gameManager._settingsDataPersisten;
    protected SC_SaveAndLoadPlayerData1 _playerData => _gameManager._saveAndLoadPlayerData;
  }
}


