using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f944083f-4a56-4240-aeb2-9db01a800bec")]
        public void Method_1013_16c7()
        {
            ii(0x1013_16c7, 5); pushd(0x108);                           /* push 0x108 */
            ii(0x1013_16cc, 5); calld(Definitions.sys_check_available_stack_size, 0x34681); /* call 0x10165d52 */
            ii(0x1013_16d1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_16d2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_16d3, 1); pushd(edx);                             /* push edx */
            ii(0x1013_16d4, 1); pushd(esi);                             /* push esi */
            ii(0x1013_16d5, 1); pushd(edi);                             /* push edi */
            ii(0x1013_16d6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_16d7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_16d9, 6); sub(esp, 0xec);                         /* sub esp, 0xec */
            ii(0x1013_16df, 4); or(memb_a32[ss, ebp - 0x4], 0x1);       /* or byte [ebp-0x4], 0x1 */
            ii(0x1013_16e3, 6); lea(eax, ebp - 0xec);                   /* lea eax, [ebp-0xec] */
            ii(0x1013_16e9, 5); calld(0x1012_c8d0, -0x4e1e);            /* call 0x1012c8d0 */
            ii(0x1013_16ee, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_16f1, 4); and(memb_a32[ss, ebp - 0x4], -0x2 /* 0xfe */); /* and byte [ebp-0x4], 0xfe */
            ii(0x1013_16f5, 6); lea(eax, ebp - 0xec);                   /* lea eax, [ebp-0xec] */
            ii(0x1013_16fb, 5); calld(0x1012_e775, -0x2f8b);            /* call 0x1012e775 */
            ii(0x1013_1700, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_1702, 6); lea(eax, ebp - 0xec);                   /* lea eax, [ebp-0xec] */
            ii(0x1013_1708, 5); calld(0x1012_dd71, -0x399c);            /* call 0x1012dd71 */
            ii(0x1013_170d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_170f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1710, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1711, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1712, 1); popd(edx);                              /* pop edx */
            ii(0x1013_1713, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1714, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1715, 1); retd(); return;                         /* ret */
        }
    }
}