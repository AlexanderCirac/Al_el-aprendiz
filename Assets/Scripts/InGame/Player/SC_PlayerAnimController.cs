using UnityEngine;

namespace AL.Player
{
  public class SC_PlayerAnimController : MonoBehaviour
  {

      #region Attribute
    public GameObject m_animacionSalto;
   [HideInInspector]
    public bool m_boolanimacion;
    private bool m_boolsalto;
    [HideInInspector]
    public bool m_boolsalto1;
    [HideInInspector]
    public bool m_boolagachar;
    private float m_tiempo;
    public GameObject m_caida;
    #endregion

      #region UnityCall
      // Start is called before the first frame update
      void Start()
      {

      }

      // Update is called once per frame
      void Update()
      {
        SaltoAnimacionCaida();
      }


      void OnTriggerEnter(Collider coll)
      {
        if (coll.CompareTag("Suelo"))
        {
          m_animacionSalto.SetActive(false);
          m_boolsalto1 = false;
        }

        if (m_boolsalto && coll.CompareTag("Suelo"))
        {
          m_boolagachar = true;
        }
      }

      void OnTriggerExit(Collider coll)
      {
        if (coll.CompareTag("Suelo"))
        {
          m_animacionSalto.SetActive(true);
          m_boolanimacion = true;
          m_boolsalto1 = true;
        }
      }
      public void ActivarSalto()
      {
        m_boolsalto = true;

      }
      #endregion

      #region custom private methods

    void SaltoAnimacionCaida()
    {
      if (m_boolagachar)
      {
        m_tiempo += 1 * Time.deltaTime;

        if (m_tiempo < 0.3f)
        {
          m_caida.SetActive(true);
        }      
        else
        {
          m_caida.SetActive(false);
          m_boolanimacion = false;
          m_boolagachar = false;
        
        }
      }
      else
      {
        m_tiempo = 0;
      }
    }
      #endregion
  
  
  }
}
