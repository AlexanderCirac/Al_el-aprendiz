using UnityEngine;
namespace AlexanderCA.ProMenu.Explication
{
    using AlexanderCA.ProMenu.ToolsInspector;
    using AlexanderCA.ProMenu.UI;
    using AlexanderCA.ProMenu.Data;
    using AlexanderCA.ProMenu.Opciones;
    using AlexanderCA.ProMenu.LoadBar;
    [RequireComponent(typeof(PrM_UIManager))]
    [RequireComponent(typeof(PrM_OptGameManager))]
    [RequireComponent(typeof(PrM_LoadGameManger))]
    public class PrM_Explication : PrM_Behaviour
    {
        
        #region Attributes
        public PrM_ExplicationInfo _explication;
        //My tools
        internal PrM_UIManager _proMenuUIMannager;
        internal PrM_OptGameManager _proMenuOptionsMannager;
        internal PrM_DataPersistent _proDataOptionsPersisten;
        internal PrM_LoadGameController _proLoadBarController;
        internal PrM_LoadGameManger _proLoadBarManager;
        //singleton
        public static PrM_Explication _instance;
        #endregion

        #region UnityCalls
        void Awake() => Init();
        void Start() => StartUp();
        #endregion 
    
        #region custom private Method
        void Init()
        {
            _instance = this;
            _proMenuUIMannager = FindObjectOfType<PrM_UIManager>();
            _proMenuOptionsMannager = FindObjectOfType<PrM_OptGameManager>();
            _proLoadBarController = FindObjectOfType<PrM_LoadGameController>();
            _proLoadBarManager = FindObjectOfType<PrM_LoadGameManger>();
            _proDataOptionsPersisten = FindObjectOfType<PrM_DataPersistent>();
 
        }        
        void StartUp()
        {
            _proDataOptionsPersisten = FindObjectOfType<PrM_DataPersistent>();
        }
        #endregion
    }
}
