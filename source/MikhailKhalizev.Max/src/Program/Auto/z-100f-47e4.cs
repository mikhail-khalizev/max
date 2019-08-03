using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("605eda83-a830-4abd-b29c-ce3750e0b5be")]
        public void Method_100f_47e4()
        {
            ii(0x100f_47e4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_47e9, 5); calld(Definitions.sys_check_available_stack_size, 0x71564); /* call 0x10165d52 */
            ii(0x100f_47ee, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_47ef, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_47f0, 1); pushd(edx);                             /* push edx */
            ii(0x100f_47f1, 1); pushd(esi);                             /* push esi */
            ii(0x100f_47f2, 1); pushd(edi);                             /* push edi */
            ii(0x100f_47f3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_47f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_47f6, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_47fc, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_47ff, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_4802, 5); mov(memb_a32[ds, 0x101c_37cc], al);     /* mov [0x101c37cc], al */
            ii(0x100f_4807, 5); mov(al, memb_a32[ds, 0x101c_37cc]);     /* mov al, [0x101c37cc] */
            ii(0x100f_480c, 5); mov(memb_a32[ds, 0x101b_87ff], al);     /* mov [0x101b87ff], al */
            ii(0x100f_4811, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4813, 6); mov(dl, memb_a32[ds, 0x101c_37cc]);     /* mov dl, [0x101c37cc] */
            ii(0x100f_4819, 5); mov(eax, memd_a32[ds, 0x101b_87fb]);    /* mov eax, [0x101b87fb] */
            ii(0x100f_481e, 5); calld(0x100c_fb73, -0x24cb0);           /* call 0x100cfb73 */
            ii(0x100f_4823, 5); calld(0x100f_f5c1, 0xad99);             /* call 0x100ff5c1 */
            ii(0x100f_4828, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_482a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_482b, 1); popd(edi);                              /* pop edi */
            ii(0x100f_482c, 1); popd(esi);                              /* pop esi */
            ii(0x100f_482d, 1); popd(edx);                              /* pop edx */
            ii(0x100f_482e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_482f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_4830, 1); retd(); return;                         /* ret */
        }
    }
}