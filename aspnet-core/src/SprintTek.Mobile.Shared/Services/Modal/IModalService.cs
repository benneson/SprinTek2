﻿using System.Threading.Tasks;
using SprintTek.Views;
using Xamarin.Forms;

namespace SprintTek.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
