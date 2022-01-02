using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_acertijoLuna : MonoBehaviour
{

  //esta script es para el acertijo de luna


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public GameObject m_dialogo1;
  public GameObject m_dialogo2;
  public GameObject m_dialogo3;
  public GameObject m_dialogoGenral;
  public GameObject m_dialogoAcert;
  public GameObject m_esCorrecto;
  public GameObject m_esIncorrecto;
  public GameObject m_acertijo;
  public GameObject m_puerta;
  public GameObject m_objeto1;
  public GameObject m_objeto2;
  public GameObject m_objeto3;

    public void Dialogo1() // dira el dialogo1 (con boton Afuera)
  {
    m_dialogoGenral.SetActive(true);
    m_dialogo1.SetActive(true);
    m_dialogo3.SetActive(false);
    m_dialogo2.SetActive(false);
  }
public void Dialogo2() // dira el dialogo2
{
  m_dialogo1.SetActive(false);
  m_dialogo3.SetActive(false);
  m_dialogo2.SetActive(true); 
}
  public void Dialogo3()// dira el dialogo3
  {
    m_dialogo1.SetActive(false);
    m_dialogo2.SetActive(false);
    m_dialogo3.SetActive(true);
  }  
  public void Dialogo4Emepezar() // dira el dialogo4
  {
    m_acertijo.SetActive(true);
    m_objeto1.SetActive(true);
    m_objeto2.SetActive(true);
    m_objeto3.SetActive(true);
    m_dialogoAcert.SetActive(false);
    m_dialogo3.SetActive(false);
    m_dialogoGenral.SetActive(false);
  }
  public void Escorrecto()//abrimos dialogo que es correcto (con boton afuera)
  {
    m_esCorrecto.SetActive(true);
   
  }
  public GameObject m_BotonCorrecto;
  public void CerrarEscorrecto() // cerramos todo para que pase de nivel
  {
    m_puerta.SetActive(false);
    m_acertijo.SetActive(false);
    m_esCorrecto.SetActive(false);
    m_BotonCorrecto.SetActive(false);
  }  
  public void EsIncorrecto()//abrimos dialogo que incorrecto (con boton afuera)
  {
    m_esIncorrecto.SetActive(true);
   
  }
  public GameObject m_BotonIncorrecto;
  public void CerrarEsIncorrecto() // cerramos dialogo es incorrecto
  {
    m_dialogoAcert.SetActive(true);
    m_BotonIncorrecto.SetActive(false);
    m_acertijo.SetActive(false);
    m_objeto1.GetComponent<SC_CORRINCORR>().m_tocado = false;
    m_objeto2.GetComponent<SC_CORRINCORR>().m_tocado = false;
    m_objeto3.GetComponent<SC_CORRINCORR>().m_tocado = false;
    m_esIncorrecto.SetActive(false);


}
}
