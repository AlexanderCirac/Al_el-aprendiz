using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ControladorDialogos : MonoBehaviour
{
  //esta script es para controlar los dialogos del nivel 1
  private bool m_dialogos01;
  [HideInInspector]
  public bool m_dialogos02;
  [HideInInspector]
  public bool m_dialogos03;
  [HideInInspector]
  public bool m_vacio;

  public GameObject m_objectDialogo01;
  public GameObject m_objectDialogo02;
  public GameObject m_objectDialogo03;
  public GameObject m_objetoVacio;
  // Start is called before the first frame update
  void Start()
    {
      m_dialogos01 = true;
    }

    // Update is called once per frame
    void Update()
    {
    Abrirdialogos();
    }

  void Abrirdialogos()
  {
    //dialogo 01;
    if (m_dialogos01 && !m_vacio)
    {
      m_objectDialogo01.SetActive(true);
      m_objetoVacio.SetActive(true);
    }
    //dialogo 02;

    if (m_dialogos02 && !m_vacio)
    {
      m_objectDialogo02.SetActive(true);
      m_objetoVacio.SetActive(true);
    }
    // dialogo 03;
    if (m_dialogos03 && !m_vacio)
    {
      m_objectDialogo03.SetActive(true);
      m_objetoVacio.SetActive(true);
    }
  }

  public void Cerrardialogo01()
  {
    m_vacio = true;
    m_dialogos01 = false;
    m_objectDialogo01.SetActive(false);
    m_objetoVacio.SetActive(false);
  }

  public void Cerrardialogo02()
  {
    m_vacio = true;
    m_dialogos02 = false;
    m_objectDialogo02.SetActive(false);
    m_objetoVacio.SetActive(false);
  }

  public void Cerrardialogo03()
  {
    m_vacio = true;
    m_dialogos03 = false;
    m_objectDialogo03.SetActive(false);
    m_objetoVacio.SetActive(false);
  }
}
