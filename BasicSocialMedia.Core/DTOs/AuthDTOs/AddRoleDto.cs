﻿using BasicSocialMedia.Core.Interfaces.DTOInterfaces.Base;

namespace BasicSocialMedia.Core.DTOs.AuthDTOs
{
	public class AddRoleDto : IRoleNameDto
	{
		public string RoleName { get; set; } = null!;
	}
}
