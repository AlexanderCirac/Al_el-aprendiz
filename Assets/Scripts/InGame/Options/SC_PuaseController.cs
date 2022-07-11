using UnityEngine;
using UnityEngine.UI;

namespace AL.InGame.UI
{


  public class SC_PuaseController : MonoBehaviour
  {
    #region Attributes
    [HideInInspector]
    [SerializeField] Button _pauseButton;
    //Anim
    [SerializeField] GameObject _pauseCloseAnim;
    [SerializeField] GameObject _pauseOpenAnim;
    //Open menu pause
    [SerializeField] GameObject _pauseMenu;
    #endregion

    #region UnityCalls
    void Awake() => Init();
    #endregion

    #region custom private methods
    //para abrir el menu de pausa y desactivarlo
    void Init()
    {
      _pauseButton.onClick.AddListener(ToPausa);
    }
    void ToPausa()
    {
      _pauseMenu.SetActive(!_pauseMenu.activeSelf);

      if (_pauseMenu.activeSelf)
      {
        _pauseCloseAnim.SetActive(false);
        _pauseMenu.SetActive(true);
        _pauseOpenAnim.SetActive(true);
        Time.timeScale = 0;        
      }
      else
      {
        _pauseCloseAnim.SetActive(true);
        _pauseMenu.SetActive(false);
        _pauseOpenAnim.SetActive(false);
        Time.timeScale = 1;

      }
    }
    #endregion
  }
}
