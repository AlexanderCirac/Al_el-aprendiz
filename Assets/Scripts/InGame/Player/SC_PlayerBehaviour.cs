using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AL.Player
{

    public class SC_PlayerBehaviour : MonoBehaviour
    {
      protected SC_PlayerManager _playerManager => SC_PlayerManager._instance;
      protected SC_JumpController _jumpController => _playerManager._controlSalto;
      protected SC_ControAgachar _duckController=> _playerManager._controlAgachar;
    }
}
