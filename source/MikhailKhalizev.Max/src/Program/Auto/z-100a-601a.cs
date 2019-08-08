using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4d796a48-564e-45df-9ee1-2bb742b030f9")]
        public void Method_100a_601a()
        {
            ii(0x100a_601a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_601f, 5); calld(Definitions.sys_check_available_stack_size, 0xb_fd2e); /* call 0x10165d52 */
            ii(0x100a_6024, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_6025, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_6026, 1); pushd(esi);                             /* push esi */
            ii(0x100a_6027, 1); pushd(edi);                             /* push edi */
            ii(0x100a_6028, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_6029, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_602b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_6031, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_6034, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_6037, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_603a, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100a_603e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_6041, 4); sub(ax, memw_a32[ds, edx + 0x1c]);      /* sub ax, [edx+0x1c] */
            ii(0x100a_6045, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100a_6048, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_604b, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100a_604f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_6052, 4); sub(ax, memw_a32[ds, edx + 0x1a]);      /* sub ax, [edx+0x1a] */
            ii(0x100a_6056, 1); cwde();                                 /* cwde */
            ii(0x100a_6057, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_6059, 5); calld(0x100a_5f65, -0xf9);              /* call 0x100a5f65 */
            ii(0x100a_605e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_6061, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6064, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6066, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_6067, 1); popd(edi);                              /* pop edi */
            ii(0x100a_6068, 1); popd(esi);                              /* pop esi */
            ii(0x100a_6069, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_606a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_606b, 1); retd(); return;                         /* ret */
        }
    }
}
