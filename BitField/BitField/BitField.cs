using System;
using System.Collections.Generic;

namespace Utility
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

        public int NumFlags { get => _flags.Count; }

        private bool CheckRange(int key)
        {
            if (key >= _flags.Count)
                throw new IndexOutOfRangeException();
            return true;
        }

        public BitField(int flags)
        {
            _flags = new List<bool>(32);
            PopulateFlags(flags, 32);
        }

        public BitField(short flags)
        {
            _flags = new List<bool>(16);
            PopulateFlags(flags, 16);
        }

        public BitField(byte flags)
        {
            _flags = new List<bool>(8);
            PopulateFlags(flags, 8);
        }

        private void PopulateFlags(int flags, int len)
        {
            for (int i = 0; i < len; i++)
            {
                _flags.Add((flags & (1 << i)) > 0);
            }
        }
    }
}