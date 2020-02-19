using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class OnCollisionFall : MonoBehaviour
{
    public GameObject enemy;
    private int score = 0;
    public GameObject panel;


    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }


    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "white")
        {
            collider.GetComponent<Rigidbody>().isKinematic = false;
         

        }

        else if(collider.gameObject.tag == "enemy")
        {
          
            panel.SetActive(true);
            collider.GetComponent<Rigidbody>().isKinematic = false;


        }

        


        
    }

    public void ResetScene()
    {
        SceneManager.LoadScene("SampleScene");




    }

    public void OnTriggerExit(Collider bottom)
    {
        if(bottom.transform.position.y < 0)
        {

            bottom.gameObject.SetActive(false);
            score += 10;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
