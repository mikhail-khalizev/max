using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_90d0-c4433ce2")]
        public void Method_100a_90d0()
        {
            ii(0x100a_90d0, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x100a_90d5, 5); calld(Definitions.sys_check_available_stack_size, 0xb_cc78); /* call 0x10165d52 */
            ii(0x100a_90da, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_90db, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_90dc, 1); pushd(edx);                             /* push edx */
            ii(0x100a_90dd, 1); pushd(esi);                             /* push esi */
            ii(0x100a_90de, 1); pushd(edi);                             /* push edi */
            ii(0x100a_90df, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_90e0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_90e2, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x100a_90e8, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_90ed, 5); calld(0x100a_40b3, -0x503f);            /* call 0x100a40b3 */
            ii(0x100a_90f2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_90f3, 1); popd(edi);                              /* pop edi */
            ii(0x100a_90f4, 1); popd(esi);                              /* pop esi */
            ii(0x100a_90f5, 1); popd(edx);                              /* pop edx */
            ii(0x100a_90f6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_90f7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_90f8, 1); retd();                                 /* ret */
        }
    }
}
