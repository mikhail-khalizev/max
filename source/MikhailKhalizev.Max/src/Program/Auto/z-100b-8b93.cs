using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8b93-47fb5d0e")]
        public void Method_100b_8b93()
        {
            ii(0x100b_8b93, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_8b98, 5); call(Definitions.sys_check_available_stack_size, 0xa_d1b5); /* call 0x10165d52 */
            ii(0x100b_8b9d, 1); push(ebx);                              /* push ebx */
            ii(0x100b_8b9e, 1); push(ecx);                              /* push ecx */
            ii(0x100b_8b9f, 1); push(esi);                              /* push esi */
            ii(0x100b_8ba0, 1); push(edi);                              /* push edi */
            ii(0x100b_8ba1, 1); push(ebp);                              /* push ebp */
            ii(0x100b_8ba2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8ba4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_8baa, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_8bad, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_8bb0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_8bb3, 3); mov(edx, memd[ds, eax + 0x5]);          /* mov edx, [eax+0x5] */
            ii(0x100b_8bb6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_8bb9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_8bbc, 5); call(0x1011_d8e9, 0x6_4d28);            /* call 0x1011d8e9 */
            ii(0x100b_8bc1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_8bc4, 3); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x100b_8bc7, 5); call(0x100a_b33c, -0xd890);             /* call 0x100ab33c */
            ii(0x100b_8bcc, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_8bce, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_8bd1, 3); add(edx, 0xd);                          /* add edx, 0xd */
            ii(0x100b_8bd4, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_8bd7, 5); call(0x1007_5e64, -0x4_2d78);           /* call 0x10075e64 */
            ii(0x100b_8bdc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_8bde, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_8be1, 5); call(0x100a_c0cb, -0xcb1b);             /* call 0x100ac0cb */
            ii(0x100b_8be6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8be8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_8be9, 1); pop(edi);                               /* pop edi */
            ii(0x100b_8bea, 1); pop(esi);                               /* pop esi */
            ii(0x100b_8beb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_8bec, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_8bed, 1); ret();                                  /* ret */
        }
    }
}
