using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3c46b031-224e-44af-9bfb-5310db93433d")]
        public void Method_1007_60ac()
        {
            ii(0x1007_60ac, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_60b1, 5); calld(Definitions.sys_check_available_stack_size, 0xefc9c); /* call 0x10165d52 */
            ii(0x1007_60b6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_60b7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_60b8, 1); pushd(esi);                             /* push esi */
            ii(0x1007_60b9, 1); pushd(edi);                             /* push edi */
            ii(0x1007_60ba, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_60bb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_60bd, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_60c3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_60c6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_60c9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_60cc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_60cf, 5); add(eax, 0x86);                         /* add eax, 0x86 */
            ii(0x1007_60d4, 5); calld(0x1007_6630, 0x557);              /* call 0x10076630 */
            ii(0x1007_60d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_60db, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_60dc, 1); popd(edi);                              /* pop edi */
            ii(0x1007_60dd, 1); popd(esi);                              /* pop esi */
            ii(0x1007_60de, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_60df, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_60e0, 1); retd(); return;                         /* ret */
        }
    }
}
