using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCountries : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] myCountries;


    public void Enable()
    {
        
            myCountries[0].SetActive(true);
        
    }
}
