using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExaminableManager : MonoBehaviour
{
    [SerializeField] Transform examinableTarget;
    Vector3 cachedPosition;
    Quaternion cachedRotation;
    Vector3 cachedScale;
    Examinable currentExaminedObject;
    bool isExamining = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isExamining == true)
        {
            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if(touch.phase == TouchPhase.Moved)
                {
                    currentExaminedObject.transform.Rotate(touch.deltaPosition.x, touch.deltaPosition.y, 0);
                }
            }
        }
    }

    public void PerformExamine(Examinable examinable)
    {
        currentExaminedObject = examinable;
        cachedPosition = currentExaminedObject.transform.position;
        cachedRotation = currentExaminedObject.transform.rotation;
        cachedScale = currentExaminedObject.transform.localScale;


        Vector3 scaleOffset = cachedScale * examinable.examineScaleOffset;
        currentExaminedObject.transform.localScale = scaleOffset;


        currentExaminedObject.transform.position = examinableTarget.position;
        currentExaminedObject.transform.parent = examinableTarget;

        isExamining = true;
    }

    public void PerformUnexamine()
    {
        currentExaminedObject.transform.position = cachedPosition;
        currentExaminedObject.transform.rotation = cachedRotation;
        currentExaminedObject.transform.localScale = cachedScale;
        currentExaminedObject.transform.parent = null;
        currentExaminedObject = null;
        isExamining = false;
    }
}
