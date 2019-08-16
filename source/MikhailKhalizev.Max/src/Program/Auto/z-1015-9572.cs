using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a18bdb29-3c93-49b0-9bf7-b31c851a1132")]
        public void Method_1015_9572()
        {
            ii(0x1015_9572, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_9577, 5); calld(Definitions.sys_check_available_stack_size, 0xc7d6); /* call 0x10165d52 */
            ii(0x1015_957c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_957d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_957e, 1); pushd(esi);                             /* push esi */
            ii(0x1015_957f, 1); pushd(edi);                             /* push edi */
            ii(0x1015_9580, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_9581, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9583, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_9589, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_958c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_958f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_9592, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_9595, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_959a, 5); calld(0x100f_448c, -0x6_5113);          /* call 0x100f448c */
            ii(0x1015_959f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_95a2, 5); calld(0x1015_2387, -0x7220);            /* call 0x10152387 */
            ii(0x1015_95a7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_95aa, 5); calld(0x100f_fa70, -0x5_9b3f);          /* call 0x100ffa70 */
            ii(0x1015_95af, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_95b1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_95b2, 1); popd(edi);                              /* pop edi */
            ii(0x1015_95b3, 1); popd(esi);                              /* pop esi */
            ii(0x1015_95b4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_95b5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_95b6, 1); retd(); return;                         /* ret */
        }
    }
}