﻿
using BasicSocialMedia.Core.Models.AuthModels;

namespace BasicSocialMedia.Core.Interfaces.ModelsInterfaces
{
	public interface IPostComment : IId, ITimestamp, IContent
	{
		public bool IsDeleted { get; set; }
		public string UserId { get; set; }
		public ApplicationUser? User { get; set; }
	}
}
