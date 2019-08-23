using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b280-6cee22b4")]
        public void /* sys */ Method_1016_b280()
        {
            ii(0x1016_b280, 1); push(ebx);                              /* push ebx */
            ii(0x1016_b281, 1); push(edx);                              /* push edx */
            ii(0x1016_b282, 1); push(edi);                              /* push edi */
            ii(0x1016_b283, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_b285, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_b288, 6); if(jz(0x1016_b30c, 0x7e)) goto l_0x1016_b30c; /* jz 0x1016b30c */
            ii(0x1016_b28e, 6); cmp(eax, memd[ds, 0x101c_fb64]);        /* cmp eax, [0x101cfb64] */
            ii(0x1016_b294, 2); if(jnz(0x1016_b29f, 0x9)) goto l_0x1016_b29f; /* jnz 0x1016b29f */
            ii(0x1016_b296, 5); call(/* sys */ 0x1016_b464, 0x1c9);     /* call 0x1016b464 */
            ii(0x1016_b29b, 1); pop(edi);                               /* pop edi */
            ii(0x1016_b29c, 1); pop(edx);                               /* pop edx */
            ii(0x1016_b29d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_b29e, 1); ret(); return;                          /* ret */
        l_0x1016_b29f:
            ii(0x1016_b29f, 6); cmp(eax, memd[ds, 0x101c_fb5c]);        /* cmp eax, [0x101cfb5c] */
            ii(0x1016_b2a5, 2); if(jnz(0x1016_b2b0, 0x9)) goto l_0x1016_b2b0; /* jnz 0x1016b2b0 */
            ii(0x1016_b2a7, 5); call(/* sys */ 0x1016_b5b4, 0x308);     /* call 0x1016b5b4 */
            ii(0x1016_b2ac, 1); pop(edi);                               /* pop edi */
            ii(0x1016_b2ad, 1); pop(edx);                               /* pop edx */
            ii(0x1016_b2ae, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_b2af, 1); ret(); return;                          /* ret */
        l_0x1016_b2b0:
            ii(0x1016_b2b0, 5); mov(eax, memd[ds, 0x101c_fb78]);        /* mov eax, [0x101cfb78] */
            ii(0x1016_b2b5, 6); cmp(eax, memd[ds, 0x101c_fb6c]);        /* cmp eax, [0x101cfb6c] */
            ii(0x1016_b2bb, 2); if(jz(0x1016_b30c, 0x4f)) goto l_0x1016_b30c; /* jz 0x1016b30c */
            ii(0x1016_b2bd, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_b2bf, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_b2c2, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_b2c4, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_b2c7, 6); mov(memd[ds, eax + 0x101c_f96c], edx);  /* mov [eax+0x101cf96c], edx */
            ii(0x1016_b2cd, 5); add(eax, 0x101c_f96c);                  /* add eax, 0x101cf96c */
            ii(0x1016_b2d2, 3); lea(edx, memd[ds, eax + 0x8]);          /* lea edx, [eax+0x8] */
            ii(0x1016_b2d5, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1016_b2d8, 5); call(/* sys */ 0x1016_c298, 0xfbb);     /* call 0x1016c298 */
            ii(0x1016_b2dd, 6); mov(edi, memd[ds, 0x101c_fb78]);        /* mov edi, [0x101cfb78] */
            ii(0x1016_b2e3, 1); inc(edi);                               /* inc edi */
            ii(0x1016_b2e4, 6); mov(memd[ds, 0x101c_fb78], edi);        /* mov [0x101cfb78], edi */
            ii(0x1016_b2ea, 3); cmp(edi, 0x28);                         /* cmp edi, 0x28 */
            ii(0x1016_b2ed, 2); if(jnz(0x1016_b2fb, 0xc)) goto l_0x1016_b2fb; /* jnz 0x1016b2fb */
            ii(0x1016_b2ef, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_b2f1, 6); mov(memd[ds, 0x101c_fb78], ebx);        /* mov [0x101cfb78], ebx */
            ii(0x1016_b2f7, 1); pop(edi);                               /* pop edi */
            ii(0x1016_b2f8, 1); pop(edx);                               /* pop edx */
            ii(0x1016_b2f9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_b2fa, 1); ret(); return;                          /* ret */
        l_0x1016_b2fb:
            ii(0x1016_b2fb, 7); cmp(memd[ds, 0x101c_fb6c], -0x1 /* 0xff */); /* cmp dword [0x101cfb6c], 0xffffffff */
            ii(0x1016_b302, 2); if(jnz(0x1016_b30c, 0x8)) goto l_0x1016_b30c; /* jnz 0x1016b30c */
            ii(0x1016_b304, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_b306, 6); mov(memd[ds, 0x101c_fb6c], edx);        /* mov [0x101cfb6c], edx */
        l_0x1016_b30c:
            ii(0x1016_b30c, 1); pop(edi);                               /* pop edi */
            ii(0x1016_b30d, 1); pop(edx);                               /* pop edx */
            ii(0x1016_b30e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_b30f, 1); ret();                                  /* ret */
        }
    }
}
