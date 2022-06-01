using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

namespace AL.Data
{

  public class SC_SaveAndLoadPlayerData1 : MyMonoBehaviour
  {
    #region Attributes
    [Header("Nombre Scriptable")]
    [SerializeField] private string _nameData;
    [Header("Scriptable Object")]
    [SerializeField] private SC_SaveData _playerDat1a;
    //[SerializeField] private SC_SettingsDataPersisten _settingsData;

    #region Singlenton
    public static SC_SaveAndLoadPlayerData1 _instance;
    #endregion

    #endregion


    #region UnityCalls
    void Awake() => Init();
    // Start is called before the first frame update
    void Start() => FirstLoad();
    #endregion

    #region custom private methods
    void Init()
    {
      //_settingsData = SC_SettingsDataPersisten._instanceData;
      _instance = this;
    }
    void FirstLoad()
    {
      if (File.Exists(Application.persistentDataPath + string.Format(".pso", _nameData)))
      {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + string.Format(".pso", _nameData), FileMode.Open);
        JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), _playerDat1a);
        file.Close();
      }
      else
      {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", _nameData));
        var json = JsonUtility.ToJson(_playerDat1a);
        bf.Serialize(file, json);
        file.Close();
      }

      //_settingsData._levelCurrentSave = _playerData._savedLevel;
      //_settingsData._valueBrightness = _playerData._saveValueBrighnesst;
      //_settingsData._valuenMusica = _playerData._saveValueMusic;
      //_settingsData._handLeft = _playerData._saveHandLeft;
      //_settingsData._ad = _playerData._saveAd;
      //_settingsData._firstDLC = _playerData._saveFirstDLC;
    }
    #endregion

    #region custom public methods
    public void Save()
    {
      //_playerData._savedLevel = _settingsData._levelCurrentSave;
      //_playerData._saveValueBrighnesst = _settingsData._valueBrightness;
      //_playerData._saveValueMusic = _settingsData._valuenMusica;
      //_playerData._saveHandLeft = _settingsData._handLeft;
      //_playerData._saveAd = _settingsData._ad;
      //_playerData._saveFirstDLC = _settingsData._firstDLC;

      BinaryFormatter bf = new BinaryFormatter();
      FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", _nameData));
      var json = JsonUtility.ToJson(_playerDat1a);
      bf.Serialize(file, json);
      file.Close();
    }
    public void Load()
    {
      if (File.Exists(Application.persistentDataPath + string.Format(".pso", _nameData)))
      {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + string.Format(".pso", _nameData), FileMode.Open);
        JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), _playerDat1a);
        file.Close();
      }

      //_settingsData._levelCurrentSave = _playerData._savedLevel;
      //_settingsData._valueBrightness = _playerData._saveValueBrighnesst;
      //_settingsData._valuenMusica = _playerData._saveValueMusic;
      //_settingsData._handLeft = _playerData._saveHandLeft;
    }
    public void Delete()
    {
      //_playerData._savedLevel = 0;
      //_settingsData._levelCurrentSave = 0;
      //_playerData._saveAd = false;
      //_playerData._saveFirstDLC = false;

      BinaryFormatter bf = new BinaryFormatter();
      FileStream file = File.Create(Application.persistentDataPath + string.Format(".pso", _nameData));
      var json = JsonUtility.ToJson(_playerDat1a);
      bf.Serialize(file, json);
      file.Close();
    }
  }
  #endregion


}