using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cfeb9d98-33da-44ac-bddf-a7bddea58a17")]
        public void Method_1007_678c()
        {
            ii(0x1007_678c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_6791, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f5bc); /* call 0x10165d52 */
            ii(0x1007_6796, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6797, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6798, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6799, 1); pushd(esi);                             /* push esi */
            ii(0x1007_679a, 1); pushd(edi);                             /* push edi */
            ii(0x1007_679b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_679c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_679e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_67a4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_67a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_67aa, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1007_67ac, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_67af, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_67b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_67b4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_67b5, 1); popd(edi);                              /* pop edi */
            ii(0x1007_67b6, 1); popd(esi);                              /* pop esi */
            ii(0x1007_67b7, 1); popd(edx);                              /* pop edx */
            ii(0x1007_67b8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_67b9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_67ba, 1); retd(); return;                         /* ret */
        }
    }
}
