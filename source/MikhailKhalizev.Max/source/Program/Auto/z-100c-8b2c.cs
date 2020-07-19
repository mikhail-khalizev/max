using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_8b2c-32784866")]
        public void Method_100c_8b2c()
        {
            ii(0x100c_8b2c, 5);  push(0x40);                           /* push 0x40 */
            ii(0x100c_8b31, 5);  call(Definitions.sys_check_available_stack_size, 0x9_d21c);/* call 0x10165d52 */
            ii(0x100c_8b36, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_8b37, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_8b38, 1);  push(edx);                            /* push edx */
            ii(0x100c_8b39, 1);  push(esi);                            /* push esi */
            ii(0x100c_8b3a, 1);  push(edi);                            /* push edi */
            ii(0x100c_8b3b, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_8b3c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_8b3e, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x100c_8b44, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_8b47, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8b4a, 4);  cmp(memd[ds, eax + 6], 0);            /* cmp dword [eax+0x6], 0x0 */
            ii(0x100c_8b4e, 6);  if(jnz(0x100c_8ee6, 0x392)) goto l_0x100c_8ee6;/* jnz 0x100c8ee6 */
            ii(0x100c_8b54, 5);  mov(eax, memd[ds, 0x101c_9454]);      /* mov eax, [0x101c9454] */
            ii(0x100c_8b59, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_8b5c, 7);  mov(dx, memw[ds, 0x101c_8172]);       /* mov dx, [0x101c8172] */
            ii(0x100c_8b63, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8b66, 3);  mov(memw[ds, eax], dx);               /* mov [eax], dx */
            ii(0x100c_8b69, 5);  mov(eax, memd[ds, 0x101c_8170]);      /* mov eax, [0x101c8170] */
            ii(0x100c_8b6e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_8b71, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_8b74, 5);  call(Definitions.sys_new_arr, 0x9_d497);/* call 0x10166010 */
            ii(0x100c_8b79, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_8b7b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8b7e, 3);  mov(memd[ds, eax + 6], edx);          /* mov [eax+0x6], edx */
            ii(0x100c_8b81, 5);  mov(eax, memd[ds, 0x101c_8170]);      /* mov eax, [0x101c8170] */
            ii(0x100c_8b86, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_8b89, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_8b8c, 5);  call(Definitions.sys_new_arr, 0x9_d47f);/* call 0x10166010 */
            ii(0x100c_8b91, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_8b93, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8b96, 3);  mov(memd[ds, eax + 2], edx);          /* mov [eax+0x2], edx */
            ii(0x100c_8b99, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x100c_8ba0, 2);  jmp(0x100c_8ba8, 6); goto l_0x100c_8ba8;/* jmp 0x100c8ba8 */
        l_0x100c_8ba2:
            ii(0x100c_8ba2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_8ba5, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x100c_8ba8:
            ii(0x100c_8ba8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_8bab, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x100c_8bb2, 2);  if(jge(0x100c_8bfe, 0x4a)) goto l_0x100c_8bfe;/* jge 0x100c8bfe */
            ii(0x100c_8bb4, 5);  mov(eax, memd[ds, 0x101c_8172]);      /* mov eax, [0x101c8172] */
            ii(0x100c_8bb9, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_8bbc, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100c_8bbe, 5);  call(Definitions.sys_new_arr, 0x9_d44d);/* call 0x10166010 */
            ii(0x100c_8bc3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_8bc5, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100c_8bc9, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_8bcc, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_8bce, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8bd1, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_8bd4, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100c_8bd6, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x100c_8bd8, 5);  mov(eax, memd[ds, 0x101c_8172]);      /* mov eax, [0x101c8172] */
            ii(0x100c_8bdd, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_8be0, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100c_8be2, 5);  call(Definitions.sys_new_arr, 0x9_d429);/* call 0x10166010 */
            ii(0x100c_8be7, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_8be9, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100c_8bed, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_8bf0, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_8bf2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8bf5, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x100c_8bf8, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100c_8bfa, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x100c_8bfc, 2);  jmp(0x100c_8ba2, -0x5c); goto l_0x100c_8ba2;/* jmp 0x100c8ba2 */
        l_0x100c_8bfe:
            ii(0x100c_8bfe, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100c_8c05, 2);  jmp(0x100c_8c0d, 6); goto l_0x100c_8c0d;/* jmp 0x100c8c0d */
        l_0x100c_8c07:
            ii(0x100c_8c07, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8c0a, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x100c_8c0d:
            ii(0x100c_8c0d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8c10, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x100c_8c17, 6);  if(jge(0x100c_8ce3, 0xc6)) goto l_0x100c_8ce3;/* jge 0x100c8ce3 */
            ii(0x100c_8c1d, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x100c_8c24, 2);  jmp(0x100c_8c2c, 6); goto l_0x100c_8c2c;/* jmp 0x100c8c2c */
        l_0x100c_8c26:
            ii(0x100c_8c26, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_8c29, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x100c_8c2c:
            ii(0x100c_8c2c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_8c2f, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x100c_8c36, 6);  if(jge(0x100c_8cde, 0xa2)) goto l_0x100c_8cde;/* jge 0x100c8cde */
            ii(0x100c_8c3c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_8c3f, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x100c_8c41, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100c_8c46, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100c_8c49, 2);  if(jnz(0x100c_8c6b, 0x20)) goto l_0x100c_8c6b;/* jnz 0x100c8c6b */
            ii(0x100c_8c4b, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100c_8c4f, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100c_8c52, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8c55, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_8c58, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8c5a, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_8c5e, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x100c_8c60, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_8c62, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8c64, 5);  mov(memw[ds, eax], 0xffff);           /* mov word [eax], 0xffff */
            ii(0x100c_8c69, 2);  jmp(0x100c_8c89, 0x1e); goto l_0x100c_8c89;/* jmp 0x100c8c89 */
        l_0x100c_8c6b:
            ii(0x100c_8c6b, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100c_8c6f, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100c_8c72, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8c75, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_8c78, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8c7a, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_8c7e, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x100c_8c80, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_8c82, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8c84, 5);  mov(memw[ds, eax], 0x7fff);           /* mov word [eax], 0x7fff */
        l_0x100c_8c89:
            ii(0x100c_8c89, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_8c8c, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
            ii(0x100c_8c8f, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x100c_8c91, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100c_8c96, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100c_8c99, 2);  if(jnz(0x100c_8cbb, 0x20)) goto l_0x100c_8cbb;/* jnz 0x100c8cbb */
            ii(0x100c_8c9b, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100c_8c9f, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100c_8ca2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8ca5, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x100c_8ca8, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8caa, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_8cae, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x100c_8cb0, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_8cb2, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8cb4, 5);  mov(memw[ds, eax], 0xffff);           /* mov word [eax], 0xffff */
            ii(0x100c_8cb9, 2);  jmp(0x100c_8cd9, 0x1e); goto l_0x100c_8cd9;/* jmp 0x100c8cd9 */
        l_0x100c_8cbb:
            ii(0x100c_8cbb, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100c_8cbf, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100c_8cc2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8cc5, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x100c_8cc8, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8cca, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_8cce, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x100c_8cd0, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_8cd2, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8cd4, 5);  mov(memw[ds, eax], 0x7fff);           /* mov word [eax], 0x7fff */
        l_0x100c_8cd9:
            ii(0x100c_8cd9, 5);  jmp(0x100c_8c26, -0xb8); goto l_0x100c_8c26;/* jmp 0x100c8c26 */
        l_0x100c_8cde:
            ii(0x100c_8cde, 5);  jmp(0x100c_8c07, -0xdc); goto l_0x100c_8c07;/* jmp 0x100c8c07 */
        l_0x100c_8ce3:
            ii(0x100c_8ce3, 5);  mov(eax, 0x101c_8178);                /* mov eax, 0x101c8178 */
            ii(0x100c_8ce8, 5);  call(0x1007_6338, -0x5_29b5);         /* call 0x10076338 */
            ii(0x100c_8ced, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_8cef, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8cf2, 5);  call(0x1007_64b8, -0x5_283f);         /* call 0x100764b8 */
            ii(0x100c_8cf7, 5);  mov(eax, 0x101c_8178);                /* mov eax, 0x101c8178 */
            ii(0x100c_8cfc, 5);  call(0x1007_6338, -0x5_29c9);         /* call 0x10076338 */
            ii(0x100c_8d01, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x100c_8d04, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_8d06, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100c_8d08, 5);  call(0x1007_643c, -0x5_28d1);         /* call 0x1007643c */
            ii(0x100c_8d0d, 2);  jmp(0x100c_8d17, 8); goto l_0x100c_8d17;/* jmp 0x100c8d17 */
        l_0x100c_8d0f:
            ii(0x100c_8d0f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8d12, 5);  call(0x1007_6bf8, -0x5_211f);         /* call 0x10076bf8 */
        l_0x100c_8d17:
            ii(0x100c_8d17, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_8d19, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8d1c, 5);  call(0x1013_ad71, 0x7_2050);          /* call 0x1013ad71 */
            ii(0x100c_8d21, 2);  test(al, al);                         /* test al, al */
            ii(0x100c_8d23, 6);  if(jz(0x100c_8deb, 0xc2)) goto l_0x100c_8deb;/* jz 0x100c8deb */
            ii(0x100c_8d29, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8d2c, 5);  call(0x1007_63a0, -0x5_2991);         /* call 0x100763a0 */
            ii(0x100c_8d31, 5);  cmp(memw[ds, eax + 8], 0x27);         /* cmp word [eax+0x8], 0x27 */
            ii(0x100c_8d36, 2);  if(jz(0x100c_8d4b, 0x13)) goto l_0x100c_8d4b;/* jz 0x100c8d4b */
            ii(0x100c_8d38, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8d3b, 5);  call(0x1007_63a0, -0x5_29a0);         /* call 0x100763a0 */
            ii(0x100c_8d40, 5);  cmp(memw[ds, eax + 8], 0x21);         /* cmp word [eax+0x8], 0x21 */
            ii(0x100c_8d45, 6);  if(jnz(0x100c_8de6, 0x9b)) goto l_0x100c_8de6;/* jnz 0x100c8de6 */
        l_0x100c_8d4b:
            ii(0x100c_8d4b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8d4e, 5);  call(0x1007_63a0, -0x5_29b3);         /* call 0x100763a0 */
            ii(0x100c_8d53, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100c_8d57, 2);  if(jz(0x100c_8d6d, 0x14)) goto l_0x100c_8d6d;/* jz 0x100c8d6d */
            ii(0x100c_8d59, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8d5c, 5);  call(0x1007_63a0, -0x5_29c1);         /* call 0x100763a0 */
            ii(0x100c_8d61, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x100c_8d64, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100c_8d69, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_8d6b, 2);  if(jg(0x100c_8d6f, 2)) goto l_0x100c_8d6f;/* jg 0x100c8d6f */
        l_0x100c_8d6d:
            ii(0x100c_8d6d, 2);  jmp(0x100c_8de6, 0x77); goto l_0x100c_8de6;/* jmp 0x100c8de6 */
        l_0x100c_8d6f:
            ii(0x100c_8d6f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8d72, 5);  call(0x1007_63a0, -0x5_29d7);         /* call 0x100763a0 */
            ii(0x100c_8d77, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x100c_8d7a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_8d7d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_8d80, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_8d82, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8d85, 3);  mov(edx, memd[ds, eax + 6]);          /* mov edx, [eax+0x6] */
            ii(0x100c_8d88, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x100c_8d8a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8d8d, 5);  call(0x1007_63a0, -0x5_29f2);         /* call 0x100763a0 */
            ii(0x100c_8d92, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x100c_8d95, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_8d98, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100c_8d9a, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_8d9c, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x100c_8d9e, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100c_8da0, 5);  mov(memw[ds, eax], 0xffff);           /* mov word [eax], 0xffff */
            ii(0x100c_8da5, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8da8, 5);  call(0x1007_63a0, -0x5_2a0d);         /* call 0x100763a0 */
            ii(0x100c_8dad, 5);  cmp(memw[ds, eax + 8], 0x21);         /* cmp word [eax+0x8], 0x21 */
            ii(0x100c_8db2, 2);  if(jnz(0x100c_8de6, 0x32)) goto l_0x100c_8de6;/* jnz 0x100c8de6 */
            ii(0x100c_8db4, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8db7, 5);  call(0x1007_63a0, -0x5_2a1c);         /* call 0x100763a0 */
            ii(0x100c_8dbc, 3);  mov(ebx, memd[ds, eax + 24]);         /* mov ebx, [eax+0x18] */
            ii(0x100c_8dbf, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100c_8dc2, 3);  shl(ebx, 2);                          /* shl ebx, 0x2 */
            ii(0x100c_8dc5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8dc8, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_8dcb, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x100c_8dcd, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8dd0, 5);  call(0x1007_63a0, -0x5_2a35);         /* call 0x100763a0 */
            ii(0x100c_8dd5, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x100c_8dd8, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_8ddb, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100c_8ddd, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x100c_8ddf, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8de1, 5);  mov(memw[ds, eax], 0x7fff);           /* mov word [eax], 0x7fff */
        l_0x100c_8de6:
            ii(0x100c_8de6, 5);  jmp(0x100c_8d0f, -0xdc); goto l_0x100c_8d0f;/* jmp 0x100c8d0f */
        l_0x100c_8deb:
            ii(0x100c_8deb, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x100c_8df0, 5);  call(0x1007_6338, -0x5_2abd);         /* call 0x10076338 */
            ii(0x100c_8df5, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x100c_8df8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_8dfa, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100c_8dfc, 5);  call(0x1007_643c, -0x5_29c5);         /* call 0x1007643c */
            ii(0x100c_8e01, 2);  jmp(0x100c_8e0b, 8); goto l_0x100c_8e0b;/* jmp 0x100c8e0b */
        l_0x100c_8e03:
            ii(0x100c_8e03, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8e06, 5);  call(0x1007_6bf8, -0x5_2213);         /* call 0x10076bf8 */
        l_0x100c_8e0b:
            ii(0x100c_8e0b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_8e0d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8e10, 5);  call(0x1013_ad71, 0x7_1f5c);          /* call 0x1013ad71 */
            ii(0x100c_8e15, 2);  test(al, al);                         /* test al, al */
            ii(0x100c_8e17, 6);  if(jz(0x100c_8edc, 0xbf)) goto l_0x100c_8edc;/* jz 0x100c8edc */
            ii(0x100c_8e1d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8e20, 5);  call(0x1007_63a0, -0x5_2a85);         /* call 0x100763a0 */
            ii(0x100c_8e25, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100c_8e29, 2);  if(jz(0x100c_8e3f, 0x14)) goto l_0x100c_8e3f;/* jz 0x100c8e3f */
            ii(0x100c_8e2b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8e2e, 5);  call(0x1007_63a0, -0x5_2a93);         /* call 0x100763a0 */
            ii(0x100c_8e33, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x100c_8e36, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100c_8e3b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_8e3d, 2);  if(jg(0x100c_8e41, 2)) goto l_0x100c_8e41;/* jg 0x100c8e41 */
        l_0x100c_8e3f:
            ii(0x100c_8e3f, 2);  jmp(0x100c_8e50, 0xf); goto l_0x100c_8e50;/* jmp 0x100c8e50 */
        l_0x100c_8e41:
            ii(0x100c_8e41, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8e44, 5);  call(0x1007_63a0, -0x5_2aa9);         /* call 0x100763a0 */
            ii(0x100c_8e49, 5);  cmp(memw[ds, eax + 8], 0xc);          /* cmp word [eax+0x8], 0xc */
            ii(0x100c_8e4e, 2);  if(jnz(0x100c_8e55, 5)) goto l_0x100c_8e55;/* jnz 0x100c8e55 */
        l_0x100c_8e50:
            ii(0x100c_8e50, 5);  jmp(0x100c_8ed7, 0x82); goto l_0x100c_8ed7;/* jmp 0x100c8ed7 */
        l_0x100c_8e55:
            ii(0x100c_8e55, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x100c_8e58, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8e5b, 5);  call(0x1007_63a0, -0x5_2ac0);         /* call 0x100763a0 */
            ii(0x100c_8e60, 5);  call(0x1015_2532, 0x8_96cd);          /* call 0x10152532 */
            ii(0x100c_8e65, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100c_8e68, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_8e6b, 2);  jmp(0x100c_8e73, 6); goto l_0x100c_8e73;/* jmp 0x100c8e73 */
        l_0x100c_8e6d:
            ii(0x100c_8e6d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_8e70, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x100c_8e73:
            ii(0x100c_8e73, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100c_8e77, 3);  cmp(eax, memd[ss, ebp - 28]);         /* cmp eax, [ebp-0x1c] */
            ii(0x100c_8e7a, 2);  if(jge(0x100c_8ed7, 0x5b)) goto l_0x100c_8ed7;/* jge 0x100c8ed7 */
            ii(0x100c_8e7c, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_8e7f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_8e82, 2);  jmp(0x100c_8e8a, 6); goto l_0x100c_8e8a;/* jmp 0x100c8e8a */
        l_0x100c_8e84:
            ii(0x100c_8e84, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_8e87, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x100c_8e8a:
            ii(0x100c_8e8a, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100c_8e8e, 3);  cmp(eax, memd[ss, ebp - 24]);         /* cmp eax, [ebp-0x18] */
            ii(0x100c_8e91, 2);  if(jge(0x100c_8ed5, 0x42)) goto l_0x100c_8ed5;/* jge 0x100c8ed5 */
            ii(0x100c_8e93, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100c_8e97, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_8e9a, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_8e9c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8e9f, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_8ea2, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8ea4, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_8ea8, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x100c_8eaa, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_8eac, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8eae, 5);  mov(memw[ds, eax], 0x7fff);           /* mov word [eax], 0x7fff */
            ii(0x100c_8eb3, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100c_8eb7, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_8eba, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_8ebc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8ebf, 3);  mov(eax, memd[ds, eax + 2]);          /* mov eax, [eax+0x2] */
            ii(0x100c_8ec2, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8ec4, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_8ec8, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x100c_8eca, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_8ecc, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8ece, 5);  mov(memw[ds, eax], 0x7fff);           /* mov word [eax], 0x7fff */
            ii(0x100c_8ed3, 2);  jmp(0x100c_8e84, -0x51); goto l_0x100c_8e84;/* jmp 0x100c8e84 */
        l_0x100c_8ed5:
            ii(0x100c_8ed5, 2);  jmp(0x100c_8e6d, -0x6a); goto l_0x100c_8e6d;/* jmp 0x100c8e6d */
        l_0x100c_8ed7:
            ii(0x100c_8ed7, 5);  jmp(0x100c_8e03, -0xd9); goto l_0x100c_8e03;/* jmp 0x100c8e03 */
        l_0x100c_8edc:
            ii(0x100c_8edc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_8ede, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_8ee1, 5);  call(0x1007_5f6c, -0x5_2f7a);         /* call 0x10075f6c */
        l_0x100c_8ee6:
            ii(0x100c_8ee6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_8ee8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_8ee9, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_8eea, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_8eeb, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_8eec, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_8eed, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_8eee, 1);  ret();                                /* ret */
        }
    }
}
