using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_4d64-32b89b8c")]
        public void Method_1014_4d64()
        {
            ii(0x1014_4d64, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_4d69, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0fe4); /* call 0x10165d52 */
            ii(0x1014_4d6e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_4d6f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_4d70, 1); pushd(esi);                             /* push esi */
            ii(0x1014_4d71, 1); pushd(edi);                             /* push edi */
            ii(0x1014_4d72, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_4d73, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_4d75, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_4d7b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_4d7e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_4d81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_4d83, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_4d86, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_4d89, 5); calld(0x1007_5eac, -0xc_eee2);          /* call 0x10075eac */
            ii(0x1014_4d8e, 3); sub(eax, 0x4e);                         /* sub eax, 0x4e */
            ii(0x1014_4d91, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_4d94, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_4d97, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_4d9a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_4d9d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_4d9f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_4da0, 1); popd(edi);                              /* pop edi */
            ii(0x1014_4da1, 1); popd(esi);                              /* pop esi */
            ii(0x1014_4da2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_4da3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_4da4, 1); retd(); return;                         /* ret */
        }
    }
}
