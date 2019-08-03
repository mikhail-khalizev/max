using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d557ef62-1e19-4ef0-b88f-f7a261f060bb")]
        public void Method_1013_aa70()
        {
            ii(0x1013_aa70, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_aa75, 5); calld(Definitions.sys_check_available_stack_size, 0x2b2d8); /* call 0x10165d52 */
            ii(0x1013_aa7a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_aa7b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_aa7c, 1); pushd(esi);                             /* push esi */
            ii(0x1013_aa7d, 1); pushd(edi);                             /* push edi */
            ii(0x1013_aa7e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_aa7f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_aa81, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_aa87, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_aa8a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_aa8d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_aa90, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_aa93, 5); calld(0x1013_acc5, 0x22d);              /* call 0x1013acc5 */
            ii(0x1013_aa98, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_aa9b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_aa9e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_aaa0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_aaa1, 1); popd(edi);                              /* pop edi */
            ii(0x1013_aaa2, 1); popd(esi);                              /* pop esi */
            ii(0x1013_aaa3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_aaa4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_aaa5, 1); retd(); return;                         /* ret */
        }
    }
}
