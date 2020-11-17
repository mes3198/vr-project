using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphRender : MonoBehaviour
{
    public Toggle BarGraphToggleUI;
    public Toggle PieChartToggleUI;
    public Toggle LineGraphToggleUI;
    public Button FilterButtonUI;
    public Button ExitButtonUI;
   
    private Boolean BarGraph;
    private Boolean PieChart;
    private Boolean LineGraph;
    // Start is called before the first frame update
    void Start()
    {
        FilterButtonUI.GetComponent<Button>().onClick.AddListener(FilterOnClickEvent);
        ExitButtonUI.GetComponent<Button>().onClick.AddListener(ExitOnClickEvent);

        BarGraph = BarGraphToggleUI.GetComponent<Toggle>().isOn;
        PieChart = PieChartToggleUI.GetComponent<Toggle>().isOn;
        LineGraph = LineGraphToggleUI.GetComponent<Toggle>().isOn;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.GetChild(0).GetComponent<Renderer>().enabled = BarGraph;
        gameObject.transform.GetChild(1).GetComponent<Renderer>().enabled = PieChart;
        gameObject.transform.GetChild(2).GetComponent<Renderer>().enabled = LineGraph;
    }

    void FilterOnClickEvent()
    {
        BarGraph = BarGraphToggleUI.GetComponent<Toggle>().isOn;
        PieChart = PieChartToggleUI.GetComponent<Toggle>().isOn;
        LineGraph = LineGraphToggleUI.GetComponent<Toggle>().isOn;
    }

    void ExitOnClickEvent()
    {

    }
}
