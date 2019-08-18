using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9c28-8a5cfa18")]
        public void Method_1008_9c28()
        {
            ii(0x1008_9c28, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_9c2d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c120); /* call 0x10165d52 */
            ii(0x1008_9c32, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9c33, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9c34, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9c35, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9c36, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9c37, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9c38, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9c3a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_9c40, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9c43, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9c46, 5); calld(0x1007_6d58, -0x1_2ef3);          /* call 0x10076d58 */
            ii(0x1008_9c4b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_9c4e, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1008_9c51, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9c54, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_9c57, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9c5a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_9c5d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9c5f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9c60, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9c61, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9c62, 1); popd(edx);                              /* pop edx */
            ii(0x1008_9c63, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9c64, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9c65, 1); retd(); return;                         /* ret */
        }
    }
}
