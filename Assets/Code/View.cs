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
            Debug.Log($"Итерация: {i}\tОшибка:\t{neuron.LastError}");
        }

        while (neuron.LastError > neuron.Smooth || neuron.LastError < -neuron.Smooth);

        Debug.Log("-=Обучение завершено=-");

        var u = 243; //перевести 243 долларa в рубли 

        Debug.Log($"{neuron.ProcessInputData(u)} rub  в {u} usd");

        Debug.Log($"{neuron.ProcessInputData(540)} rub  в {541} usd");

        Debug.Log($"{neuron.RestoreInputData(10)} usd в {10} rub");
    }
     
}
