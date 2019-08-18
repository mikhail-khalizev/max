using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("348c5ec4-7ee9-41ce-b55c-bfc04248ef63")]
        public void Method_1016_4a60()
        {
            ii(0x1016_4a60, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1016_4a65, 5); calld(Definitions.sys_check_available_stack_size, 0x12e8); /* call 0x10165d52 */
            ii(0x1016_4a6a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4a6b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4a6c, 1); pushd(edx);                             /* push edx */
            ii(0x1016_4a6d, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4a6e, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4a6f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4a70, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4a72, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_4a78, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_4a7b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4a7e, 5); calld(0x1007_6d58, -0xe_dd2b);          /* call 0x10076d58 */
            ii(0x1016_4a83, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_4a86, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1016_4a89, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_4a8c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4a8f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_4a92, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_4a95, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4a97, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4a98, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4a99, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4a9a, 1); popd(edx);                              /* pop edx */
            ii(0x1016_4a9b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4a9c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4a9d, 1); retd(); return;                         /* ret */
        }
    }
}
