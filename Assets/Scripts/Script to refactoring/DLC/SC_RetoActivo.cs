using UnityEngine;
using AL.Data;
public class SC_RetoActivo : MonoBehaviour
{
  //esta scritp es para activar el reto del dlc cuando el jugador colisione con el trigger, donde previamente se elegira de forma random un reto


    // Start is called before the first frame update
    void Start()
    {
  //  SC_DJ = FindObjectOfType<SC_SettingsDataPersisten>();
    }

    // Update is called once per frame
    void Update()
    {
    RandoReto();
    RetoActivo();
    }

  private bool m_boolReto;
  public int m_idReto;
  void RandoReto()
  {
    if (!m_boolReto)
    {
      m_idReto = Random.Range(1, m_reto.Length);
      m_boolReto = true; 
    }
  }

  public GameObject[] m_reto;
  void RetoActivo()
  {
    if (m_idReto > 0 )
    {

       m_reto[(m_idReto-1)].SetActive(true);
    }
  }


  public void CerrarDialogoRechazar()
  {
  }

  public GameObject  m_evento;
  [HideInInspector]
  public void ActivarEvento()
  {
    m_evento.SetActive(true);
    RetoActivo();
  }

  public void LoHasPasado(int m_id)
  {
    //if (m_id == 1)
    //{
    //  SC_DJ._isRetorno1 = true;
    //}    
    //if (m_id == 2)
    //{
    //  SC_DJ._isRetorno2 = true;
    //}
    //if (m_id == 3)
    //{
    //  SC_DJ._isRetorno3 = true;
    //}
    m_evento.SetActive(false);
    if (m_dialogo != null)
    {

    m_dialogo.SetActive(false);
    }
  }

  //esta funcion es para poder
  public GameObject m_jugador;
  //private SC_SettingsDataPersisten SC_DJ;
  public GameObject m_dialogo;
  public GameObject m_dialogo1;
  public void HasPerdido()
  {
    m_jugador.GetComponent<SC_LifeController>().m_vida --;
    if (m_dialogo != null)
    {

    m_dialogo.SetActive(false);
    }
    m_evento.SetActive(false);

  }
}
