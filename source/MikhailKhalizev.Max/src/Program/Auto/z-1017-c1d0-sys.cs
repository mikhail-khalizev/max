using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_c1d0-43856b12")]
        public void /* sys */ Method_1017_c1d0()
        {
            ii(0x1017_c1d0, 1); push(ebp);                              /* push ebp */
            ii(0x1017_c1d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_c1d3, 1); push(esi);                              /* push esi */
            ii(0x1017_c1d4, 1); push(edi);                              /* push edi */
            ii(0x1017_c1d5, 3); mov(edx, memd[ss, ebp + 0x14]);         /* mov edx, [ebp+0x14] */
            ii(0x1017_c1d8, 1); push(edx);                              /* push edx */
            ii(0x1017_c1d9, 3); mov(ebx, memd[ss, ebp + 0x10]);         /* mov ebx, [ebp+0x10] */
            ii(0x1017_c1dc, 1); push(ebx);                              /* push ebx */
            ii(0x1017_c1dd, 3); mov(ecx, memd[ss, ebp + 0xc]);          /* mov ecx, [ebp+0xc] */
            ii(0x1017_c1e0, 1); push(ecx);                              /* push ecx */
            ii(0x1017_c1e1, 3); mov(esi, memd[ss, ebp + 0x8]);          /* mov esi, [ebp+0x8] */
            ii(0x1017_c1e4, 1); push(esi);                              /* push esi */
            ii(0x1017_c1e5, 5); call(/* sys */ 0x1017_b8a0, -0x94a);    /* call 0x1017b8a0 */
            ii(0x1017_c1ea, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1017_c1ed, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_c1ef, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_c1f1, 2); if(jnz(0x1017_c230, 0x3d)) goto l_0x1017_c230; /* jnz 0x1017c230 */
            ii(0x1017_c1f3, 5); mov(edi, 0x1);                          /* mov edi, 0x1 */
            ii(0x1017_c1f8, 2); xor(esi, esi);                          /* xor esi, esi */
        l_0x1017_c1fa:
            ii(0x1017_c1fa, 5); call(/* sys */ 0x1017_ba30, -0x7cf);    /* call 0x1017ba30 */
            ii(0x1017_c1ff, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_c201, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_c203, 2); if(jnz(0x1017_c22c, 0x27)) goto l_0x1017_c22c; /* jnz 0x1017c22c */
        l_0x1017_c205:
            ii(0x1017_c205, 6); call_abs(memd[ds, 0x1020_9c8c]);        /* call dword [0x10209c8c] */
            ii(0x1017_c20b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_c20d, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1017_c210, 2); if(jnz(0x1017_c22c, 0x1a)) goto l_0x1017_c22c; /* jnz 0x1017c22c */
            ii(0x1017_c212, 6); cmp(esi, memd[ds, 0x101b_e454]);        /* cmp esi, [0x101be454] */
            ii(0x1017_c218, 2); if(jnz(0x1017_c225, 0xb)) goto l_0x1017_c225; /* jnz 0x1017c225 */
            ii(0x1017_c21a, 5); call(/* sys */ 0x1017_a380, -0x1e9f);   /* call 0x1017a380 */
            ii(0x1017_c21f, 6); mov(memd[ds, 0x101b_e454], edi);        /* mov [0x101be454], edi */
        l_0x1017_c225:
            ii(0x1017_c225, 5); call(/* sys */ 0x1017_97f0, -0x2a3a);   /* call 0x101797f0 */
            ii(0x1017_c22a, 2); jmp(0x1017_c205, -0x27); goto l_0x1017_c205; /* jmp 0x1017c205 */
        l_0x1017_c22c:
            ii(0x1017_c22c, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_c22e, 2); if(jz(0x1017_c1fa, -0x36)) goto l_0x1017_c1fa; /* jz 0x1017c1fa */
        l_0x1017_c230:
            ii(0x1017_c230, 7); cmp(memd[ds, 0x101b_e458], 0);          /* cmp dword [0x101be458], 0x0 */
            ii(0x1017_c237, 2); if(jz(0x1017_c250, 0x17)) goto l_0x1017_c250; /* jz 0x1017c250 */
            ii(0x1017_c239, 5); call(/* sys */ 0x1017_97f0, -0x2a4e);   /* call 0x101797f0 */
            ii(0x1017_c23e, 5); call(/* sys */ 0x1017_9650, -0x2bf3);   /* call 0x10179650 */
            ii(0x1017_c243, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_c245, 5); call(/* sys */ 0x1017_9cb0, -0x259a);   /* call 0x10179cb0 */
            ii(0x1017_c24a, 6); mov(memd[ds, 0x101b_e458], ecx);        /* mov [0x101be458], ecx */
        l_0x1017_c250:
            ii(0x1017_c250, 3); cmp(ebx, -0x1 /* 0xff */);              /* cmp ebx, 0xffffffff */
            ii(0x1017_c253, 2); if(jnz(0x1017_c257, 0x2)) goto l_0x1017_c257; /* jnz 0x1017c257 */
            ii(0x1017_c255, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
        l_0x1017_c257:
            ii(0x1017_c257, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_c259, 3); lea(esp, memd[ss, ebp - 0x8]);          /* lea esp, [ebp-0x8] */
            ii(0x1017_c25c, 1); pop(edi);                               /* pop edi */
            ii(0x1017_c25d, 1); pop(esi);                               /* pop esi */
            ii(0x1017_c25e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_c25f, 1); ret();                                  /* ret */
        }
    }
}
