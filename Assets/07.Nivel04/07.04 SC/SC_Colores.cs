using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Colores : MonoBehaviour
{
  public SC_PuzlesColores SC_PC;
  public bool m_activarParticulas;
  //esta script es para pasar la informacion al controlador de los puzzles

  public GameObject m_particulas;

  private void Update()
  {
    //if (SC_PC.m_Secuencia.Length == SC_PC.m_objetos.ToArray().Length)
    //{
      if (SC_PC.m_objetos.ToArray().Length == 0)
      {
        m_particulas.SetActive(false);
        m_activarParticulas = false;
      }
    //}
  }

  private void OnTriggerEnter(Collider coll)
  {
    //if (m_activarParticulas == false)
   // {
      if (coll.CompareTag("Player"))
      {
        if (SC_PC.m_objetos.ToArray().Length == 0) {
          Debug.Log("Añadir por primera vez" + gameObject.tag);
          SC_PC.m_objetos.Add ( this.gameObject);
          m_particulas.SetActive(true);
          m_activarParticulas = true;
          }
        else
        {
          Debug.Log("Añadir" + gameObject.tag);
          SC_PC.m_objetos.Add(this.gameObject);
          m_particulas.SetActive(true);
          m_activarParticulas = true;
        }
     // }
    }
  }
}
