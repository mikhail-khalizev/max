using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_892b-2149f4d6")]
        public void Method_1014_892b()
        {
            ii(0x1014_892b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_8930, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d41d); /* call 0x10165d52 */
            ii(0x1014_8935, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_8936, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_8937, 1); pushd(edx);                             /* push edx */
            ii(0x1014_8938, 1); pushd(esi);                             /* push esi */
            ii(0x1014_8939, 1); pushd(edi);                             /* push edi */
            ii(0x1014_893a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_893b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_893d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_8943, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8946, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1014_894a, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_8950, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1014_8956, 5); calld(0x100d_f462, -0x6_94f9);          /* call 0x100df462 */
            ii(0x1014_895b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_895e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8961, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_8963, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_8964, 1); popd(edi);                              /* pop edi */
            ii(0x1014_8965, 1); popd(esi);                              /* pop esi */
            ii(0x1014_8966, 1); popd(edx);                              /* pop edx */
            ii(0x1014_8967, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_8968, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_8969, 1); retd(); return;                         /* ret */
        }
    }
}
