using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9cb0-1a5b9525")]
        public void /* sys */ Method_1017_9cb0()
        {
            ii(0x1017_9cb0, 1); push(ebp);                              /* push ebp */
            ii(0x1017_9cb1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_9cb3, 1); push(ebx);                              /* push ebx */
            ii(0x1017_9cb4, 1); push(edx);                              /* push edx */
            ii(0x1017_9cb5, 7); cmp(memd[ds, 0x101b_e418], -1 /* 0xff */); /* cmp dword [0x101be418], 0xffffffff */
            ii(0x1017_9cbc, 2); if(jz(0x1017_9cde, 0x20)) goto l_0x1017_9cde; /* jz 0x10179cde */
            ii(0x1017_9cbe, 6); mov(edx, memd[ds, 0x101b_e434]);        /* mov edx, [0x101be434] */
            ii(0x1017_9cc4, 3); cmp(edx, -1 /* 0xff */);                /* cmp edx, 0xffffffff */
            ii(0x1017_9cc7, 2); if(jz(0x1017_9cde, 0x15)) goto l_0x1017_9cde; /* jz 0x10179cde */
            ii(0x1017_9cc9, 5); mov(eax, memd[ds, 0x101b_e418]);        /* mov eax, [0x101be418] */
            ii(0x1017_9cce, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1017_9cd3, 5); call(/* sys */ 0x1018_0376, 0x669e);    /* call 0x10180376 */
            ii(0x1017_9cd8, 6); mov(memd[ds, 0x101b_e434], ebx);        /* mov [0x101be434], ebx */
        l_0x1017_9cde:
            ii(0x1017_9cde, 3); lea(esp, memd[ss, ebp - 8]);            /* lea esp, [ebp-0x8] */
            ii(0x1017_9ce1, 1); pop(edx);                               /* pop edx */
            ii(0x1017_9ce2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_9ce3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_9ce4, 1); ret();                                  /* ret */
        }
    }
}
