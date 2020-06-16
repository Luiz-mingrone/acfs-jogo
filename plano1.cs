using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

 public class plano1 : MonoBehaviour {
     public GameObject cubo;
     public GameObject ob;
      public bool criarObjeto;
    
 	//tem 3 plataformas que quando o carro passa por elas, são transportadas para frente das outras formando um loop
void Start () {
     
}

 IEnumerator Espera (){
             
      criarObjeto = false;
       yield return new WaitForSeconds(10.0f);
      

 }


void   Update () {
        
         //depois que o carro passar por esta plataforma ela será transportada para 180 posições pra frente(aparece atras das outras duas plataformas criando um loop)
 		 if(cubo.transform.position.z > this.transform.position.z+40 && criarObjeto == true )
         {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+180);
                    
             //cria 3 objetos em posições aleatorias dentro do espaço da plataforma
             Instantiate(ob, new Vector3(1f, 2.1f, Random.Range(transform.position.z - 40, transform.position.z + 60)), Quaternion.identity);
                  StartCoroutine("Espera");
             Instantiate(ob, new Vector3(1f, 2.1f, Random.Range(transform.position.z - 30, transform.position.z + 30)), Quaternion.identity);
               StartCoroutine("Espera");
            Instantiate(ob, new Vector3(1f, 2.1f, Random.Range(transform.position.z - 30, transform.position.z + 30)), Quaternion.identity);
        
         }
         if(cubo.transform.position.z < this.transform.position.z-40 && criarObjeto == true )
             {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-180);
             
                //cria 3 objetos em posições aleatorias dentro do espaço da plataforma
                Instantiate(ob, new Vector3(1f, 2.1f, Random.Range(transform.position.z - 40, transform.position.z + 60)), Quaternion.identity);
                  StartCoroutine("Espera");
                 Instantiate(ob, new Vector3(1f, 2.1f, Random.Range(transform.position.z - 30, transform.position.z + 30)), Quaternion.identity);
                   StartCoroutine("Espera");
                 Instantiate(ob, new Vector3(1f, 2.1f, Random.Range(transform.position.z - 30, transform.position.z + 30)), Quaternion.identity);
 }
 }

 }

	

