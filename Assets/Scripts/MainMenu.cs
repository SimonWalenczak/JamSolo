using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private VideoPlayer _previousVideo;
    [SerializeField] private VideoPlayer _mainMenuVideo;
    private float _previousVideoTimer;

    [SerializeField] private float _timerBeforeButton;
    [SerializeField] GameObject _buttonParent;
    
    private void Start()
    {
        _previousVideoTimer = (float)_previousVideo.clip.length;
        
        StartCoroutine(PreviousMainMenu());
    }

    IEnumerator PreviousMainMenu()
    {
        yield return new WaitForSeconds(_previousVideoTimer);
        _previousVideo.gameObject.SetActive(false);
        _mainMenuVideo.gameObject.SetActive(true);
        
        yield return new WaitForSeconds(_timerBeforeButton);
        _buttonParent.SetActive(true);
    }
}
