using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b8ccb01a-efbb-4407-924f-d209d0d2d91c")]
        public void Method_100e_0580()
        {
            ii(0x100e_0580, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_0585, 5); calld(Definitions.sys_check_available_stack_size, 0x8_57c8); /* call 0x10165d52 */
            ii(0x100e_058a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_058b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_058c, 1); pushd(esi);                             /* push esi */
            ii(0x100e_058d, 1); pushd(edi);                             /* push edi */
            ii(0x100e_058e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_058f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0591, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_0597, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_059a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_059d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_05a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_05a3, 5); calld(0x1007_6cd0, -0x6_98d8);          /* call 0x10076cd0 */
            ii(0x100e_05a8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_05ab, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_05ae, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_05b1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_05b4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_05b7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_05ba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_05bc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_05bd, 1); popd(edi);                              /* pop edi */
            ii(0x100e_05be, 1); popd(esi);                              /* pop esi */
            ii(0x100e_05bf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_05c0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_05c1, 1); retd(); return;                         /* ret */
        }
    }
}
