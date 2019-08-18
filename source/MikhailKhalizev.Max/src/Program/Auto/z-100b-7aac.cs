using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d9c6d5e6-1d49-4a06-8ca2-455e01c19c35")]
        public void Method_100b_7aac()
        {
            ii(0x100b_7aac, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_7ab1, 5); calld(Definitions.sys_check_available_stack_size, 0xa_e29c); /* call 0x10165d52 */
            ii(0x100b_7ab6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_7ab7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_7ab8, 1); pushd(esi);                             /* push esi */
            ii(0x100b_7ab9, 1); pushd(edi);                             /* push edi */
            ii(0x100b_7aba, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_7abb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7abd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7ac3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_7ac6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_7ac9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_7acc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_7acf, 5); calld(0x1007_6c98, -0x4_0e3c);          /* call 0x10076c98 */
            ii(0x100b_7ad4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_7ad7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_7ada, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7adc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_7add, 1); popd(edi);                              /* pop edi */
            ii(0x100b_7ade, 1); popd(esi);                              /* pop esi */
            ii(0x100b_7adf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_7ae0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_7ae1, 1); retd(); return;                         /* ret */
        }
    }
}
