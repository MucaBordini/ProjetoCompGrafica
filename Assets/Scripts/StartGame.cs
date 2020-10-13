using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject Watermelon;
    public GameObject Banana;
    public GameObject Hamburguer;
    public GameObject Hotdog;
    public GameObject Cheese;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnGUI() {
            GUIStyle myStyle = new GUIStyle();
            GUIStyle nEat = new GUIStyle();
            GUIStyle eat = new GUIStyle();
            myStyle.fontSize = 26;
            nEat.fontSize = 26;
            nEat.normal.textColor = Color.red;
            eat.fontSize = 26;
            eat.normal.textColor = Color.green;

            GUI.Label(new Rect(10, 10, 250, 60), "Você está com fome, encontre todas as comidas!", myStyle);
            if(Watermelon.activeSelf == true) {
                GUI.Label(new Rect(10, 80, 250, 20), "Melancia", nEat);
            } else {
                GUI.Label(new Rect(10, 80, 250, 20), "Melancia", eat);
            }
            if(Banana.activeSelf == true) {
                GUI.Label(new Rect(10, 110, 250, 20), "Banana", nEat);
            } else {
                GUI.Label(new Rect(10, 110, 250, 20), "Banana", eat);
            }
            if(Cheese.activeSelf == true) {
                GUI.Label(new Rect(10, 140, 250, 20), "Queijo", nEat);
            } else {
                GUI.Label(new Rect(10, 140, 250, 20), "Queijo", eat);
            }
            if(Hamburguer.activeSelf == true) {
                GUI.Label(new Rect(10, 170, 250, 20), "Hamburguer", nEat);
            } else {
                GUI.Label(new Rect(10, 170, 250, 20), "Hamburguer", eat);
            }
            if(Hotdog.activeSelf == true) {
                GUI.Label(new Rect(10, 200, 250, 20), "HotDog", nEat);
            } else {
                GUI.Label(new Rect(10, 200, 250, 20), "HotDog", eat);
            }   
    }
}
