using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_Evento2 : MonoBehaviour
{
  //esta script es para controlar los sucesos del evento 2

  // Start is called before the first frame update
  void Start()
  {
    m_bolita.SetActive(false);
    m_numeros = m_inTiempo.Length;
  }

  // Update is called once per frame
  void Update()
  {

    if (m_m1)
    {
      Invoke("ActivarBoluta", 0.1f);
     
    }
    if (m_m2)
    {
      TerminarTiempo();
      ActivarCargaTiempo();
    }
  }

  //para cerrar la regla del evento
  public GameObject m_reglas;
  //primer paso
  public void CerrarDialogo()
  {
    m_bolita.SetActive(true);
    m_reglas.SetActive(false);
    Time.timeScale = 1;
    m_m1 = true;
    m_m2 = true;
  }

  //para cuando superen el reto
  public GameObject m_ganado;
  public GameObject m_evento;
  //quarto paso
  public void HasGando()
  {
    m_ganado.SetActive(true);
    m_m1 = false;
    m_m2 = false;
  }
  //para cuando fallen el reto
  public GameObject m_perdido;

  public GameObject m_bolita;
  private bool m_m1;
  private bool m_m2;
  //segundo paso
  void ActivarBoluta()
  {
    m_bolita.GetComponent<Button>().interactable = true;
    if (m_bolita.GetComponent<Button>().interactable == true)
    {
      m_m1 = false;
    }
  }


  public GameObject m_varra;
  private float m_tiempo;
  //tercer paso
  void TerminarTiempo()
  {
    if (m_varra.GetComponent<Scrollbar>().value >= 1)
    {
      m_perdido.SetActive(true);
      m_bolita.SetActive(false);
    }
    else
    {
      m_tiempo += 0.2f * Time.deltaTime;
      m_varra.GetComponent<Scrollbar>().value = m_tiempo;
    }
  }


  //tercerpaso
  //ganar tiempo
  public void quitarTiempo(int m_id)
  {
    m_numeros--; // resta un numero del texto
    m_tiempo = ((m_varra.GetComponent<Scrollbar>().value - (m_varra.GetComponent<Scrollbar>().value * 50) / 100)); // ganas tiempo 
    m_inTiempo[m_id-1].SetActive(false);
  }


  //tercera parte
  //esto lo que ara es que en cierto momentos aya un cuenta que mejores

  public Text m_textNumeros;
  private int m_numeros;
  private float m_tiempo2;
  public GameObject[] m_inTiempo;
  private bool m_2;
  private bool m_2_1;
  private bool m_3;
  private bool m_3_1;
  private bool m_4;
  private bool m_4_1;

  void ActivarCargaTiempo() {


    m_textNumeros.text = m_numeros.ToString();

      if (m_tiempo2 < 7)
      {
        m_tiempo2 += 1 * Time.deltaTime;
      }  
      if (m_tiempo2 > 1.5f )
      {
      m_2 = true;
      } 
      if (m_tiempo2 > 4f )
      {
      m_3 = true;
      }     
      if (m_tiempo2 > 6f)
      {
      m_4 = true;
      }

    if (m_2)
    {
      if (!m_2_1)
      {
        m_inTiempo[0].SetActive(true);
        m_2_1 = true;
      }
    }  
    if (m_3)
    {
      if (!m_3_1)
      {
        m_inTiempo[1].SetActive(true);
        m_3_1 = true;
      }
    }
    if (m_4)
    {
      if (!m_4_1)
      {
        m_inTiempo[2].SetActive(true);
        m_4_1 = true;
      }
    }
  }
    



}
