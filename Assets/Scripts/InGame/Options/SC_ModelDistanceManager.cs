using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ModelDistanceManager : MonoBehaviour {
  // Idea: Esta scritp es para colocar los datos universales distancia para todos los objetos.
  //descripcion: Lo que se ponde son numeros para definir a todos los objetos ( de forma universal) que tiene la script SC_Modelo_distacia_Jugador cual seria la distancia
  //correcta para que se pongan sus mallas o que desaparezcan
 // [HideInInspector]
  public GameObject m_Jugador;

  public float m_Distancia_ParaOcutarse;
  public float m_Distancia_ParaMallaBaja;
  public float m_Distancia_ParaMallaAlta;


  private void Start()
  {
    m_Distancia_ParaMallaAlta = 0;
  }

  //private void Update()
  //{
    
  //  if(m_Jugador == null)
  //  {

  //    m_Jugador = GameObject.FindGameObjectWithTag("Player");
  //  }

  //}
}
