using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class MetricPicker : XRSocketInteractor
{
    public MetricCateogories _correctCateogory = MetricCateogories.kilometer;


    protected override void Awake()
    {
        base.Awake();
       
    }
    protected override void OnHoverEntering(HoverEnterEventArgs args)
    {
        base.OnHoverEntering(args);
        CompareInteractor(args);
    }
    public void CompareInteractor(HoverEnterEventArgs args)
    {
        var hoveringInteractor = args.interactableObject.transform;
        var metric = hoveringInteractor.GetComponent<MetricObject>();

        if (metric != null && metric._objectCategory == _correctCateogory)
        {
            //Correct metric object
            // if(gameObject.CompareTag("MilimeterIcon"))
            GameManager.instance.PlayCorrectMetricSound(this.transform.position);//the position of each collider
           //S gameObject.SetActive(false);
        }
        else
        {
            //incorrect
            GameManager.instance.PlayIncorrectMetricSound();
        }


    }
}
