using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao_Camera : MonoBehaviour
{
    float unidadeRx, unidadeRy;
    float vR;

    public GameObject personagem;
    // Start is called before the first frame update
    void Start()
    {
        vR = 70f;
        unidadeRx = 0f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        unidadeRx += Input.GetAxis("Mouse Y") * vR * Time.deltaTime;
        unidadeRx = Mathf.Clamp(unidadeRx, -60f, 60f);
        transform.localEulerAngles = new Vector3(-unidadeRx, 0, 0);

        unidadeRy = Input.GetAxis("Mouse X") * vR * Time.deltaTime;
        personagem.transform.Rotate(0, unidadeRy, 0);
    }
}
