using UnityEngine;
using AL.Data;

namespace AL
{
    public class MyMonoBehaviour : MonoBehaviour
    {
        protected SC_SettingsDataPersisten settingsData => SC_SettingsDataPersisten._instanceData;
        protected SC_SaveAndLoadPlayerData saveAndLoad => SC_SaveAndLoadPlayerData._instance;

    } 
}
