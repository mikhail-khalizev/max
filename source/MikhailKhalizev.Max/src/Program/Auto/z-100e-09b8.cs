using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_09b8-fbbc7c4b")]
        public void Method_100e_09b8()
        {
            ii(0x100e_09b8, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_09bd, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5390); /* call 0x10165d52 */
            ii(0x100e_09c2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_09c3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_09c4, 1); pushd(esi);                             /* push esi */
            ii(0x100e_09c5, 1); pushd(edi);                             /* push edi */
            ii(0x100e_09c6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_09c7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_09c9, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_09cf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_09d2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_09d5, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100e_09da, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_09de, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_09e1, 5); calld(0x1013_af3b, 0x5_a555);           /* call 0x1013af3b */
            ii(0x100e_09e6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_09e9, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_09ec, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_09ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_09f2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_09f5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_09f8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_09fa, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_09fb, 1); popd(edi);                              /* pop edi */
            ii(0x100e_09fc, 1); popd(esi);                              /* pop esi */
            ii(0x100e_09fd, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_09fe, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_09ff, 1); retd(); return;                         /* ret */
        }
    }
}
