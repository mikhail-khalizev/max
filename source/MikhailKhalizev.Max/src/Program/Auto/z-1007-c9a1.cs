using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_c9a1-b84107c9")]
        public void Method_1007_c9a1()
        {
            ii(0x1007_c9a1, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_c9a6, 5); calld(Definitions.sys_check_available_stack_size, 0xe_93a7); /* call 0x10165d52 */
            ii(0x1007_c9ab, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_c9ac, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_c9ad, 1); pushd(esi);                             /* push esi */
            ii(0x1007_c9ae, 1); pushd(edi);                             /* push edi */
            ii(0x1007_c9af, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_c9b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_c9b2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_c9b8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_c9bb, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_c9be, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_c9c0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_c9c1, 1); popd(edi);                              /* pop edi */
            ii(0x1007_c9c2, 1); popd(esi);                              /* pop esi */
            ii(0x1007_c9c3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_c9c4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_c9c5, 1); retd();                                 /* ret */
        }
    }
}
