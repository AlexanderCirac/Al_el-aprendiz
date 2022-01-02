using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SC_Morir : MonoBehaviour
{

  //en esta scrip sera para indicar que el jugador a muerto 
  //y que le de la posibilidad de reinciar la partida o de salir del juego

  public GameObject m_pregunta;
  public SC_Vida SC_V;
  private bool m_mori;

    // Start is called before the first frame update
    void Start()
    {
    m_pregunta.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      Morir();
    }

  void Morir()
  {
    if (SC_V.m_vida <= 0 || m_mori == true)
    {
      m_pregunta.SetActive(true);
      Time.timeScale = 0;
    }
    
  }

  public void Salir()
  {
    Application.Quit();
  }

  public void Reinciar(int m_nivel)
  {
    //Application.LoadLevel(m_nivel);
    SceneManager.LoadScene(m_nivel);
  }
}
