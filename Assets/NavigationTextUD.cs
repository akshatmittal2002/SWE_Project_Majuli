using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

[RequireComponent(typeof(TMP_Text))]
public class NavigationTextUD : MonoBehaviour
{
    public string displayText;
    private float thetaStep = Mathf.PI / 32f;
    [SerializeField]
    public float WaitBetweenWobbles = 0.1f;
    [SerializeField]
    private float theta = 0f;
    [SerializeField]
    public float Intensity = 500f;
    [SerializeField]
    public float x = 270f;
   Quaternion _targetAngle;
    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("ChangeTarget", 0f, WaitBetweenWobbles);
        GetComponent<TextMeshPro>().text = displayText;
    }
    // Update is called once per frame
    void Update()
    {
        //change text of t1
        GetComponent<TextMeshPro>().text = displayText;
        // transform.rotation = Quaternion.Lerp(transform.rotation, _targetAngle, Time.deltaTime);
    }
    void ChangeTarget()
    {
        _targetAngle = Quaternion.Euler(Vector3.down * Mathf.Sin(theta) * Intensity + Vector3.up * x);
        if(theta >= Mathf.PI / 15f || theta <= -Mathf.PI / 15f){
            thetaStep = -thetaStep;
        }
        theta += thetaStep;
    }
}
