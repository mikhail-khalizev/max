using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e2a8-95491dce")]
        public void Method_1007_e2a8()
        {
            ii(0x1007_e2a8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_e2ad, 5); calld(Definitions.sys_check_available_stack_size, 0xe_7aa0); /* call 0x10165d52 */
            ii(0x1007_e2b2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_e2b3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_e2b4, 1); pushd(edx);                             /* push edx */
            ii(0x1007_e2b5, 1); pushd(esi);                             /* push esi */
            ii(0x1007_e2b6, 1); pushd(edi);                             /* push edi */
            ii(0x1007_e2b7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_e2b8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_e2ba, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_e2c0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_e2c3, 4); mov(memb_a32[ss, ebp - 0x8], 0xd);      /* mov byte [ebp-0x8], 0xd */
            ii(0x1007_e2c7, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1007_e2ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_e2cc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_e2cd, 1); popd(edi);                              /* pop edi */
            ii(0x1007_e2ce, 1); popd(esi);                              /* pop esi */
            ii(0x1007_e2cf, 1); popd(edx);                              /* pop edx */
            ii(0x1007_e2d0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_e2d1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_e2d2, 1); retd();                                 /* ret */
        }
    }
}
