using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ActivarNiveles : MonoBehaviour
{
  //esta script es para desbloquear las misiones siguientes una
  //vez que se ayan pasado el nivel anterior

  public SC_DatosJugador SC_DJ;

  public int m_NivelDesbloquear;
  private bool m_DoOnce = false;
  public GameObject[] m_Niveles;


  private void Start()
  {
   
  }

  // Update is called once per frame
  void Update()
    {
   
    if (SC_DJ != null)
    {
      ActivarNiveles();
    }
    else
    {
      BuscarSC_Datos();
    }
  }

  void ActivarNiveles()
  {
    if (SC_DJ.m_nivel == 0)
    {
      m_NivelDesbloquear = 0;
    }
    else
    {
      m_NivelDesbloquear = SC_DJ.m_nivel;
    }

    if (m_DoOnce == false)
    {
      for (int i = 0; i <= m_NivelDesbloquear; i++)
      {
        m_Niveles[i].SetActive(true);
      }
      m_DoOnce = true;
    }
  }

  void BuscarSC_Datos()
  {//cargara en una variable publica la script que almacena todos los datos
    if (SC_DJ == null)
    {
      SC_DJ = FindObjectOfType<SC_DatosJugador>();
    }
  }
}
