using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_b14d-835d660d")]
        public void Method_100e_b14d()
        {
            ii(0x100e_b14d, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_b152, 5); calld(Definitions.sys_check_available_stack_size, 0x7_abfb); /* call 0x10165d52 */
            ii(0x100e_b157, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_b158, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_b159, 1); pushd(esi);                             /* push esi */
            ii(0x100e_b15a, 1); pushd(edi);                             /* push edi */
            ii(0x100e_b15b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_b15c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b15e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_b164, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_b167, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_b16a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_b16d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b170, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_b173, 5); calld(Definitions.sys_strcpy, 0x7_ad57); /* call 0x10165ecf */
            ii(0x100e_b178, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b17a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_b17b, 1); popd(edi);                              /* pop edi */
            ii(0x100e_b17c, 1); popd(esi);                              /* pop esi */
            ii(0x100e_b17d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_b17e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_b17f, 1); retd();                                 /* ret */
        }
    }
}
