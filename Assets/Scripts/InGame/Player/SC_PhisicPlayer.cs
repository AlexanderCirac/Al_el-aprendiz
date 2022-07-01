using UnityEngine;


namespace AL.Player
{

  public class SC_PhisicPlayer : MonoBehaviour
  {

      #region Attribute
      public SC_JumpController SC_CA;
      public PhysicMaterial m_PM;    
      #endregion

      #region UnityCall
      void Update() => controlfisicas();
      #endregion

      #region custom private methods
      void controlfisicas()
      {
        if (SC_CA._isJumping == false)
        {
          m_PM.dynamicFriction = 0.1f;
        }
        else
        {
          m_PM.dynamicFriction = 1;
        }
      }
      #endregion

  }
}
