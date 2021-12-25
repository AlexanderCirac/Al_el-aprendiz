using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SC_GuardarYCargar2 : MonoBehaviour
{
  [Header("Nombre Scriptable")]
  public string m_nombrePersistente;
  [Header("Scriptable Object")]
  public Suscriptable1 m_objetoPersistente;
  public GameObject m_player;


  public bool m_1;
  public bool m_2;
  // Start is called before the first frame update
  void Start(){
    
    
  }

    // Update is called once per frame
    void Update() { cargadoauto(); }

  void cargadoauto()
  {
   if(!m_1){
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
      m_1 = true;
    }
  }

  public void Guardar()
  {
    m_objetoPersistente.m_valorInt = 1;
    m_objetoPersistente.posX = m_player.transform.position.x;
    m_objetoPersistente.posY = m_player.transform.position.y;
    m_objetoPersistente.posZ = m_player.transform.position.z;

    //Do Nothing
    BinaryFormatter bf = new BinaryFormatter();
    FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", m_nombrePersistente));
    var json = JsonUtility.ToJson(m_objetoPersistente);
    bf.Serialize(file, json);
    file.Close();
    
  }

  public void cargar()
  {

    if (m_objetoPersistente.m_valorInt == 1)
    {
      if (File.Exists(Application.persistentDataPath + string.Format(".pso", m_nombrePersistente)))
      {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + string.Format(".pso", m_nombrePersistente), FileMode.Open);
        JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), m_objetoPersistente);
        file.Close();
      }
      m_player.transform.position = new Vector3(m_objetoPersistente.posX, m_objetoPersistente.posY, m_objetoPersistente.posZ);
    }
  }


  public void borrar()
  {
    if (m_objetoPersistente.m_valorInt == 1)
    {
      m_objetoPersistente.m_valorInt = 0;
      m_objetoPersistente.posX = 0f;
      m_objetoPersistente.posY = 0f;
      m_objetoPersistente.posZ = 0f;

    }

      //Do Nothing
      BinaryFormatter bf = new BinaryFormatter();
      FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", m_nombrePersistente));
      var json = JsonUtility.ToJson(m_objetoPersistente);
      bf.Serialize(file, json);
      file.Close();
    }
}
