using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AL
{
  using AL.Data;
  public class ALBehaviour : MonoBehaviour
  {

    protected SC_InGameGeneralManager _gameManager => SC_InGameGeneralManager._instance;
    protected SC_SettingsDataPersisten _settingData => _gameManager._settingsDataPersisten;
    protected SC_SaveAndLoadPlayerData1 _playerData => _gameManager._saveAndLoadPlayerData;
  }
}


