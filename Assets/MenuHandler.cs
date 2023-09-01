using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHandler : MonoBehaviour
{

    string playerName;

    [SerializeField] Text PlayerInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetPlayerName()
    {
        playerName = PlayerInput.text;
        Debug.Log(playerName);
    }

}
