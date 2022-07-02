using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace AL.Player
{
  public class SC_PlayerAnimController : SC_PlayerBehaviour
  {

      #region Attribute
      //Sprite with anim
      [SerializeField] GameObject _jumpAnim;
      [SerializeField] GameObject _fallJampAnim;
      [SerializeField] GameObject _walkAnim;
      [SerializeField] GameObject _idleAnim;
      [SerializeField] GameObject _shootAnim;
      //buttons to activate anim
      
      [SerializeField] Button _jumpAnimButton;
      [SerializeField] Button _walkAnimButton;
      [SerializeField] Button _shootAnimButton;

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
