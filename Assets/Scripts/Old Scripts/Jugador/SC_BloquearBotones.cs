using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AL.Player;
public class SC_BloquearBotones : MonoBehaviour
{
  //esta script es para bloquear de forma visual ciertos botones, cuando el jugador este agachado e impedir interaccion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    Bloquear();
    }

  //este boton es el que dira que nos indicara que bloque los
  public bool m_bloquear;
  public void botonBloq()
  {
    if (!m_bloquear)
    {
      m_bloquear = true;
    }
    else
    {
      m_bloquear = false;
    }
  }

  public GameObject m_bloqSalt;
  public GameObject m_bloqAtaq;
  public GameObject m_bloqAgachado; 
  public GameObject m_bloqSaltIzq;
  public GameObject m_bloqAtaqIzq;
  public GameObject m_bloqAgachadoIzq;
//  public SC_JumpController SC_CS;
  public SC_PlayerController SC_JM;
  void Bloquear()
  {
    if (!m_bloquear)
    {
      m_bloqSalt.SetActive(false);
      m_bloqAtaq.SetActive(false); 
      m_bloqSaltIzq.SetActive(false);
      m_bloqAtaqIzq.SetActive(false);

    }
    else
    {
      m_bloqSalt.SetActive(true);
      m_bloqAtaq.SetActive(true);      
      m_bloqSaltIzq.SetActive(true);
      m_bloqAtaqIzq.SetActive(true);
    }
    //bloqueamos el boton de agachar, siempre que el jugador este saltando ,bloqueamos el boton de agachado o cuando este permanezca
    //en una zona de agachado para que no se desagache
    //if (SC_CS.m_boolAgachar || !SC_CS.m_boolSalto)
    //{
    //  m_bloqAgachado.SetActive(true);
    //  m_bloqAgachadoIzq.SetActive(true);
    //  if (atacagarGeneralSinIzq != null)
    //  {

    //  atacagarGeneralSinIzq.SetActive(true);
    //  atacagarGeneralSin.SetActive(true);
    //  }

    //  if (SC_JM.jugador.transform.localScale.x > SC_JM.m_normalY / 3)
    //  {
    //    SC_CS.m_boolAgachar = false;
    //  } 


    //}
    //else
    //{
    //    m_bloqAgachado.SetActive(false);
    //    m_bloqAgachadoIzq.SetActive(false);
    //  if (atacagarGeneralSinIzq != null)
    //  {

    //  atacagarGeneralSinIzq.SetActive(false);
    //  atacagarGeneralSin.SetActive(false);
    //  }

    //  if (SC_JM.jugador.transform.localScale.x < SC_JM.m_normalY )
    //  {
    //    SC_CS.m_boolAgachar = true;
    //  }
    //  //if (SC_CS.m_boolSalto)
    //  //{
    //  //}
    //}


  }

  public GameObject atacagarGeneralSinIzq;
  public GameObject atacagarGeneralSin;

}
