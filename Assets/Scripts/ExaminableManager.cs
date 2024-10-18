using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExaminableManager : MonoBehaviour
{
    [SerializeField] Transform examinableTarget;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerformExamine(Examinable examinable)
    {
        examinable.transform.position = examinableTarget.position;
        examinable.transform.parent = examinableTarget;
    }
}
