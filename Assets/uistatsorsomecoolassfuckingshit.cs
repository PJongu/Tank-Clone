using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uistatsorsomecoolassfuckingshit : MonoBehaviour
{
    public enemy player;
    public string displayHealth;
    public TMP_Text coolasshealthtext;
    // Start is called before the first frame update
    void Start()
    {
        coolasshealthtext = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
            displayHealth = player.GetComponent<enemy>().health.ToString();
            coolasshealthtext.text = ("Health:" + displayHealth);
        } 
    }
}
