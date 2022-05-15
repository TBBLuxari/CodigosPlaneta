using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ui : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;

    public void Colombia() 
    {
        if (Panel1.activeInHierarchy)
        {
            Panel1.SetActive(false);
        }
        else 
        {
            Panel1.SetActive(true);
            Panel2.SetActive(false);
            Panel3.SetActive(false);
        }
    }
    public void Brasil()
    {
        if (Panel2.activeInHierarchy)
        {
            Panel2.SetActive(false);
        }
        else
        {
            Panel2.SetActive(true);
            Panel1.SetActive(false);
            Panel3.SetActive(false);
        }
    }
    public void China() 
    {
        if (Panel3.activeInHierarchy)
        {
            Panel3.SetActive(false);
        }
        else
        {
            Panel3.SetActive(true);
            Panel1.SetActive(false);
            Panel2.SetActive(false);
        }
    }
}
