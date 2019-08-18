using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0cfe540b-7d80-4e4b-883e-d908b264b253")]
        public void Method_100c_b91f()
        {
            ii(0x100c_b91f, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b924, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a429); /* call 0x10165d52 */
            ii(0x100c_b929, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b92a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b92b, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b92c, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b92d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b92e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b930, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b936, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b939, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b93c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_b93f, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100c_b942, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b945, 5); calld(0x1008_b4b4, -0x4_0496);          /* call 0x1008b4b4 */
            ii(0x100c_b94a, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100c_b94d, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100c_b950, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b952, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b953, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b954, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b955, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b956, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b957, 1); retd(); return;                         /* ret */
        }
    }
}
