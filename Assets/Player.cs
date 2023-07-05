using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Player : MonoBehaviour
{
    
    public float veloc  ;
    public float entradaHorizontal;
    public float entradaVertical;
    public GameObject pfLaser;
    public GameObject _disparoTriploPreFab;
 
    public float tempoDeDisparo = 0.3f;
    public float podeDisparar = 0.3f;
 
    public bool possoDarDisparoTriplo = false;
 
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Método Start de "+this.name);
        veloc = 5.0f;
        transform.position = new Vector3(0,0,0);
 
    }
 
    // Update is called once per frame
    void Update()
    {
        Movimento();
 
        if (Input.GetKeyDown(KeyCode.Space)){
        


 
    
        if (Time.time > podeDisparar){
 
             if (possoDarDisparoTriplo == true){
 
                Instantiate(_disparoTriploPreFab,transform.position + new Vector3 (0,0,0), Quaternion.identity);
 
            } else {
                Instantiate(pfLaser,transform.position + new Vector3 (1.8f,0,0), Quaternion.identity);
            }



 
            podeDisparar = Time.time + tempoDeDisparo;




 
        }
      }
 
    }
 
    private void Movimento() {
 
        entradaHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * veloc * Time.deltaTime * entradaHorizontal );
 
        entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * veloc * Time.deltaTime * entradaVertical );
 
        
 
    }
}