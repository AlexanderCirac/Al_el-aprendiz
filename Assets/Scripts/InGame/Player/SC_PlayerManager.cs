using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AL.Player
{
    public class SC_PlayerManager : SC_PlayerBehaviour
    {
        #region Attributes
        internal static SC_PlayerManager _instance;
        internal SC_JumpController _controlSalto;
        internal SC_DuckController _controlAgachar;
        #endregion

        #region Unity Calls
        void Awake() => Init();
        #endregion

        #region custom private methods
        private void Init()
        {
          _instance = this;
          _controlSalto = FindObjectOfType<SC_JumpController>();
          _controlAgachar = FindObjectOfType<SC_DuckController>();
        }

        #endregion
    }
}
