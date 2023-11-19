﻿using KatmanliBurger_DATA.Abstracts;

namespace KatmanliBurger_DATA.DomainModels
{
	public class ParameterDetail:BaseEntity
	{
		public string Code { get; set; }
		public string Description { get; set; }
        public ParameterType ParameterType { get; set; }
        public int ParameterTypeId { get; set; }
    }
}
