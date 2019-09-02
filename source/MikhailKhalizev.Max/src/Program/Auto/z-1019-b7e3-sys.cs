using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b7e3-947635f")]
        public void /* sys */ Method_1019_b7e3()
        {
            ii(0x1019_b7e3, 1); push(ebx);                              /* push ebx */
            ii(0x1019_b7e4, 1); push(edx);                              /* push edx */
            ii(0x1019_b7e5, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_b7e7, 6); call_abs(memd[ds, 0x101c_1d0c]);        /* call dword [0x101c1d0c] */ /* Вызов '0x1019_c524'. */
            ii(0x1019_b7ed, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_b7ef, 2); if(jnz(0x1019_b80c, 0x1b)) goto l_0x1019_b80c; /* jnz 0x1019b80c */
            ii(0x1019_b7f1, 3); mov(edx, memd[ds, ebx + 4]);            /* mov edx, [ebx+0x4] */
            ii(0x1019_b7f4, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1019_b7f6, 5); call(/* sys */ 0x1019_b79b, -0x60);     /* call 0x1019b79b */
            ii(0x1019_b7fb, 3); cmp(memd[ds, ebx], 1);                  /* cmp dword [ebx], 0x1 */
            ii(0x1019_b7fe, 2); if(jnz(0x1019_b807, 7)) goto l_0x1019_b807; /* jnz 0x1019b807 */
            ii(0x1019_b800, 5); call(/* sys */ 0x1018_d3ba, -0xe44b);   /* call 0x1018d3ba */
            ii(0x1019_b805, 2); jmp(0x1019_b80c, 5); goto l_0x1019_b80c; /* jmp 0x1019b80c */
        l_0x1019_b807:
            ii(0x1019_b807, 5); call(/* sys */ 0x1018_d3cb, -0xe441);   /* call 0x1018d3cb */
        l_0x1019_b80c:
            ii(0x1019_b80c, 3); fld(memq[ds, ebx + 24]);                /* fld qword [ebx+0x18] */
            ii(0x1019_b80f, 1); pop(edx);                               /* pop edx */
            ii(0x1019_b810, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_b811, 1); ret();                                  /* ret */
        }
    }
}
