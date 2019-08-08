using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2e1a3362-05c1-4818-9d56-fa033b9228e5")]
        public void Method_100a_3671()
        {
            ii(0x100a_3671, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_3676, 5); calld(Definitions.sys_check_available_stack_size, 0xc_26d7); /* call 0x10165d52 */
            ii(0x100a_367b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_367c, 1); pushd(esi);                             /* push esi */
            ii(0x100a_367d, 1); pushd(edi);                             /* push edi */
            ii(0x100a_367e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_367f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_3681, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_3687, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_368a, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_368d, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100a_3690, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_3693, 4); cmp(memb_a32[ds, eax + 0x6], 0);        /* cmp byte [eax+0x6], 0x0 */
            ii(0x100a_3697, 2); if(jzd(0x100a_36ac, 0x13)) goto l_0x100a_36ac; /* jz 0x100a36ac */
            ii(0x100a_3699, 4); movsx(ebx, memb_a32[ss, ebp - 0x4]);    /* movsx ebx, byte [ebp-0x4] */
            ii(0x100a_369d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_36a0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_36a3, 5); calld(0x100a_346a, -0x23e);             /* call 0x100a346a */
            ii(0x100a_36a8, 2); test(al, al);                           /* test al, al */
            ii(0x100a_36aa, 2); if(jnzd(0x100a_36ae, 0x2)) goto l_0x100a_36ae; /* jnz 0x100a36ae */
        l_0x100a_36ac:
            ii(0x100a_36ac, 2); jmpd(0x100a_36bb, 0xd); goto l_0x100a_36bb; /* jmp 0x100a36bb */
        l_0x100a_36ae:
            ii(0x100a_36ae, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_36b1, 4); mov(memb_a32[ds, eax + 0x6], 0);        /* mov byte [eax+0x6], 0x0 */
            ii(0x100a_36b5, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100a_36b9, 2); jmpd(0x100a_36bf, 0x4); goto l_0x100a_36bf; /* jmp 0x100a36bf */
        l_0x100a_36bb:
            ii(0x100a_36bb, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x100a_36bf:
            ii(0x100a_36bf, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100a_36c2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_36c4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_36c5, 1); popd(edi);                              /* pop edi */
            ii(0x100a_36c6, 1); popd(esi);                              /* pop esi */
            ii(0x100a_36c7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_36c8, 1); retd(); return;                         /* ret */
        }
    }
}
