using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neuron
{
    private decimal weight = 0.1m;
    public decimal LastError { get; private set; }
    public decimal Smooth { get; set; } = 0.0001m;

    public decimal ProcessInputData(decimal input)
    {
        return input * weight;
    }
     
    public decimal RestoreInputData(decimal output)
    {
        return output / weight;
    }

    public void Training(decimal input, decimal expectedResult)
    {
        var actualResult = input * weight;
        LastError = expectedResult - actualResult;
        var corr = (LastError / actualResult) * Smooth;
        weight += corr;
    }

}
