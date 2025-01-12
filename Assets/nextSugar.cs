using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class nextSugar : MonoBehaviour
{
    public GameObject nextSuga;
    public GameObject gulatuang;
    public GameObject gulaselesai;
    public GameObject masukkinstraw;
    public GameObject adukstraw;
    public GameObject strawjam;
    
    public void ClicktoNextSuga(){
        nextSuga.SetActive(false);
        gulatuang.SetActive(true);
    }
    public void Clicktotuang(){
        gulatuang.SetActive(false);
        gulaselesai.SetActive(true);
    }
    public void Clicktolanjurgula(){
        gulaselesai.SetActive(false);
        masukkinstraw.SetActive(true);
    }
    public void Clicktostarpanci(){
        masukkinstraw.SetActive(false);
        adukstraw.SetActive(true);
    }
    public void hasiljam(){
        adukstraw.SetActive(false);
        strawjam.SetActive(true);
    }
    public void OpenScene(){
    SceneManager.LoadScene("Sendjam");
}

}
