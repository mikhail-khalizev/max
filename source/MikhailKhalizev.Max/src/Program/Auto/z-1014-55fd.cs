using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_55fd-7f1cf2ce")]
        public void Method_1014_55fd()
        {
            ii(0x1014_55fd, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_5602, 5); calld(Definitions.sys_check_available_stack_size, 0x2_074b); /* call 0x10165d52 */
            ii(0x1014_5607, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_5608, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_5609, 1); pushd(edx);                             /* push edx */
            ii(0x1014_560a, 1); pushd(esi);                             /* push esi */
            ii(0x1014_560b, 1); pushd(edi);                             /* push edi */
            ii(0x1014_560c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_560d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_560f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_5615, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_5618, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_561b, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1014_561e, 5); calld(0x1014_7fc0, 0x299d);             /* call 0x10147fc0 */
            ii(0x1014_5623, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_5626, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_5629, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_562b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_562c, 1); popd(edi);                              /* pop edi */
            ii(0x1014_562d, 1); popd(esi);                              /* pop esi */
            ii(0x1014_562e, 1); popd(edx);                              /* pop edx */
            ii(0x1014_562f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_5630, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_5631, 1); retd();                                 /* ret */
        }
    }
}
