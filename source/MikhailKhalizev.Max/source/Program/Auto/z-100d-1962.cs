using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_1962-a14fbbd7")]
        public void Method_100d_1962()
        {
            ii(0x100d_1962, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_1967, 5);  call(Definitions.sys_check_available_stack_size, 0x9_43e6);/* call 0x10165d52 */
            ii(0x100d_196c, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_196d, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_196e, 1);  push(esi);                            /* push esi */
            ii(0x100d_196f, 1);  push(edi);                            /* push edi */
            ii(0x100d_1970, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_1971, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_1973, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100d_1979, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_197c, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_197f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_1982, 3);  mov(eax, memd[ds, eax + 49]);         /* mov eax, [eax+0x31] */
            ii(0x100d_1985, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100d_1988, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x100d_198a, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_198d, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_1991, 5);  call(0x100d_4b64, 0x31ce);            /* call 0x100d4b64 */
            ii(0x100d_1996, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_1999, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_199c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_199e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_199f, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_19a0, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_19a1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_19a2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_19a3, 1);  ret();                                /* ret */
        }
    }
}
