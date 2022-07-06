using UnityEngine.UI;
using UnityEngine;

namespace AL.InGame
{
  public class SC_Carta : MonoBehaviour
  {
    #region Attribute
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
    public SC_ModelDistanceManager SC_CDJ;
    private bool m_doTwo;
    public float m_numeroActual;
    //intento 2 
    public RectTransform m_punto;
    #endregion

    #region UnityCalls

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


    #endregion

    #region custom public methods
    public void CerrarCarta()
    {
      m_sobreGeneral.SetActive(false);
      m_doTwo = true;
    }
    #endregion

    #region custom private methods
    void MoverSobre()
    {

      if (m_barra.value <= 0.95f)
      {
        m_tapaSobre.GetComponent<RectTransform>().anchorMin = new Vector2(m_tapaSobre.GetComponent<RectTransform>().anchorMin.x, m_punto.GetComponent<RectTransform>().anchorMin.x);
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

    //esta parte es para ir desbloqueando la cantidad de objetos del nivel
    //para no sobrecargar
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
    #endregion
  }
}