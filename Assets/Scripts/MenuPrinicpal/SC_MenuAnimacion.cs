using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MenuAnimacion : MonoBehaviour
{

  //esta script es para controlar la animaciones cuando cambiemos de canvas.


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public GameObject m_AnimacionAlante;
  public GameObject m_AnimacionAtras;
  public GameObject m_Fondo_Normal;
  public void CambiarPaginaAlante()
  {
    m_AnimacionAlante.SetActive(true);
    m_AnimacionAtras.SetActive(false);
    m_Fondo_Normal.SetActive(false);
  } 
  public void CambiarPaginaAtras()
  {
    m_AnimacionAlante.SetActive(false);
    m_AnimacionAtras.SetActive(true);
    m_Fondo_Normal.SetActive(false);
  }
}
