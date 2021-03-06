using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_2ae2-c632d5e0")]
        public void Method_1007_2ae2()
        {
            ii(0x1007_2ae2, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1007_2ae7, 5);  call(Definitions.sys_check_available_stack_size, 0xf_3266);/* call 0x10165d52 */
            ii(0x1007_2aec, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_2aed, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_2aee, 1);  push(edx);                            /* push edx */
            ii(0x1007_2aef, 1);  push(esi);                            /* push esi */
            ii(0x1007_2af0, 1);  push(edi);                            /* push edi */
            ii(0x1007_2af1, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_2af2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_2af4, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1007_2afa, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_2afd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2b00, 5);  call(0x1007_623c, 0x3737);            /* call 0x1007623c */
            ii(0x1007_2b05, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x1007_2b08, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_2b0a, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_2b0c, 5);  call(0x1007_6800, 0x3cef);            /* call 0x10076800 */
            ii(0x1007_2b11, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2b14, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1007_2b18, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_2b1b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2b1e, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x1007_2b22, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_2b25, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2b28, 4);  cmp(memb[ds, eax + 61], 0xc);         /* cmp byte [eax+0x3d], 0xc */
            ii(0x1007_2b2c, 2);  if(jz(0x1007_2b37, 9)) goto l_0x1007_2b37;/* jz 0x10072b37 */
            ii(0x1007_2b2e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2b31, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_2b35, 2);  if(jnz(0x1007_2b39, 2)) goto l_0x1007_2b39;/* jnz 0x10072b39 */
        l_0x1007_2b37:
            ii(0x1007_2b37, 2);  jmp(0x1007_2b42, 9); goto l_0x1007_2b42;/* jmp 0x10072b42 */
        l_0x1007_2b39:
            ii(0x1007_2b39, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2b3c, 4);  cmp(memb[ds, eax + 61], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1007_2b40, 2);  if(jnz(0x1007_2b44, 2)) goto l_0x1007_2b44;/* jnz 0x10072b44 */
        l_0x1007_2b42:
            ii(0x1007_2b42, 2);  jmp(0x1007_2b4d, 9); goto l_0x1007_2b4d;/* jmp 0x10072b4d */
        l_0x1007_2b44:
            ii(0x1007_2b44, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2b47, 4);  cmp(memb[ds, eax + 61], 9);           /* cmp byte [eax+0x3d], 0x9 */
            ii(0x1007_2b4b, 2);  if(jnz(0x1007_2b4f, 2)) goto l_0x1007_2b4f;/* jnz 0x10072b4f */
        l_0x1007_2b4d:
            ii(0x1007_2b4d, 2);  jmp(0x1007_2b58, 9); goto l_0x1007_2b58;/* jmp 0x10072b58 */
        l_0x1007_2b4f:
            ii(0x1007_2b4f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2b52, 4);  cmp(memb[ds, eax + 62], 0xe);         /* cmp byte [eax+0x3e], 0xe */
            ii(0x1007_2b56, 2);  if(jnz(0x1007_2b5a, 2)) goto l_0x1007_2b5a;/* jnz 0x10072b5a */
        l_0x1007_2b58:
            ii(0x1007_2b58, 2);  jmp(0x1007_2b63, 9); goto l_0x1007_2b63;/* jmp 0x10072b63 */
        l_0x1007_2b5a:
            ii(0x1007_2b5a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2b5d, 4);  cmp(memb[ds, eax + 62], 2);           /* cmp byte [eax+0x3e], 0x2 */
            ii(0x1007_2b61, 2);  if(jnz(0x1007_2b76, 0x13)) goto l_0x1007_2b76;/* jnz 0x10072b76 */
        l_0x1007_2b63:
            ii(0x1007_2b63, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_2b67, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2b69, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_2b6c, 5);  call(0x1007_5eec, 0x337b);            /* call 0x10075eec */
            ii(0x1007_2b71, 5);  jmp(0x1007_2c2e, 0xb8); goto l_0x1007_2c2e;/* jmp 0x10072c2e */
        l_0x1007_2b76:
            ii(0x1007_2b76, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2b79, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1007_2b7d, 2);  if(jnz(0x1007_2b88, 9)) goto l_0x1007_2b88;/* jnz 0x10072b88 */
            ii(0x1007_2b7f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2b82, 4);  cmp(memb[ds, eax + 62], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1007_2b86, 2);  if(jnz(0x1007_2b8a, 2)) goto l_0x1007_2b8a;/* jnz 0x10072b8a */
        l_0x1007_2b88:
            ii(0x1007_2b88, 2);  jmp(0x1007_2b9d, 0x13); goto l_0x1007_2b9d;/* jmp 0x10072b9d */
        l_0x1007_2b8a:
            ii(0x1007_2b8a, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_2b8e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2b90, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_2b93, 5);  call(0x1007_5eec, 0x3354);            /* call 0x10075eec */
            ii(0x1007_2b98, 5);  jmp(0x1007_2c2e, 0x91); goto l_0x1007_2c2e;/* jmp 0x10072c2e */
        l_0x1007_2b9d:
            ii(0x1007_2b9d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2ba0, 5);  call(0x1007_2a44, -0x161);            /* call 0x10072a44 */
            ii(0x1007_2ba5, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_2ba7, 2);  if(jz(0x1007_2bbc, 0x13)) goto l_0x1007_2bbc;/* jz 0x10072bbc */
            ii(0x1007_2ba9, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1007_2bad, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2baf, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_2bb2, 5);  call(0x1007_5eec, 0x3335);            /* call 0x10075eec */
            ii(0x1007_2bb7, 5);  jmp(0x1007_2c2e, 0x72); goto l_0x1007_2c2e;/* jmp 0x10072c2e */
        l_0x1007_2bbc:
            ii(0x1007_2bbc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2bbf, 4);  cmp(memb[ds, eax + 80], 0);           /* cmp byte [eax+0x50], 0x0 */
            ii(0x1007_2bc3, 2);  if(jz(0x1007_2c09, 0x44)) goto l_0x1007_2c09;/* jz 0x10072c09 */
            ii(0x1007_2bc5, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1007_2bca, 1);  push(eax);                            /* push eax */
            ii(0x1007_2bcb, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1007_2bcd, 1);  push(eax);                            /* push eax */
            ii(0x1007_2bce, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_2bd1, 5);  call(0x1007_6730, 0x3b5a);            /* call 0x10076730 */
            ii(0x1007_2bd6, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x1007_2bd9, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_2bdc, 1);  push(eax);                            /* push eax */
            ii(0x1007_2bdd, 3);  lea(ecx, memd[ss, ebp - 16]);         /* lea ecx, [ebp-0x10] */
            ii(0x1007_2be0, 3);  lea(ebx, memd[ss, ebp - 12]);         /* lea ebx, [ebp-0xc] */
            ii(0x1007_2be3, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_2be6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2be9, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_2bec, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_2bef, 5);  call(0x1007_0efa, -0x1cfa);           /* call 0x10070efa */
            ii(0x1007_2bf4, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x1007_2bf7, 2);  if(jz(0x1007_2c09, 0x10)) goto l_0x1007_2c09;/* jz 0x10072c09 */
            ii(0x1007_2bf9, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1007_2bfd, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2bff, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_2c02, 5);  call(0x1007_5eec, 0x32e5);            /* call 0x10075eec */
            ii(0x1007_2c07, 2);  jmp(0x1007_2c2e, 0x25); goto l_0x1007_2c2e;/* jmp 0x10072c2e */
        l_0x1007_2c09:
            ii(0x1007_2c09, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2c0c, 3);  mov(edx, memd[ds, eax + 10]);         /* mov edx, [eax+0xa] */
            ii(0x1007_2c0f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_2c12, 3);  call_abs(memd[ds, edx + 4]);          /* call dword [edx+0x4] */
            ii(0x1007_2c15, 3);  mov(memb[ss, ebp - 8], al);           /* mov [ebp-0x8], al */
            ii(0x1007_2c18, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_2c1a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_2c1d, 5);  call(0x1007_5eec, 0x32ca);            /* call 0x10075eec */
            ii(0x1007_2c22, 2);  jmp(0x1007_2c2e, 0xa); goto l_0x1007_2c2e;/* jmp 0x10072c2e */
        //  ii(0x1007_2c24, 10);  Недостижимый код.
        l_0x1007_2c2e:
            ii(0x1007_2c2e, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1007_2c31, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_2c33, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_2c34, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_2c35, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_2c36, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_2c37, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_2c38, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_2c39, 1);  ret();                                /* ret */
        }
    }
}
