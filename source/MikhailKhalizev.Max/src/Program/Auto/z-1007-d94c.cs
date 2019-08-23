using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_d94c-3225a02f")]
        public void Method_1007_d94c()
        {
            ii(0x1007_d94c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_d951, 5); calld(Definitions.sys_check_available_stack_size, 0xe_83fc); /* call 0x10165d52 */
            ii(0x1007_d956, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_d957, 1); pushd(esi);                             /* push esi */
            ii(0x1007_d958, 1); pushd(edi);                             /* push edi */
            ii(0x1007_d959, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_d95a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_d95c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_d962, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_d965, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_d968, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1007_d96b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_d96d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_d96e, 1); popd(edi);                              /* pop edi */
            ii(0x1007_d96f, 1); popd(esi);                              /* pop esi */
            ii(0x1007_d970, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_d971, 1); retd();                                 /* ret */
        }
    }
}
