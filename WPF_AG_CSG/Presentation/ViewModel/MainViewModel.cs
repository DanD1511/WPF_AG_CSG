using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_AG_CSG.Domain.Entities;
using WPF_AG_CSG.Infrastructure.Mappers;
using WPF_AG_CSG.Services.ApiService;

namespace WPF_AG_CSG.Presentation.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private readonly ApiService _apiService;
        private readonly DTOMapper _mapper;

        public ICommand GetGenParametersCommand { get; }

        public MainViewModel()
        {
            _apiService = new ApiService();
            _mapper = new DTOMapper();

            GetGenParametersCommand = new AsyncRelayCommand<string>(GetGenParameters);
        }

        public async Task GetGenParameters(string? genName)
        {
            Debug.WriteLine(genName);
            Dictionary<string, object?> request = new Dictionary<string, object?>
            {
                {"name", genName },
                {"data", new Dictionary<string, string>() },
            };

            var response = await _apiService.Post("/apitest", request);
        }
    }
}
