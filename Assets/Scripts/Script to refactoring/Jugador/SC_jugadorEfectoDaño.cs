using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_jugadorEfectoDaño : MonoBehaviour
{

  //esta script se utilizara para empujar al jugador a una direccion cuando este reciva daño
    // Start is called before the first frame update
    void Start()
    {
            m_rg = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      ContraladorEfectos();
      EmpujarJugador();
      parpadeo();
    }

  //esto activara en que lado tiene que ser empujado el jugador
  public bool m_empujarDerecha;
  public bool m_empujarIzquierda;
  public bool m_empujarArriba;
  public bool m_empujarArriba1;
  private void OnTriggerEnter(Collider coll)
  {
    if(coll.gameObject.layer == 9 )
    {
      m_empujarIzquierda = true;
    } 
    if(coll.gameObject.layer == 8)
    {
      m_empujarDerecha = true;
    }  
    if(coll.gameObject.layer == 10)
    {
      m_empujarArriba = true;
    }  
    if(coll.gameObject.layer == 11)
    {
      m_empujarArriba1 = true;
    }
  }

  //esto empujara al jugador
  private float m_tiempo;
  private Rigidbody m_rg;
  public float m_velocidadMovimiento;
  public float m_velocidadMovimientocaida;
 public SC_JugadorMovimiento SC_J;
 
  void EmpujarJugador()
  {

    if (!SC_J.m_ascensor)
    {
      if (m_empujarIzquierda)
      {
         m_rg.MovePosition(new Vector3(this.transform.position.x - m_velocidadMovimiento, this.transform.position.y, this.transform.position.z));
      }
      if (m_empujarDerecha)
      {
        m_rg.MovePosition(new Vector3(this.transform.position.x + m_velocidadMovimiento, this.transform.position.y, this.transform.position.z));
      }
      if (m_empujarArriba)
      {
        m_rg.MovePosition(new Vector3(this.transform.position.x, this.transform.position.y + m_velocidadMovimientocaida , this.transform.position.z));


      }    
      if (m_empujarArriba1)
      {
        m_rg.MovePosition(new Vector3(this.transform.position.x, this.transform.position.y + (m_velocidadMovimientocaida*1.5f), this.transform.position.z));
      }
    }
    else
    {
      if (m_empujarIzquierda)
      {
        this.transform.position = new Vector3(this.transform.position.x - (m_velocidadMovimiento / 14), this.transform.position.y, this.transform.position.z);
      }
      if (m_empujarDerecha)
      {
        this.transform.position = new Vector3(this.transform.position.x + (m_velocidadMovimiento / 14), this.transform.position.y, this.transform.position.z);
      }
      if (m_empujarArriba)
      {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + m_velocidadMovimientocaida, this.transform.position.z);
      }
      
    }
  }

  //esto ara que parpade todo el rato cuando el jugador reciva daño
  public GameObject m_raizAnimacionesObj;
  public Animator m_raizAnimacionesAnim;
  void parpadeo()
  {
    if (m_tiempo < 0.8f)
    {
      if (m_empujarIzquierda || m_empujarDerecha || m_empujarArriba || m_empujarArriba1)
      {
        m_raizAnimacionesAnim.enabled = true;
        m_tiempo += 1 * Time.deltaTime;
      
      }
    }
    else
    {
      m_empujarIzquierda = false;
      m_empujarDerecha = false;
      m_empujarArriba = false;
      m_empujarArriba1 = false;
      m_raizAnimacionesAnim.enabled = false;
      m_raizAnimacionesObj.SetActive(true);
      m_tiempo = 0;
    }
  }

  //esta funcion es para eviatar que se active doble efectos de daño el primero que se active, el resto se anularan
  void ContraladorEfectos()
  {
    if (m_empujarIzquierda)
    {
      m_empujarDerecha = false;
      m_empujarArriba = false;
      m_empujarArriba1 = false;
    } 
    if (m_empujarDerecha)
    {
      m_empujarIzquierda = false;
      m_empujarArriba = false;
      m_empujarArriba1 = false;
    }   
    if (m_empujarArriba)
    {
      m_empujarIzquierda = false;
      m_empujarDerecha = false;
      m_empujarArriba1 = false;
    }
    if (m_empujarArriba1)
    {
      m_empujarIzquierda = false;
      m_empujarDerecha = false;
      m_empujarArriba = false;
    }
  }
}
