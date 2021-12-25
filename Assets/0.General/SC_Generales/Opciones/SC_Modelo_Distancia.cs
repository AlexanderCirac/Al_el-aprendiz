using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class SC_Modelo_Distancia : MonoBehaviour {

  //Idea; Esta script es para que cambie la aprencia del modelo segun la distancia del jugador.

  [HideInInspector]
  public SC_Controlador_Distancia_jugador SC_CDJ;



  public GameObject m_Objeto_base;

 

  private Vector2 m_distancia;
  private float m_Distancia_Total;
  private int m_Numero;
  private int m_Numero1;

  [System.Serializable]
  public class c_Mallas{
    public Mesh m_Malla_Baja;
      public float m_Distancia_ParaMallaBaja_Personalizada;



    public Mesh m_Malla_Alta;
      public float m_Distancia_ParaMallaAlta_Personalizada;
  }
  public c_Mallas Mallas = new c_Mallas();

  



  // Update is called once per frame
  void Update () {

    LeerScript();
    if (m_Objeto_base != null)
    {
    }

    LeerDistanciaMesh();
  }


  void LeerScript()
  {
    if (SC_CDJ == null) {

      SC_CDJ = FindObjectOfType<SC_Controlador_Distancia_jugador>();
    }

    if(m_Objeto_base == null)
    {
     m_Objeto_base = this.gameObject;
     
    }


  }
  void LeerDistanciaMesh()
  {
    //calcular la distancia entre objeto base y el jugador
    m_distancia = new Vector2 (SC_CDJ.m_Jugador.transform.position.x - m_Objeto_base.gameObject.transform.position.x, SC_CDJ.m_Jugador.transform.position.y - m_Objeto_base.gameObject.transform.position.y); // cogemos el vector 2
    //transformamos el vector 2 en un float y sacamos la distancia, siempre positivo (Mathf.Abs)
    m_Distancia_Total = Mathf.Abs(m_distancia.sqrMagnitude);

    // si esta fuera del rango desaparecera y sino estara activo
    if (m_Distancia_Total > SC_CDJ.m_Distancia_ParaOcutarse)
    {
      if (m_Numero1 != 1) {//tiene un 1 para terminar la lectura y no este leyendo todo el rato
        //m_Objeto_base.GetComponent<MeshRenderer>().enabled = false;
        //m_Objeto_base.GetComponent<Collider>().enabled = false;
        //esta es otra forma de ocultar un objeto de atrabes de los hijos
        this.transform.GetChild(0).gameObject.SetActive(false);
        m_Numero1 = 1;
      }
    }
    else
    {
      if (m_Numero1 != 2)
      {//tiene un 1 para terminar la lectura y no este leyendo todo el rato
        //m_Objeto_base.GetComponent<MeshRenderer>().enabled = true;
        //m_Objeto_base.GetComponent<Collider>().enabled = true;
        this.transform.GetChild(0).gameObject.SetActive(true);
        m_Numero1 = 2;
      }
    }

    // si esta fuera del rango se pondra la malla de calidad baja
      //cogera los datos personalizados
    if ( Mallas.m_Malla_Baja != null && m_Numero != 3 && Mallas.m_Distancia_ParaMallaBaja_Personalizada != 0 && m_Distancia_Total > Mallas.m_Distancia_ParaMallaBaja_Personalizada && m_Distancia_Total < SC_CDJ.m_Distancia_ParaOcutarse)
    {
      m_Objeto_base.GetComponent<MeshFilter>().mesh = Mallas.m_Malla_Baja;
      m_Numero = 3;
    }
    else //Cogera los datos del controlador general
    {
      if (Mallas.m_Malla_Baja != null && m_Numero != 3 && m_Distancia_Total > SC_CDJ.m_Distancia_ParaMallaBaja && m_Distancia_Total < SC_CDJ.m_Distancia_ParaOcutarse){
        m_Objeto_base.GetComponent<MeshFilter>().mesh = Mallas.m_Malla_Baja;
        m_Numero = 3;
      }
    }

    // si esta fuera del rango se pondra la malla de calidad baja
      //cogera los datos personalizados
    if (Mallas.m_Malla_Alta != null && Mallas.m_Distancia_ParaMallaAlta_Personalizada != 0 && m_Numero != 4 && m_Distancia_Total < Mallas.m_Distancia_ParaMallaBaja_Personalizada && m_Distancia_Total > Mallas.m_Distancia_ParaMallaAlta_Personalizada)
    {
      m_Objeto_base.GetComponent<MeshFilter>().mesh = Mallas.m_Malla_Alta;
      m_Numero = 4;
    }
    else//Cogera los datos del controlador general
    {
      if (Mallas.m_Malla_Alta != null && m_Numero != 4 && m_Distancia_Total < SC_CDJ.m_Distancia_ParaMallaBaja && m_Distancia_Total > SC_CDJ.m_Distancia_ParaMallaAlta)
      {
        m_Objeto_base.GetComponent<MeshFilter>().mesh = Mallas.m_Malla_Alta;
        m_Numero = 4;
      }
    }
  }

 
}
