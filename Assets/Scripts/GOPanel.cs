using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GOPanel : MonoBehaviour
{
    [SerializeField] GameObject _goPanel, _drLight;




    public void Restart()
    {
        _goPanel.SetActive(false);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        _drLight.SetActive(true);
    }



}
