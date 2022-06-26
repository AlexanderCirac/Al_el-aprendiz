using UnityEngine;
using UnityEngine.UI;

public class SC_FlipController : MonoBehaviour
{

  #region Attribute
  [SerializeField] SpriteRenderer _flipPlayer;
  [SerializeField] Button _leftButton;
  [SerializeField] Button _rightButton;
  #endregion

  #region UnityCalls
  void Awake() => Init();
  #endregion

  #region custom private method
  void Init()
  {
    _leftButton.onClick.AddListener(() => _flipPlayer.flipX = false);
    _rightButton.onClick.AddListener(() => _flipPlayer.flipX = true);
  }
  #endregion
}
