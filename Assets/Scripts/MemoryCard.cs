using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] GameObject cardBack;

    public void OnMouseDown() {
        if(cardBack.activeSelf) {
            cardBack.SetActive(false);
        }
    }

    [SerializeField] SceneController controller;
    private int _id;
    private int Id {
        get {return _id;}
    }
    public void SetCard(int id, Sprite image) {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
