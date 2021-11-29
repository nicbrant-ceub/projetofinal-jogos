using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {
 public bool EstaSubindo,EstaDescendo,EstaParado,EstaPerto;
 public Transform paradaBaixo,paradaAlta;
 public float speed = 3;
 public GameObject Botao;
 void OnTriggerEnter (){
 EstaPerto = true;
 }
 void OnTriggerExit (){
 EstaPerto = false;
 }
 void FixedUpdate (){
 if(EstaSubindo == true){
 transform.position = Vector3.MoveTowards(transform.position,paradaAlta.transform.position,speed*Time.deltaTime);
 }
 if(EstaDescendo == true){
 transform.position = Vector3.MoveTowards(transform.position,paradaBaixo.transform.position,speed*Time.deltaTime);
 }
 if(transform.position == paradaBaixo.transform.position || transform.position == paradaAlta.transform.position){
 Botao.GetComponent<Renderer>().material.color = Color.red;
 EstaParado = true;
 }else{
 Botao.GetComponent<Renderer>().material.color = Color.green;
 EstaParado = false;
 }
 if(Input.GetKeyDown("e") && EstaPerto == true && EstaParado == true){
 if(transform.position == paradaBaixo.transform.position){
 EstaSubindo = true;
 EstaDescendo = false;
 }else if(transform.position == paradaAlta.transform.position){
 EstaSubindo = false;
 EstaDescendo = true;
 }
 }
 }
}