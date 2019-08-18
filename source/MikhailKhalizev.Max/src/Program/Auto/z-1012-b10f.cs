using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2c8f3ec0-a925-4ba4-9abb-f5046a3061e3")]
        public void Method_1012_b10f()
        {
            ii(0x1012_b10f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_b114, 5); calld(Definitions.sys_check_available_stack_size, 0x3_ac39); /* call 0x10165d52 */
            ii(0x1012_b119, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_b11a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_b11b, 1); pushd(edx);                             /* push edx */
            ii(0x1012_b11c, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b11d, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b11e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b11f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b121, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_b127, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_b12a, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x1d);   /* mov byte [0x101c5c1c], 0x1d */
            ii(0x1012_b131, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_b134, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_b13a, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x6);    /* mov word [0x101c5c1f], 0x6 */
            ii(0x1012_b143, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1012_b148, 5); calld(0x1010_7757, -0x2_39f6);          /* call 0x10107757 */
            ii(0x1012_b14d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_b14f, 5); mov(eax, 0x101c_5c21);                  /* mov eax, 0x101c5c21 */
            ii(0x1012_b154, 5); calld(Definitions.sys_memcpy, 0x3_acf2); /* call 0x10165e4b */
            ii(0x1012_b159, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_b15e, 5); calld(0x1012_5be9, -0x557a);            /* call 0x10125be9 */
            ii(0x1012_b163, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b165, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b166, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b167, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b168, 1); popd(edx);                              /* pop edx */
            ii(0x1012_b169, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_b16a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_b16b, 1); retd(); return;                         /* ret */
        }
    }
}
