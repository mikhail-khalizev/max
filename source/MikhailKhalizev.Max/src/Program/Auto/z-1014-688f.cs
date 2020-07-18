using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_688f-8ef1a4a5")]
        public void Method_1014_688f()
        {
            ii(0x1014_688f, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_6894, 5);  call(Definitions.sys_check_available_stack_size, 0x1_f4b9);/* call 0x10165d52 */
            ii(0x1014_6899, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_689a, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_689b, 1);  push(edx);                            /* push edx */
            ii(0x1014_689c, 1);  push(esi);                            /* push esi */
            ii(0x1014_689d, 1);  push(edi);                            /* push edi */
            ii(0x1014_689e, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_689f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_68a1, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_68a7, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_68aa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_68ad, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1014_68b0, 2);  if(jnz(0x1014_68bb, 9)) goto l_0x1014_68bb;/* jnz 0x101468bb */
            ii(0x1014_68b2, 7);  mov(memd[ss, ebp - 8], 0x64);         /* mov dword [ebp-0x8], 0x64 */
            ii(0x1014_68b9, 2);  jmp(0x1014_68d6, 0x1b); goto l_0x1014_68d6;/* jmp 0x101468d6 */
        l_0x1014_68bb:
            ii(0x1014_68bb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_68be, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1014_68c0, 5);  call(Definitions.sys_ftell, 0x2_be82);/* call 0x10172747 */
            ii(0x1014_68c5, 3);  imul(edx, eax, 0x64);                 /* imul edx, eax, 0x64 */
            ii(0x1014_68c8, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1014_68ca, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1014_68cd, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1014_68d0, 3);  idiv(memd[ds, ebx + 32]);             /* idiv dword [ebx+0x20] */
            ii(0x1014_68d3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1014_68d6:
            ii(0x1014_68d6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_68d9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_68db, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_68dc, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_68dd, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_68de, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_68df, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_68e0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_68e1, 1);  ret();                                /* ret */
        }
    }
}
