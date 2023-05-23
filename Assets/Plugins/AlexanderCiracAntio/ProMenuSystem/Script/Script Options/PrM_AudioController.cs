using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

namespace AlexanderCA.ProMenu.Opciones
{

    public class PrM_AudioController : PrM_Behaviour
    {
        #region Attributes
        AudioSource[] _audioSource;
        Scrollbar _soundScrollBar;
        int _iDSoundFloat;
        #endregion


        #region custom public Methods
        /// <summary>
        /// Set audio source and scrollbar for control sound effects
        /// </summary>
        /// <param name="_audioSource">to see the effects of sound value</param>
        /// <param name="_soundScrollBar">for to controll the sound value</param>
        public void SetSoundController(AudioSource[] _audioSource, Scrollbar _soundScrollBar, int _iDSoundFloat, float _sound)
        {
          this._audioSource = _audioSource;
          this._soundScrollBar = _soundScrollBar;
          this._iDSoundFloat = _iDSoundFloat;
          ToSound(_sound);
        }
        #endregion

        #region custom private Methods
        /// <summary>
        /// Control sound effects
        /// </summary>
        void ToSound(float _sound)
        {
            if (_soundScrollBar)
            {
                if(_audioSource != null)
                    for (int i = 0; i <= _audioSource.Length-1; i++)
                        _audioSource[i].volume = _sound;
                
                    _soundScrollBar.value = _sound;
                    _soundScrollBar.onValueChanged.AddListener(ReasignValueSound);
            }
            else
            {     
                if(_audioSource != null)
                {
                    for (int i = 0; i <= _audioSource.Length-1 ; i++)
                    {
                        _audioSource[i].volume = _sound;

                    }
                }
            }
        }  
        void ReasignValueSound(float val)
        {
            for (int i = 0; i <= _audioSource.Length-1; i++)
            {
                     _audioSource[i].volume = val;             
                     _optionsManager._soundFloat[_iDSoundFloat] = val;
            }
        }
        #endregion

    }
}
