using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5d7b614d-37d6-4c9b-9896-90f4c34335c9")]
        public void Method_1007_6dd0()
        {
            ii(0x1007_6dd0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_6dd5, 5); calld(Definitions.sys_check_available_stack_size, 0xe_ef78); /* call 0x10165d52 */
            ii(0x1007_6dda, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6ddb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6ddc, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6ddd, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6dde, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6ddf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6de0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6de2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_6de8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_6deb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6dee, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1007_6df0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6df3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6df6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6df8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6df9, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6dfa, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6dfb, 1); popd(edx);                              /* pop edx */
            ii(0x1007_6dfc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6dfd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6dfe, 1); retd(); return;                         /* ret */
        }
    }
}
