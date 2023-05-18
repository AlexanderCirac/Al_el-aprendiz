using UnityEngine;

namespace AL.InGame.UI
{
  public class SC_QuitController : MonoBehaviour
  {
    #region Attributes
    public GameObject m_mesanje;
    #endregion

    #region UnityCalls
    #endregion

    #region custom private methods
    public void Salir()
    {
      Application.Quit();
    }

    public void ActivarSalir()
    {
      m_mesanje.SetActive(true);
    }
    public void DesactivarSalir()
    {
      m_mesanje.SetActive(false);
    }

    public void NivelEleccion(int m_nivel)
    {
      Application.LoadLevel(m_nivel);
    }
    #endregion

    

  }
}
