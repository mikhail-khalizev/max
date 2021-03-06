using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_85ad-d5c46cee")]
        public void Method_1014_85ad()
        {
            ii(0x1014_85ad, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1014_85b2, 5);  call(Definitions.sys_check_available_stack_size, 0x1_d79b);/* call 0x10165d52 */
            ii(0x1014_85b7, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_85b8, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_85b9, 1);  push(edx);                            /* push edx */
            ii(0x1014_85ba, 1);  push(esi);                            /* push esi */
            ii(0x1014_85bb, 1);  push(edi);                            /* push edi */
            ii(0x1014_85bc, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_85bd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_85bf, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_85c5, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_85c8, 5);  call(0x1014_82f4, -0x2d9);            /* call 0x101482f4 */
            ii(0x1014_85cd, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_85d0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_85d3, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1014_85d6, 2);  if(jae(0x1014_85e1, 9)) goto l_0x1014_85e1;/* jae 0x101485e1 */
            ii(0x1014_85d8, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_85df, 2);  jmp(0x1014_85f3, 0x12); goto l_0x1014_85f3;/* jmp 0x101485f3 */
        l_0x1014_85e1:
            ii(0x1014_85e1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_85e4, 3);  sub(eax, memd[ss, ebp - 4]);          /* sub eax, [ebp-0x4] */
            ii(0x1014_85e7, 5);  mov(ebx, 0x4a9);                      /* mov ebx, 0x4a9 */
            ii(0x1014_85ec, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_85ee, 2);  div(ebx);                             /* div ebx */
            ii(0x1014_85f0, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1014_85f3:
            ii(0x1014_85f3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_85f6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_85f8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_85f9, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_85fa, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_85fb, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_85fc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_85fd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_85fe, 1);  ret();                                /* ret */
        }
    }
}
