using UnityEngine.UI;
using UnityEngine;

namespace AL.InGame
{
  public class SC_Carta : MonoBehaviour
  {
    #region Attribute
    Button _closeButton;
    public GameObject m_sobreGeneral;
    public GameObject m_cartaSobre;
    public RectTransform m_tapaSobre;
    public GameObject m_contenidoSobre;
    public Slider m_barra;
    public float m_numeroActual;
    //intento 2 
    public RectTransform m_punto;
    #endregion

    #region UnityCalls
    void Start() => Init();

    // Update is called once per frame
    void Update() => MoveLetter();


    #endregion

    #region custom public methods
    void CloseLetter() => m_sobreGeneral.SetActive(false);
    #endregion

    #region custom private methods
     void Init()
      {
          m_sobreGeneral.SetActive(true);
          m_cartaSobre.SetActive(true);
          m_contenidoSobre.SetActive(false);
          _closeButton.onClick.AddListener(CloseLetter);
          m_barra.onValueChanged.AddListener(delegate { SliderLetterController(); });
      }
    void MoveLetter()
    {

      if (m_barra.value <= 0.95f)
        m_tapaSobre.GetComponent<RectTransform>().anchorMin = new Vector2(m_tapaSobre.GetComponent<RectTransform>().anchorMin.x, m_punto.GetComponent<RectTransform>().anchorMin.x);
      else
      {
        m_cartaSobre.SetActive(false);
        m_contenidoSobre.SetActive(true);
      }
    }

    void SliderLetterController()
    {
        m_numeroActual = m_barra.value;
    }
    #endregion
  }
}