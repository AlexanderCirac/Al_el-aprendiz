using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AL.Player
{
  public class SC_PlayerController : SC_PlayerBehaviour
  {
      #region
      [SerializeField] private Rigidbody m_rg;
      [SerializeField] private GameObject jugador;
      public float m_velocidadMovimiento;
      public float m_velocidadSaltar;
     
      float m_tiempo;

      //estas funciones son para activare el movimiento durante el ascensor
      internal bool m_ascensor;
      #endregion

      #region Unity Calls
      void Update() => Saltarboton();
      #endregion
      
      #region custom public methods
      public void MoverDercha()
      {

       
          if (!m_ascensor)
          {
            m_rg.MovePosition(new Vector3(jugador.transform.position.x + m_velocidadMovimiento * Time.deltaTime, jugador.transform.position.y, jugador.transform.position.z));
          }
          else
          {
            jugador.transform.position = new Vector3(jugador.transform.position.x +( (m_velocidadMovimiento / 2) * Time.deltaTime), jugador.transform.position.y, jugador.transform.position.z);
          }
    

      }

      public void MoverIzquierda()
      {


          if (!m_ascensor)
          {
            m_rg.MovePosition(new Vector3(jugador.transform.position.x - m_velocidadMovimiento * Time.deltaTime, jugador.transform.position.y, jugador.transform.position.z));// form
          }
          else
          {
            jugador.transform.position =  new Vector3(jugador.transform.position.x -( (m_velocidadMovimiento /2) * Time.deltaTime) , jugador.transform.position.y, jugador.transform.position.z);
          }
      }

      public void Saltar() // Pasar Salto
      {
        if (_jumpController._isJumping == true)
        {
          m_rg.velocity = Vector3.up * m_velocidadSaltar  ;
          m_tiempo = 0;
        }
      }
      #endregion

      #region custom private methods
      void Saltarboton() //PasarSalto
      {
        if (_jumpController._isJumping == true && Input.GetKeyDown(KeyCode.Space))
        {
          m_rg.velocity = Vector3.up * m_velocidadSaltar ;
          m_tiempo = 0;
        }
      }

      void ControladorSalto() // Pasar Salto
      {
        if(_jumpController._isJumping == false)
        {
          m_tiempo = m_tiempo + 2 * Time.deltaTime;
            if (m_tiempo > 2)
            {
              m_rg.velocity = Vector3.down * (m_velocidadSaltar/1.1f);
            }
        }
      }
      #endregion
  }
}

