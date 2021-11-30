using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject[] par1 = new GameObject[2];
    public GameObject[] par2 = new GameObject[2];
    public GameObject[] par3 = new GameObject[2];
    public GameObject[] par4 = new GameObject[2];
    public GameObject[] par5 = new GameObject[2];
    public GameObject[] par6 = new GameObject[2];
    public GameObject[] par7 = new GameObject[2];
    public GameObject[] par8 = new GameObject[2];
    public GameObject[] par9 = new GameObject[2];
    public GameObject[] par10 = new GameObject[2];
    public GameObject[] par11 = new GameObject[2];
    public GameObject[] par12 = new GameObject[2];
    public float[] rand = {0,0,0,0,0,0,0,0,0,0,0,0};
    // Start is called before the first frame update
    void Start()
    {        
        rand[0] = Random.value; 
        rand[1] = Random.value; 
        rand[2] = Random.value; 
        rand[3] = Random.value; 
        rand[4] = Random.value; 
        rand[5] = Random.value; 
        rand[6] = Random.value; 
        rand[7] = Random.value; 
        rand[8] = Random.value; 
        rand[9] = Random.value; 
        rand[10] = Random.value; 
        rand[11] = Random.value; 
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Death")
        {
            SceneManager.LoadScene("Game Over");
        }else if (other.transform.tag == "Finish")
        {
            SceneManager.LoadScene("Winner");
        }
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject == par1[0]||collision.gameObject == par1[1]){
            if(rand[0]>0.5){
                Destroy(par1[0]);
            }else{
                Destroy(par1[1]);
            }
        }else if(collision.gameObject == par2[0]||collision.gameObject == par2[1]){
            if(rand[0]>0.5){
                Destroy(par2[0]);
            }else{
                Destroy(par2[1]);
            }
        }
        else if(collision.gameObject == par3[0]||collision.gameObject == par3[1]){
            if(rand[0]>0.5){
                Destroy(par3[0]);
            }else{
                Destroy(par3[1]);
            }
        }
        else if(collision.gameObject == par4[0]||collision.gameObject == par4[1]){
            if(rand[0]>0.5){
                Destroy(par4[0]);
            }else{
                Destroy(par4[1]);
            }
        }
        else if(collision.gameObject == par5[0]||collision.gameObject == par5[1]){
            if(rand[0]>0.5){
                Destroy(par5[0]);
            }else{
                Destroy(par5[1]);
            }
        }
        else if(collision.gameObject == par6[0]||collision.gameObject == par6[1]){
            if(rand[0]>0.5){
                Destroy(par6[0]);
            }else{
                Destroy(par6[1]);
            }
        }
        else if(collision.gameObject == par7[0]||collision.gameObject == par7[1]){
            if(rand[0]>0.5){
                Destroy(par7[0]);
            }else{
                Destroy(par7[1]);
            }
        }
        else if(collision.gameObject == par8[0]||collision.gameObject == par8[1]){
            if(rand[0]>0.5){
                Destroy(par8[0]);
            }else{
                Destroy(par8[1]);
            }
        }
        else if(collision.gameObject == par9[0]||collision.gameObject == par9[1]){
            if(rand[0]>0.5){
                Destroy(par9[0]);
            }else{
                Destroy(par9[1]);
            }
        }
        else if(collision.gameObject == par10[0]||collision.gameObject == par10[1]){
            if(rand[0]>0.5){
                Destroy(par10[0]);
            }else{
                Destroy(par10[1]);
            }
        }
        else if(collision.gameObject == par11[0]||collision.gameObject == par11[1]){
            if(rand[0]>0.5){
                Destroy(par11[0]);
            }else{
                Destroy(par11[1]);
            }
        }
        else if(collision.gameObject == par12[0]||collision.gameObject == par12[1]){
            if(rand[0]>0.5){
                Destroy(par12[0]);
            }else{
                Destroy(par12[1]);
            }
        }
    }
}
