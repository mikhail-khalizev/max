using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_9cd1-426778e0")]
        public void Method_1014_9cd1()
        {
            ii(0x1014_9cd1, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1014_9cd6, 5);  call(Definitions.sys_check_available_stack_size, 0x1_c077);/* call 0x10165d52 */
            ii(0x1014_9cdb, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_9cdc, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_9cdd, 1);  push(edx);                            /* push edx */
            ii(0x1014_9cde, 1);  push(esi);                            /* push esi */
            ii(0x1014_9cdf, 1);  push(edi);                            /* push edi */
            ii(0x1014_9ce0, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_9ce1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_9ce3, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1014_9ce9, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_9cec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9cef, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1014_9cf2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_9cf5, 3);  imul(edx, eax, 0x33);                 /* imul edx, eax, 0x33 */
            ii(0x1014_9cf8, 5);  mov(eax, 0x101c_81c0);                /* mov eax, 0x101c81c0 */
            ii(0x1014_9cfd, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1014_9cff, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_9d02, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1014_9d05, 5);  call(Definitions.my_ctor_0x101b_4184, -0xd_321a);/* call 0x10076af0 */
            ii(0x1014_9d0a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_9d0d, 4);  cmp(memd[ds, eax + 39], 0);           /* cmp dword [eax+0x27], 0x0 */
            ii(0x1014_9d11, 6);  if(jz(0x1014_9f9f, 0x288)) goto l_0x1014_9f9f;/* jz 0x10149f9f */
            ii(0x1014_9d17, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9d1a, 4);  mov(ax, memw[ds, eax + 22]);          /* mov ax, [eax+0x16] */
            ii(0x1014_9d1e, 4);  mov(memw[ss, ebp - 12], ax);          /* mov [ebp-0xc], ax */
            ii(0x1014_9d22, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9d25, 4);  mov(ax, memw[ds, eax + 24]);          /* mov ax, [eax+0x18] */
            ii(0x1014_9d29, 4);  mov(memw[ss, ebp - 10], ax);          /* mov [ebp-0xa], ax */
            ii(0x1014_9d2d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9d30, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1014_9d34, 2);  if(jz(0x1014_9d3f, 9)) goto l_0x1014_9d3f;/* jz 0x10149d3f */
            ii(0x1014_9d36, 7);  mov(memd[ss, ebp - 20], 0x40);        /* mov dword [ebp-0x14], 0x40 */
            ii(0x1014_9d3d, 2);  jmp(0x1014_9d46, 7); goto l_0x1014_9d46;/* jmp 0x10149d46 */
        l_0x1014_9d3f:
            ii(0x1014_9d3f, 7);  mov(memd[ss, ebp - 20], 0x20);        /* mov dword [ebp-0x14], 0x20 */
        l_0x1014_9d46:
            ii(0x1014_9d46, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_9d49, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_9d4c, 4);  movsx(ebx, memw[ss, ebp - 12]);       /* movsx ebx, word [ebp-0xc] */
            ii(0x1014_9d50, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_9d54, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9d57, 2);  sub(ebx, edx);                        /* sub ebx, edx */
            ii(0x1014_9d59, 6);  mov(memd[ds, eax + 181], ebx);        /* mov [eax+0xb5], ebx */
            ii(0x1014_9d5f, 4);  movsx(ebx, memw[ss, ebp - 10]);       /* movsx ebx, word [ebp-0xa] */
            ii(0x1014_9d63, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_9d67, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9d6a, 2);  sub(ebx, edx);                        /* sub ebx, edx */
            ii(0x1014_9d6c, 6);  mov(memd[ds, eax + 185], ebx);        /* mov [eax+0xb9], ebx */
            ii(0x1014_9d72, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1014_9d76, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_9d7a, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1014_9d7c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9d7f, 1);  dec(edx);                             /* dec edx */
            ii(0x1014_9d80, 6);  mov(memd[ds, eax + 189], edx);        /* mov [eax+0xbd], edx */
            ii(0x1014_9d86, 4);  movsx(edx, memw[ss, ebp - 10]);       /* movsx edx, word [ebp-0xa] */
            ii(0x1014_9d8a, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_9d8e, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1014_9d90, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9d93, 1);  dec(edx);                             /* dec edx */
            ii(0x1014_9d94, 6);  mov(memd[ds, eax + 193], edx);        /* mov [eax+0xc1], edx */
            ii(0x1014_9d9a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9d9d, 6);  mov(eax, memd[ds, eax + 211]);        /* mov eax, [eax+0xd3] */
            ii(0x1014_9da3, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_9da6, 1);  push(eax);                            /* push eax */
            ii(0x1014_9da7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_9daa, 3);  mov(ecx, memd[ds, eax + 39]);         /* mov ecx, [eax+0x27] */
            ii(0x1014_9dad, 4);  movsx(ebx, memw[ss, ebp - 10]);       /* movsx ebx, word [ebp-0xa] */
            ii(0x1014_9db1, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1014_9db5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9db8, 5);  add(eax, 0xb5);                       /* add eax, 0xb5 */
            ii(0x1014_9dbd, 5);  call(0x1014_9997, -0x42b);            /* call 0x10149997 */
            ii(0x1014_9dc2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9dc5, 4);  test(memb[ds, eax + 21], 0xa);        /* test byte [eax+0x15], 0xa */
            ii(0x1014_9dc9, 2);  if(jz(0x1014_9e07, 0x3c)) goto l_0x1014_9e07;/* jz 0x10149e07 */
            ii(0x1014_9dcb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9dce, 6);  mov(eax, memd[ds, eax + 213]);        /* mov eax, [eax+0xd5] */
            ii(0x1014_9dd4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_9dd7, 1);  push(eax);                            /* push eax */
            ii(0x1014_9dd8, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_9ddb, 3);  mov(ecx, memd[ds, eax + 39]);         /* mov ecx, [eax+0x27] */
            ii(0x1014_9dde, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9de1, 5);  movsx(ax, memb[ds, eax + 48]);        /* movsx ax, byte [eax+0x30] */
            ii(0x1014_9de6, 3);  add(eax, memd[ss, ebp - 10]);         /* add eax, [ebp-0xa] */
            ii(0x1014_9de9, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1014_9dec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9def, 5);  movsx(ax, memb[ds, eax + 47]);        /* movsx ax, byte [eax+0x2f] */
            ii(0x1014_9df4, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1014_9df7, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_9dfa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9dfd, 5);  add(eax, 0xb5);                       /* add eax, 0xb5 */
            ii(0x1014_9e02, 5);  call(0x1014_9997, -0x470);            /* call 0x10149997 */
        l_0x1014_9e07:
            ii(0x1014_9e07, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9e0a, 10);  mov(memd[ds, eax + 197], 0x7d00);    /* mov dword [eax+0xc5], 0x7d00 */
            ii(0x1014_9e14, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9e17, 10);  mov(memd[ds, eax + 205], 0xffff_8300);/* mov dword [eax+0xcd], 0xffff8300 */
            ii(0x1014_9e21, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9e24, 10);  mov(memd[ds, eax + 201], 0x7d00);    /* mov dword [eax+0xc9], 0x7d00 */
            ii(0x1014_9e2e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9e31, 10);  mov(memd[ds, eax + 209], 0xffff_8300);/* mov dword [eax+0xd1], 0xffff8300 */
            ii(0x1014_9e3b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_9e3e, 6);  add(edx, 0xd9);                       /* add edx, 0xd9 */
            ii(0x1014_9e44, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1014_9e47, 5);  call(0x1007_6a6c, -0xd_33e0);         /* call 0x10076a6c */
            ii(0x1014_9e4c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9e4f, 6);  mov(eax, memd[ds, eax + 211]);        /* mov eax, [eax+0xd3] */
            ii(0x1014_9e55, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_9e58, 1);  push(eax);                            /* push eax */
            ii(0x1014_9e59, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_9e5c, 3);  mov(ecx, memd[ds, eax + 43]);         /* mov ecx, [eax+0x2b] */
            ii(0x1014_9e5f, 4);  movsx(ebx, memw[ss, ebp - 10]);       /* movsx ebx, word [ebp-0xa] */
            ii(0x1014_9e63, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1014_9e67, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9e6a, 5);  add(eax, 0xc5);                       /* add eax, 0xc5 */
            ii(0x1014_9e6f, 5);  call(0x1014_9997, -0x4dd);            /* call 0x10149997 */
            ii(0x1014_9e74, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9e77, 4);  test(memb[ds, eax + 21], 0xa);        /* test byte [eax+0x15], 0xa */
            ii(0x1014_9e7b, 2);  if(jz(0x1014_9eb9, 0x3c)) goto l_0x1014_9eb9;/* jz 0x10149eb9 */
            ii(0x1014_9e7d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9e80, 6);  mov(eax, memd[ds, eax + 213]);        /* mov eax, [eax+0xd5] */
            ii(0x1014_9e86, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1014_9e89, 1);  push(eax);                            /* push eax */
            ii(0x1014_9e8a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_9e8d, 3);  mov(ecx, memd[ds, eax + 43]);         /* mov ecx, [eax+0x2b] */
            ii(0x1014_9e90, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9e93, 5);  movsx(ax, memb[ds, eax + 48]);        /* movsx ax, byte [eax+0x30] */
            ii(0x1014_9e98, 3);  add(eax, memd[ss, ebp - 10]);         /* add eax, [ebp-0xa] */
            ii(0x1014_9e9b, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1014_9e9e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9ea1, 5);  movsx(ax, memb[ds, eax + 47]);        /* movsx ax, byte [eax+0x2f] */
            ii(0x1014_9ea6, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1014_9ea9, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_9eac, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9eaf, 5);  add(eax, 0xc5);                       /* add eax, 0xc5 */
            ii(0x1014_9eb4, 5);  call(0x1014_9997, -0x522);            /* call 0x10149997 */
        l_0x1014_9eb9:
            ii(0x1014_9eb9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9ebc, 6);  mov(edx, memd[ds, eax + 197]);        /* mov edx, [eax+0xc5] */
            ii(0x1014_9ec2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9ec5, 6);  cmp(edx, memd[ds, eax + 205]);        /* cmp edx, [eax+0xcd] */
            ii(0x1014_9ecb, 2);  if(jg(0x1014_9ee1, 0x14)) goto l_0x1014_9ee1;/* jg 0x10149ee1 */
            ii(0x1014_9ecd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9ed0, 6);  mov(edx, memd[ds, eax + 201]);        /* mov edx, [eax+0xc9] */
            ii(0x1014_9ed6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9ed9, 6);  cmp(edx, memd[ds, eax + 209]);        /* cmp edx, [eax+0xd1] */
            ii(0x1014_9edf, 2);  if(jle(0x1014_9ee3, 2)) goto l_0x1014_9ee3;/* jle 0x10149ee3 */
        l_0x1014_9ee1:
            ii(0x1014_9ee1, 2);  jmp(0x1014_9efa, 0x17); goto l_0x1014_9efa;/* jmp 0x10149efa */
        l_0x1014_9ee3:
            ii(0x1014_9ee3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9ee6, 6);  mov(edx, memd[ds, eax + 197]);        /* mov edx, [eax+0xc5] */
            ii(0x1014_9eec, 3);  sub(edx, 0x10);                       /* sub edx, 0x10 */
            ii(0x1014_9eef, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9ef2, 6);  cmp(edx, memd[ds, eax + 181]);        /* cmp edx, [eax+0xb5] */
            ii(0x1014_9ef8, 2);  if(jge(0x1014_9efc, 2)) goto l_0x1014_9efc;/* jge 0x10149efc */
        l_0x1014_9efa:
            ii(0x1014_9efa, 2);  jmp(0x1014_9f17, 0x1b); goto l_0x1014_9f17;/* jmp 0x10149f17 */
        l_0x1014_9efc:
            ii(0x1014_9efc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9eff, 6);  mov(edx, memd[ds, eax + 201]);        /* mov edx, [eax+0xc9] */
            ii(0x1014_9f05, 3);  sub(edx, 0x10);                       /* sub edx, 0x10 */
            ii(0x1014_9f08, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f0b, 6);  cmp(edx, memd[ds, eax + 185]);        /* cmp edx, [eax+0xb9] */
            ii(0x1014_9f11, 6);  if(jge(0x1014_9f9f, 0x88)) goto l_0x1014_9f9f;/* jge 0x10149f9f */
        l_0x1014_9f17:
            ii(0x1014_9f17, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f1a, 6);  mov(edx, memd[ds, eax + 181]);        /* mov edx, [eax+0xb5] */
            ii(0x1014_9f20, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f23, 6);  mov(eax, memd[ds, eax + 197]);        /* mov eax, [eax+0xc5] */
            ii(0x1014_9f29, 5);  call(Definitions.my_min, -0xc_07aa);  /* call 0x10089784 */
            ii(0x1014_9f2e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_9f30, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f33, 6);  mov(memd[ds, eax + 197], edx);        /* mov [eax+0xc5], edx */
            ii(0x1014_9f39, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f3c, 6);  mov(edx, memd[ds, eax + 185]);        /* mov edx, [eax+0xb9] */
            ii(0x1014_9f42, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f45, 6);  mov(eax, memd[ds, eax + 201]);        /* mov eax, [eax+0xc9] */
            ii(0x1014_9f4b, 5);  call(Definitions.my_min, -0xc_07cc);  /* call 0x10089784 */
            ii(0x1014_9f50, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_9f52, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f55, 6);  mov(memd[ds, eax + 201], edx);        /* mov [eax+0xc9], edx */
            ii(0x1014_9f5b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f5e, 6);  mov(edx, memd[ds, eax + 189]);        /* mov edx, [eax+0xbd] */
            ii(0x1014_9f64, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f67, 6);  mov(eax, memd[ds, eax + 205]);        /* mov eax, [eax+0xcd] */
            ii(0x1014_9f6d, 5);  call(0x1007_6e7c, -0xd_30f6);         /* call 0x10076e7c */
            ii(0x1014_9f72, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_9f74, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f77, 6);  mov(memd[ds, eax + 205], edx);        /* mov [eax+0xcd], edx */
            ii(0x1014_9f7d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f80, 6);  mov(edx, memd[ds, eax + 193]);        /* mov edx, [eax+0xc1] */
            ii(0x1014_9f86, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f89, 6);  mov(eax, memd[ds, eax + 209]);        /* mov eax, [eax+0xd1] */
            ii(0x1014_9f8f, 5);  call(0x1007_6e7c, -0xd_3118);         /* call 0x10076e7c */
            ii(0x1014_9f94, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_9f96, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_9f99, 6);  mov(memd[ds, eax + 209], edx);        /* mov [eax+0xd1], edx */
        l_0x1014_9f9f:
            ii(0x1014_9f9f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_9fa1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_9fa2, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_9fa3, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_9fa4, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_9fa5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_9fa6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_9fa7, 1);  ret();                                /* ret */
        }
    }
}
