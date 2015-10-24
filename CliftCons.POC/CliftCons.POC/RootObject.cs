using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliftCons.POC
{ 
    public class RootObject
    {
        public string hash { get; set; }
        public string branch { get; set; }
        public string previous_block_hash { get; set; }
        public List<object> next_blocks { get; set; }
        public int height { get; set; }
        public int confirmations { get; set; }
        public string merkle_root { get; set; }
        public string time { get; set; }
        public string created_at { get; set; }
        public object nonce { get; set; }
        public int bits { get; set; }
        public double difficulty { get; set; }
        public object reward { get; set; }
        public int fees { get; set; }
        public object total_out { get; set; }
        public int size { get; set; }
        public int transactions_count { get; set; }
        public int version { get; set; }
        public List<string> transaction_hashes { get; set; }
    }
}
