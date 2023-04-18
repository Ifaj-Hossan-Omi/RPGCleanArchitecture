using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Infrastructure.Token
{
    public class RefreshToken
    {
        // public string Token { get; set; }
        // public DateTime Expires { get; set; }
        // public string CreatedByIp { get; set; }
        // public DateTime Created { get; set; }
        // public string RevokedByIp { get; set; }
        // public DateTime? Revoked { get; set; }
        // public bool IsActive => Revoked == null && Expires > DateTime.UtcNow;


        public required string Token { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }
    }
}
