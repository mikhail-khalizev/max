using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7c78-93da0a33")]
        public void Method_100b_7c78()
        {
            ii(0x100b_7c78, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_7c7d, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e0d0); /* call 0x10165d52 */
            ii(0x100b_7c82, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7c83, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7c84, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7c85, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7c86, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7c87, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7c89, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_7c8f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7c92, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_7c95, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_7c98, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7c9b, 5); calld(0x1013_a112, 0x8_2472);           /* call 0x1013a112 */
            ii(0x100b_7ca0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7ca3, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_7ca6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_7ca9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7cac, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_7caf, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_7cb2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7cb4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7cb5, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7cb6, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7cb7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7cb8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7cb9, 1); retd(); return;                         /* ret */
        }
    }
}
