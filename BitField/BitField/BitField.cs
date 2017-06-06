using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitField
{
    public class BitField
    {
        private List<bool> _flags { get; set; }
        public bool this[int key]
        {
            get
            {
                CheckRange(key);
                return _flags[key];
            }
            set
            {
                CheckRange(key);
                _flags[key] = value;
            }
        }

        private bool CheckRange(int key)
        {
            if (key >= _flags.Count)
                throw new IndexOutOfRangeException();
            return true;
        }

        public BitField(int flags)
        {
            _flags = new List<bool>(32);
            PopulateFlags(flags);
        }

        public BitField(short flags)
        {
            _flags = new List<bool>(16);
            PopulateFlags(flags);
        }

        public BitField(byte flags)
        {
            _flags = new List<bool>(8);
            PopulateFlags(flags);
        }

        private void PopulateFlags(int flags)
        {
            for (int i = 0; i < _flags.Count; i++)
            {
                _flags[i] = (flags & (1 << i)) > 0;
            }
        }
    }
}