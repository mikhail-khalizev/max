using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_fcb7-976c2e80")]
        public void /* sys */ Method_1017_fcb7()
        {
            ii(0x1017_fcb7, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_fcb8, 1);  push(esi);                            /* push esi */
            ii(0x1017_fcb9, 1);  push(edi);                            /* push edi */
            ii(0x1017_fcba, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_fcbb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1017_fcbd, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1017_fcc3, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1017_fcc6, 3);  mov(memd[ss, ebp - 20], edx);         /* mov [ebp-0x14], edx */
            ii(0x1017_fcc9, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1017_fccc, 3);  push(memd[ss, ebp - 16]);             /* push dword [ebp-0x10] */
            ii(0x1017_fccf, 5);  call(/* sys */ 0x1019_548c, 0x1_57b8);/* call 0x1019548c */
            ii(0x1017_fcd4, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1017_fcd7, 3);  lea(ecx, memd[ss, ebp - 12]);         /* lea ecx, [ebp-0xc] */
            ii(0x1017_fcda, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_fcdb, 3);  lea(ecx, memd[ss, ebp - 8]);          /* lea ecx, [ebp-0x8] */
            ii(0x1017_fcde, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_fcdf, 2);  push(0x20);                           /* push 0x20 */
            ii(0x1017_fce1, 5);  call(/* sys */ 0x1019_52e4, 0x1_55fe);/* call 0x101952e4 */
            ii(0x1017_fce6, 3);  add(esp, 0xc);                        /* add esp, 0xc */
            ii(0x1017_fce9, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1017_fceb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1017_fcee, 4);  mov(memw[ss, ebp - 24], ax);          /* mov [ebp-0x18], ax */
            ii(0x1017_fcf2, 3);  mov(memd[ss, ebp - 28], ecx);         /* mov [ebp-0x1c], ecx */
            ii(0x1017_fcf5, 2);  push(0x10);                           /* push 0x10 */
            ii(0x1017_fcf7, 2);  mov(esi, ds);                         /* mov esi, ds */
            ii(0x1017_fcf9, 5);  mov(ecx, 0x1020_a1e4);                /* mov ecx, 0x1020a1e4 */
            ii(0x1017_fcfe, 2);  mov(ebx, esi);                        /* mov ebx, esi */
            ii(0x1017_fd00, 2);  mov(esi, ecx);                        /* mov esi, ecx */
            ii(0x1017_fd02, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1017_fd05, 3);  mov(ecx, memd[ss, ebp - 28]);         /* mov ecx, [ebp-0x1c] */
            ii(0x1017_fd08, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_fd0a, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1017_fd0c, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1017_fd0e, 2);  mov(ebx, esi);                        /* mov ebx, esi */
            ii(0x1017_fd10, 5);  call(/* sys */ 0x1017_d4ca, -0x284b); /* call 0x1017d4ca */
            ii(0x1017_fd15, 3);  push(memd[ss, ebp - 12]);             /* push dword [ebp-0xc] */
            ii(0x1017_fd18, 5);  call(/* sys */ 0x1019_53bf, 0x1_56a2);/* call 0x101953bf */
            ii(0x1017_fd1d, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1017_fd20, 3);  push(memd[ss, ebp - 12]);             /* push dword [ebp-0xc] */
            ii(0x1017_fd23, 3);  push(memd[ss, ebp - 8]);              /* push dword [ebp-0x8] */
            ii(0x1017_fd26, 5);  call(/* sys */ 0x1019_5325, 0x1_55fa);/* call 0x10195325 */
            ii(0x1017_fd2b, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1017_fd2e, 1);  leave();                              /* leave */
            ii(0x1017_fd2f, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_fd30, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_fd31, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_fd32, 1);  ret();                                /* ret */
        }
    }
}
