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

   //global variables define visibility of graphs
    private Boolean BarGraph;
    private Boolean PieChart;
    private Boolean LineGraph;

    // Start is called before the first frame update
    void Start()
    {
        //Connects EventOnClick with the function to process this event
        FilterButtonUI.GetComponent<Button>().onClick.AddListener(FilterOnClickEvent);
        ExitButtonUI.GetComponent<Button>().onClick.AddListener(ExitOnClickEvent);

        //Initializes global variables to the current states of the Toggles
        BarGraph = BarGraphToggleUI.GetComponent<Toggle>().isOn;
        PieChart = PieChartToggleUI.GetComponent<Toggle>().isOn;
        LineGraph = LineGraphToggleUI.GetComponent<Toggle>().isOn;
    }

    // Update is called once per frame
    void Update()
    {
        //Setting the visibility of the children to the current value of the Toggles
        //gameObject.transform.GetChild(0).GetComponent<Renderer>().enabled = BarGraph;
        //gameObject.transform.GetChild(1).GetComponent<Renderer>().enabled = PieChart;
        // gameObject.transform.GetChild(2).GetComponent<Renderer>().enabled = LineGraph;
        Debug.Log(BarGraph.ToString() + "," + PieChart.ToString() + "," + LineGraph.ToString());

        if (gameObject.transform.Find("Canvas").GetComponent<Canvas>().enabled && BarGraph)
        {
            gameObject.transform.GetChild(0).GetComponent<Renderer>().enabled = true;
        }
        else
        {
            gameObject.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
        }
        if (gameObject.transform.Find("Canvas").GetComponent<Canvas>().enabled && PieChart)
        {
            gameObject.transform.GetChild(1).GetComponent<Renderer>().enabled = true;
        }
        else
        {
            gameObject.transform.GetChild(1).GetComponent<Renderer>().enabled = false;
        }
        if (gameObject.transform.Find("Canvas").GetComponent<Canvas>().enabled && LineGraph)
        {
            gameObject.transform.GetChild(2).GetComponent<Renderer>().enabled = true;
        }
        else
        {
            gameObject.transform.GetChild(2).GetComponent<Renderer>().enabled = false;
        }
    }

    //Saves the state of the Toggles at the moment of clicking on the Filter button
    void FilterOnClickEvent()
    {
        BarGraph = BarGraphToggleUI.GetComponent<Toggle>().isOn;
        PieChart = PieChartToggleUI.GetComponent<Toggle>().isOn;
        LineGraph = LineGraphToggleUI.GetComponent<Toggle>().isOn;
    }

    void ExitOnClickEvent()
    {
        Application.Quit();
        Debug.Log("You touched this button.");
    }
}
