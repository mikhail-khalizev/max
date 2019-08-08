using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6ad430f3-c931-4bd4-a95f-daa7bb0c2fa4")]
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
            ii(0x1013_6050, 5); calld(Definitions.my_ctor_0x101b38d0, -0xb_f811); /* call 0x10076844 */
            ii(0x1013_6055, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_6058, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1013_605c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_605f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_6062, 2); if(jmpd_func(0x1013_60a8, 0x44)) return; /* jmp 0x101360a8 */
            ii(0x1013_6064, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_61b4); /* mov dword [ebp-0x20], 0x101c61b4 */
            ii(0x1013_606b, 2); if(jmpd_func(0x1013_60c5, 0x58)) return; /* jmp 0x101360c5 */
            ii(0x1013_606d, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_64b0); /* mov dword [ebp-0x20], 0x101c64b0 */
            ii(0x1013_6074, 2); if(jmpd_func(0x1013_60c5, 0x4f)) return; /* jmp 0x101360c5 */
            ii(0x1013_6076, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_67ac); /* mov dword [ebp-0x20], 0x101c67ac */
            ii(0x1013_607d, 2); if(jmpd_func(0x1013_60c5, 0x46)) return; /* jmp 0x101360c5 */
            ii(0x1013_607f, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_6aa8); /* mov dword [ebp-0x20], 0x101c6aa8 */
            ii(0x1013_6086, 2); if(jmpd_func(0x1013_60c5, 0x3d)) return; /* jmp 0x101360c5 */
            ii(0x1013_6088, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_6da4); /* mov dword [ebp-0x20], 0x101c6da4 */
            ii(0x1013_608f, 2); if(jmpd_func(0x1013_60c5, 0x34)) return; /* jmp 0x101360c5 */
        }
    }
}
