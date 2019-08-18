using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7b28-ded7434e")]
        public void Method_100b_7b28()
        {
            ii(0x100b_7b28, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_7b2d, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e220); /* call 0x10165d52 */
            ii(0x100b_7b32, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7b33, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7b34, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7b35, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7b36, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7b37, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7b39, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_7b3f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7b42, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_7b45, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_7b48, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7b4b, 5); calld(0x1007_6d14, -0x4_0e3c);          /* call 0x10076d14 */
            ii(0x100b_7b50, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7b53, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_7b56, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_7b59, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7b5c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_7b5f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_7b62, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7b64, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7b65, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7b66, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7b67, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7b68, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7b69, 1); retd(); return;                         /* ret */
        }
    }
}
