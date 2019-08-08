using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0b2a189d-1674-4200-a17a-75b7adbdb5c1")]
        public void Method_1007_6204()
        {
            ii(0x1007_6204, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_6209, 5); calld(Definitions.sys_check_available_stack_size, 0xe_fb44); /* call 0x10165d52 */
            ii(0x1007_620e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_620f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6210, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6211, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6212, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6213, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6214, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6216, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_621c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_621f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_6222, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1007_6225, 5); calld(0x1007_68e0, 0x6b6);              /* call 0x100768e0 */
            ii(0x1007_622a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_622d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6230, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6232, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6233, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6234, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6235, 1); popd(edx);                              /* pop edx */
            ii(0x1007_6236, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6237, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6238, 1); retd(); return;                         /* ret */
        }
    }
}
