﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Response.Gateway
{
    public class SteamAccountResponse
    {
        public string? steamid { get; set; }
        public string? personaname { get; set; }
        public string? avatarfull { get; set; }
        public string? profileurl { get; set; }
    }
}
