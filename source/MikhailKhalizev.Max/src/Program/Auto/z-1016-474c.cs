using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_474c-a293d4bf")]
        public void Method_1016_474c()
        {
            ii(0x1016_474c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_4751, 5); calld(Definitions.sys_check_available_stack_size, 0x15fc); /* call 0x10165d52 */
            ii(0x1016_4756, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4757, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4758, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4759, 1); pushd(edi);                             /* push edi */
            ii(0x1016_475a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_475b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_475d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_4763, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_4766, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_4769, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1016_476d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_476f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_4771, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4774, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1016_4777, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_4779, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_477c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_477f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4781, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4782, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4783, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4784, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4785, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4786, 1); retd(); return;                         /* ret */
        }
    }
}
