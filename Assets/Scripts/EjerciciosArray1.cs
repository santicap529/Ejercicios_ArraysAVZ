using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosArray1 : MonoBehaviour
{
    public GameObject[] cubitos;
    int contadora = 0;
    int contadora2 = 3;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.E))
      {
        if(contadora < cubitos.Length)
        {
            cubitos[contadora].SetActive(false);
            contadora++;
        }
      }

      if(Input.GetKeyDown(KeyCode.R))
      {
        if(contadora2 >= 0)
        {
            cubitos[contadora2].SetActive(false);
            contadora2--;
        }
      }
    }
    
    void DesactivarPrimerElemento(GameObject[] arr){
        if(arr.Length > 0){
          arr[0].SetActive(false);  
        }
        else{
            Debug.Log("Array esta vacio");
        }
    }

    void DesactivarTodosLosElementos(GameObject[] arr){
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i].SetActive(false);
        }
    }
}
