using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8d1e-8dcaa88d")]
        public void Method_100e_8d1e()
        {
            ii(0x100e_8d1e, 5);  push(0x50);                           /* push 0x50 */
            ii(0x100e_8d23, 5);  call(Definitions.sys_check_available_stack_size, 0x7_d02a);/* call 0x10165d52 */
            ii(0x100e_8d28, 1);  push(esi);                            /* push esi */
            ii(0x100e_8d29, 1);  push(edi);                            /* push edi */
            ii(0x100e_8d2a, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_8d2b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_8d2d, 6);  sub(esp, 0x40);                       /* sub esp, 0x40 */
            ii(0x100e_8d33, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_8d36, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100e_8d39, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100e_8d3c, 3);  mov(memd[ss, ebp - 12], ecx);         /* mov [ebp-0xc], ecx */
            ii(0x100e_8d3f, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100e_8d43, 6);  if(jz(0x100e_8ee9, 0x1a0)) goto l_0x100e_8ee9;/* jz 0x100e8ee9 */
            ii(0x100e_8d49, 4);  cmp(memd[ss, ebp + 16], 0);           /* cmp dword [ebp+0x10], 0x0 */
            ii(0x100e_8d4d, 2);  if(jnz(0x100e_8d5b, 0xc)) goto l_0x100e_8d5b;/* jnz 0x100e8d5b */
            ii(0x100e_8d4f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_8d51, 5);  call(0x100e_883d, -0x519);            /* call 0x100e883d */
            ii(0x100e_8d56, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x100e_8d59, 2);  jmp(0x100e_8d61, 6); goto l_0x100e_8d61;/* jmp 0x100e8d61 */
        l_0x100e_8d5b:
            ii(0x100e_8d5b, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100e_8d5e, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
        l_0x100e_8d61:
            ii(0x100e_8d61, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100e_8d64, 4);  mov(ax, memw[ds, eax + 16]);          /* mov ax, [eax+0x10] */
            ii(0x100e_8d68, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100e_8d6b, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100e_8d6e, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100e_8d72, 3);  mov(edx, memd[ss, ebp - 52]);         /* mov edx, [ebp-0x34] */
            ii(0x100e_8d75, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x100e_8d78, 1);  inc(eax);                             /* inc eax */
            ii(0x100e_8d79, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_8d7c, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100e_8d7f, 4);  mov(ax, memw[ds, eax + 12]);          /* mov ax, [eax+0xc] */
            ii(0x100e_8d83, 3);  mov(edx, memd[ss, ebp - 52]);         /* mov edx, [ebp-0x34] */
            ii(0x100e_8d86, 4);  sub(ax, memw[ds, edx + 4]);           /* sub ax, [edx+0x4] */
            ii(0x100e_8d8a, 1);  inc(eax);                             /* inc eax */
            ii(0x100e_8d8b, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100e_8d8e, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100e_8d92, 5);  cmp(eax, 0x280);                      /* cmp eax, 0x280 */
            ii(0x100e_8d97, 2);  if(jle(0x100e_8da0, 7)) goto l_0x100e_8da0;/* jle 0x100e8da0 */
            ii(0x100e_8d99, 7);  mov(memd[ss, ebp - 24], 0x280);       /* mov dword [ebp-0x18], 0x280 */
        l_0x100e_8da0:
            ii(0x100e_8da0, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_8da4, 5);  cmp(eax, 0x1e0);                      /* cmp eax, 0x1e0 */
            ii(0x100e_8da9, 2);  if(jle(0x100e_8db2, 7)) goto l_0x100e_8db2;/* jle 0x100e8db2 */
            ii(0x100e_8dab, 7);  mov(memd[ss, ebp - 28], 0x1e0);       /* mov dword [ebp-0x1c], 0x1e0 */
        l_0x100e_8db2:
            ii(0x100e_8db2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_8db5, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100e_8db8, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100e_8dbb, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x100e_8dbe, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100e_8dc1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_8dc4, 4);  mov(ax, memw[ds, eax + 2]);           /* mov ax, [eax+0x2] */
            ii(0x100e_8dc8, 6);  mov(memw[ds, 0x101c_3658], ax);       /* mov [0x101c3658], ax */
            ii(0x100e_8dce, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_8dd1, 4);  mov(ax, memw[ds, eax + 4]);           /* mov ax, [eax+0x4] */
            ii(0x100e_8dd5, 3);  sub(memd[ss, ebp - 8], eax);          /* sub [ebp-0x8], eax */
            ii(0x100e_8dd8, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_8ddb, 4);  mov(ax, memw[ds, eax + 6]);           /* mov ax, [eax+0x6] */
            ii(0x100e_8ddf, 3);  sub(memd[ss, ebp - 4], eax);          /* sub [ebp-0x4], eax */
            ii(0x100e_8de2, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100e_8de6, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100e_8de9, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x100e_8dec, 3);  lea(ebx, memd[ds, eax + edx]);        /* lea ebx, [eax+edx] */
            ii(0x100e_8def, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100e_8df3, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_8df7, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x100e_8dfa, 2);  add(ebx, eax);                        /* add ebx, eax */
            ii(0x100e_8dfc, 3);  mov(memd[ss, ebp - 56], ebx);         /* mov [ebp-0x38], ebx */
            ii(0x100e_8dff, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_8e02, 3);  add(eax, 8);                          /* add eax, 0x8 */
            ii(0x100e_8e05, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100e_8e08, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x100e_8e0b, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x100e_8e0d, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x100e_8e10, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_8e14, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100e_8e16, 2);  if(jge(0x100e_8e2c, 0x14)) goto l_0x100e_8e2c;/* jge 0x100e8e2c */
            ii(0x100e_8e18, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_8e1c, 3);  sub(memd[ss, ebp - 60], eax);         /* sub [ebp-0x3c], eax */
            ii(0x100e_8e1f, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_8e23, 3);  sub(memd[ss, ebp - 56], eax);         /* sub [ebp-0x38], eax */
            ii(0x100e_8e26, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8e29, 3);  add(memd[ss, ebp - 40], eax);         /* add [ebp-0x28], eax */
        l_0x100e_8e2c:
            ii(0x100e_8e2c, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100e_8e30, 4);  movsx(eax, memw[ss, ebp - 48]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100e_8e34, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100e_8e36, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100e_8e3a, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100e_8e3c, 2);  if(jl(0x100e_8e4a, 0xc)) goto l_0x100e_8e4a;/* jl 0x100e8e4a */
            ii(0x100e_8e3e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8e41, 3);  add(eax, memd[ss, ebp - 48]);         /* add eax, [ebp-0x30] */
            ii(0x100e_8e44, 3);  sub(eax, memd[ss, ebp - 24]);         /* sub eax, [ebp-0x18] */
            ii(0x100e_8e47, 3);  sub(memd[ss, ebp - 40], eax);         /* sub [ebp-0x28], eax */
        l_0x100e_8e4a:
            ii(0x100e_8e4a, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x100e_8e51, 2);  jmp(0x100e_8e59, 6); goto l_0x100e_8e59;/* jmp 0x100e8e59 */
        l_0x100e_8e53:
            ii(0x100e_8e53, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100e_8e56, 3);  inc(memd[ss, ebp - 36]);              /* inc dword [ebp-0x24] */
        l_0x100e_8e59:
            ii(0x100e_8e59, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100e_8e5c, 7);  cmp(ax, memw[ds, 0x101c_3658]);       /* cmp ax, [0x101c3658] */
            ii(0x100e_8e63, 6);  if(jge(0x100e_8ee9, 0x80)) goto l_0x100e_8ee9;/* jge 0x100e8ee9 */
            ii(0x100e_8e69, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_8e6c, 4);  cmp(ax, memw[ss, ebp - 28]);          /* cmp ax, [ebp-0x1c] */
            ii(0x100e_8e70, 6);  if(jge(0x100e_8ee9, 0x73)) goto l_0x100e_8ee9;/* jge 0x100e8ee9 */
            ii(0x100e_8e76, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_8e7a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100e_8e7c, 2);  if(jl(0x100e_8ed0, 0x52)) goto l_0x100e_8ed0;/* jl 0x100e8ed0 */
            ii(0x100e_8e7e, 5);  cmp(memw[ss, ebp - 12], 0);           /* cmp word [ebp-0xc], 0x0 */
            ii(0x100e_8e83, 2);  if(jnz(0x100e_8e96, 0x11)) goto l_0x100e_8e96;/* jnz 0x100e8e96 */
            ii(0x100e_8e85, 4);  movsx(ebx, memw[ss, ebp - 40]);       /* movsx ebx, word [ebp-0x28] */
            ii(0x100e_8e89, 3);  mov(edx, memd[ss, ebp - 60]);         /* mov edx, [ebp-0x3c] */
            ii(0x100e_8e8c, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x100e_8e8f, 5);  call(Definitions.sys_memcpy, 0x7_cfb7);/* call 0x10165e4b */
            ii(0x100e_8e94, 2);  jmp(0x100e_8ed0, 0x3a); goto l_0x100e_8ed0;/* jmp 0x100e8ed0 */
        l_0x100e_8e96:
            ii(0x100e_8e96, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x100e_8e9d, 2);  jmp(0x100e_8ea5, 6); goto l_0x100e_8ea5;/* jmp 0x100e8ea5 */
        l_0x100e_8e9f:
            ii(0x100e_8e9f, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_8ea2, 3);  inc(memd[ss, ebp - 32]);              /* inc dword [ebp-0x20] */
        l_0x100e_8ea5:
            ii(0x100e_8ea5, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_8ea8, 4);  cmp(ax, memw[ss, ebp - 40]);          /* cmp ax, [ebp-0x28] */
            ii(0x100e_8eac, 2);  if(jge(0x100e_8ed0, 0x22)) goto l_0x100e_8ed0;/* jge 0x100e8ed0 */
            ii(0x100e_8eae, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100e_8eb2, 3);  add(eax, memd[ss, ebp - 60]);         /* add eax, [ebp-0x3c] */
            ii(0x100e_8eb5, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x100e_8eb7, 3);  mov(memb[ss, ebp - 64], al);          /* mov [ebp-0x40], al */
            ii(0x100e_8eba, 3);  mov(al, memb[ss, ebp - 64]);          /* mov al, [ebp-0x40] */
            ii(0x100e_8ebd, 3);  cmp(al, memb[ss, ebp - 20]);          /* cmp al, [ebp-0x14] */
            ii(0x100e_8ec0, 2);  if(jz(0x100e_8ece, 0xc)) goto l_0x100e_8ece;/* jz 0x100e8ece */
            ii(0x100e_8ec2, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x100e_8ec6, 3);  add(edx, memd[ss, ebp - 56]);         /* add edx, [ebp-0x38] */
            ii(0x100e_8ec9, 3);  mov(al, memb[ss, ebp - 64]);          /* mov al, [ebp-0x40] */
            ii(0x100e_8ecc, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
        l_0x100e_8ece:
            ii(0x100e_8ece, 2);  jmp(0x100e_8e9f, -0x31); goto l_0x100e_8e9f;/* jmp 0x100e8e9f */
        l_0x100e_8ed0:
            ii(0x100e_8ed0, 4);  movsx(eax, memw[ss, ebp - 48]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100e_8ed4, 3);  add(memd[ss, ebp - 60], eax);         /* add [ebp-0x3c], eax */
            ii(0x100e_8ed7, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x100e_8edb, 3);  add(memd[ss, ebp - 56], eax);         /* add [ebp-0x38], eax */
            ii(0x100e_8ede, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_8ee1, 3);  inc(memd[ss, ebp - 4]);               /* inc dword [ebp-0x4] */
            ii(0x100e_8ee4, 5);  jmp(0x100e_8e53, -0x96); goto l_0x100e_8e53;/* jmp 0x100e8e53 */
        l_0x100e_8ee9:
            ii(0x100e_8ee9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_8eeb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_8eec, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_8eed, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_8eee, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
