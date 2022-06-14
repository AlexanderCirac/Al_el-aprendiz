using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AL.Player
{
  public class SC_PlayerController : SC_PlayerBehaviour
  {
      #region
      public Rigidbody m_rg;
      public GameObject jugador;
      public float m_velocidadMovimiento;
      public float m_velocidadSaltar;
      public bool m_agachar;
      private bool m_liana = false;

      [HideInInspector]
      public float m_normalY;
      private float m_normalZ;
      
      [HideInInspector]
      public bool m_m1;

      public float m_tiempo;
      private bool m_tiempoControl;

      //estas funciones son para activare el movimiento durante el ascensor
      public bool m_ascensor;
      #endregion

      #region Unity Calls
      private void Start()
      {
    
        m_normalY = jugador.transform.localScale.y;
        m_normalZ = jugador.transform.localScale.z;
 
      }
      private void Update()
      {
   
    
        Saltarboton();
      }
      #endregion
      
      #region custom public methods
      public void MoverDercha()
      {

          // m_rg.MovePosition(new Vector3(jugador.transform.position.x + m_velocidadMovimiento, jugador.transform.position.y, jugador.transform.position.z));
          if (!m_ascensor)
          {
            m_rg.MovePosition(new Vector3(jugador.transform.position.x + m_velocidadMovimiento * Time.deltaTime, jugador.transform.position.y, jugador.transform.position.z));
            //jugador.transform.position = new Vector3(jugador.transform.position.x + (m_velocidadMovimiento/2), jugador.transform.position.y, jugador.transform.position.z);
          }
          else
          {
            jugador.transform.position = new Vector3(jugador.transform.position.x +( (m_velocidadMovimiento / 2) * Time.deltaTime), jugador.transform.position.y, jugador.transform.position.z);
          }
    

      }

      public void MoverIzquierda()
      {

          //m_rg.MovePosition (new Vector3(jugador.transform.position.x - m_velocidadMovimiento, jugador.transform.position.y, jugador.transform.position.z));// forma 1 ( movimiento con fisica pero sin deslizamiento)
          if (!m_ascensor)
          {
            m_rg.MovePosition(new Vector3(jugador.transform.position.x - m_velocidadMovimiento * Time.deltaTime, jugador.transform.position.y, jugador.transform.position.z));// forma 1 ( movimiento con fisica pero sin deslizamiento)
          }
          else
          {
            jugador.transform.position =  new Vector3(jugador.transform.position.x -( (m_velocidadMovimiento /2) * Time.deltaTime) , jugador.transform.position.y, jugador.transform.position.z);// forma 1 ( movimiento con fisica pero sin deslizamiento)
          }
          //m_rg.velocity = Vector3.left * m_velocidadMovimiento; // forma 2 ( movimiento con fisica pero tiene un deslizamiento)
          //jugador.transform.position = new Vector3(jugador.transform.position.x - m_velocidadMovimiento * Time.deltaTime, jugador.transform.position.y, jugador.transform.position.z);// forma 3 ( movimiento sin fisica)
    
      }

      public void Saltar()
      {
        //m_rg.AddForce ( Vector3.up * m_velocidadSaltar);
        if (_jumpController.m_boolSalto == true)
        {

          m_rg.velocity = Vector3.up * m_velocidadSaltar  ;
          //m_rg.velocity = Vector3.up * m_velocidadSaltar  *Time.deltaTime;
          m_tiempo = 0;
        }
      }
      #endregion

      #region custom private methods
      
      void Saltarboton()
      {
        //m_rg.AddForce ( Vector3.up * m_velocidadSaltar);
        if (_jumpController.m_boolSalto == true && Input.GetKeyDown(KeyCode.Space))
        {

          m_rg.velocity = Vector3.up * m_velocidadSaltar ;
          //m_rg.velocity = Vector3.up * m_velocidadSaltar *Time.deltaTime;
          m_tiempo = 0;
        }
      }

      void ControladorSalto()
      {
        if(_jumpController.m_boolSalto == false)
        {
          m_tiempo = m_tiempo + 2 * Time.deltaTime;
          // m_tiempo ++;
            if (m_tiempo > 2)
            {
              m_rg.velocity = Vector3.down * (m_velocidadSaltar/1.1f);
            }
        }

      }
      #endregion
  }
}

