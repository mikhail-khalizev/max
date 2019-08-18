using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f525786e-1a82-4938-9293-f84b9ddd1185")]
        public void Method_100a_6863()
        {
            ii(0x100a_6863, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_6868, 5); calld(Definitions.sys_check_available_stack_size, 0xb_f4e5); /* call 0x10165d52 */
            ii(0x100a_686d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_686e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_686f, 1); pushd(edx);                             /* push edx */
            ii(0x100a_6870, 1); pushd(esi);                             /* push esi */
            ii(0x100a_6871, 1); pushd(edi);                             /* push edi */
            ii(0x100a_6872, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_6873, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6875, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_687b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_687e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6881, 4); mov(memb_a32[ds, eax + 0x1c], 0x1);     /* mov byte [eax+0x1c], 0x1 */
            ii(0x100a_6885, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6888, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_688b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_688e, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_6891, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_6894, 3); calld_abs(memd_a32[ds, edx + 0x3c]);    /* call dword [edx+0x3c] */
            ii(0x100a_6897, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6899, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_689a, 1); popd(edi);                              /* pop edi */
            ii(0x100a_689b, 1); popd(esi);                              /* pop esi */
            ii(0x100a_689c, 1); popd(edx);                              /* pop edx */
            ii(0x100a_689d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_689e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_689f, 1); retd(); return;                         /* ret */
        }
    }
}
