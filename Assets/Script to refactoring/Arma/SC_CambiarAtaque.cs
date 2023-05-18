using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_CambiarAtaque : MonoBehaviour
{

  private bool m_abrir;
  private bool m_boolactual;
  public GameObject[] m_tiposImagen;
  private int m_contador; 

    // Update is called once per frame
    void Update()
    {
        ActivarElegir();
    }

  public void Activar()
  {
    m_abrir =! m_abrir;

  }

  void ActivarElegir()
  {
   
    if (m_contador < m_tiposImagen.Length )
    {
      m_tiposImagen[m_contador].SetActive(m_abrir);
      m_contador++;
      Debug.Log("leer contador");
      m_boolactual = m_abrir;
    }
    else
    {
      if (m_boolactual != m_abrir)
      {
        m_contador = 0;
        Debug.Log("reiniciar contador");
      }
    }
    
    
    
  }

}
