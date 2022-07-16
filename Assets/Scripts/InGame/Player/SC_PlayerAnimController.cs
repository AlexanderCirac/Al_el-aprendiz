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
      [SerializeField] GameObject _duckDownAnim;
      [SerializeField] GameObject _getUpAnim;
      //buttons to activate anim
      
      [SerializeField] Button _jumpAnimButton;
      [SerializeField] Button _walkAnimButton;
      [SerializeField] Button _shootAnimButton;
      [SerializeField] Button _duckButton;

      #endregion

      #region UnityCall
       void Start() => Init();

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
      void AttackBeggin()
      {
          _shootAnim.SetActive(true);
          _idleAnim.SetActive(false);
          Invoke(nameof(AttackEnding),.9f);
          
      }       
      void AttackEnding()
      {
          _shootAnim.SetActive(false);
          _idleAnim.SetActive(true);
          
      }       
      void ToDuck(bool _stateBool)
      {
              _duckDownAnim.SetActive(_stateBool);
              _getUpAnim.SetActive(!_stateBool);
      }     
      IEnumerator FallJumpAnim()
      {
         
          _fallJampAnim.SetActive(true);
          _jumpAnim.SetActive(false);
          yield return new WaitForSeconds(0.1f);
           _fallJampAnim.SetActive(false);
      } 

      void Init()
      {
         _jumpAnimButton.onClick.AddListener(JumpAnim);
         _shootAnimButton.onClick.AddListener(AttackBeggin);
      }
      #endregion
  
  
  }
}
