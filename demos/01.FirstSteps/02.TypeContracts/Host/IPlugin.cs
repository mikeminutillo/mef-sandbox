﻿namespace Host
{
    public interface IPlugin
    {
        string Name { get; }
        void Execute();
    }
}
