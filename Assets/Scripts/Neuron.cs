using System;
using System.Collections.Generic;

public class Neuron
{
    public delegate float Input();
    Dictionary<Input, float> _inputFatorDict;

    public Neuron()
    {
        _inputFatorDict = new Dictionary<Input, float>();
    }

    public Neuron(float inp)
    {
        
        _inputFatorDict = new Dictionary<Input, float>();
        _inputFatorDict.Add(delegate () { return inp; }, 1.0f);
    }

    public float ComputeValue()
    {
        float res = 0.0f;
        foreach (var each in _inputFatorDict)
        {
            res += each.Key() / each.Value;
        }
        return res;
    }

    public void Add(Input inp, float factor)
    {
        _inputFatorDict.Add(inp, factor);
    }

    public void Add(float inp, float factor)
    {
        _inputFatorDict.Add(delegate () { return inp; }, factor);
    }

    public void Remove(Input inp)
    {
        _inputFatorDict.Remove(inp);
    }
}