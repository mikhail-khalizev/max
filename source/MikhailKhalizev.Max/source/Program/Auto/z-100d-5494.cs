using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5494-e3e91808")]
        public void Method_100d_5494()
        {
            ii(0x100d_5494, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_5499, 5);  call(Definitions.sys_check_available_stack_size, 0x9_08b4);/* call 0x10165d52 */
            ii(0x100d_549e, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_549f, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_54a0, 1);  push(esi);                            /* push esi */
            ii(0x100d_54a1, 1);  push(edi);                            /* push edi */
            ii(0x100d_54a2, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_54a3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_54a5, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100d_54ab, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_54ae, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_54b1, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_54b4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_54b7, 5);  call(0x100d_54cc, 0x10);              /* call 0x100d54cc */
            ii(0x100d_54bc, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_54bf, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_54c2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_54c4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_54c5, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_54c6, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_54c7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_54c8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_54c9, 1);  ret();                                /* ret */
        }
    }
}
