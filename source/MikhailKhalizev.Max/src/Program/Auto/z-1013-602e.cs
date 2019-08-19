using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_602e-a0a1e2bd")]
        public void Method_1013_602e()
        {
            ii(0x1013_602e, 5); pushd(0x50);                            /* push 0x50 */
            ii(0x1013_6033, 5); calld(Definitions.sys_check_available_stack_size, 0x2_fd1a); /* call 0x10165d52 */
            ii(0x1013_6038, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_6039, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_603a, 1); pushd(edx);                             /* push edx */
            ii(0x1013_603b, 1); pushd(esi);                             /* push esi */
            ii(0x1013_603c, 1); pushd(edi);                             /* push edi */
            ii(0x1013_603d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_603e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_6040, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1013_6046, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_6049, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1013_604d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1013_6050, 5); calld(Definitions.my_ctor_0x101b_38d0, -0xb_f811); /* call 0x10076844 */
            ii(0x1013_6055, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_6058, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1013_605c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_605f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_6062, 2); if(jmpd_func(0x1013_60a8, 0x44)) return; /* jmp 0x101360a8 */
        }
    }
}
