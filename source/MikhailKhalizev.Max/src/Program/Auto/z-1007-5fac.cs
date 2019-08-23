using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5fac-c2ffb2d9")]
        public void Method_1007_5fac()
        {
            ii(0x1007_5fac, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_5fb1, 5); calld(Definitions.sys_check_available_stack_size, 0xe_fd9c); /* call 0x10165d52 */
            ii(0x1007_5fb6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_5fb7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_5fb8, 1); pushd(esi);                             /* push esi */
            ii(0x1007_5fb9, 1); pushd(edi);                             /* push edi */
            ii(0x1007_5fba, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_5fbb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5fbd, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_5fc3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_5fc6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_5fc9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_5fcc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_5fcf, 5); calld(0x1013_a2ab, 0xc_42d7);           /* call 0x1013a2ab */
            ii(0x1007_5fd4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5fd6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_5fd7, 1); popd(edi);                              /* pop edi */
            ii(0x1007_5fd8, 1); popd(esi);                              /* pop esi */
            ii(0x1007_5fd9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_5fda, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_5fdb, 1); retd();                                 /* ret */
        }
    }
}
