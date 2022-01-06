using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using AL.Data;
public class SC_GuardarYCargarJugador : MonoBehaviour
{

  [Header("Nombre Scriptable")]
  public string m_nombrePersistente;
  [Header("Scriptable Object")]
  public SC_SaveData m_objetoPersistente;
  public SC_SettingsDataPersisten m_Datos;


  public bool m_1;
  private bool m_2;

  // Start is called before the first frame update
  void Start()
  {
    m_Datos = SC_SettingsDataPersisten._instanceData;
   
  }

  private void Update()
  {
    if (m_Datos != null) {
    cargadoauto();
    }
  }


  void cargadoauto()
  {
    if (!m_1)
    { 

      if (File.Exists(Application.persistentDataPath + string.Format(".pso", m_nombrePersistente)))
      {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + string.Format(".pso", m_nombrePersistente), FileMode.Open);
        JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), m_objetoPersistente);
        file.Close();
      }
      else
      {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", m_nombrePersistente));
        var json = JsonUtility.ToJson(m_objetoPersistente);
        bf.Serialize(file, json);
        file.Close();
      }
      m_Datos._levelCurrentSave = m_objetoPersistente._savedLevel;
      m_Datos._valueBrightness = m_objetoPersistente._saveValueBrighnesst;
      m_Datos._valuenMusica = m_objetoPersistente._saveValueMusic;
      //m_Datos.m_ID_Grafico = m_objetoPersistente.m_ID_Grafico;
      m_Datos._handLeft = m_objetoPersistente._saveHandLeft;
      m_Datos._ad = m_objetoPersistente._saveAd;
      m_Datos._firstDLC = m_objetoPersistente._saveFirstDLC;
      m_1 = true;
    }
   
  }

  public void GuardarOpciones()
  {
 
    m_objetoPersistente._savedLevel = m_Datos._levelCurrentSave;
    m_objetoPersistente._saveValueBrighnesst = m_Datos._valueBrightness;
    m_objetoPersistente._saveValueMusic = m_Datos._valuenMusica;
    //m_objetoPersistente.m_ID_Grafico = m_Datos.m_ID_Grafico;
    m_objetoPersistente._saveHandLeft = m_Datos._handLeft;
    m_objetoPersistente._saveAd = m_Datos._ad;
    m_objetoPersistente._saveFirstDLC = m_Datos._firstDLC;

    BinaryFormatter bf = new BinaryFormatter();
    FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", m_nombrePersistente));
    var json = JsonUtility.ToJson(m_objetoPersistente);
    bf.Serialize(file, json);
    file.Close();

  }


  public void CargarOpciones()
  {
    if (File.Exists(Application.persistentDataPath + string.Format(".pso", m_nombrePersistente)))
    {
      BinaryFormatter bf = new BinaryFormatter();
      FileStream file = File.Open(Application.persistentDataPath + string.Format(".pso", m_nombrePersistente), FileMode.Open);
      JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), m_objetoPersistente);
      file.Close();
    }
   m_Datos._levelCurrentSave = m_objetoPersistente._savedLevel;
    m_Datos._valueBrightness = m_objetoPersistente._saveValueBrighnesst;
    m_Datos._valuenMusica = m_objetoPersistente._saveValueMusic;
    //m_Datos.m_ID_Grafico = m_objetoPersistente.m_ID_Grafico;
    m_Datos._handLeft = m_objetoPersistente._saveHandLeft;

  }


  public void BorrarDatosNivel()
  {
    m_objetoPersistente._savedLevel = 0;
    m_Datos._levelCurrentSave = 0;
    m_objetoPersistente._saveAd = false;
    m_objetoPersistente._saveFirstDLC = false;
    BinaryFormatter bf = new BinaryFormatter();
    FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", m_nombrePersistente));
    var json = JsonUtility.ToJson(m_objetoPersistente);
    bf.Serialize(file, json);
    file.Close();
  }

}

