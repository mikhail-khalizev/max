using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_d56f-a12011bd")]
        public void Method_1008_d56f()
        {
            ii(0x1008_d56f, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_d574, 5); calld(Definitions.sys_check_available_stack_size, 0xd_87d9); /* call 0x10165d52 */
            ii(0x1008_d579, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_d57a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_d57b, 1); pushd(edx);                             /* push edx */
            ii(0x1008_d57c, 1); pushd(esi);                             /* push esi */
            ii(0x1008_d57d, 1); pushd(edi);                             /* push edi */
            ii(0x1008_d57e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_d57f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_d581, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_d587, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_d58a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d58d, 4); cmp(memb_a32[ds, eax + 0x25], 0x6);     /* cmp byte [eax+0x25], 0x6 */
            ii(0x1008_d591, 2); if(jnzd(0x1008_d59a, 0x7)) goto l_0x1008_d59a; /* jnz 0x1008d59a */
            ii(0x1008_d593, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d596, 4); mov(memb_a32[ds, eax + 0x25], 0x5);     /* mov byte [eax+0x25], 0x5 */
        l_0x1008_d59a:
            ii(0x1008_d59a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d59d, 4); cmp(memb_a32[ds, eax + 0x25], 0x9);     /* cmp byte [eax+0x25], 0x9 */
            ii(0x1008_d5a1, 2); if(jged(0x1008_d5b4, 0x11)) goto l_0x1008_d5b4; /* jge 0x1008d5b4 */
            ii(0x1008_d5a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_d5a5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d5a8, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d5ab, 5); calld(0x1013_ad71, 0xa_d7c1);           /* call 0x1013ad71 */
            ii(0x1008_d5b0, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d5b2, 2); if(jnzd(0x1008_d5b6, 0x2)) goto l_0x1008_d5b6; /* jnz 0x1008d5b6 */
        l_0x1008_d5b4:
            ii(0x1008_d5b4, 2); jmpd(0x1008_d5d4, 0x1e); goto l_0x1008_d5d4; /* jmp 0x1008d5d4 */
        l_0x1008_d5b6:
            ii(0x1008_d5b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d5b9, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_d5bc, 5); calld(0x1008_af28, -0x2699);            /* call 0x1008af28 */
            ii(0x1008_d5c1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_d5c4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_d5c7, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_d5ca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_d5cd, 3); calld_abs(memd_a32[ds, edx + 0x24]);    /* call dword [edx+0x24] */
            ii(0x1008_d5d0, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d5d2, 2); if(jzd(0x1008_d5d6, 0x2)) goto l_0x1008_d5d6; /* jz 0x1008d5d6 */
        l_0x1008_d5d4:
            ii(0x1008_d5d4, 2); jmpd(0x1008_d5e0, 0xa); goto l_0x1008_d5e0; /* jmp 0x1008d5e0 */
        l_0x1008_d5d6:
            ii(0x1008_d5d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d5d9, 5); calld(0x1008_df3e, 0x960);              /* call 0x1008df3e */
            ii(0x1008_d5de, 2); jmpd(0x1008_d5f2, 0x12); goto l_0x1008_d5f2; /* jmp 0x1008d5f2 */
        l_0x1008_d5e0:
            ii(0x1008_d5e0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d5e3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_d5e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_d5e9, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_d5ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_d5ef, 3); calld_abs(memd_a32[ds, edx + 0x3c]);    /* call dword [edx+0x3c] */
        l_0x1008_d5f2:
            ii(0x1008_d5f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_d5f4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_d5f5, 1); popd(edi);                              /* pop edi */
            ii(0x1008_d5f6, 1); popd(esi);                              /* pop esi */
            ii(0x1008_d5f7, 1); popd(edx);                              /* pop edx */
            ii(0x1008_d5f8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_d5f9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_d5fa, 1); retd();                                 /* ret */
        }
    }
}
