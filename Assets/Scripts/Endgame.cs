using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    private void OnGUI() {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 26;
        myStyle.normal.textColor = Color.white;
        GUI.Label(new Rect(10, 10, 250, 60), "PRESSIONE A TECLA ESC PARA SAIR!", myStyle);
    }
}
