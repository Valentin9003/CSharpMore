﻿namespace _01.Define_an_Interface_IPerson.Interfaces
{
    public interface IPerson : IBirthable
    {
        string Name { get; }

        int Age { get; }
    }
}
