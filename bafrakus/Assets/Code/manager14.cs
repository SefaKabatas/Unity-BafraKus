﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager14 : MonoBehaviour
{
    public Toggle toggle;
    public bool control;
    private void Start()
    {
        bool IsOn = false;
        control = false;
        if (PlayerPrefs.GetInt("IsOn14") == 1)
        {
            IsOn = true;
        }
        else
        {
            IsOn = false;
        }
        toggle.isOn = IsOn;
    }
    private void Update()
    {
        if (control == true)
        {
            kaydet();
        }
    }
    public void kaydet()
    {

        control = true;
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("IsOn14", 1);
        }
        else
        {
            PlayerPrefs.SetInt("IsOn14", 0);
        }
    }

}
