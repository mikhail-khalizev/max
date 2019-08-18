using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2540e223-7694-4ad7-8b7c-843a1d681e8a")]
        public void Method_100c_89d1()
        {
            ii(0x100c_89d1, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_89d6, 5); calld(Definitions.sys_check_available_stack_size, 0x9_d377); /* call 0x10165d52 */
            ii(0x100c_89db, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_89dc, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_89dd, 1); pushd(edx);                             /* push edx */
            ii(0x100c_89de, 1); pushd(esi);                             /* push esi */
            ii(0x100c_89df, 1); pushd(edi);                             /* push edi */
            ii(0x100c_89e0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_89e1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_89e3, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_89e9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_89ec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_89ef, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100c_89f2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_89f5, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x100c_89fb, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x100c_8a00, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_8a02, 5); calld(0x100b_cf11, -0xbaf6);            /* call 0x100bcf11 */
            ii(0x100c_8a07, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_8a09, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_8a0a, 1); popd(edi);                              /* pop edi */
            ii(0x100c_8a0b, 1); popd(esi);                              /* pop esi */
            ii(0x100c_8a0c, 1); popd(edx);                              /* pop edx */
            ii(0x100c_8a0d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_8a0e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_8a0f, 1); retd(); return;                         /* ret */
        }
    }
}
