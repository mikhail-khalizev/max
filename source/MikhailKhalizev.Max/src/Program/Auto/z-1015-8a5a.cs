using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("19d9a3ed-5286-4c7e-a4c4-074b96eb933e")]
        public void Method_1015_8a5a()
        {
            ii(0x1015_8a5a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_8a5f, 5); calld(Definitions.sys_check_available_stack_size, 0xd2ee); /* call 0x10165d52 */
            ii(0x1015_8a64, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_8a65, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_8a66, 1); pushd(esi);                             /* push esi */
            ii(0x1015_8a67, 1); pushd(edi);                             /* push edi */
            ii(0x1015_8a68, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_8a69, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_8a6b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_8a71, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_8a74, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_8a77, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_8a7a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_8a7d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_8a82, 5); calld(0x100f_448c, -0x6_45fb);          /* call 0x100f448c */
            ii(0x1015_8a87, 5); calld(0x1015_8711, -0x37b);             /* call 0x10158711 */
            ii(0x1015_8a8c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_8a8e, 2); if(jzd(0x1015_8aa2, 0x12)) goto l_0x1015_8aa2; /* jz 0x10158aa2 */
            ii(0x1015_8a90, 5); mov(ebx, 0x1b);                         /* mov ebx, 0x1b */
            ii(0x1015_8a95, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x1015_8a9a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_8a9d, 5); calld(0x1016_3053, 0xa5b1);             /* call 0x10163053 */
        l_0x1015_8aa2:
            ii(0x1015_8aa2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_8aa4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_8aa5, 1); popd(edi);                              /* pop edi */
            ii(0x1015_8aa6, 1); popd(esi);                              /* pop esi */
            ii(0x1015_8aa7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_8aa8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_8aa9, 1); retd(); return;                         /* ret */
        }
    }
}
