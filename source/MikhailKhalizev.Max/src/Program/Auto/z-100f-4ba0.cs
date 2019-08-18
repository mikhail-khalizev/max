using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("242761ae-8069-4f50-bba5-45e226f72b38")]
        public void Method_100f_4ba0()
        {
            ii(0x100f_4ba0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_4ba5, 5); calld(Definitions.sys_check_available_stack_size, 0x7_11a8); /* call 0x10165d52 */
            ii(0x100f_4baa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_4bab, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_4bac, 1); pushd(edx);                             /* push edx */
            ii(0x100f_4bad, 1); pushd(esi);                             /* push esi */
            ii(0x100f_4bae, 1); pushd(edi);                             /* push edi */
            ii(0x100f_4baf, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_4bb0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4bb2, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_4bb8, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_4bbb, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_4bbe, 5); mov(memb_a32[ds, 0x101c_388a], al);     /* mov [0x101c388a], al */
            ii(0x100f_4bc3, 5); mov(al, memb_a32[ds, 0x101c_388a]);     /* mov al, [0x101c388a] */
            ii(0x100f_4bc8, 5); mov(memb_a32[ds, 0x101b_8845], al);     /* mov [0x101b8845], al */
            ii(0x100f_4bcd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4bcf, 6); mov(dl, memb_a32[ds, 0x101c_388a]);     /* mov dl, [0x101c388a] */
            ii(0x100f_4bd5, 5); mov(eax, memd_a32[ds, 0x101b_8841]);    /* mov eax, [0x101b8841] */
            ii(0x100f_4bda, 5); calld(0x100c_fb73, -0x2_506c);          /* call 0x100cfb73 */
            ii(0x100f_4bdf, 5); calld(0x100f_f5c1, 0xa9dd);             /* call 0x100ff5c1 */
            ii(0x100f_4be4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_4be6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_4be7, 1); popd(edi);                              /* pop edi */
            ii(0x100f_4be8, 1); popd(esi);                              /* pop esi */
            ii(0x100f_4be9, 1); popd(edx);                              /* pop edx */
            ii(0x100f_4bea, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_4beb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_4bec, 1); retd(); return;                         /* ret */
        }
    }
}
