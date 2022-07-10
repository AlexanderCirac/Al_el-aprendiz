using UnityEngine;

public class SC_PuaseController : MonoBehaviour
{
  #region Attributes
  [HideInInspector]
  public bool m_AbrirMenu;

  public GameObject m_interfazJuego;
  public GameObject m_menuPausa;
  private bool m_enmarcha;
  private float m_tiempo;
  public Animator m_animacionBotonGeneral;
  //esto es para activar animacion del menu pausa

  public GameObject m_animacion_Desplegable;
  public GameObject m_animacion_Plegable;
  #endregion

  #region UnityCalls
  private void Update()
  {
    MenuPausa();
    controlador();
  }
  #endregion

  #region custom public methods

  public void AbrirMenuPausa()
  {

    m_AbrirMenu = true;

  }

  public void CerrarMenuPausa()
  {

    m_AbrirMenu = false;

  }
  #endregion

  #region custom private methods
  //para abrir el menu de pausa y desactivarlo
  void MenuPausa()
  {
    if (m_AbrirMenu)
    {
      ActivarAniMenu();

    }
    else
    {
      DesctivarAniMenu();
      m_menuPausa.SetActive(false);
      m_interfazJuego.SetActive(true);
    }
  }


  // public GameObject m_nomral;
  void ActivarAniMenu()
  {
    m_animacion_Desplegable.SetActive(true);
    //  m_nomral.SetActive(false);
    m_animacion_Plegable.SetActive(false);
    m_enmarcha = true;
    m_animacionBotonGeneral.enabled = true;
  }
  void DesctivarAniMenu()
  {
    m_animacion_Desplegable.SetActive(false);
    //  m_nomral.SetActive(false);
    m_animacion_Plegable.SetActive(true);
    m_enmarcha = false;
    m_animacionBotonGeneral.enabled = false;
  }

  void controlador()
  {
    if (m_enmarcha)
    {
      m_tiempo += 1 * Time.deltaTime;
    }
    else
    {
      m_tiempo = 0;
    }

    if (m_tiempo > 0.6f)
    {
      m_menuPausa.SetActive(true);
      m_interfazJuego.SetActive(false);
    }
  }
  #endregion

}
