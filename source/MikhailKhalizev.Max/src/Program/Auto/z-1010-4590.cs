using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c9d2e229-ad7a-4414-9078-e3a1142dc4dc")]
        public void Method_1010_4590()
        {
            ii(0x1010_4590, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_4595, 5); calld(Definitions.sys_check_available_stack_size, 0x6_17b8); /* call 0x10165d52 */
            ii(0x1010_459a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_459b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_459c, 1); pushd(esi);                             /* push esi */
            ii(0x1010_459d, 1); pushd(edi);                             /* push edi */
            ii(0x1010_459e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_459f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_45a1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_45a7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_45aa, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_45ad, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_45b0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_45b3, 5); calld(0x1007_6d14, -0x8_d8a4);          /* call 0x10076d14 */
            ii(0x1010_45b8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_45bb, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1010_45be, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_45c1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_45c4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_45c7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_45ca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_45cc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_45cd, 1); popd(edi);                              /* pop edi */
            ii(0x1010_45ce, 1); popd(esi);                              /* pop esi */
            ii(0x1010_45cf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_45d0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_45d1, 1); retd(); return;                         /* ret */
        }
    }
}
