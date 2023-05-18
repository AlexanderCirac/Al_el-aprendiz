using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Nivel : MonoBehaviour
{
  public GameObject m_textoCargando;
  private bool m_activar;

  //esta script es cargar el nivel

  private void Update()
  {
    activarCarga();
  }

  void activarCarga()
  {
    if (m_activar)
    {
      if (m_textoCargando != null)
      {

    m_textoCargando.SetActive(true);
      }
    }
  }
  public void CargarNivel(int m_nivel)
  {
    Application.LoadLevel(m_nivel);
    m_activar = true;
  }
 
}
