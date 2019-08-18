using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b434-3adf4d7a")]
        public void Method_100a_b434()
        {
            ii(0x100a_b434, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_b439, 5); calld(Definitions.sys_check_available_stack_size, 0xb_a914); /* call 0x10165d52 */
            ii(0x100a_b43e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_b43f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_b440, 1); pushd(esi);                             /* push esi */
            ii(0x100a_b441, 1); pushd(edi);                             /* push edi */
            ii(0x100a_b442, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_b443, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_b445, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_b44b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_b44e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_b451, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b454, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100a_b457, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_b45a, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100a_b45d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_b45f, 2); if(jnzd(0x100a_b475, 0x14)) goto l_0x100a_b475; /* jnz 0x100ab475 */
            ii(0x100a_b461, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_b464, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100a_b466, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_b469, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_b46c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100a_b46e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_b471, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_b473, 2); if(jzd(0x100a_b477, 0x2)) goto l_0x100a_b477; /* jz 0x100ab477 */
        l_0x100a_b475:
            ii(0x100a_b475, 2); jmpd(0x100a_b47d, 0x6); goto l_0x100a_b47d; /* jmp 0x100ab47d */
        l_0x100a_b477:
            ii(0x100a_b477, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100a_b47b, 2); jmpd(0x100a_b481, 0x4); goto l_0x100a_b481; /* jmp 0x100ab481 */
        l_0x100a_b47d:
            ii(0x100a_b47d, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x100a_b481:
            ii(0x100a_b481, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100a_b484, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100a_b487, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100a_b48a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_b48c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_b48d, 1); popd(edi);                              /* pop edi */
            ii(0x100a_b48e, 1); popd(esi);                              /* pop esi */
            ii(0x100a_b48f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_b490, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_b491, 1); retd(); return;                         /* ret */
        }
    }
}
