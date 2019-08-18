using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("28d325da-518a-4ac5-82be-722a35cf9085")]
        public void Method_100d_4f8c()
        {
            ii(0x100d_4f8c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_4f91, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0dbc); /* call 0x10165d52 */
            ii(0x100d_4f96, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_4f97, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_4f98, 1); pushd(edx);                             /* push edx */
            ii(0x100d_4f99, 1); pushd(esi);                             /* push esi */
            ii(0x100d_4f9a, 1); pushd(edi);                             /* push edi */
            ii(0x100d_4f9b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_4f9c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4f9e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_4fa4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_4fa7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4faa, 3); mov(al, memb_a32[ds, eax + 0x8]);       /* mov al, [eax+0x8] */
            ii(0x100d_4fad, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100d_4fb0, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100d_4fb3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4fb5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_4fb6, 1); popd(edi);                              /* pop edi */
            ii(0x100d_4fb7, 1); popd(esi);                              /* pop esi */
            ii(0x100d_4fb8, 1); popd(edx);                              /* pop edx */
            ii(0x100d_4fb9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_4fba, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_4fbb, 1); retd(); return;                         /* ret */
        }
    }
}
