using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Cinematica_01 : MonoBehaviour
{

  //esta script es para controlar la cinematica


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Animacion();
    }

  private float m_tiempo;
  public Animator m_animacion;
  public GameObject m_dialogo01;
  void Animacion()
  {
    if (m_tiempo < 1f)
    {
      m_tiempo += 1 * Time.deltaTime;
    }

    if (m_tiempo < 1f)
    {
      m_animacion.enabled = true;
    }

    if (m_tiempo > 0.7f  && m_tiempo < 1f)
    {
      m_dialogo01.SetActive(true);
    }
  }

  public GameObject m_dialogo02;
  public GameObject m_dialogo03;
  public GameObject m_dialogo04;
  public GameObject m_dialogo05;
  public GameObject m_dialogo06;
  public GameObject m_dialogo07;
  public void AbrirDialogos02()
  {
    m_dialogo02.SetActive(true);
    m_dialogo01.SetActive(false);
  } 
  public void AbrirDialogos03()
  {
    m_dialogo03.SetActive(true);
    m_dialogo02.SetActive(false);
  }  
  public void AbrirDialogos04()
  {
    m_dialogo04.SetActive(true);
    m_dialogo03.SetActive(false);
  }  
  public void AbrirDialogos05()
  {
    m_dialogo05.SetActive(true);
    m_dialogo04.SetActive(false);
  }  
  public void AbrirDialogos6()
  {
    m_dialogo06.SetActive(true);
    m_dialogo05.SetActive(false);
  }   public void AbrirDialogos7()
  {
    m_dialogo07.SetActive(true);
    m_dialogo06.SetActive(false);
  }  

  public void NoAceptarMision(int m_nivel)
  {
    Application.LoadLevel(m_nivel);
  }
}
