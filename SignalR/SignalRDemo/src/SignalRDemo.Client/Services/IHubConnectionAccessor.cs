﻿namespace SignalRDemo.Client.Services;

public interface IHubConnectionAccessor
{
    Task<string> Configure();
}