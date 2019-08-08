using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f0a27bc9-cdca-42a7-9798-545a69833a13")]
        public void /* sys */ Method_1017_d776()
        {
            ii(0x1017_d776, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_d777, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_d778, 1); pushd(esi);                             /* push esi */
            ii(0x1017_d779, 1); pushd(edi);                             /* push edi */
            ii(0x1017_d77a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_d77b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_d77d, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_d77f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d781, 2); if(jnzd(0x1017_d78f, 0xc)) goto l_0x1017_d78f; /* jnz 0x1017d78f */
            ii(0x1017_d783, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_d785, 5); calld(Definitions.sys_malloc, -0x1_27ac); /* call 0x1016afde */
            ii(0x1017_d78a, 5); jmpd(0x1017_d80e, 0x7f); goto l_0x1017_d80e; /* jmp 0x1017d80e */
        l_0x1017_d78f:
            ii(0x1017_d78f, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_d791, 2); if(jnzd(0x1017_d79f, 0xc)) goto l_0x1017_d79f; /* jnz 0x1017d79f */
            ii(0x1017_d793, 5); calld(Definitions.sys_free, -0x1_26d7); /* call 0x1016b0c1 */
            ii(0x1017_d798, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d79a, 5); jmpd(0x1017_d80e, 0x6f); goto l_0x1017_d80e; /* jmp 0x1017d80e */
        l_0x1017_d79f:
            ii(0x1017_d79f, 5); calld(/* sys */ 0x1019_4780, 0x1_6fdc); /* call 0x10194780 */
            ii(0x1017_d7a4, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_d7a6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_d7a8, 5); calld(/* sys */ 0x1019_4789, 0x1_6fdc); /* call 0x10194789 */
            ii(0x1017_d7ad, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1017_d7af, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d7b1, 2); if(jnzd(0x1017_d80c, 0x59)) goto l_0x1017_d80c; /* jnz 0x1017d80c */
            ii(0x1017_d7b3, 5); mov(al, memb_a32[ds, 0x101b_e58e]);     /* mov al, [0x101be58e] */
            ii(0x1017_d7b8, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1017_d7bb, 2); if(jnzd(0x1017_d7d1, 0x14)) goto l_0x1017_d7d1; /* jnz 0x1017d7d1 */
            ii(0x1017_d7bd, 3); lea(eax, ebx - 0x4);                    /* lea eax, [ebx-0x4] */
            ii(0x1017_d7c0, 3); lea(edx, ecx + 0x4);                    /* lea edx, [ecx+0x4] */
            ii(0x1017_d7c3, 5); calld(/* sys */ 0x1018_6bd8, 0x9410);   /* call 0x10186bd8 */
            ii(0x1017_d7c8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d7ca, 2); if(jzd(0x1017_d7d1, 0x5)) goto l_0x1017_d7d1; /* jz 0x1017d7d1 */
            ii(0x1017_d7cc, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1017_d7cf, 2); jmpd(0x1017_d80e, 0x3d); goto l_0x1017_d80e; /* jmp 0x1017d80e */
        l_0x1017_d7d1:
            ii(0x1017_d7d1, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_d7d3, 5); calld(Definitions.sys_malloc, -0x1_27fa); /* call 0x1016afde */
            ii(0x1017_d7d8, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1017_d7da, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_d7dc, 2); if(jzd(0x1017_d803, 0x25)) goto l_0x1017_d803; /* jz 0x1017d803 */
            ii(0x1017_d7de, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1017_d7e0, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1017_d7e2, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1017_d7e4, 1); pushd(es);                              /* push es */
            ii(0x1017_d7e5, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1017_d7e7, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1017_d7e9, 1); pushd(edi);                             /* push edi */
            ii(0x1017_d7ea, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_d7ec, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1017_d7ef, 2); repne_a32(() => movsd_a32());           /* repne movsd */
            ii(0x1017_d7f1, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1017_d7f3, 3); and(cl, 0x3);                           /* and cl, 0x3 */
            ii(0x1017_d7f6, 2); repne_a32(() => movsb_a32());           /* repne movsb */
            ii(0x1017_d7f8, 1); popd(edi);                              /* pop edi */
            ii(0x1017_d7f9, 1); popd(es);                               /* pop es */
            ii(0x1017_d7fa, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_d7fc, 5); calld(Definitions.sys_free, -0x1_2740); /* call 0x1016b0c1 */
            ii(0x1017_d801, 2); jmpd(0x1017_d80c, 0x9); goto l_0x1017_d80c; /* jmp 0x1017d80c */
        l_0x1017_d803:
            ii(0x1017_d803, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_d805, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_d807, 5); calld(/* sys */ 0x1019_4789, 0x1_6f7d); /* call 0x10194789 */
        l_0x1017_d80c:
            ii(0x1017_d80c, 2); mov(eax, ebp);                          /* mov eax, ebp */
        l_0x1017_d80e:
            ii(0x1017_d80e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_d80f, 1); popd(edi);                              /* pop edi */
            ii(0x1017_d810, 1); popd(esi);                              /* pop esi */
            ii(0x1017_d811, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_d812, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_d813, 1); retd(); return;                         /* ret */
        }
    }
}
