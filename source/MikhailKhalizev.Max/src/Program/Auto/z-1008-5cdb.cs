using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_5cdb-2f853857")]
        public void Method_1008_5cdb()
        {
            ii(0x1008_5cdb, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_5ce0, 5);  call(Definitions.sys_check_available_stack_size, 0xe_006d);/* call 0x10165d52 */
            ii(0x1008_5ce5, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_5ce6, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_5ce7, 1);  push(edx);                            /* push edx */
            ii(0x1008_5ce8, 1);  push(esi);                            /* push esi */
            ii(0x1008_5ce9, 1);  push(edi);                            /* push edi */
            ii(0x1008_5cea, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_5ceb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_5ced, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_5cf3, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_5cf6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5cf9, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_5cfc, 5);  call(0x1008_9d08, 0x4007);            /* call 0x10089d08 */
            ii(0x1008_5d01, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_5d03, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_5d06, 5);  call(0x1008_9be4, 0x3ed9);            /* call 0x10089be4 */
            ii(0x1008_5d0b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5d0e, 5);  call(0x1008_4dd5, -0xf3e);            /* call 0x10084dd5 */
            ii(0x1008_5d13, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_5d15, 2);  if(jz(0x1008_5d2c, 0x15)) goto l_0x1008_5d2c;/* jz 0x10085d2c */
            ii(0x1008_5d17, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1008_5d1c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5d1f, 3);  add(eax, 0x32);                       /* add eax, 0x32 */
            ii(0x1008_5d22, 5);  call(0x1007_65d0, -0xf757);           /* call 0x100765d0 */
            ii(0x1008_5d27, 5);  call(0x100a_297d, 0x1_cc51);          /* call 0x100a297d */
        l_0x1008_5d2c:
            ii(0x1008_5d2c, 2);  jmp(0x1008_5d36, 8); goto l_0x1008_5d36;/* jmp 0x10085d36 */
        l_0x1008_5d2e:
            ii(0x1008_5d2e, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_5d31, 5);  call(0x1007_6bf8, -0xf13e);           /* call 0x10076bf8 */
        l_0x1008_5d36:
            ii(0x1008_5d36, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_5d38, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_5d3b, 5);  call(0x1013_ad71, 0xb_5031);          /* call 0x1013ad71 */
            ii(0x1008_5d40, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_5d42, 2);  if(jz(0x1008_5d67, 0x23)) goto l_0x1008_5d67;/* jz 0x10085d67 */
            ii(0x1008_5d44, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_5d47, 5);  call(0x1008_9acc, 0x3d80);            /* call 0x10089acc */
            ii(0x1008_5d4c, 5);  call(0x1007_b91c, -0xa435);           /* call 0x1007b91c */
            ii(0x1008_5d51, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_5d53, 2);  if(jz(0x1008_5d65, 0x10)) goto l_0x1008_5d65;/* jz 0x10085d65 */
            ii(0x1008_5d55, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1008_5d59, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_5d5b, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_5d5e, 5);  call(0x1008_9044, 0x32e1);            /* call 0x10089044 */
            ii(0x1008_5d63, 2);  jmp(0x1008_5db1, 0x4c); goto l_0x1008_5db1;/* jmp 0x10085db1 */
        l_0x1008_5d65:
            ii(0x1008_5d65, 2);  jmp(0x1008_5d2e, -0x39); goto l_0x1008_5d2e;/* jmp 0x10085d2e */
        l_0x1008_5d67:
            ii(0x1008_5d67, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_5d69, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5d6c, 3);  add(eax, 0x2e);                       /* add eax, 0x2e */
            ii(0x1008_5d6f, 5);  call(0x1013_ad71, 0xb_4ffd);          /* call 0x1013ad71 */
            ii(0x1008_5d74, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_5d76, 2);  if(jz(0x1008_5d97, 0x1f)) goto l_0x1008_5d97;/* jz 0x10085d97 */
            ii(0x1008_5d78, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_5d7b, 3);  add(eax, 0x2e);                       /* add eax, 0x2e */
            ii(0x1008_5d7e, 5);  call(0x1008_9970, 0x3bed);            /* call 0x10089970 */
            ii(0x1008_5d83, 5);  call(0x1008_764d, 0x18c5);            /* call 0x1008764d */
            ii(0x1008_5d88, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1008_5d8b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_5d8d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_5d90, 5);  call(0x1008_9044, 0x32af);            /* call 0x10089044 */
            ii(0x1008_5d95, 2);  jmp(0x1008_5db1, 0x1a); goto l_0x1008_5db1;/* jmp 0x10085db1 */
        l_0x1008_5d97:
            ii(0x1008_5d97, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1008_5d9b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_5d9d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_5da0, 5);  call(0x1008_9044, 0x329f);            /* call 0x10089044 */
            ii(0x1008_5da5, 2);  jmp(0x1008_5db1, 0xa); goto l_0x1008_5db1;/* jmp 0x10085db1 */
        //  ii(0x1008_5da7, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1008_5da9, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
        //  ii(0x1008_5dac, 5);  call(0x1008_9044, 0x3293);            /* call 0x10089044 */
        l_0x1008_5db1:
            ii(0x1008_5db1, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1008_5db4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_5db6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_5db7, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_5db8, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_5db9, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_5dba, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_5dbb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_5dbc, 1);  ret();                                /* ret */
        }
    }
}
