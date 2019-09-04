using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4797-9973b732")]
        public void Method_100d_4797()
        {
            ii(0x100d_4797, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_479c, 5);  call(Definitions.sys_check_available_stack_size, 0x9_15b1);/* call 0x10165d52 */
            ii(0x100d_47a1, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_47a2, 1);  push(esi);                            /* push esi */
            ii(0x100d_47a3, 1);  push(edi);                            /* push edi */
            ii(0x100d_47a4, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_47a5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_47a7, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100d_47ad, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_47b0, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100d_47b3, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100d_47b6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_47b9, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100d_47bc, 6);  mov(memd[ds, edx + 145], eax);        /* mov [edx+0x91], eax */
            ii(0x100d_47c2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_47c5, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100d_47c8, 3);  cmp(eax, memd[ds, edx + 62]);         /* cmp eax, [edx+0x3e] */
            ii(0x100d_47cb, 2);  if(jnz(0x100d_47f6, 0x29)) goto l_0x100d_47f6;/* jnz 0x100d47f6 */
            ii(0x100d_47cd, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100d_47d1, 2);  if(jz(0x100d_47dd, 0xa)) goto l_0x100d_47dd;/* jz 0x100d47dd */
            ii(0x100d_47d3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_47d6, 5);  call(0x100d_44aa, -0x331);            /* call 0x100d44aa */
            ii(0x100d_47db, 2);  jmp(0x100d_47f0, 0x13); goto l_0x100d_47f0;/* jmp 0x100d47f0 */
        l_0x100d_47dd:
            ii(0x100d_47dd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_47e0, 5);  call(0x100d_0149, -0x469c);           /* call 0x100d0149 */
            ii(0x100d_47e5, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_47e8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_47eb, 5);  call(0x100d_19a4, -0x2e4c);           /* call 0x100d19a4 */
        l_0x100d_47f0:
            ii(0x100d_47f0, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100d_47f4, 2);  jmp(0x100d_4831, 0x3b); goto l_0x100d_4831;/* jmp 0x100d4831 */
        l_0x100d_47f6:
            ii(0x100d_47f6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_47f9, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100d_47fc, 6);  cmp(eax, memd[ds, edx + 141]);        /* cmp eax, [edx+0x8d] */
            ii(0x100d_4802, 2);  if(jnz(0x100d_482d, 0x29)) goto l_0x100d_482d;/* jnz 0x100d482d */
            ii(0x100d_4804, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100d_4808, 2);  if(jz(0x100d_4814, 0xa)) goto l_0x100d_4814;/* jz 0x100d4814 */
            ii(0x100d_480a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_480d, 5);  call(0x100d_4523, -0x2ef);            /* call 0x100d4523 */
            ii(0x100d_4812, 2);  jmp(0x100d_4827, 0x13); goto l_0x100d_4827;/* jmp 0x100d4827 */
        l_0x100d_4814:
            ii(0x100d_4814, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_4817, 5);  call(0x100d_0149, -0x46d3);           /* call 0x100d0149 */
            ii(0x100d_481c, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_481f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_4822, 5);  call(0x100d_19a4, -0x2e83);           /* call 0x100d19a4 */
        l_0x100d_4827:
            ii(0x100d_4827, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x100d_482b, 2);  jmp(0x100d_4831, 4); goto l_0x100d_4831;/* jmp 0x100d4831 */
        l_0x100d_482d:
            ii(0x100d_482d, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x100d_4831:
            ii(0x100d_4831, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x100d_4834, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_4836, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_4837, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_4838, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_4839, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_483a, 1);  ret();                                /* ret */
        }
    }
}
