﻿using Core.Entities.Abstract;

namespace Entities.DtoConcrete
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
