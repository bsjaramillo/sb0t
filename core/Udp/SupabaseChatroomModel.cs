using Supabase;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace core.Udp
{
    // Define your table model
    [Table("chatrooms_for_servers")]
    public class SupabaseChatroomModel : BaseModel
    {
        [Column("id")]
        public string Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("ip")]
        public string Ip { get; set; }

        [Column("port")]
        public ushort Port { get; set; }

        [Column("topic")]
        public string Topic { get; set; }
    }
}
