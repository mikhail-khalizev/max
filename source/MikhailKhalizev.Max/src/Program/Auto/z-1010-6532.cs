using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6532-8d041b09")]
        public void Method_1010_6532()
        {
            ii(0x1010_6532, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_6537, 5); calld(Definitions.sys_check_available_stack_size, 0x5_f816); /* call 0x10165d52 */
            ii(0x1010_653c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_653d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_653e, 1); pushd(esi);                             /* push esi */
            ii(0x1010_653f, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6540, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6541, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6543, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_6549, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_654c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_654f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_6552, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6553, 5); calld(0x1012_36ac, 0x1_d154);           /* call 0x101236ac */
            ii(0x1010_6558, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1010_655b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_655e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_6561, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_6564, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6566, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6567, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6568, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6569, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_656a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_656b, 1); retd();                                 /* ret */
        }
    }
}
