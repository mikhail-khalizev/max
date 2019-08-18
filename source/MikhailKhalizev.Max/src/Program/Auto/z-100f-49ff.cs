using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("454c4459-2098-4812-a35b-8dd43859fe53")]
        public void Method_100f_49ff()
        {
            ii(0x100f_49ff, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_4a04, 5); calld(Definitions.sys_check_available_stack_size, 0x7_1349); /* call 0x10165d52 */
            ii(0x100f_4a09, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_4a0a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_4a0b, 1); pushd(edx);                             /* push edx */
            ii(0x100f_4a0c, 1); pushd(esi);                             /* push esi */
            ii(0x100f_4a0d, 1); pushd(edi);                             /* push edi */
            ii(0x100f_4a0e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_4a0f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4a11, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_4a17, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_4a1a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_4a1d, 5); mov(memb_a32[ds, 0x101c_37d1], al);     /* mov [0x101c37d1], al */
            ii(0x100f_4a22, 5); mov(al, memb_a32[ds, 0x101c_37d1]);     /* mov al, [0x101c37d1] */
            ii(0x100f_4a27, 5); mov(memb_a32[ds, 0x101b_888b], al);     /* mov [0x101b888b], al */
            ii(0x100f_4a2c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4a2e, 6); mov(dl, memb_a32[ds, 0x101c_37d1]);     /* mov dl, [0x101c37d1] */
            ii(0x100f_4a34, 5); mov(eax, memd_a32[ds, 0x101b_8887]);    /* mov eax, [0x101b8887] */
            ii(0x100f_4a39, 5); calld(0x100c_fb73, -0x2_4ecb);          /* call 0x100cfb73 */
            ii(0x100f_4a3e, 5); calld(0x100f_f5c1, 0xab7e);             /* call 0x100ff5c1 */
            ii(0x100f_4a43, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_4a45, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_4a46, 1); popd(edi);                              /* pop edi */
            ii(0x100f_4a47, 1); popd(esi);                              /* pop esi */
            ii(0x100f_4a48, 1); popd(edx);                              /* pop edx */
            ii(0x100f_4a49, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_4a4a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_4a4b, 1); retd(); return;                         /* ret */
        }
    }
}
