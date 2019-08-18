using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1475deb8-61e3-4557-9482-8abca361235f")]
        public void Method_1014_52ce()
        {
            ii(0x1014_52ce, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_52d3, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0a7a); /* call 0x10165d52 */
            ii(0x1014_52d8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_52d9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_52da, 1); pushd(esi);                             /* push esi */
            ii(0x1014_52db, 1); pushd(edi);                             /* push edi */
            ii(0x1014_52dc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_52dd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_52df, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_52e5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_52e8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_52eb, 5); mov(edx, StringDefinitions.ExpectingAWord2); /* mov edx, 0x101acfcd */
            ii(0x1014_52f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_52f3, 5); calld(0x1014_5151, -0x1a7);             /* call 0x10145151 */
            ii(0x1014_52f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_52fb, 5); calld(Definitions.my_string_ctor, -0x3818); /* call 0x10141ae8 */
            ii(0x1014_5300, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_5303, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5305, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5306, 1); popd(edi);                              /* pop edi */
            ii(0x1014_5307, 1); popd(esi);                              /* pop esi */
            ii(0x1014_5308, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_5309, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_530a, 1); retd(); return;                         /* ret */
        }
    }
}
