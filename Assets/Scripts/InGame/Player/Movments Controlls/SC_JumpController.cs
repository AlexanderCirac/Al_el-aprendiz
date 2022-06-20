using UnityEngine;
using UnityEngine.UI;

namespace AL.Player
{
  public class SC_JumpController : MonoBehaviour
  {

    #region Attributes
    internal bool _isJumping;
    internal bool _isOnJump;
    /// <summary>
    /// Pasar una scritp para  agachar y otra para atacar
    /// </summary>
    //[SerializeField] private GameObject m_bloqAtaq1;
    //[SerializeField] private GameObject m_bloqAtaq1Izq;
    [SerializeField] private float _jampVelocity;
    [SerializeField] private Rigidbody m_rg;
    [SerializeField] private Button _jumpRightButton;
    [SerializeField] private Button _jumpLeftButton;
    #endregion

    #region  Unity Calls
    void Awake() => Init();
    void OnTriggerStay(Collider col)
    {
      if (col.CompareTag("Suelo"))
        ToUnlockJump();
      else
        ToLockJump();
    }
    void OnTriggerExit(Collider col)
    {
      if (col.CompareTag("Suelo"))
        ToLockJump();
    }
    #endregion

    #region custom private methods
    void Init()
    {
      _jumpRightButton.onClick.AddListener(Saltar);
      _jumpLeftButton.onClick.AddListener(Saltar);
    }
    void ToLockJump()
    {
      _jumpRightButton.interactable = false;
      _jumpLeftButton.interactable = false;
      _isJumping = false;
    }
    void ToUnlockJump()
    {
      _jumpRightButton.interactable = true;
      _jumpLeftButton.interactable = true;
      _isJumping = true;
    }

    void Saltar() // Pasar Salto
    {
        m_rg.velocity = Vector3.up * _jampVelocity;
    }
    #endregion
  }
}
