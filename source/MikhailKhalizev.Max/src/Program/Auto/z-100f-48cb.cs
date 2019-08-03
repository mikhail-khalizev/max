using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d14bae02-ade1-499b-b83e-8ad09f5773fe")]
        public void Method_100f_48cb()
        {
            ii(0x100f_48cb, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_48d0, 5); calld(Definitions.sys_check_available_stack_size, 0x7147d); /* call 0x10165d52 */
            ii(0x100f_48d5, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_48d6, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_48d7, 1); pushd(edx);                             /* push edx */
            ii(0x100f_48d8, 1); pushd(esi);                             /* push esi */
            ii(0x100f_48d9, 1); pushd(edi);                             /* push edi */
            ii(0x100f_48da, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_48db, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_48dd, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_48e3, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_48e6, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_48e9, 5); mov(memb_a32[ds, 0x101c_37ce], al);     /* mov [0x101c37ce], al */
            ii(0x100f_48ee, 5); mov(al, memb_a32[ds, 0x101c_37ce]);     /* mov al, [0x101c37ce] */
            ii(0x100f_48f3, 5); mov(memb_a32[ds, 0x101b_881b], al);     /* mov [0x101b881b], al */
            ii(0x100f_48f8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_48fa, 6); mov(dl, memb_a32[ds, 0x101c_37ce]);     /* mov dl, [0x101c37ce] */
            ii(0x100f_4900, 5); mov(eax, memd_a32[ds, 0x101b_8817]);    /* mov eax, [0x101b8817] */
            ii(0x100f_4905, 5); calld(0x100c_fb73, -0x24d97);           /* call 0x100cfb73 */
            ii(0x100f_490a, 5); calld(0x100f_f5c1, 0xacb2);             /* call 0x100ff5c1 */
            ii(0x100f_490f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_4911, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_4912, 1); popd(edi);                              /* pop edi */
            ii(0x100f_4913, 1); popd(esi);                              /* pop esi */
            ii(0x100f_4914, 1); popd(edx);                              /* pop edx */
            ii(0x100f_4915, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_4916, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_4917, 1); retd(); return;                         /* ret */
        }
    }
}
