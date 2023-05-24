using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_dialogo1 : MonoBehaviour
{

  //esta script es para pasar de dialogo  a otro
    // Start is called before the first frame update
    void Start()
    {
    m_siguiente = 0;
    }

    // Update is called once per frame
    void Update()
    {
    texto();
    }


  private int m_siguiente;
  public void botonPasar1()
  {
    m_siguiente++;
  }


  public GameObject m_g1;
  public GameObject m_g2;
  public GameObject m_g3;
  public GameObject m_bu1;
  public GameObject m_bu2_1;
  public GameObject m_bu2_2;

  void texto()
  {
    if (m_siguiente == 0)
    {
      m_g1.SetActive(true);
      m_g2.SetActive(false);
      m_g3.SetActive(false);

      m_bu2_1.SetActive(false);
      m_bu2_2.SetActive(false);
    } 
    if (m_siguiente == 1)
    {
      m_g1.SetActive(false);
      m_g2.SetActive(true);
      m_g3.SetActive(false);

      m_bu2_1.SetActive(false);
      m_bu2_2.SetActive(false);
    }   
    if (m_siguiente == 2)
    {
      m_g1.SetActive(false);
      m_g2.SetActive(false);
      m_g3.SetActive(true);
      m_bu1.SetActive(false);
      m_bu2_1.SetActive(true);
      m_bu2_2.SetActive(true);
    }
  }

}
