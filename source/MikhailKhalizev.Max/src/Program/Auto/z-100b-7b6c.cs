using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("918596aa-1506-4319-9231-a3f19bdef212")]
        public void Method_100b_7b6c()
        {
            ii(0x100b_7b6c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_7b71, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e1dc); /* call 0x10165d52 */
            ii(0x100b_7b76, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7b77, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7b78, 1); pushd(edx);                             /* push edx */
            ii(0x100b_7b79, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7b7a, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7b7b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7b7c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7b7e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7b84, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_7b87, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_7b8a, 5); calld(0x1007_6d58, -0x4_0e37);          /* call 0x10076d58 */
            ii(0x100b_7b8f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_7b92, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_7b95, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7b98, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_7b9b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_7b9e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_7ba1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7ba3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7ba4, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7ba5, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7ba6, 1); popd(edx);                              /* pop edx */
            ii(0x100b_7ba7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7ba8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7ba9, 1); retd(); return;                         /* ret */
        }
    }
}
