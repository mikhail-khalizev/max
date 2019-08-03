using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("aa0c6731-63de-4bac-a252-9a0181dd5dc7")]
        public void Method_100f_32a2()
        {
            ii(0x100f_32a2, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100f_32a7, 5); calld(Definitions.sys_check_available_stack_size, 0x72aa6); /* call 0x10165d52 */
            ii(0x100f_32ac, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_32ad, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_32ae, 1); pushd(esi);                             /* push esi */
            ii(0x100f_32af, 1); pushd(edi);                             /* push edi */
            ii(0x100f_32b0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_32b1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_32b3, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100f_32b9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_32bc, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100f_32bf, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_32c3, 1); pushd(eax);                             /* push eax */
            ii(0x100f_32c4, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100f_32c8, 1); pushd(eax);                             /* push eax */
            ii(0x100f_32c9, 5); mov(eax, 0x101a_2469);                  /* mov eax, 0x101a2469 */ /* "%3.3i-%3.3i" */
            ii(0x100f_32ce, 1); pushd(eax);                             /* push eax */
            ii(0x100f_32cf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100f_32d2, 1); pushd(eax);                             /* push eax */
            ii(0x100f_32d3, 5); calld(Definitions.sys_sprintf, 0x72c29); /* call 0x10165f01 */
            ii(0x100f_32d8, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x100f_32db, 5); mov(ecx, 0x15);                         /* mov ecx, 0x15 */
            ii(0x100f_32e0, 5); mov(ebx, 0xa2);                         /* mov ebx, 0xa2 */
            ii(0x100f_32e5, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100f_32e8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_32ea, 5); calld(0x100f_3176, -0x179);             /* call 0x100f3176 */
            ii(0x100f_32ef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_32f1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_32f2, 1); popd(edi);                              /* pop edi */
            ii(0x100f_32f3, 1); popd(esi);                              /* pop esi */
            ii(0x100f_32f4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_32f5, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_32f6, 1); retd(); return;                         /* ret */
        }
    }
}
