using UnityEngine;
using AL.Data;
public class SC_DesbloquearNivel : MonoBehaviour
{
  //esto lo que ara es sumar el nivel del juego para que cuando vayas al mapa de niveles puedas ir al correspondiente
  [HideInInspector]
 // public SC_SettingsDataPersisten SC_D;

  public int m_nivelAcutal;
  
  
  void Update()
    {
      BuscarSC_Datos();
    }

  public void CondicionVictoria()
  {
    //if (m_nivelAcutal > SC_D._levelCurrentSave)
    //{
    //  SC_D._levelCurrentSave++;
    //}
   // Application.LoadLevel(2);
  }

  void BuscarSC_Datos()
  {//cargara en una variable publica la script que almacena todos los datos
    //if (SC_D == null)
    //{
    //  SC_D = FindObjectOfType<SC_SettingsDataPersisten>();
    //}
  }


  ////forma de hacerlo 1
  //private void OnTriggerEnter(Collider col)
  //{
  //  if (col.CompareTag("Player"))
  //  {
  //    if (m_nivelAcutal > SC_D.m_nivel)
  //    {
  //      SC_D.m_nivel++;
  //    }
  //    Destroy(m_caja);
  //    m_canvasVictoria.SetActive(true);
  //  }
  //}
}
