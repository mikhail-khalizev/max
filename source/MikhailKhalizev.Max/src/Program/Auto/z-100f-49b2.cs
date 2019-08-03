using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f05a5a35-f5de-40a0-a5c6-7308f3a28d96")]
        public void Method_100f_49b2()
        {
            ii(0x100f_49b2, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_49b7, 5); calld(Definitions.sys_check_available_stack_size, 0x71396); /* call 0x10165d52 */
            ii(0x100f_49bc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_49bd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_49be, 1); pushd(edx);                             /* push edx */
            ii(0x100f_49bf, 1); pushd(esi);                             /* push esi */
            ii(0x100f_49c0, 1); pushd(edi);                             /* push edi */
            ii(0x100f_49c1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_49c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_49c4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_49ca, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_49cd, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_49d0, 5); mov(memb_a32[ds, 0x101c_37d0], al);     /* mov [0x101c37d0], al */
            ii(0x100f_49d5, 5); mov(al, memb_a32[ds, 0x101c_37d0]);     /* mov al, [0x101c37d0] */
            ii(0x100f_49da, 5); mov(memb_a32[ds, 0x101b_887d], al);     /* mov [0x101b887d], al */
            ii(0x100f_49df, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_49e1, 6); mov(dl, memb_a32[ds, 0x101c_37d0]);     /* mov dl, [0x101c37d0] */
            ii(0x100f_49e7, 5); mov(eax, memd_a32[ds, 0x101b_8879]);    /* mov eax, [0x101b8879] */
            ii(0x100f_49ec, 5); calld(0x100c_fb73, -0x24e7e);           /* call 0x100cfb73 */
            ii(0x100f_49f1, 5); calld(0x100f_f5c1, 0xabcb);             /* call 0x100ff5c1 */
            ii(0x100f_49f6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_49f8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_49f9, 1); popd(edi);                              /* pop edi */
            ii(0x100f_49fa, 1); popd(esi);                              /* pop esi */
            ii(0x100f_49fb, 1); popd(edx);                              /* pop edx */
            ii(0x100f_49fc, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_49fd, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_49fe, 1); retd(); return;                         /* ret */
        }
    }
}