using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;

namespace AL.Data
{

  public class SC_SaveAndLoadPlayerData1 : MyMonoBehaviour
  {
    #region Attributes
    [Header("Nombre Scriptable")]
    [SerializeField] string _nameData;
    [Header("Scriptable Object")]
    [SerializeField] SC_SaveData _saveData;
    [SerializeField] Button _loadButton;
    [SerializeField] Button _saveButton;
    [SerializeField] Button _deleteButton;
    
    #endregion



    #region UnityCalls
    void Awake() => Init();
    // Start is called before the first frame update
    void Start() => StartUp();
    #endregion

    #region custom private methods
    void Init()
    {
      _loadButton.onClick.AddListener(Load);
      _saveButton.onClick.AddListener(Save);
      _deleteButton.onClick.AddListener(Delete);
    }
    void StartUp()
    {
      if (File.Exists(Application.persistentDataPath + string.Format(".pso", _nameData)))
      {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + string.Format(".pso", _nameData), FileMode.Open);
        JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), _saveData);
        file.Close();
      }
      else
      {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", _nameData));
        var json = JsonUtility.ToJson(_saveData);
        bf.Serialize(file, json);
        file.Close();
      }

      _settingData._levelCurrentSave = _saveData._savedLevel;
      _settingData._valueBrightness = _saveData._saveValueBrighnesst;
      _settingData._valuenMusica = _saveData._saveValueMusic;
      _settingData._ishandLeft = _saveData._saveHandLeft;
      _settingData._isAd = _saveData._saveAd;
      _settingData._isFirstDLC = _saveData._saveFirstDLC;
    }
    void Load()
    {
      if (File.Exists(Application.persistentDataPath + string.Format(".pso", _nameData)))
      {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + string.Format(".pso", _nameData), FileMode.Open);
        JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), _saveData);
        file.Close();
      }

      _settingData._levelCurrentSave = _saveData._savedLevel;
      _settingData._valueBrightness = _saveData._saveValueBrighnesst;
      _settingData._valuenMusica = _saveData._saveValueMusic;
      _settingData._ishandLeft = _saveData._saveHandLeft;
    }
    void Delete()
    {
      _saveData._savedLevel = 0;
      _settingData._levelCurrentSave = 0;
      _saveData._saveAd = false;
      _saveData._saveFirstDLC = false;

      BinaryFormatter bf = new BinaryFormatter();
      FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", _nameData));
      var json = JsonUtility.ToJson(_saveData);
      bf.Serialize(file, json);
      file.Close();
    }
    #endregion

    #region custom internal methods
    internal void Save()
    {
      _saveData._savedLevel = _settingData._levelCurrentSave;
      _saveData._saveValueBrighnesst = _settingData._valueBrightness;
      _saveData._saveValueMusic = _settingData._valuenMusica;
      _saveData._saveHandLeft = _settingData._ishandLeft;
      _saveData._saveAd = _settingData._isAd;
      _saveData._saveFirstDLC = _settingData._isFirstDLC;

      BinaryFormatter bf = new BinaryFormatter();
      FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", _nameData));
      var json = JsonUtility.ToJson(_saveData);
      bf.Serialize(file, json);
      file.Close();
    }
  }
  #endregion


}