using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Al.InGame.Obstacles
{
    public class BloqueParpadeante : MonoBehaviour
    {
        #region Attributes
        [SerializeField] float _timeBlinking;
        [SerializeField] int _timeDesabled;
        [SerializeField] int _timeEnabled;
        float _saveTimeBlink;
        [SerializeField] GameObject _objetoBlinked;
        [SerializeField] bool _isBlinked = false;
        #endregion


        #region UnityCalls
        private void Start()
        {
            _saveTimeBlink = _timeBlinking;
            StartCoroutine(IEStartBlink());

        }
        #endregion

        #region privat custom method
        IEnumerator IEBlink()
        {

            if (!_isBlinked)
            {
                float _time =  ((_timeBlinking * 25) / 100);
                _timeBlinking -= _time;
                yield return new WaitForSeconds(_timeBlinking);
                _objetoBlinked.GetComponent<MeshRenderer>().enabled = false;
                yield return new WaitForSeconds(0.05f);
                _objetoBlinked.GetComponent<MeshRenderer>().enabled = true;

                if (_timeBlinking < 0.1f)
                {
                    _objetoBlinked.SetActive(false);
                    _isBlinked = true;
                    StartCoroutine(IEBlink());
                }
                else
                {

                    StartCoroutine(IEBlink());
                }

            }
            else
            {

                yield return new WaitForSeconds(_timeDesabled);
                StartCoroutine(IEStartBlink());
            }
        }
        IEnumerator IEStartBlink()
        {
             _timeBlinking = _saveTimeBlink;
            _objetoBlinked.SetActive(true);
            _isBlinked = false;
            yield return new WaitForSeconds(_timeEnabled);
            StartCoroutine(IEBlink());

        }
        #endregion
    }
}
