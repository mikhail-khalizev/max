using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4be5d5d1-f7a5-4c5d-8547-06cfaccb4fe5")]
        public void Method_1011_bce1()
        {
            ii(0x1011_bce1, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_bce6, 5); calld(Definitions.sys_check_available_stack_size, 0x4_a067); /* call 0x10165d52 */
            ii(0x1011_bceb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_bcec, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_bced, 1); pushd(esi);                             /* push esi */
            ii(0x1011_bcee, 1); pushd(edi);                             /* push edi */
            ii(0x1011_bcef, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_bcf0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_bcf2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_bcf8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_bcfb, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_bcfe, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_bd01, 3); add(ebx, 0x16);                         /* add ebx, 0x16 */
            ii(0x1011_bd04, 5); mov(edx, StringDefinitions.X7);         /* mov edx, 0x101a7d96 */
            ii(0x1011_bd09, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_bd0c, 5); calld(0x1014_5c2e, 0x2_9f1d);           /* call 0x10145c2e */
            ii(0x1011_bd11, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1011_bd14, 3); add(ebx, 0x18);                         /* add ebx, 0x18 */
            ii(0x1011_bd17, 5); mov(edx, StringDefinitions.Y5);         /* mov edx, 0x101a7d98 */
            ii(0x1011_bd1c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_bd1f, 5); calld(0x1014_5c2e, 0x2_9f0a);           /* call 0x10145c2e */
            ii(0x1011_bd24, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_bd26, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_bd27, 1); popd(edi);                              /* pop edi */
            ii(0x1011_bd28, 1); popd(esi);                              /* pop esi */
            ii(0x1011_bd29, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_bd2a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_bd2b, 1); retd(); return;                         /* ret */
        }
    }
}