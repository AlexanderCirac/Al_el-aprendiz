using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ControlEvento1 : MonoBehaviour
{
  //esta script es para terminar
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
      IrAlante();
      Posicion();
    }


  //esta funcion es para que el coso siga para alante
  public GameObject m_guia;
 // [HideInInspector]
  public float m_velocidad;
  void IrAlante()
  {
    if (m_m1)
    {
      m_guia.transform.Translate (Vector3.forward * m_velocidad * Time.deltaTime, Space.World);
      Time.timeScale = 1;
      Debug.Log("1");
    }
  }


  //esta funcion es para empezar este evento
  public bool m_m1;
  public GameObject m_Reglas;
  public void ActivarEvento()
  {
    m_Reglas.SetActive(false);
    m_m1 = true;
  }


  //esta funcion es para que bicho se ponga en una sitio
  [SerializeField]
  private int m_idPos;
  public void BotonPos(bool m_boton)
  {

    if (m_boton)
    {
      if (m_idPos <3 )
      { 
       m_idPos++;
      }
    }
    else
    {
      if (m_idPos > 1)
      {
       m_idPos--;
      }
    }
  }

  //Esta funcion es para que el bicho este en un sitio o otro
  public GameObject m_bicho;
  public GameObject[] m_pos;
  void Posicion( )
  {
    if (m_m1)
    {
      m_bicho.transform.position = m_pos[(m_idPos - 1)].transform.position;
    }
  }

  private bool m_m3;
  
}
