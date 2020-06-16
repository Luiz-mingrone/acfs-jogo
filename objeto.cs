using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

 public class objeto : MonoBehaviour {

     public GameObject cubo;


 	void Update () {
         //ainda não está funcionando
         //se o carro estiver 30 posições a frente do objeto ele sera destruido
 		if (cubo.transform.position.z > transform.position.z + 30)
         {
             Destroy(this);
         }
    
 	}
 }
