using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyMenu : MonoBehaviour
{
    public GameObject BuyMenuPanel;
    void Start()
    {
        BuyMenuPanel.SetActive(false);
    }
    void Update()
    {   
        if (Input.GetButtonDown("Buy"))
        {
            BuyMenuPanel.SetActive(true);
        }
    }
}
