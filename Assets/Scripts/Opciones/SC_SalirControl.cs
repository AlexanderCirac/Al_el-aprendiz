using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_SalirControl : MonoBehaviour
{
  //esta script es para controlar el salir


  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public GameObject m_mesanje;

  public void Salir()
  {
    Application.Quit();
  }

  public void ActivarSalir()
  {
    m_mesanje.SetActive(true);
  }  
  public void DesactivarSalir()
  {
    m_mesanje.SetActive(false);
  }

  public void NivelEleccion(int m_nivel)
  {
    Application.LoadLevel(m_nivel);
  }
}
