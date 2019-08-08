using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("92539618-b566-49ad-bd61-7724a7ce0564")]
        public void Method_1012_9093()
        {
            ii(0x1012_9093, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_9098, 5); calld(Definitions.sys_check_available_stack_size, 0x3_ccb5); /* call 0x10165d52 */
            ii(0x1012_909d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_909e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_909f, 1); pushd(edx);                             /* push edx */
            ii(0x1012_90a0, 1); pushd(esi);                             /* push esi */
            ii(0x1012_90a1, 1); pushd(edi);                             /* push edi */
            ii(0x1012_90a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_90a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_90a5, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_90ab, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_90ae, 7); mov(memb_a32[ds, 0x101c_5c1c], 0xd);    /* mov byte [0x101c5c1c], 0xd */
            ii(0x1012_90b5, 9); mov(memw_a32[ds, 0x101c_5c1f], 0x4);    /* mov word [0x101c5c1f], 0x4 */
            ii(0x1012_90be, 6); mov(ebx, memd_a32[ds, 0x101c_5c1d]);    /* mov ebx, [0x101c5c1d] */
            ii(0x1012_90c4, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_90c7, 3); lea(edx, ebp - 0x4);                    /* lea edx, [ebp-0x4] */
            ii(0x1012_90ca, 5); mov(eax, 0x101c_5c21);                  /* mov eax, 0x101c5c21 */
            ii(0x1012_90cf, 5); calld(Definitions.sys_memcpy, 0x3_cd77); /* call 0x10165e4b */
            ii(0x1012_90d4, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_90d9, 5); calld(0x1012_5be9, -0x34f5);            /* call 0x10125be9 */
            ii(0x1012_90de, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_90e0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_90e1, 1); popd(edi);                              /* pop edi */
            ii(0x1012_90e2, 1); popd(esi);                              /* pop esi */
            ii(0x1012_90e3, 1); popd(edx);                              /* pop edx */
            ii(0x1012_90e4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_90e5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_90e6, 1); retd(); return;                         /* ret */
        }
    }
}
