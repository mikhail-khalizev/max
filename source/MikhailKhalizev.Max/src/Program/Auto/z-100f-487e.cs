using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cd6d782b-2b6d-4e2f-82d2-1a4ee01a6e2a")]
        public void Method_100f_487e()
        {
            ii(0x100f_487e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_4883, 5); calld(Definitions.sys_check_available_stack_size, 0x7_14ca); /* call 0x10165d52 */
            ii(0x100f_4888, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_4889, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_488a, 1); pushd(edx);                             /* push edx */
            ii(0x100f_488b, 1); pushd(esi);                             /* push esi */
            ii(0x100f_488c, 1); pushd(edi);                             /* push edi */
            ii(0x100f_488d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_488e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4890, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_4896, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_4899, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_489c, 5); mov(memb_a32[ds, 0x101c_37cd], al);     /* mov [0x101c37cd], al */
            ii(0x100f_48a1, 5); mov(al, memb_a32[ds, 0x101c_37cd]);     /* mov al, [0x101c37cd] */
            ii(0x100f_48a6, 5); mov(memb_a32[ds, 0x101b_880d], al);     /* mov [0x101b880d], al */
            ii(0x100f_48ab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_48ad, 6); mov(dl, memb_a32[ds, 0x101c_37cd]);     /* mov dl, [0x101c37cd] */
            ii(0x100f_48b3, 5); mov(eax, memd_a32[ds, 0x101b_8809]);    /* mov eax, [0x101b8809] */
            ii(0x100f_48b8, 5); calld(0x100c_fb73, -0x2_4d4a);          /* call 0x100cfb73 */
            ii(0x100f_48bd, 5); calld(0x100f_f5c1, 0xacff);             /* call 0x100ff5c1 */
            ii(0x100f_48c2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_48c4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_48c5, 1); popd(edi);                              /* pop edi */
            ii(0x100f_48c6, 1); popd(esi);                              /* pop esi */
            ii(0x100f_48c7, 1); popd(edx);                              /* pop edx */
            ii(0x100f_48c8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_48c9, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_48ca, 1); retd(); return;                         /* ret */
        }
    }
}
