using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject tutorial;

    // Start is called before the first frame update
    void Start()
    {
        tutorial.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tutorial.gameObject.SetActive(false);
        }
        
    }
}
