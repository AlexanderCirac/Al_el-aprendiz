using UnityEngine;

public class SC_ShootController : MonoBehaviour
{
  #region Attribute
  public GameObject m_balaDer;
  public GameObject m_balaIzq;
  public GameObject m_disparadorDer;
  public GameObject m_disparadorIzq;

  public bool m_dispararJugador;
  public bool m_proyectil;

  private bool m_dispararDer = true;
  private bool m_dispararIzq;
  #endregion

  #region UnityCalls
  private void Update()
  {
    if (m_proyectil)
    {
      Invoke("descativar", 0.49f); // reactivamos funcion de disparar
    }
  }
  #endregion

  #region custom private methods
  public void Disparar()
  {
    if (!m_dispararJugador && !m_proyectil ) {
      Invoke("disparar1", 0.5f);
      m_dispararJugador = true; // desactivamos boton para asegurarnos que no funcione asta que pase el tiempo
    }
  }

  public void dispararDerecha()
  {
    m_dispararDer = true ;
    m_dispararIzq = false;
  }
  public void dispararIzq()
  {
    m_dispararIzq = true;
    m_dispararDer = false;
  }

  void disparar1() // creamos la bala
  {
    if (!m_proyectil)
    {
      if (m_dispararDer)
      {
      Instantiate(m_balaDer, m_disparadorDer.transform.position, Quaternion.identity);
      }      
      if (m_dispararIzq)
      {
      Instantiate(m_balaIzq, m_disparadorIzq.transform.position, Quaternion.identity);
      }
      m_proyectil = true;
    }
  }
 void descativar() // funcion para volber a disparar
  {
    m_proyectil = false;
    m_dispararJugador = false;
  }
  
  #endregion
}
