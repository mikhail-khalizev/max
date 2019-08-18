using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("78807735-c4c9-4de5-ae17-616a432d775e")]
        public void Method_1012_b0af()
        {
            ii(0x1012_b0af, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_b0b4, 5); calld(Definitions.sys_check_available_stack_size, 0x3_ac99); /* call 0x10165d52 */
            ii(0x1012_b0b9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_b0ba, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_b0bb, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b0bc, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b0bd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b0be, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b0c0, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_b0c6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_b0c9, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_b0cc, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x2b);   /* mov byte [0x101c5c1c], 0x2b */
            ii(0x1012_b0d3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_b0d6, 5); calld(0x1007_6154, -0xb_4f87);          /* call 0x10076154 */
            ii(0x1012_b0db, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_b0e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_b0e4, 5); calld(Definitions.sys_strlen, 0x4_6dde); /* call 0x10171ec7 */
            ii(0x1012_b0e9, 1); inc(eax);                               /* inc eax */
            ii(0x1012_b0ea, 6); mov(memw_a32[ds, 0x101c_5c1f], ax);     /* mov [0x101c5c1f], ax */
            ii(0x1012_b0f0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_b0f3, 5); mov(eax, 0x101c_5c21);                  /* mov eax, 0x101c5c21 */
            ii(0x1012_b0f8, 5); calld(Definitions.sys_strcpy, 0x3_add2); /* call 0x10165ecf */
            ii(0x1012_b0fd, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_b102, 5); calld(0x1012_5be9, -0x551e);            /* call 0x10125be9 */
            ii(0x1012_b107, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b109, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b10a, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b10b, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b10c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_b10d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_b10e, 1); retd(); return;                         /* ret */
        }
    }
}
