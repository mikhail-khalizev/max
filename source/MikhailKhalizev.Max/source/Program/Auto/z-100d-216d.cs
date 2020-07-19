using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_216d-26b357eb")]
        public void Method_100d_216d()
        {
            ii(0x100d_216d, 5);  push(0x30);                           /* push 0x30 */
            ii(0x100d_2172, 5);  call(Definitions.sys_check_available_stack_size, 0x9_3bdb);/* call 0x10165d52 */
            ii(0x100d_2177, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_2178, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_2179, 1);  push(esi);                            /* push esi */
            ii(0x100d_217a, 1);  push(edi);                            /* push edi */
            ii(0x100d_217b, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_217c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_217e, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100d_2184, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_2187, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_218a, 5);  call(0x100d_4fec, 0x2e5d);            /* call 0x100d4fec */
            ii(0x100d_218f, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100d_2191, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_2194, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_2197, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_219a, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x100d_219c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_219f, 2);  call_abs(memd[ds, edx]);              /* call dword [edx] */
            ii(0x100d_21a1, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x100d_21a3, 5);  call(0x100d_504c, 0x2ea4);            /* call 0x100d504c */
            ii(0x100d_21a8, 2);  test(al, al);                         /* test al, al */
            ii(0x100d_21aa, 2);  if(jz(0x100d_21e1, 0x35)) goto l_0x100d_21e1;/* jz 0x100d21e1 */
            ii(0x100d_21ac, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_21af, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_21b2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_21b5, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_21b8, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_21bb, 3);  mov(esi, memd[ds, eax + 19]);         /* mov esi, [eax+0x13] */
            ii(0x100d_21be, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_21c1, 5);  call(0x100d_4f8c, 0x2dc6);            /* call 0x100d4f8c */
            ii(0x100d_21c6, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100d_21c8, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100d_21ca, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_21cd, 5);  call(0x100d_4fbc, 0x2dea);            /* call 0x100d4fbc */
            ii(0x100d_21d2, 3);  mov(ecx, memd[ss, ebp - 24]);         /* mov ecx, [ebp-0x18] */
            ii(0x100d_21d5, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_21d7, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x100d_21d9, 3);  call_abs(memd[ds, esi + 24]);         /* call dword [esi+0x18] */
            ii(0x100d_21dc, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x100d_21df, 2);  jmp(0x100d_21e5, 4); goto l_0x100d_21e5;/* jmp 0x100d21e5 */
        l_0x100d_21e1:
            ii(0x100d_21e1, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x100d_21e5:
            ii(0x100d_21e5, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100d_21e8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_21ea, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_21eb, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_21ec, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_21ed, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_21ee, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_21ef, 1);  ret();                                /* ret */
        }
    }
}
