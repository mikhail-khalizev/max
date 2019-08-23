using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_b063-33555f1d")]
        public void Method_1012_b063()
        {
            ii(0x1012_b063, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_b068, 5); calld(Definitions.sys_check_available_stack_size, 0x3_ace5); /* call 0x10165d52 */
            ii(0x1012_b06d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_b06e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_b06f, 1); pushd(edx);                             /* push edx */
            ii(0x1012_b070, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b071, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b072, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b073, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b075, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_b07b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_b07e, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x32);   /* mov byte [0x101c5c1c], 0x32 */
            ii(0x1012_b085, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_b088, 5); calld(0x1007_6154, -0xb_4f39);          /* call 0x10076154 */
            ii(0x1012_b08d, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_b093, 9); mov(memw_a32[ds, 0x101c_5c1f], 0);      /* mov word [0x101c5c1f], 0x0 */
            ii(0x1012_b09c, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_b0a1, 5); calld(0x1012_5be9, -0x54bd);            /* call 0x10125be9 */
            ii(0x1012_b0a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b0a8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b0a9, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b0aa, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b0ab, 1); popd(edx);                              /* pop edx */
            ii(0x1012_b0ac, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_b0ad, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_b0ae, 1); retd();                                 /* ret */
        }
    }
}
