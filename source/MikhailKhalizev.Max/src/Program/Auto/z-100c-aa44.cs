using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2410a76e-dded-4011-89f8-cf4dbc47db46")]
        public void Method_100c_aa44()
        {
            ii(0x100c_aa44, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_aa49, 5); calld(Definitions.sys_check_available_stack_size, 0x9_b304); /* call 0x10165d52 */
            ii(0x100c_aa4e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_aa4f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_aa50, 1); pushd(esi);                             /* push esi */
            ii(0x100c_aa51, 1); pushd(edi);                             /* push edi */
            ii(0x100c_aa52, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_aa53, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_aa55, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_aa5b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_aa5e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_aa61, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_aa64, 5); calld(0x1008_b410, -0x3_f659);          /* call 0x1008b410 */
            ii(0x100c_aa69, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100c_aa6c, 5); calld(Definitions.my_3_get_count, -0x3_f5f1); /* call 0x1008b480 */
            ii(0x100c_aa71, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100c_aa74, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_aa77, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_aa7a, 5); calld(0x100c_aa88, 0x9);                /* call 0x100caa88 */
            ii(0x100c_aa7f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_aa81, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_aa82, 1); popd(edi);                              /* pop edi */
            ii(0x100c_aa83, 1); popd(esi);                              /* pop esi */
            ii(0x100c_aa84, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_aa85, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_aa86, 1); retd(); return;                         /* ret */
        }
    }
}
