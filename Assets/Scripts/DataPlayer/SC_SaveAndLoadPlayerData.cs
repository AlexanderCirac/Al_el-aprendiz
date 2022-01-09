﻿using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using AL.Data;

namespace AL.Data
{
    public class SC_SaveAndLoadPlayerData : MonoBehaviour
    {
          #region Attributes
          [Header("Nombre Scriptable")]
          [SerializeField] private string _nameOfPlayerData;
          [Header("Scriptable Object")]
          [SerializeField] private SC_SaveData _playerData;
          [SerializeField] private SC_SettingsDataPersisten _settingsData;
          #endregion          
          #region Singlenton
          public static SC_SaveAndLoadPlayerData _instance;
          #endregion

          #region UnityCalls
          private void Awake()
          {
              _settingsData = SC_SettingsDataPersisten._instanceData;
              _instance = this;
          }
          // Start is called before the first frame update
          void Start()
          {
              FirstLoad();
          }
          #endregion          

          #region Methods
          private void FirstLoad()
          {
              if (File.Exists(Application.persistentDataPath + string.Format(".pso", _nameOfPlayerData)))
              {
                  BinaryFormatter bf = new BinaryFormatter();
                  FileStream file = File.Open(Application.persistentDataPath + string.Format(".pso", _nameOfPlayerData), FileMode.Open);
                  JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), _playerData);
                  file.Close();
              }
              else
              {
                  BinaryFormatter bf = new BinaryFormatter();
                  FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", _nameOfPlayerData));
                  var json = JsonUtility.ToJson(_playerData);
                  bf.Serialize(file, json);
                  file.Close();
              }

              _settingsData._levelCurrentSave = _playerData._savedLevel;
              _settingsData._valueBrightness = _playerData._saveValueBrighnesst;
              _settingsData._valuenMusica = _playerData._saveValueMusic;
              //m_Datos.m_ID_Grafico = m_objetoPersistente.m_ID_Grafico;
              _settingsData._handLeft = _playerData._saveHandLeft;
              _settingsData._ad = _playerData._saveAd;
              _settingsData._firstDLC = _playerData._saveFirstDLC;
          }

          public void Save()
          {
              _playerData._savedLevel = _settingsData._levelCurrentSave;
              _playerData._saveValueBrighnesst = _settingsData._valueBrightness;
              _playerData._saveValueMusic = _settingsData._valuenMusica;
              //m_objetoPersistente.m_ID_Grafico = m_Datos.m_ID_Grafico;
              _playerData._saveHandLeft = _settingsData._handLeft;
              _playerData._saveAd = _settingsData._ad;
              _playerData._saveFirstDLC = _settingsData._firstDLC;

              BinaryFormatter bf = new BinaryFormatter();
              FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", _nameOfPlayerData));
              var json = JsonUtility.ToJson(_playerData);
              bf.Serialize(file, json);
              file.Close();
          }

          public void Load()
          {
              if (File.Exists(Application.persistentDataPath + string.Format(".pso", _nameOfPlayerData)))
              {
                  BinaryFormatter bf = new BinaryFormatter();
                  FileStream file = File.Open(Application.persistentDataPath + string.Format(".pso", _nameOfPlayerData), FileMode.Open);
                  JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), _playerData);
                  file.Close();
              }

              _settingsData._levelCurrentSave = _playerData._savedLevel;
              _settingsData._valueBrightness = _playerData._saveValueBrighnesst;
              _settingsData._valuenMusica = _playerData._saveValueMusic;
              //m_Datos.m_ID_Grafico = m_objetoPersistente.m_ID_Grafico;
              _settingsData._handLeft = _playerData._saveHandLeft;
          }

          public void Delete()
          {
              _playerData._savedLevel = 0;
              _settingsData._levelCurrentSave = 0;
              _playerData._saveAd = false;
              _playerData._saveFirstDLC = false;

              BinaryFormatter bf = new BinaryFormatter();
              FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", _nameOfPlayerData));
              var json = JsonUtility.ToJson(_playerData);
              bf.Serialize(file, json);
              file.Close();
          }

        }
          #endregion


}

