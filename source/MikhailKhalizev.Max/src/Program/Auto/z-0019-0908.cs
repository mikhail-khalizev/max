using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0908-c3334608")]
        public void Method_0019_0908()
        {
            ii(0x19_0908, 5); cmp(memb_a32[ss, ebp + 0x20], 0);         /* cmp byte [ebp+0x20], 0x0 */
            ii(0x19_090d, 4); if(jzw(0x19_0931, 0x20)) goto l_0x19_0931; /* jz 0x931 */
            ii(0x19_0911, 5); cmp(memb_a32[ss, ebp + 0x20], 0x4);       /* cmp byte [ebp+0x20], 0x4 */
            ii(0x19_0916, 4); if(jaw(0x19_0929, 0xf)) goto l_0x19_0929; /* ja 0x929 */
            ii(0x19_091a, 1); pushw(ds);                                /* push ds */
            ii(0x19_091b, 3); pushw(0xa8);                              /* push 0xa8 */
            ii(0x19_091e, 1); popw(ds);                                 /* pop ds */
            ii(0x19_091f, 5); cmp(memb_a16[ds, 0x185e], 0);             /* cmp byte [0x185e], 0x0 */
            ii(0x19_0924, 1); popw(ds);                                 /* pop ds */
            ii(0x19_0925, 4); if(jnzw(0x19_0931, 0x8)) goto l_0x19_0931; /* jnz 0x931 */
        l_0x19_0929:
            ii(0x19_0929, 5); or(memb_a32[ss, ebp + 0x2c], 0x1);        /* or byte [ebp+0x2c], 0x1 */
            ii(0x19_092e, 2); jmpw(0x19_0974, 0x44); goto l_0x19_0974;  /* jmp 0x974 */
        //  ii(0x19_0930, 1); nop();                                    /* nop */
        l_0x19_0931:
            ii(0x19_0931, 5); if(jmpw_a16_far_ind(cs, 0x1474)) return;  /* jmp far word [cs:0x1474] */
            ii(0x19_0936, 2); xchg(bx, bx);                             /* xchg bx, bx */
            ii(0x19_0938, 2); xor(al, 0x45);                            /* xor al, 0x45 */
            ii(0x19_093a, 2); if(jow(0x19_093c, 0)) goto l_0x19_093c;   /* jo 0x93c */
        l_0x19_093c:
            ii(0x19_093c, 5); mov(esi, memd_a32[ss, ebp + 0x8]);        /* mov esi, [ebp+0x8] */
            ii(0x19_0941, 4); pushw(memw_a32[ss, ebp + 0]);             /* push word [ebp] */
            ii(0x19_0945, 1); popw(ds);                                 /* pop ds */
            ii(0x19_0946, 5); or(memb_a32[ss, ebp + 0x2c], 0x1);        /* or byte [ebp+0x2c], 0x1 */
            ii(0x19_094b, 1); pushw(cs);                                /* push cs */
            ii(0x19_094c, 1); popw(es);                                 /* pop es */
            ii(0x19_094d, 5); lea(edi, 0x1463);                         /* lea edi, [0x1463] */
            ii(0x19_0952, 3); mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0x19_0955, 4); movzx(ecx, cx);                           /* movzx ecx, cx */
            ii(0x19_0959, 3); repe_a32(() => cmpsb_a32());              /* a32 repe cmpsb */
            ii(0x19_095c, 4); if(jnzw(0x19_097d, 0x1d)) goto l_0x19_097d; /* jnz 0x97d */
            ii(0x19_0960, 5); lea(eax, 0x1460);                         /* lea eax, [0x1460] */
            ii(0x19_0965, 5); mov(memd_a32[ss, ebp + 0x4], eax);        /* mov [ebp+0x4], eax */
            ii(0x19_096a, 1); pushw(cs);                                /* push cs */
            ii(0x19_096b, 4); popw(memw_a32[ss, ebp + 0x2]);            /* pop word [ebp+0x2] */
            ii(0x19_096f, 5); and(memb_a32[ss, ebp + 0x2c], -0x2 /* 0xfe */); /* and byte [ebp+0x2c], 0xfe */
        l_0x19_0974:
            ii(0x19_0974, 3); mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x19_0977, 1); popw(ds);                                 /* pop ds */
            ii(0x19_0978, 1); popw(es);                                 /* pop es */
            ii(0x19_0979, 2); popad();                                  /* popad */
            ii(0x19_097b, 2); iretd(); return;                          /* iretd */
        l_0x19_097d:
            ii(0x19_097d, 5); jmpw_a16_far_ind(cs, 0x14a8);             /* jmp far word [cs:0x14a8] */
        }
    }
}
