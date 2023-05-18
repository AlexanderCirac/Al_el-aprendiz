using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlatafomasCaidas : MonoBehaviour
{

  //en esta scirpt es para poder hacer plataforma que caigan cuando el jugador choque


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      Caer();
  }

  private bool m_caidPlat;
  private void OnTriggerEnter(Collider coll)
  {

    if (coll.CompareTag("Player"))
    {
      m_caidPlat = true;
    }
  }
  
  
  public GameObject m_plataforma;
  public float m_tiempo;
  private int m_velocidad;
  public Animator m_animacion;
  void Caer()
  {


    if (m_caidPlat)
    {
      m_animacion.enabled =true;
      m_tiempo += 1 * Time.deltaTime;
    }

    if (m_tiempo > 1.3f)
    {
      m_plataforma.GetComponent<Rigidbody>().useGravity = true;
      m_plataforma.GetComponent<Rigidbody>().isKinematic = false;
    }
     if (m_tiempo > 1f)
    {
      m_animacion.enabled = false;
    }
    if (m_tiempo > 1.35f)
    {
      Destroy(m_plataforma);
    }





  }
}
