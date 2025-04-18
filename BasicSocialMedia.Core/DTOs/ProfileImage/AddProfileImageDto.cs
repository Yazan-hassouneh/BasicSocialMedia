﻿using BasicSocialMedia.Core.Interfaces.DTOInterfaces.Base;
using Microsoft.AspNetCore.Http;

namespace BasicSocialMedia.Core.DTOs.ProfileImage
{
	public class AddProfileImageDto : IUserIdDto
	{
		public int? CurrentImageId { get; set; } = null;
		public string UserId { get; set; } = null!;
		public IFormFile Image { get; set; } = null!;
	}
}
