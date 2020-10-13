using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimentacao_Personagem : MonoBehaviour
{
    float unidadeTx, unidadeTz;
    float vT;
    bool nearFood;

    public GameObject Watermelon;
    public GameObject Banana;
    public GameObject Hamburguer;
    public GameObject Hotdog;
    public GameObject Cheese;
    private int eaten = 0;

    private GameObject SelectedFood;
    // Start is called before the first frame update
    void Start()
    {
        vT = 3.0f;
        nearFood = false;
    }

    // Update is called once per frame
    void Update()
    {
        unidadeTx = Input.GetAxis("Horizontal") * vT * Time.deltaTime;
        unidadeTz = Input.GetAxis("Vertical") * vT * Time.deltaTime;

        transform.Translate(unidadeTx, 0, unidadeTz);

        if(nearFood) {
            if(Input.GetKeyDown(KeyCode.F)){
                nearFood = false;
                eaten++;
                SelectedFood.SetActive(false);
            }
        }

        if (eaten == 5) {
            SceneManager.LoadScene (1);
        }

    }

    private void OnTriggerEnter(Collider other) {

        switch(other.tag){
            case "watermelon":
                SelectedFood = Watermelon;
                nearFood = true;
                break;
            case "banana":
                SelectedFood = Banana;
                nearFood = true;
                break;
            case "hamburguer":
                SelectedFood = Hamburguer;
                nearFood = true;
                break;
            case "hotdog":
                SelectedFood = Hotdog;
                nearFood = true;
                break;
            case "cheese":
                SelectedFood = Cheese;
                nearFood = true;
                break;
            default:
                break;
        }

        // if(other.tag == "food"){
        //     nearFood = true;
        // }
    }

    private void OnTriggerExit (Collider other) {
        // if(
        //     other.tag == "watermelon" ||
        //     other.tag == "banana" ||
        //     other.tag == "hamburguer" ||
        //     other.tag == "hotdog" ||
        //     other.tag == "cheese"
        // )
        // {
            nearFood = false;
        //}
    }

    private void OnGUI() {
        if(nearFood) {
            GUI.Label(new Rect(Screen.width/2, Screen.height/2, 250, 30), "Pressione 'F' para comer");
        }
    }
}
