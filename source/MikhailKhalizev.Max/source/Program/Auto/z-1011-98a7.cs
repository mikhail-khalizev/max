using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_98a7-f6dde70f")]
        public void Method_1011_98a7()
        {
            ii(0x1011_98a7, 5);  push(0x50);                           /* push 0x50 */
            ii(0x1011_98ac, 5);  call(Definitions.sys_check_available_stack_size, 0x4_c4a1);/* call 0x10165d52 */
            ii(0x1011_98b1, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_98b2, 1);  push(esi);                            /* push esi */
            ii(0x1011_98b3, 1);  push(edi);                            /* push edi */
            ii(0x1011_98b4, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_98b5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_98b7, 6);  sub(esp, 0x38);                       /* sub esp, 0x38 */
            ii(0x1011_98bd, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_98c0, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_98c3, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1011_98c6, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_98c9, 3);  mov(edx, memd[ds, edx + 20]);         /* mov edx, [edx+0x14] */
            ii(0x1011_98cc, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_98cf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_98d2, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_98d4, 3);  mov(bl, memb[ds, eax + 42]);          /* mov bl, [eax+0x2a] */
            ii(0x1011_98d7, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_98d9, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_98dc, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1011_98de, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_98e1, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_98e5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1011_98e7, 6);  if(jz(0x1011_9a87, 0x19a)) goto l_0x1011_9a87;/* jz 0x10119a87 */
            ii(0x1011_98ed, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_98f0, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1011_98f4, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_98f7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_98fa, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x1011_98fe, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_9901, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1011_9904, 3);  shl(eax, 6);                          /* shl eax, 0x6 */
            ii(0x1011_9907, 5);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1011_990c, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_990f, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_9912, 3);  shl(eax, 6);                          /* shl eax, 0x6 */
            ii(0x1011_9915, 5);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1011_991a, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_991d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9920, 3);  mov(eax, memd[ds, eax + 29]);         /* mov eax, [eax+0x1d] */
            ii(0x1011_9923, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_9926, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9929, 3);  mov(eax, memd[ds, eax + 33]);         /* mov eax, [eax+0x21] */
            ii(0x1011_992c, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1011_992f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_9931, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_9934, 3);  mov(al, memb[ds, edx + 78]);          /* mov al, [edx+0x4e] */
            ii(0x1011_9937, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_993a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_993d, 4);  cmp(memb[ds, eax + 79], 0);           /* cmp byte [eax+0x4f], 0x0 */
            ii(0x1011_9941, 2);  if(jz(0x1011_994f, 0xc)) goto l_0x1011_994f;/* jz 0x1011994f */
            ii(0x1011_9943, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_9946, 3);  mov(al, memb[ds, eax + 79]);          /* mov al, [eax+0x4f] */
            ii(0x1011_9949, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_994b, 1);  dec(eax);                             /* dec eax */
            ii(0x1011_994c, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x1011_994f:
            ii(0x1011_994f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_9952, 5);  call(0x1007_623c, -0xa_371b);         /* call 0x1007623c */
            ii(0x1011_9957, 4);  mov(ax, memw[ds, eax + 16]);          /* mov ax, [eax+0x10] */
            ii(0x1011_995b, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_995e, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1011_9965, 2);  jmp(0x1011_996d, 6); goto l_0x1011_996d;/* jmp 0x1011996d */
        l_0x1011_9967:
            ii(0x1011_9967, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_996a, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1011_996d:
            ii(0x1011_996d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_9970, 4);  cmp(ax, memw[ss, ebp - 36]);          /* cmp ax, [ebp-0x24] */
            ii(0x1011_9974, 6);  if(jg(0x1011_9a87, 0x10d)) goto l_0x1011_9a87;/* jg 0x10119a87 */
            ii(0x1011_997a, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_997e, 6);  cmp(eax, memd[ds, 0x101c_38f4]);      /* cmp eax, [0x101c38f4] */
            ii(0x1011_9984, 2);  if(jge(0x1011_9992, 0xc)) goto l_0x1011_9992;/* jge 0x10119992 */
            ii(0x1011_9986, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1011_998a, 6);  cmp(eax, memd[ds, 0x101c_38ec]);      /* cmp eax, [0x101c38ec] */
            ii(0x1011_9990, 2);  if(jg(0x1011_9994, 2)) goto l_0x1011_9994;/* jg 0x10119994 */
        l_0x1011_9992:
            ii(0x1011_9992, 2);  jmp(0x1011_99a0, 0xc); goto l_0x1011_99a0;/* jmp 0x101199a0 */
        l_0x1011_9994:
            ii(0x1011_9994, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1011_9998, 6);  cmp(eax, memd[ds, 0x101c_38f8]);      /* cmp eax, [0x101c38f8] */
            ii(0x1011_999e, 2);  if(jl(0x1011_99a2, 2)) goto l_0x1011_99a2;/* jl 0x101199a2 */
        l_0x1011_99a0:
            ii(0x1011_99a0, 2);  jmp(0x1011_99ae, 0xc); goto l_0x1011_99ae;/* jmp 0x101199ae */
        l_0x1011_99a2:
            ii(0x1011_99a2, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1011_99a6, 6);  cmp(eax, memd[ds, 0x101c_38f0]);      /* cmp eax, [0x101c38f0] */
            ii(0x1011_99ac, 2);  if(jg(0x1011_99b0, 2)) goto l_0x1011_99b0;/* jg 0x101199b0 */
        l_0x1011_99ae:
            ii(0x1011_99ae, 2);  jmp(0x1011_9a23, 0x73); goto l_0x1011_9a23;/* jmp 0x10119a23 */
        l_0x1011_99b0:
            ii(0x1011_99b0, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1011_99b4, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x1011_99b7, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_99b9, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_99bc, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x1011_99c2, 6);  mov(edx, memd[ds, 0x101c_38fa]);      /* mov edx, [0x101c38fa] */
            ii(0x1011_99c8, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_99cb, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1011_99cd, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1011_99d0, 4);  movsx(edx, memw[ss, ebp - 28]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1011_99d4, 3);  shl(edx, 0x10);                       /* shl edx, 0x10 */
            ii(0x1011_99d7, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1011_99d9, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1011_99dc, 6);  idiv(memd[ds, 0x101c_38c4]);          /* idiv dword [0x101c38c4] */
            ii(0x1011_99e2, 6);  mov(edx, memd[ds, 0x101c_38fc]);      /* mov edx, [0x101c38fc] */
            ii(0x1011_99e8, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_99eb, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1011_99ed, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1011_99f0, 5);  cmp(memw[ss, ebp - 24], 0);           /* cmp word [ebp-0x18], 0x0 */
            ii(0x1011_99f5, 2);  if(jz(0x1011_99fd, 6)) goto l_0x1011_99fd;/* jz 0x101199fd */
            ii(0x1011_99f7, 4);  mov(memb[ss, ebp - 48], 3);           /* mov byte [ebp-0x30], 0x3 */
            ii(0x1011_99fb, 2);  jmp(0x1011_9a01, 4); goto l_0x1011_9a01;/* jmp 0x10119a01 */
        l_0x1011_99fd:
            ii(0x1011_99fd, 4);  mov(memb[ss, ebp - 48], 2);           /* mov byte [ebp-0x30], 0x2 */
        l_0x1011_9a01:
            ii(0x1011_9a01, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_9a03, 3);  mov(al, memb[ss, ebp - 48]);          /* mov al, [ebp-0x30] */
            ii(0x1011_9a06, 1);  cwde();                               /* cwde */
            ii(0x1011_9a07, 1);  push(eax);                            /* push eax */
            ii(0x1011_9a08, 4);  movsx(ecx, memw[ss, ebp - 56]);       /* movsx ecx, word [ebp-0x38] */
            ii(0x1011_9a0c, 4);  movsx(ebx, memw[ss, ebp - 52]);       /* movsx ebx, word [ebp-0x34] */
            ii(0x1011_9a10, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9a13, 3);  mov(al, memb[ds, eax + 24]);          /* mov al, [eax+0x18] */
            ii(0x1011_9a16, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1011_9a18, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1011_9a1b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_9a1e, 5);  call(0x1011_94ea, -0x539);            /* call 0x101194ea */
        l_0x1011_9a23:
            ii(0x1011_9a23, 5);  cmp(memw[ss, ebp - 24], 0);           /* cmp word [ebp-0x18], 0x0 */
            ii(0x1011_9a28, 2);  if(jnz(0x1011_9a30, 6)) goto l_0x1011_9a30;/* jnz 0x10119a30 */
            ii(0x1011_9a2a, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_9a2d, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x1011_9a30:
            ii(0x1011_9a30, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_9a33, 3);  dec(memd[ss, ebp - 24]);              /* dec dword [ebp-0x18] */
            ii(0x1011_9a36, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_9a39, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_9a3b, 3);  mov(dl, memb[ds, eax + 42]);          /* mov dl, [eax+0x2a] */
            ii(0x1011_9a3e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9a41, 4);  imul(edx, memd[ds, eax + 37]);        /* imul edx, [eax+0x25] */
            ii(0x1011_9a45, 3);  add(memd[ss, ebp - 40], edx);         /* add [ebp-0x28], edx */
            ii(0x1011_9a48, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_9a4b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_9a4d, 3);  mov(dl, memb[ds, eax + 42]);          /* mov dl, [eax+0x2a] */
            ii(0x1011_9a50, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9a53, 4);  imul(edx, memd[ds, eax + 41]);        /* imul edx, [eax+0x29] */
            ii(0x1011_9a57, 3);  add(memd[ss, ebp - 44], edx);         /* add [ebp-0x2c], edx */
            ii(0x1011_9a5a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9a5d, 3);  mov(edx, memd[ds, eax + 23]);         /* mov edx, [eax+0x17] */
            ii(0x1011_9a60, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_9a63, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1011_9a66, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_9a69, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_9a6b, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_9a6e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_9a71, 3);  mov(edx, memd[ds, eax + 25]);         /* mov edx, [eax+0x19] */
            ii(0x1011_9a74, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1011_9a77, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1011_9a7a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_9a7d, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_9a7f, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_9a82, 5);  jmp(0x1011_9967, -0x120); goto l_0x1011_9967;/* jmp 0x10119967 */
        l_0x1011_9a87:
            ii(0x1011_9a87, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_9a89, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_9a8a, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_9a8b, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_9a8c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_9a8d, 1);  ret();                                /* ret */
        }
    }
}
