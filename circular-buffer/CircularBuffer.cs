using System;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private T[] _Buffer;
    private int _WriteIndex;
    private int _ElementsInBuffer;
    private int _Capacity;
    private Queue<int> _WriteQueue; 
    public CircularBuffer(int capacity)
    {
        _Buffer = new T[capacity];
        _Capacity = capacity;
        this.Clear();
    }

    public T Read()
    {
        if (_WriteQueue.Count==0) throw new InvalidOperationException("Invalid read.");
        T value = _Buffer[_WriteQueue.Dequeue()]; 
        _ElementsInBuffer--;
        return value;
    }

    public void Write(T value)
    {
        if (_ElementsInBuffer == _Capacity) throw new InvalidOperationException("Buffer is full");
        _Buffer[_WriteIndex] = value;
        _WriteQueue.Enqueue(_WriteIndex);
        _WriteIndex = (_WriteIndex + 1) % _Capacity;
        _ElementsInBuffer++;
    }

    public void Overwrite(T value)
    {
        if (_ElementsInBuffer == _Capacity) {
            int index = _WriteQueue.Dequeue();
            _Buffer[index] = value;
            _WriteQueue.Enqueue(index);
        }
        else this.Write(value);
    }

    public void Clear()
    {
        for (int i=0;i<_Capacity;i++)
        {
            _Buffer[i]=default(T);
        }
        _ElementsInBuffer = 0;
        _WriteIndex = 0;
        _WriteQueue = new Queue<int>();
    }
}