﻿using BasicSocialMedia.Core.Interfaces.DTOInterfaces.Base;
using BasicSocialMedia.Core.Interfaces.DTOInterfaces.Base.File;
using Microsoft.AspNetCore.Http;

namespace BasicSocialMedia.Core.DTOs.FileModelsDTOs
{
	public class AddPostFileDto : IUserIdDto, IPostIdDto, IIFormFile
	{
		public int PostId { get; set; }
		public string UserId { get; set; } = null!;
		public List<IFormFile> Files { get; set; } = null!;
	}
}
