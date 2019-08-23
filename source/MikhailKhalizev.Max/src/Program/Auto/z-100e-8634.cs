using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8634-602a263d")]
        public void Method_100e_8634()
        {
            ii(0x100e_8634, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_8639, 5); calld(Definitions.sys_check_available_stack_size, 0x7_d714); /* call 0x10165d52 */
            ii(0x100e_863e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_863f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_8640, 1); pushd(esi);                             /* push esi */
            ii(0x100e_8641, 1); pushd(edi);                             /* push edi */
            ii(0x100e_8642, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_8643, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_8645, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_864b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_864e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_8651, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_8655, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_8658, 5); calld(0x100e_866c, 0xf);                /* call 0x100e866c */
            ii(0x100e_865d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_8660, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_8663, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8665, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_8666, 1); popd(edi);                              /* pop edi */
            ii(0x100e_8667, 1); popd(esi);                              /* pop esi */
            ii(0x100e_8668, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_8669, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_866a, 1); retd();                                 /* ret */
        }
    }
}
