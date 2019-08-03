using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a28ba051-c433-43bc-b2b5-68560dc9199d")]
        public void Method_100a_5fca()
        {
            ii(0x100a_5fca, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_5fcf, 5); calld(Definitions.sys_check_available_stack_size, 0xbfd7e); /* call 0x10165d52 */
            ii(0x100a_5fd4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_5fd5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_5fd6, 1); pushd(esi);                             /* push esi */
            ii(0x100a_5fd7, 1); pushd(edi);                             /* push edi */
            ii(0x100a_5fd8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_5fd9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_5fdb, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_5fe1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_5fe4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_5fe7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_5fea, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x100a_5fee, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_5ff1, 4); sub(ax, memw_a32[ds, edx + 0x2]);       /* sub ax, [edx+0x2] */
            ii(0x100a_5ff5, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100a_5ff8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_5ffb, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100a_5ffe, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_6001, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x100a_6004, 1); cwde();                                 /* cwde */
            ii(0x100a_6005, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_6007, 5); calld(0x100a_5f65, -0xa7);              /* call 0x100a5f65 */
            ii(0x100a_600c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_600f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6012, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6014, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_6015, 1); popd(edi);                              /* pop edi */
            ii(0x100a_6016, 1); popd(esi);                              /* pop esi */
            ii(0x100a_6017, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_6018, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_6019, 1); retd(); return;                         /* ret */
        }
    }
}
