using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using AL.Player;

public class SC_ControlAnimacion : MonoBehaviour
{
  public GameObject m_anSaltar;
  public GameObject m_anAterrizar;
  //esta script es para controlar las animaciones que realizara el personae segun la situacion

 // public SC_PlayerAnimController SC_AC;
  // Update is called once per frame

  private void Start()
  {
    //SC_AC = this.gameObject.GetComponent<SC_PlayerAnimController>();
  }
  void Update()
    {
   
      AnimacionCaminar();
      animacionAtaque();
    }

  //esto es para controlar el flip de las animaciones
  private bool m_boolFlipX;
  public void m_FlipIzquierda()
  {
    m_anCaminar.GetComponent<SpriteRenderer>().flipX = true;
    m_anIdle.GetComponent<SpriteRenderer>().flipX = true;
   m_anSaltar.GetComponent<SpriteRenderer>().flipX = true;
   m_anAterrizar.GetComponent<SpriteRenderer>().flipX = true;
    if (m_anDisparar != null)
    {
      m_anDisparar.GetComponent<SpriteRenderer>().flipX = true;
    }
    m_boolFlipX = true;
  }  
  
  public void m_FlipDerecha()
  {
    m_anCaminar.GetComponent<SpriteRenderer>().flipX = false;
    m_anIdle.GetComponent<SpriteRenderer>().flipX = false;
   m_anSaltar.GetComponent<SpriteRenderer>().flipX = false;
   m_anAterrizar.GetComponent<SpriteRenderer>().flipX = false;
    if (m_anDisparar != null)
    {

   m_anDisparar.GetComponent<SpriteRenderer>().flipX = false;
    }
    m_boolFlipX = false;

  }  
  //para controlar la animacion de caminar
  private bool m_caminar;
  //variables para las animaciones
  public GameObject m_anIdle;
  public GameObject m_anCaminar;
  public void m_caminarAct()
  {
    m_caminar = true;
  }  
  public void m_caminarDes()
  {
    m_caminar = false;
  }
  void AnimacionCaminar()
  {
    ////Animacion caminar
    //if ( !SC_AC.m_boolanimacion && !SC_AC.m_boolagachar && !SC_AC.m_boolsalto1 && !m_boolAtaquer /*!m_Boolagachar*/) {
    //  if (!m_caminar)
    //  {
    //    m_anIdle.SetActive(true);
    //    m_anCaminar.SetActive(false);
    //  }
    //  else
    //  {
    //    m_anIdle.SetActive(false);
    //    m_anCaminar.SetActive(true);
    //  }
    //}
    //else
    //{
    //  m_anIdle.SetActive(false);
    //  m_anCaminar.SetActive(false);
    //}
  }

  //ataque
  public GameObject m_efectoDisparo_der;
  public GameObject m_efectoDisparo_izq;
  private bool m_boolAtaquer;
  private float m_tiempoAtque;
  //variables para las animaciones
  public GameObject m_anDisparar;
  public void Ataque()
  {
    
    m_boolAtaquer = true;
  }

  void animacionAtaque()
  {
    if (m_boolAtaquer)
    {
      m_tiempoAtque += 1 * Time.deltaTime;
      m_anDisparar.SetActive(true);
      if (m_tiempoAtque > 0.5f )
      {
        if(!m_boolFlipX)
        {
        m_efectoDisparo_der.SetActive(true);
        } 
        if(m_boolFlipX)
        {
        m_efectoDisparo_izq.SetActive(true);
        }
      }
      if (m_tiempoAtque > 0.9f)
      {
        m_boolAtaquer = false;
      }
    }
    else
    {
      m_tiempoAtque = 0;
      if (m_efectoDisparo_der != null)
      {

      m_efectoDisparo_der.SetActive(false);
      m_efectoDisparo_izq.SetActive(false);
      m_anDisparar.SetActive(false);
      }
    }
  }


}
