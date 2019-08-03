using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5e52c38d-29a7-47ba-af5a-6f1623afaad0")]
        public void Method_100f_4ae4()
        {
            ii(0x100f_4ae4, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x100f_4ae9, 5); calld(Definitions.sys_check_available_stack_size, 0x71264); /* call 0x10165d52 */
            ii(0x100f_4aee, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_4aef, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_4af0, 1); pushd(edx);                             /* push edx */
            ii(0x100f_4af1, 1); pushd(esi);                             /* push esi */
            ii(0x100f_4af2, 1); pushd(edi);                             /* push edi */
            ii(0x100f_4af3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_4af4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4af6, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x100f_4afc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4afe, 5); mov(eax, memd_a32[ds, 0x101b_877d]);    /* mov eax, [0x101b877d] */
            ii(0x100f_4b03, 5); calld(0x100c_fb73, -0x24f95);           /* call 0x100cfb73 */
            ii(0x100f_4b08, 7); mov(memb_a32[ds, 0x101c_3911], 0);      /* mov byte [0x101c3911], 0x0 */
            ii(0x100f_4b0f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_4b10, 1); popd(edi);                              /* pop edi */
            ii(0x100f_4b11, 1); popd(esi);                              /* pop esi */
            ii(0x100f_4b12, 1); popd(edx);                              /* pop edx */
            ii(0x100f_4b13, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_4b14, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_4b15, 1); retd(); return;                         /* ret */
        }
    }
}
