using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace AL.Player
{
  public class SC_PlayerAnimController : SC_PlayerBehaviour
  {

      #region Attribute
      [SerializeField] GameObject _jumpAnim;
      private float m_tiempo;
      [SerializeField] GameObject _fallJampAnim;
      #endregion

      #region UnityCall


      void OnTriggerEnter(Collider coll)
      {
        if (coll.CompareTag("Suelo"))
            if(_jumpAnim.activeSelf)
                StartCoroutine(FallJumpAnim());
      }

      void OnTriggerExit(Collider coll)
      {
        if (coll.CompareTag("Suelo"))
            JumpAnim();
      }
      #endregion

      #region custom private methods
      void JumpAnim()
      {
        _jumpAnim.SetActive(false);
        _fallJampAnim.SetActive(true);
      }     
      IEnumerator FallJumpAnim()
      {
         
          _fallJampAnim.SetActive(true);
          _jumpAnim.SetActive(false);
          yield return new WaitForSeconds(0.1f);
           _fallJampAnim.SetActive(false);
      } 
      #endregion
  
  
  }
}
