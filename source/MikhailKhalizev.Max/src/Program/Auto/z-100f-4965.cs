using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_4965-50336a5b")]
        public void Method_100f_4965()
        {
            ii(0x100f_4965, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_496a, 5); calld(Definitions.sys_check_available_stack_size, 0x7_13e3); /* call 0x10165d52 */
            ii(0x100f_496f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_4970, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_4971, 1); pushd(edx);                             /* push edx */
            ii(0x100f_4972, 1); pushd(esi);                             /* push esi */
            ii(0x100f_4973, 1); pushd(edi);                             /* push edi */
            ii(0x100f_4974, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_4975, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4977, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_497d, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_4980, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_4983, 5); mov(memb_a32[ds, 0x101c_37cf], al);     /* mov [0x101c37cf], al */
            ii(0x100f_4988, 5); mov(al, memb_a32[ds, 0x101c_37cf]);     /* mov al, [0x101c37cf] */
            ii(0x100f_498d, 5); mov(memb_a32[ds, 0x101b_8829], al);     /* mov [0x101b8829], al */
            ii(0x100f_4992, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4994, 6); mov(dl, memb_a32[ds, 0x101c_37cf]);     /* mov dl, [0x101c37cf] */
            ii(0x100f_499a, 5); mov(eax, memd_a32[ds, 0x101b_8825]);    /* mov eax, [0x101b8825] */
            ii(0x100f_499f, 5); calld(0x100c_fb73, -0x2_4e31);          /* call 0x100cfb73 */
            ii(0x100f_49a4, 5); calld(0x100f_f5c1, 0xac18);             /* call 0x100ff5c1 */
            ii(0x100f_49a9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_49ab, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_49ac, 1); popd(edi);                              /* pop edi */
            ii(0x100f_49ad, 1); popd(esi);                              /* pop esi */
            ii(0x100f_49ae, 1); popd(edx);                              /* pop edx */
            ii(0x100f_49af, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_49b0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_49b1, 1); retd();                                 /* ret */
        }
    }
}
