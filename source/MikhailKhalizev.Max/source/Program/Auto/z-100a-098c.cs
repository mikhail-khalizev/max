using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_098c-23565dfb")]
        public void Method_100a_098c()
        {
            ii(0x100a_098c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_0991, 5);  call(Definitions.sys_check_available_stack_size, 0xc_53bc);/* call 0x10165d52 */
            ii(0x100a_0996, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_0997, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_0998, 1);  push(esi);                            /* push esi */
            ii(0x100a_0999, 1);  push(edi);                            /* push edi */
            ii(0x100a_099a, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_099b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_099d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100a_09a3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_09a6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_09a9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_09ac, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_09af, 2);  jmp(0x100a_09d9, 0x28); goto l_0x100a_09d9;/* jmp 0x100a09d9 */
        l_0x100a_09b1:
            ii(0x100a_09b1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_09b4, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100a_09b6, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_09b9, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_09bc, 2);  jmp(0x100a_09ff, 0x41); goto l_0x100a_09ff;/* jmp 0x100a09ff */
        l_0x100a_09be:
            ii(0x100a_09be, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_09c1, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x100a_09c4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_09c7, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_09ca, 2);  jmp(0x100a_09ff, 0x33); goto l_0x100a_09ff;/* jmp 0x100a09ff */
        l_0x100a_09cc:
            ii(0x100a_09cc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_09cf, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100a_09d2, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_09d5, 2);  jmp(0x100a_09ff, 0x28); goto l_0x100a_09ff;/* jmp 0x100a09ff */
        l_0x100a_09d7:
            ii(0x100a_09d7, 2);  jmp(0x100a_09f8, 0x1f); goto l_0x100a_09f8;/* jmp 0x100a09f8 */
        l_0x100a_09d9:
            ii(0x100a_09d9, 4);  cmp(memd[ss, ebp - 12], 0x40);        /* cmp dword [ebp-0xc], 0x40 */
            ii(0x100a_09dd, 2);  if(jb(0x100a_09f0, 0x11)) goto l_0x100a_09f0;/* jb 0x100a09f0 */
            ii(0x100a_09df, 4);  cmp(memd[ss, ebp - 12], 0x40);        /* cmp dword [ebp-0xc], 0x40 */
            ii(0x100a_09e3, 2);  if(jbe(0x100a_09cc, -0x19)) goto l_0x100a_09cc;/* jbe 0x100a09cc */
            ii(0x100a_09e5, 7);  cmp(memd[ss, ebp - 12], 0x80);        /* cmp dword [ebp-0xc], 0x80 */
            ii(0x100a_09ec, 2);  if(jz(0x100a_09b1, -0x3d)) goto l_0x100a_09b1;/* jz 0x100a09b1 */
            ii(0x100a_09ee, 2);  jmp(0x100a_09d7, -0x19); goto l_0x100a_09d7;/* jmp 0x100a09d7 */
        l_0x100a_09f0:
            ii(0x100a_09f0, 4);  cmp(memd[ss, ebp - 12], 0x20);        /* cmp dword [ebp-0xc], 0x20 */
            ii(0x100a_09f4, 2);  if(jz(0x100a_09be, -0x38)) goto l_0x100a_09be;/* jz 0x100a09be */
            ii(0x100a_09f6, 2);  jmp(0x100a_09d7, -0x21); goto l_0x100a_09d7;/* jmp 0x100a09d7 */
        l_0x100a_09f8:
            ii(0x100a_09f8, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x100a_09ff:
            ii(0x100a_09ff, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_0a02, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_0a04, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_0a05, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_0a06, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_0a07, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_0a08, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_0a09, 1);  ret();                                /* ret */
        }
    }
}
