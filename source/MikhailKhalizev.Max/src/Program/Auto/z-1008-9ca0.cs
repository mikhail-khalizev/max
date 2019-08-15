using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e9e5f4ed-0ad7-4a7d-989a-47731ecb1ab6")]
        public void Method_1008_9ca0()
        {
            ii(0x1008_9ca0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_9ca5, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c0a8); /* call 0x10165d52 */
            ii(0x1008_9caa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9cab, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9cac, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9cad, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9cae, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9caf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9cb1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9cb7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9cba, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9cbd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_9cc0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9cc3, 5); calld(0x1013_a66b, 0xb_09a3);           /* call 0x1013a66b */
            ii(0x1008_9cc8, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1008_9ccb, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_9cce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9cd0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9cd1, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9cd2, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9cd3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9cd4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9cd5, 1); retd(); return;                         /* ret */
        }
    }
}
