using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigi;
    public Image pnl;
    float yokOlHizi = 0.03f;

    void Start()
    {
        rigi = GetComponent<Rigidbody>();   
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Respawn"))
        {
            transform.position = other.gameObject.transform.position;
            rigi.isKinematic = true;
            InvokeRepeating("yokOl", 0.0f, 0.02f);
        }
        else if (other.gameObject.tag.Equals("Finish"))
        {
            rigi.isKinematic = true;
            pnl.gameObject.SetActive(true);
        }
    }
    void yokOl()
    {
        transform.localScale -= new Vector3(yokOlHizi, yokOlHizi, yokOlHizi);
        if (transform.localScale.x <= 0.0f)
        {
            pnl.gameObject.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
