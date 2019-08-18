using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bbabcce6-1d51-4818-87a2-938484864c52")]
        public void Method_1007_f581()
        {
            ii(0x1007_f581, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1007_f586, 5); calld(Definitions.sys_check_available_stack_size, 0xe_67c7); /* call 0x10165d52 */
            ii(0x1007_f58b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_f58c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_f58d, 1); pushd(esi);                             /* push esi */
            ii(0x1007_f58e, 1); pushd(edi);                             /* push edi */
            ii(0x1007_f58f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_f590, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f592, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_f598, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_f59b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_f59e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_f5a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_f5a4, 5); calld(0x1015_27ed, 0xd_3244);           /* call 0x101527ed */
            ii(0x1007_f5a9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_f5ac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_f5af, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1007_f5b2, 5); calld(0x1008_ab1c, 0xb565);             /* call 0x1008ab1c */
            ii(0x1007_f5b7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f5b9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_f5ba, 1); popd(edi);                              /* pop edi */
            ii(0x1007_f5bb, 1); popd(esi);                              /* pop esi */
            ii(0x1007_f5bc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_f5bd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_f5be, 1); retd(); return;                         /* ret */
        }
    }
}
