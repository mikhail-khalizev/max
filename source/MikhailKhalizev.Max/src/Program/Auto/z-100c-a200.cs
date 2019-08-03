using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d9633b8b-0f31-40ec-9f82-0fe2fb78aba7")]
        public void Method_100c_a200()
        {
            ii(0x100c_a200, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_a205, 5); calld(Definitions.sys_check_available_stack_size, 0x9bb48); /* call 0x10165d52 */
            ii(0x100c_a20a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_a20b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_a20c, 1); pushd(esi);                             /* push esi */
            ii(0x100c_a20d, 1); pushd(edi);                             /* push edi */
            ii(0x100c_a20e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_a20f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a211, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a217, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a21a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_a21d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100c_a222, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a225, 5); calld(0x100c_a164, -0xc6);              /* call 0x100ca164 */
            ii(0x100c_a22a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_a22d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_a230, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_a233, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_a236, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a238, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_a239, 1); popd(edi);                              /* pop edi */
            ii(0x100c_a23a, 1); popd(esi);                              /* pop esi */
            ii(0x100c_a23b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_a23c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_a23d, 1); retd(); return;                         /* ret */
        }
    }
}
