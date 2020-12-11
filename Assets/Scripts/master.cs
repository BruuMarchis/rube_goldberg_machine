using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class master : MonoBehaviour
{
    // Start is called before the first frame update
    public rotatoria engrenagem;
    public balanca balanca_1;
    public float peso_balanca;
    public float peso_atual;

    public queda cair;
    public movimento sair;


    void Start()
    {
        peso_balanca = balanca_1.peso; 
        peso_atual = balanca_1.peso;
    }

    // Update is called once per frame
    void Update()
    {
        peso_atual = balanca_1.peso;
        if (peso_balanca < peso_atual)
        {
            engrenagem.ativo = true;
            cameraControler.bolaAtual++;
            peso_balanca = balanca_1.peso;
        }

        if (cair.ok)
        {
            sair.ativo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        engrenagem.ativo = false;
    }


    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
