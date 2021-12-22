using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Shared.Materials;

namespace Client.Materials
{
	public partial class Index
	{
        private IEnumerable<MaterialDto.Index> materials;
        [Inject] public IMaterialService MaterialService { get; set; }
        protected override Task OnInitializedAsync()
        {
            return GetMaterialsAsync();
        }

        private async Task GetMaterialsAsync()
        {
            materials = await MaterialService.GetIndexAsync(null);
        }
    }
}

