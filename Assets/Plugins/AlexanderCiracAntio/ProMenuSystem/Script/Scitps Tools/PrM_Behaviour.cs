using UnityEngine;

namespace AlexanderCA.ProMenu
{
    using AlexanderCA.ProMenu.Explication;
    using AlexanderCA.ProMenu.UI;
    using AlexanderCA.ProMenu.Data;
    using AlexanderCA.ProMenu.Opciones;
    using AlexanderCA.ProMenu.LoadBar;
    public class PrM_Behaviour : MonoBehaviour
    {
       protected PrM_Explication _gameMenus => PrM_Explication._instance;
       protected PrM_UIManager _uIManager => _gameMenus._proMenuUIMannager;
       protected PrM_OptGameManager _optionsManager => _gameMenus._proMenuOptionsMannager;
       protected PrM_DataPersistent _dataPersiten => _gameMenus._proDataOptionsPersisten;
       protected PrM_LoadGameController _loadBarController => _gameMenus._proLoadBarController;       
        protected PrM_LoadGameManger _loadBarManager => _gameMenus._proLoadBarManager;
    }
}
