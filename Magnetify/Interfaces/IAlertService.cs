﻿
namespace Magnetify.Interfaces
{
    public interface IAlertService
    {
        Task ShowAlertAsync(string title, string message, string cancel);
    }
}