using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_0774-7c631ddf")]
        public void Method_100a_0774()
        {
            ii(0x100a_0774, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_0779, 5); calld(Definitions.sys_check_available_stack_size, 0xc_55d4); /* call 0x10165d52 */
            ii(0x100a_077e, 1); pushd(esi);                             /* push esi */
            ii(0x100a_077f, 1); pushd(edi);                             /* push edi */
            ii(0x100a_0780, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_0781, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_0783, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_0789, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_078c, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100a_078f, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100a_0792, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100a_0795, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_0798, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100a_079c, 6); if(jzd(0x100a_082d, 0x8b)) goto l_0x100a_082d; /* jz 0x100a082d */
            ii(0x100a_07a2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_07a5, 4); cmp(memb_a32[ds, eax + 0x3d], 0x7);     /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100a_07a9, 2); if(jnzd(0x100a_07e9, 0x3e)) goto l_0x100a_07e9; /* jnz 0x100a07e9 */
            ii(0x100a_07ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_07ae, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100a_07b1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_07b3, 2); if(jled(0x100a_07bd, 0x8)) goto l_0x100a_07bd; /* jle 0x100a07bd */
            ii(0x100a_07b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_07b8, 3); dec(memw_a32[ds, eax]);                 /* dec word [eax] */
            ii(0x100a_07bb, 2); jmpd(0x100a_07e7, 0x2a); goto l_0x100a_07e7; /* jmp 0x100a07e7 */
        l_0x100a_07bd:
            ii(0x100a_07bd, 5); mov(eax, StringDefinitions.Fuel);       /* mov eax, 0x101a0878 */
            ii(0x100a_07c2, 1); pushd(eax);                             /* push eax */
            ii(0x100a_07c3, 5); mov(ecx, StringDefinitions.MoreSNeededSTurnedOff); /* mov ecx, 0x101a087d */
            ii(0x100a_07c8, 5); mov(ebx, StringDefinitions.CannotTurnSOnSNeeded); /* mov ebx, 0x101a089d */
            ii(0x100a_07cd, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_07d0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_07d3, 5); calld(0x100a_0f77, 0x79f);              /* call 0x100a0f77 */
            ii(0x100a_07d8, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_07da, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x100a_07df, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_07e2, 5); calld(0x1016_3053, 0xc_286c);           /* call 0x10163053 */
        l_0x100a_07e7:
            ii(0x100a_07e7, 2); jmpd(0x100a_0827, 0x3e); goto l_0x100a_0827; /* jmp 0x100a0827 */
        l_0x100a_07e9:
            ii(0x100a_07e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_07ec, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x100a_07ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_07f2, 3); cmp(dx, memw_a32[ds, eax]);             /* cmp dx, [eax] */
            ii(0x100a_07f5, 2); if(jnzd(0x100a_0827, 0x30)) goto l_0x100a_0827; /* jnz 0x100a0827 */
            ii(0x100a_07f7, 5); mov(eax, StringDefinitions.Power2);     /* mov eax, 0x101a08bc */
            ii(0x100a_07fc, 1); pushd(eax);                             /* push eax */
            ii(0x100a_07fd, 5); mov(ecx, StringDefinitions.MoreSNeededSTurnedOn); /* mov ecx, 0x101a08c2 */
            ii(0x100a_0802, 5); mov(ebx, StringDefinitions.CannotTurnSOffOtherBuildingsNeedS); /* mov ebx, 0x101a08e1 */
            ii(0x100a_0807, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_080a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_080d, 5); calld(0x100a_0f77, 0x765);              /* call 0x100a0f77 */
            ii(0x100a_0812, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_0814, 5); mov(edx, 0x7);                          /* mov edx, 0x7 */
            ii(0x100a_0819, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_081c, 5); calld(0x1016_3053, 0xc_2832);           /* call 0x10163053 */
            ii(0x100a_0821, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_0824, 3); dec(memw_a32[ds, eax]);                 /* dec word [eax] */
        l_0x100a_0827:
            ii(0x100a_0827, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_082a, 3); dec(memw_a32[ds, eax]);                 /* dec word [eax] */
        l_0x100a_082d:
            ii(0x100a_082d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_082f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_0830, 1); popd(edi);                              /* pop edi */
            ii(0x100a_0831, 1); popd(esi);                              /* pop esi */
            ii(0x100a_0832, 1); retd();                                 /* ret */
        }
    }
}
