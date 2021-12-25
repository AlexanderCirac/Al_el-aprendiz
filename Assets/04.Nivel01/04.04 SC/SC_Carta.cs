using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SC_Carta : MonoBehaviour
{

  //esta script es para controlar la mecanica de la carta, cuando el jugador deslice la barra
  //se abrira la tapa del sobre y veremos su contenido

  public GameObject m_sobreGeneral;
  public GameObject m_cartaSobre;
 // public GameObject m_tapaSobre;
  public RectTransform m_tapaSobre;
  public GameObject m_contenidoSobre;
  public Slider m_barra;
 [HideInInspector]
  public bool m_doOnce;
 [HideInInspector]
  public bool m_dotwo;

  public float m_numeroActual;


  //intento 2 
  public RectTransform m_punto;

  // Start is called before the first frame update
  void Start()
    {
    m_sobreGeneral.SetActive(true);
    m_cartaSobre.SetActive(true);
    m_contenidoSobre.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        MoverSobre();
        CambiarCosas();
        ControlBarra();
       // AñadidoExtra();
    }


  void MoverSobre()
  {
    
    if (m_barra.value <= 0.95f)
    {
    m_tapaSobre.GetComponent<RectTransform>().anchorMin = new Vector2 (m_tapaSobre.GetComponent<RectTransform>().anchorMin.x,  m_punto.GetComponent<RectTransform>().anchorMin.x);
     //hay que delimitar el contenedor de la tapa para que le valor minimo sea adapte al contendor ex; si el valor empieza con el 80% ara que la tapa este al 80% tambien del total de contendero
     //con lo cual hay que hacer el contenedor de la tapa mas pequeña para que ocupe es 80% 
    }
      else
      {
        m_doOnce = true;
      }
   }

    void ControlBarra()
    {
      if (m_dotwo == true)
      {
        m_numeroActual = m_barra.value;
      }
    }

    void CambiarCosas()
  {
    if (m_doOnce == true)
    {
      m_cartaSobre.SetActive(false);
      m_contenidoSobre.SetActive(true);
    }
  }


  public void CerrarCarta()
  {
    m_sobreGeneral.SetActive(false);
    m_doTwo = true;
  }


  //esta parte es para ir desbloqueando la cantidad de objetos del nivel
  //para no sobrecargar

  public SC_Controlador_Distancia_jugador SC_CDJ;
  private bool m_doTwo;
  void AñadidoExtra()
  {
    if (!m_doOnce)
    {
      SC_CDJ.m_Distancia_ParaOcutarse = 10000;
    }
    if (m_doOnce && !m_doTwo)
    {
      SC_CDJ.m_Distancia_ParaOcutarse = 25000;
    }
    if (m_doTwo)
    {
      SC_CDJ.m_Distancia_ParaOcutarse = 50000;
    }
  }
}
