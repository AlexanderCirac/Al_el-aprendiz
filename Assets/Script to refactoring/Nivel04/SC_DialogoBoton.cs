using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_DialogoBoton : MonoBehaviour
{
  //esta script es para dar abrir un dialogo atraves de un boton de canvas
  public GameObject m_dialogo;
  public void Abrir()
  {
    m_dialogo.SetActive(true);
    Time.timeScale = 0;
  }
  public void Cerrar()
  {
    m_dialogo.SetActive(false);
    Time.timeScale = 1;
  }


  public GameObject m_dialogo1;
  public GameObject m_dialogo2;
  public GameObject m_dialogo3;

  public void Parte2()
  {
    m_dialogo1.SetActive(false);
    m_dialogo2.SetActive(true);
    m_dialogo3.SetActive(false);
  }  public void Parte3()
  {
    m_dialogo1.SetActive(false);
    m_dialogo2.SetActive(false);
    m_dialogo3.SetActive(true);
  }
}
