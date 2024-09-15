using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    public GameObject PopUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InteractPopUp()
    {
        PopUp.SetActive(true);
    }
    public void InteractPopDown()
    {
        PopUp.SetActive (false);
    }
}
