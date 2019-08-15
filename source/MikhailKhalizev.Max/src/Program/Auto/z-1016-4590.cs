using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a7eedf46-32cb-471e-8f29-690266f4e400")]
        public void Method_1016_4590()
        {
            ii(0x1016_4590, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_4595, 5); calld(Definitions.sys_check_available_stack_size, 0x17b8); /* call 0x10165d52 */
            ii(0x1016_459a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_459b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_459c, 1); pushd(esi);                             /* push esi */
            ii(0x1016_459d, 1); pushd(edi);                             /* push edi */
            ii(0x1016_459e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_459f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_45a1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_45a7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_45aa, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_45ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_45af, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_45b2, 5); add(eax, 0xfe);                         /* add eax, 0xfe */
            ii(0x1016_45b7, 5); calld(0x1007_5f2c, -0xe_e690);          /* call 0x10075f2c */
            ii(0x1016_45bc, 5); sub(eax, 0xfe);                         /* sub eax, 0xfe */
            ii(0x1016_45c1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_45c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_45c7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_45ca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_45cd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_45cf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_45d0, 1); popd(edi);                              /* pop edi */
            ii(0x1016_45d1, 1); popd(esi);                              /* pop esi */
            ii(0x1016_45d2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_45d3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_45d4, 1); retd(); return;                         /* ret */
        }
    }
}
