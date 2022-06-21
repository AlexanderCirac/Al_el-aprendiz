using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

namespace AL.Life
{

    public class SC_DeathController : MonoBehaviour
    {

          #region Attributes 
          [SerializeField] GameObject m_pregunta;
          [SerializeField] Button _quitButton;
          [SerializeField] Button _repitLevelButton;
          #endregion

          #region UnityCalls
          void Awake() => Init();
          #endregion

          #region Custom private methods
          void Init()
          {
              m_pregunta.SetActive(false);
              _quitButton.onClick.AddListener(Salir);
              _repitLevelButton.onClick.AddListener(Reinciar);
          }
          void Morir() // añadir mediante un evento
          {
              m_pregunta.SetActive(true);
              Time.timeScale = 0;
          }
          void Salir() => Application.Quit();
          void Reinciar() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
          #endregion
    }
}