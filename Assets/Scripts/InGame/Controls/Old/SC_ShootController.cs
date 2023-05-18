using UnityEngine;
using UnityEngine.UI;

public class SC_ShootController : MonoBehaviour
{
  #region Attribute
  [SerializeField] GameObject _bulletPref;
  [SerializeField] Button _shootButtonLeft;
  [SerializeField] Button _shootButtonRight;
  [SerializeField] GameObject _firingCannon;
  #endregion

  #region UnityCalls
  void Awake() => Init();
  #endregion

  #region custom private methods
  void Init()
  {
    _shootButtonLeft.onClick.AddListener(ToShoot);
    _shootButtonLeft.onClick.AddListener(ToShoot);
  }
  void ToShoot()
  {
    Instantiate(_bulletPref, _firingCannon.transform.position, Quaternion.identity);
  }
  
  #endregion
}
