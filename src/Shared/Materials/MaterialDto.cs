using System;
using FluentValidation;

namespace Shared.Materials
{
	public static class MaterialDto
	{
		public class Index
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool InStock { get; set; }
        }

        public class Create
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }   
}

