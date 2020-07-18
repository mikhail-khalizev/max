using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_bf68-81d4c24c")]
        public void Method_100a_bf68()
        {
            ii(0x100a_bf68, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_bf6d, 5);  call(Definitions.sys_check_available_stack_size, 0xb_9de0);/* call 0x10165d52 */
            ii(0x100a_bf72, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_bf73, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_bf74, 1);  push(edx);                            /* push edx */
            ii(0x100a_bf75, 1);  push(esi);                            /* push esi */
            ii(0x100a_bf76, 1);  push(edi);                            /* push edi */
            ii(0x100a_bf77, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_bf78, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_bf7a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_bf80, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_bf83, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_bf86, 4);  cmp(memb[ds, eax + 30], 0);           /* cmp byte [eax+0x1e], 0x0 */
            ii(0x100a_bf8a, 2);  if(jz(0x100a_bf9d, 0x11)) goto l_0x100a_bf9d;/* jz 0x100abf9d */
            ii(0x100a_bf8c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_bf8e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_bf91, 3);  add(eax, 0x1a);                       /* add eax, 0x1a */
            ii(0x100a_bf94, 5);  call(0x1013_ad71, 0x8_edd8);          /* call 0x1013ad71 */
            ii(0x100a_bf99, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_bf9b, 2);  if(jnz(0x100a_bf9f, 2)) goto l_0x100a_bf9f;/* jnz 0x100abf9f */
        l_0x100a_bf9d:
            ii(0x100a_bf9d, 2);  jmp(0x100a_bfeb, 0x4c); goto l_0x100a_bfeb;/* jmp 0x100abfeb */
        l_0x100a_bf9f:
            ii(0x100a_bf9f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_bfa2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_bfa5, 3);  add(eax, 0x1a);                       /* add eax, 0x1a */
            ii(0x100a_bfa8, 5);  call(0x100b_7e44, 0xbe97);            /* call 0x100b7e44 */
            ii(0x100a_bfad, 5);  call(0x1008_ad90, -0x2_1222);         /* call 0x1008ad90 */
            ii(0x100a_bfb2, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100a_bfb5, 6);  imul(ebx, ebx, 0xc5);                 /* imul ebx, ebx, 0xc5 */
            ii(0x100a_bfbb, 5);  mov(eax, 0x101c_31c4);                /* mov eax, 0x101c31c4 */
            ii(0x100a_bfc0, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100a_bfc2, 5);  call(0x100c_3bfe, 0x1_7c37);          /* call 0x100c3bfe */
            ii(0x100a_bfc7, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_bfc9, 2);  if(jz(0x100a_bfeb, 0x20)) goto l_0x100a_bfeb;/* jz 0x100abfeb */
            ii(0x100a_bfcb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_bfcd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_bfd0, 3);  add(eax, 0x1a);                       /* add eax, 0x1a */
            ii(0x100a_bfd3, 5);  call(0x100b_7ea0, 0xbec8);            /* call 0x100b7ea0 */
            ii(0x100a_bfd8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_bfda, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_bfdd, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100a_bfe0, 5);  call(0x1007_6630, -0x3_59b5);         /* call 0x10076630 */
            ii(0x100a_bfe5, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_bfe9, 2);  jmp(0x100a_bfef, 4); goto l_0x100a_bfef;/* jmp 0x100abfef */
        l_0x100a_bfeb:
            ii(0x100a_bfeb, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x100a_bfef:
            ii(0x100a_bfef, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100a_bff2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_bff4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_bff5, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_bff6, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_bff7, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_bff8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_bff9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_bffa, 1);  ret();                                /* ret */
        }
    }
}
