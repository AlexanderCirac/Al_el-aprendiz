using UnityEngine.UI;
using UnityEngine;
using AL.Data;
public class SC_BrightAndSoundData : MonoBehaviour {


  // en esta script leeremos los datos.
  //[HideInInspector]
 // public SC_SettingsDataPersisten SC_D;

  public Image m_Brillo;

  //esto es para el controlar el volumen del sonido
  public AudioSource m_musica;



  void Update () {

    //  m_BoolZurdo = m_Zurdo.isOn;
  //  m_Zurdo.isOn = m_BoolZurdo;
    BuscarSC_Datos();
    if (m_musica == null)
    {
      // m_musica = SC_D.GetComponentInChildren<AudioSource>();
    }
   LeerBrillo();
   LeerMusica();
    LleerZurdo();


  }

  void BuscarSC_Datos()
  {//cargara en una variable publica la script que almacena todos los datos
    //if (SC_D == null)
    //{ 
    //  SC_D = FindObjectOfType<SC_SettingsDataPersisten>();
    //}
  }

  void LeerBrillo()
  {
    //Cogera los datos almacenados y los aplicara al brillo
    //if (SC_D != null) {
    //  m_Brillo.color = new Color(m_Brillo.color.r, m_Brillo.color.g, m_Brillo.color.b, SC_D._valueBrightness - 0.1f);
    //}
  }

  void LeerMusica()
  {
    //Cogera los datos almacenados y los aplicara al volumen
    //if (SC_D != null)
    //{
    //  m_musica.volume = SC_D._valuenMusica;
    //}
  }

  public Toggle m_zurdo;
  public int m_numero = 0;
  void LleerZurdo()
  {
    //if (SC_D != null)
    //{
    //  if ( m_zurdo != null && m_numero == 0)
    //  {
    //    m_zurdo.isOn = SC_D._handLeft;
    //    m_numero = 1;
    //  }
    //}
  }

}
