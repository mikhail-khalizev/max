using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_05c4-daa06f25")]
        public void Method_100e_05c4()
        {
            ii(0x100e_05c4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_05c9, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5784); /* call 0x10165d52 */
            ii(0x100e_05ce, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_05cf, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_05d0, 1); pushd(esi);                             /* push esi */
            ii(0x100e_05d1, 1); pushd(edi);                             /* push edi */
            ii(0x100e_05d2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_05d3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_05d5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_05db, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_05de, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_05e1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_05e4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_05e7, 5); calld(0x1007_6d14, -0x6_98d8);          /* call 0x10076d14 */
            ii(0x100e_05ec, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_05ef, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_05f2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_05f5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_05f8, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_05fb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_05fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0600, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0601, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0602, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0603, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0604, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0605, 1); retd(); return;                         /* ret */
        }
    }
}
