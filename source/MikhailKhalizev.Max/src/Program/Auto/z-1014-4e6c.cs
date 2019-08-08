using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("66752c51-edcc-42e4-bf46-44222cc070e3")]
        public void Method_1014_4e6c()
        {
            ii(0x1014_4e6c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_4e71, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0edc); /* call 0x10165d52 */
            ii(0x1014_4e76, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_4e77, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_4e78, 1); pushd(esi);                             /* push esi */
            ii(0x1014_4e79, 1); pushd(edi);                             /* push edi */
            ii(0x1014_4e7a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_4e7b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_4e7d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_4e83, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_4e86, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_4e89, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_4e8b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_4e8e, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1014_4e91, 5); calld(0x1007_5eac, -0xc_efea);          /* call 0x10075eac */
            ii(0x1014_4e96, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1014_4e99, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_4e9c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_4e9f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_4ea2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_4ea5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_4ea7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_4ea8, 1); popd(edi);                              /* pop edi */
            ii(0x1014_4ea9, 1); popd(esi);                              /* pop esi */
            ii(0x1014_4eaa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_4eab, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_4eac, 1); retd(); return;                         /* ret */
        }
    }
}
