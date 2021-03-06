using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e17c-7578271f")]
        public void Method_1007_e17c()
        {
            ii(0x1007_e17c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_e181, 5);  call(Definitions.sys_check_available_stack_size, 0xe_7bcc);/* call 0x10165d52 */
            ii(0x1007_e186, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_e187, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_e188, 1);  push(esi);                            /* push esi */
            ii(0x1007_e189, 1);  push(edi);                            /* push edi */
            ii(0x1007_e18a, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_e18b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_e18d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1007_e193, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_e196, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_e199, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_e19c, 5);  call(0x1007_623c, -0x7f65);           /* call 0x1007623c */
            ii(0x1007_e1a1, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1007_e1a4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_e1a7, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_e1a9, 2);  if(jnz(0x1007_e1b1, 6)) goto l_0x1007_e1b1;/* jnz 0x1007e1b1 */
            ii(0x1007_e1ab, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_e1af, 2);  jmp(0x1007_e1f0, 0x3f); goto l_0x1007_e1f0;/* jmp 0x1007e1f0 */
        l_0x1007_e1b1:
            ii(0x1007_e1b1, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_e1b8, 2);  jmp(0x1007_e1c0, 6); goto l_0x1007_e1c0;/* jmp 0x1007e1c0 */
        l_0x1007_e1ba:
            ii(0x1007_e1ba, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_e1bd, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1007_e1c0:
            ii(0x1007_e1c0, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1007_e1c4, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1007_e1c7, 2);  if(jge(0x1007_e1ec, 0x23)) goto l_0x1007_e1ec;/* jge 0x1007e1ec */
            ii(0x1007_e1c9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_e1cc, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1007_e1d0, 3);  imul(eax, eax, 0x16);                 /* imul eax, eax, 0x16 */
            ii(0x1007_e1d3, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1007_e1d6, 3);  add(ebx, 0x21);                       /* add ebx, 0x21 */
            ii(0x1007_e1d9, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1007_e1db, 5);  call(0x1007_d252, -0xf8e);            /* call 0x1007d252 */
            ii(0x1007_e1e0, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_e1e2, 2);  if(jz(0x1007_e1ea, 6)) goto l_0x1007_e1ea;/* jz 0x1007e1ea */
            ii(0x1007_e1e4, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_e1e8, 2);  jmp(0x1007_e1f0, 6); goto l_0x1007_e1f0;/* jmp 0x1007e1f0 */
        l_0x1007_e1ea:
            ii(0x1007_e1ea, 2);  jmp(0x1007_e1ba, -0x32); goto l_0x1007_e1ba;/* jmp 0x1007e1ba */
        l_0x1007_e1ec:
            ii(0x1007_e1ec, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1007_e1f0:
            ii(0x1007_e1f0, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1007_e1f3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_e1f5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_e1f6, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_e1f7, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_e1f8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_e1f9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_e1fa, 1);  ret();                                /* ret */
        }
    }
}
