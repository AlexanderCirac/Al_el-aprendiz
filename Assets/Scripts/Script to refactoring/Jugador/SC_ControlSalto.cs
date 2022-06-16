using UnityEngine;

namespace AL.Player
{
  public class SC_ControlSalto : MonoBehaviour
  {

    #region Attributes
    internal bool _isJumping;
    [SerializeField] private GameObject m_bloqAtaq1;
    [SerializeField] private GameObject m_bloqAtaq1Izq;
    [SerializeField] private GameObject m_agacharder1;
    [SerializeField] private GameObject m_agacharizq1;
    internal  bool _isDucking;
    #endregion

    #region  Unity Calls
    void OnTriggerStay(Collider col)
    {

      if (col.CompareTag("Suelo"))
      {
        Desbloquear();
        _isJumping = true;

      }
      if (col.CompareTag("Agachado"))
      {
        _isDucking = true;
      }
    }
    void OnTriggerExit(Collider col)
    {

      if (col.CompareTag("Suelo"))
      {
        _isJumping = false;
        bloquear();
        m_contador = 0;
      }
      if (col.CompareTag("Agachado"))
      {
        _isDucking = false;
      }
    }
    #endregion

    #region custom public methods
    public int m_contador;
    public void contador()
    {
      if (_isJumping)
      {
        m_contador++;
      }
    }

    void parar() // pasar controlador del salto
    {
      if (m_contador > 0)
      {
        _isJumping = false;
        m_contador = 0;
      }
    }
    #endregion

    #region custom private methods
    void bloquear()
    {
      if (m_bloqAtaq1Izq != null)
      {
        m_bloqAtaq1.SetActive(true);
        m_bloqAtaq1Izq.SetActive(true);

      }
      m_agacharder1.SetActive(true);
      m_agacharizq1.SetActive(true);
    }


    void Desbloquear()
    {
      m_agacharder1.SetActive(false);
      if (m_bloqAtaq1Izq != null)
      {
        m_bloqAtaq1.SetActive(false);
        m_bloqAtaq1Izq.SetActive(false);
      }
      m_agacharizq1.SetActive(false);
    }
    #endregion
  }
}
