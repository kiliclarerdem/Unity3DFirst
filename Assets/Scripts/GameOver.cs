using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{

    [SerializeField] GameObject _goPanel;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sari"))
        {
            Time.timeScale = 0;
            _goPanel.SetActive(true);
        }
    }


}
