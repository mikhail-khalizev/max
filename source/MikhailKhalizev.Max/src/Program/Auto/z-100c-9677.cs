using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_9677-1e987065")]
        public void Method_100c_9677()
        {
            ii(0x100c_9677, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_967c, 5); calld(Definitions.sys_check_available_stack_size, 0x9_c6d1); /* call 0x10165d52 */
            ii(0x100c_9681, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_9682, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_9683, 1); pushd(esi);                             /* push esi */
            ii(0x100c_9684, 1); pushd(edi);                             /* push edi */
            ii(0x100c_9685, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_9686, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_9688, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_968e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_9691, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_9694, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100c_9696, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_9698, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_969c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_969f, 5); calld(0x100a_26d1, -0x2_6fd3);          /* call 0x100a26d1 */
            ii(0x100c_96a4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_96a7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100c_96aa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_96ad, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_96b0, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_96b3, 5); calld(Definitions.my_ctor_0x101b_4184, -0x5_2bc8); /* call 0x10076af0 */
            ii(0x100c_96b8, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100c_96bb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_96be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_96c1, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_5798); /* mov dword [eax+0x2], 0x101b5798 */
            ii(0x100c_96c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_96cb, 6); mov(memw_a32[ds, eax + 0x13], 0);       /* mov word [eax+0x13], 0x0 */
            ii(0x100c_96d1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_96d4, 6); mov(memw_a32[ds, eax + 0x15], 0);       /* mov word [eax+0x15], 0x0 */
            ii(0x100c_96da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_96dd, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_96e0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_96e3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_96e5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_96e6, 1); popd(edi);                              /* pop edi */
            ii(0x100c_96e7, 1); popd(esi);                              /* pop esi */
            ii(0x100c_96e8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_96e9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_96ea, 1); retd(); return;                         /* ret */
        }
    }
}
