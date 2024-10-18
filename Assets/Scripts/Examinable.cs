using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examinable : MonoBehaviour
{
    [SerializeField] ExaminableManager examinableManager;


    // Start is called before the first frame update
    void Start()
    {
     examinableManager = FindObjectOfType<ExaminableManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RequestExamine()
    {
        examinableManager.PerformExamine(this);
    }
}
