using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_OPMapa : MonoBehaviour
{
  //esta script es para controlar la animacion 

  public GameObject m_animacion_coso;
  public GameObject m_nomral;
  private float m_tiempo;
  public GameObject m_texto;

    // Start is called before the first frame update
    void Start()
    {
         m_desactivar = false;
    }

    // Update is called once per frame
    void Update()
    {
        Desactivar();
    }

  private bool m_desactivar;
  public Animator m_animacionBotonGeneral;
  public void Botondescativar()
  {
    m_desactivar = true;
    m_animacionBotonGeneral.enabled = true;
  }

  void Desactivar()
  {

    if (m_desactivar)
    {
      m_animacion_coso.SetActive(true);
      m_nomral.SetActive(false);
      m_tiempo += 1 * Time.deltaTime;
      m_texto.SetActive(true);
    }

    if (m_tiempo > 0.5f)
    {
      Application.LoadLevel(1);
    }
  }
}
