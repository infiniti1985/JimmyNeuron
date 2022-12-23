using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{

     private decimal usd = 1;
     private decimal rub = 2.65m;

    private Neuron neuron;

    void Start()
    {
        neuron = new Neuron();

        int i = 0;
        do
        {
            i++;
            neuron.Training(usd, rub);
            Debug.Log($"��������: {i}\t������:\t{neuron.LastError}");
        }

        while (neuron.LastError > neuron.Smooth || neuron.LastError < -neuron.Smooth);

        Debug.Log("-=�������� ���������=-");

        var u = 243; //��������� 243 ������a � ����� 

        Debug.Log($"{neuron.ProcessInputData(u)} rub  � {u} usd");

        Debug.Log($"{neuron.ProcessInputData(540)} rub  � {541} usd");

        Debug.Log($"{neuron.RestoreInputData(10)} usd � {10} rub");
    }
     
}
