using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_eac5-22d500cb")]
        public void Method_1010_eac5()
        {
            ii(0x1010_eac5, 5);  push(0x64);                           /* push 0x64 */
            ii(0x1010_eaca, 5);  call(Definitions.sys_check_available_stack_size, 0x5_7283);/* call 0x10165d52 */
            ii(0x1010_eacf, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_ead0, 1);  push(esi);                            /* push esi */
            ii(0x1010_ead1, 1);  push(edi);                            /* push edi */
            ii(0x1010_ead2, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_ead3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_ead5, 6);  sub(esp, 0x40);                       /* sub esp, 0x40 */
            ii(0x1010_eadb, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_eade, 3);  mov(memb[ss, ebp - 8], dl);           /* mov [ebp-0x8], dl */
            ii(0x1010_eae1, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1010_eae4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_eae7, 3);  mov(al, memb[ds, eax + 20]);          /* mov al, [eax+0x14] */
            ii(0x1010_eaea, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_eaef, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1010_eaf2, 2);  if(jnz(0x1010_eb15, 0x21)) goto l_0x1010_eb15;/* jnz 0x1010eb15 */
            ii(0x1010_eaf4, 4);  cmp(memb[ss, ebp - 8], 9);            /* cmp byte [ebp-0x8], 0x9 */
            ii(0x1010_eaf8, 2);  if(jz(0x1010_eb00, 6)) goto l_0x1010_eb00;/* jz 0x1010eb00 */
            ii(0x1010_eafa, 4);  cmp(memb[ss, ebp - 8], 0xb);          /* cmp byte [ebp-0x8], 0xb */
            ii(0x1010_eafe, 2);  if(jnz(0x1010_eb02, 2)) goto l_0x1010_eb02;/* jnz 0x1010eb02 */
        l_0x1010_eb00:
            ii(0x1010_eb00, 2);  jmp(0x1010_eb10, 0xe); goto l_0x1010_eb10;/* jmp 0x1010eb10 */
        l_0x1010_eb02:
            ii(0x1010_eb02, 4);  cmp(memb[ss, ebp - 8], 3);            /* cmp byte [ebp-0x8], 0x3 */
            ii(0x1010_eb06, 2);  if(jl(0x1010_eb0e, 6)) goto l_0x1010_eb0e;/* jl 0x1010eb0e */
            ii(0x1010_eb08, 4);  cmp(memb[ss, ebp - 8], 6);            /* cmp byte [ebp-0x8], 0x6 */
            ii(0x1010_eb0c, 2);  if(jle(0x1010_eb10, 2)) goto l_0x1010_eb10;/* jle 0x1010eb10 */
        l_0x1010_eb0e:
            ii(0x1010_eb0e, 2);  jmp(0x1010_eb15, 5); goto l_0x1010_eb15;/* jmp 0x1010eb15 */
        l_0x1010_eb10:
            ii(0x1010_eb10, 5);  jmp(0x1010_ed9f, 0x28a); goto l_0x1010_ed9f;/* jmp 0x1010ed9f */
        l_0x1010_eb15:
            ii(0x1010_eb15, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_eb18, 3);  mov(al, memb[ds, eax + 20]);          /* mov al, [eax+0x14] */
            ii(0x1010_eb1b, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_eb20, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1010_eb23, 2);  if(jnz(0x1010_eb36, 0x11)) goto l_0x1010_eb36;/* jnz 0x1010eb36 */
            ii(0x1010_eb25, 4);  cmp(memb[ss, ebp - 8], 0xa);          /* cmp byte [ebp-0x8], 0xa */
            ii(0x1010_eb29, 2);  if(jz(0x1010_eb31, 6)) goto l_0x1010_eb31;/* jz 0x1010eb31 */
            ii(0x1010_eb2b, 4);  cmp(memb[ss, ebp - 8], 0xc);          /* cmp byte [ebp-0x8], 0xc */
            ii(0x1010_eb2f, 2);  if(jnz(0x1010_eb36, 5)) goto l_0x1010_eb36;/* jnz 0x1010eb36 */
        l_0x1010_eb31:
            ii(0x1010_eb31, 5);  jmp(0x1010_ed9f, 0x269); goto l_0x1010_ed9f;/* jmp 0x1010ed9f */
        l_0x1010_eb36:
            ii(0x1010_eb36, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_eb3a, 3);  imul(eax, eax, 0x18);                 /* imul eax, eax, 0x18 */
            ii(0x1010_eb3d, 5);  mov(edx, 0x101b_abec);                /* mov edx, 0x101babec */
            ii(0x1010_eb42, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_eb44, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x1010_eb47, 4);  cmp(memb[ss, ebp - 8], 7);            /* cmp byte [ebp-0x8], 0x7 */
            ii(0x1010_eb4b, 2);  if(jl(0x1010_eb59, 0xc)) goto l_0x1010_eb59;/* jl 0x1010eb59 */
            ii(0x1010_eb4d, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1010_eb52, 5);  call(/* sys */ 0x1016_a24c, 0x5_b6f5);/* call 0x1016a24c */
            ii(0x1010_eb57, 2);  jmp(0x1010_eb63, 0xa); goto l_0x1010_eb63;/* jmp 0x1010eb63 */
        l_0x1010_eb59:
            ii(0x1010_eb59, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1010_eb5e, 5);  call(/* sys */ 0x1016_a24c, 0x5_b6e9);/* call 0x1016a24c */
        l_0x1010_eb63:
            ii(0x1010_eb63, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_eb66, 5);  cmp(memw[ds, eax + 8], -1 /* 0xff */);/* cmp word [eax+0x8], 0xffff */
            ii(0x1010_eb6b, 6);  if(jnz(0x1010_ebe8, 0x77)) goto l_0x1010_ebe8;/* jnz 0x1010ebe8 */
            ii(0x1010_eb71, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1010_eb76, 5);  call(Definitions.sys_new, 0x5_7285);  /* call 0x10165e00 */
            ii(0x1010_eb7b, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_eb7e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_eb81, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_eb84, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1010_eb88, 2);  if(jz(0x1010_ebcb, 0x41)) goto l_0x1010_ebcb;/* jz 0x1010ebcb */
            ii(0x1010_eb8a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_eb8d, 4);  mov(ax, memw[ds, eax + 6]);           /* mov ax, [eax+0x6] */
            ii(0x1010_eb91, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1010_eb94, 4);  sub(ax, memw[ds, edx + 2]);           /* sub ax, [edx+0x2] */
            ii(0x1010_eb98, 1);  cwde();                               /* cwde */
            ii(0x1010_eb99, 1);  push(eax);                            /* push eax */
            ii(0x1010_eb9a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_eb9d, 4);  mov(ax, memw[ds, eax + 4]);           /* mov ax, [eax+0x4] */
            ii(0x1010_eba1, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1010_eba4, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x1010_eba7, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1010_ebaa, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_ebad, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x1010_ebaf, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1010_ebb2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_ebb5, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1010_ebb8, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_ebbb, 5);  call(0x100c_e39d, -0x4_0823);         /* call 0x100ce39d */
            ii(0x1010_ebc0, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_ebc3, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_ebc6, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_ebc9, 2);  jmp(0x1010_ebd1, 6); goto l_0x1010_ebd1;/* jmp 0x1010ebd1 */
        l_0x1010_ebcb:
            ii(0x1010_ebcb, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_ebce, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x1010_ebd1:
            ii(0x1010_ebd1, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ebd5, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_ebd8, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_ebdb, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_ebdd, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_ebe0, 3);  mov(memd[ds, edx + 25], eax);         /* mov [edx+0x19], eax */
            ii(0x1010_ebe3, 5);  jmp(0x1010_eca2, 0xba); goto l_0x1010_eca2;/* jmp 0x1010eca2 */
        l_0x1010_ebe8:
            ii(0x1010_ebe8, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x1010_ebed, 5);  call(Definitions.sys_new, 0x5_720e);  /* call 0x10165e00 */
            ii(0x1010_ebf2, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_ebf5, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_ebf8, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1010_ebfb, 4);  cmp(memd[ss, ebp - 40], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1010_ebff, 2);  if(jz(0x1010_ec37, 0x36)) goto l_0x1010_ec37;/* jz 0x1010ec37 */
            ii(0x1010_ec01, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_ec04, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_ec06, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_ec09, 1);  push(eax);                            /* push eax */
            ii(0x1010_ec0a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_ec0d, 3);  movsx(ecx, memw[ds, eax]);            /* movsx ecx, word [eax] */
            ii(0x1010_ec10, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_ec13, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1010_ec17, 1);  inc(eax);                             /* inc eax */
            ii(0x1010_ec18, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1010_ec1b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_ec1e, 3);  mov(edx, memd[ds, eax + 6]);          /* mov edx, [eax+0x6] */
            ii(0x1010_ec21, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_ec24, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_ec27, 5);  call(Definitions.my_ctor_c17, -0x4_081d);/* call 0x100ce40f */
            ii(0x1010_ec2c, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1010_ec2f, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1010_ec32, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1010_ec35, 2);  jmp(0x1010_ec3d, 6); goto l_0x1010_ec3d;/* jmp 0x1010ec3d */
        l_0x1010_ec37:
            ii(0x1010_ec37, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_ec3a, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
        l_0x1010_ec3d:
            ii(0x1010_ec3d, 4);  movsx(edx, memb[ss, ebp - 8]);        /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_ec41, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1010_ec44, 3);  add(edx, memd[ss, ebp - 12]);         /* add edx, [ebp-0xc] */
            ii(0x1010_ec47, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1010_ec4a, 3);  mov(memd[ds, edx + 25], eax);         /* mov [edx+0x19], eax */
            ii(0x1010_ec4d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_ec50, 4);  cmp(memd[ds, eax + 10], 0);           /* cmp dword [eax+0xa], 0x0 */
            ii(0x1010_ec54, 2);  if(jz(0x1010_eca2, 0x4c)) goto l_0x1010_eca2;/* jz 0x1010eca2 */
            ii(0x1010_ec56, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1010_ec59, 5);  call(0x100d_5224, -0x3_9a3a);         /* call 0x100d5224 */
            ii(0x1010_ec5e, 1);  push(eax);                            /* push eax */
            ii(0x1010_ec5f, 3);  lea(eax, memd[ss, ebp - 56]);         /* lea eax, [ebp-0x38] */
            ii(0x1010_ec62, 5);  call(0x100d_5250, -0x3_9a17);         /* call 0x100d5250 */
            ii(0x1010_ec67, 1);  push(eax);                            /* push eax */
            ii(0x1010_ec68, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x1010_ec6b, 5);  call(0x100d_527c, -0x3_99f4);         /* call 0x100d527c */
            ii(0x1010_ec70, 1);  push(eax);                            /* push eax */
            ii(0x1010_ec71, 3);  lea(eax, memd[ss, ebp - 64]);         /* lea eax, [ebp-0x40] */
            ii(0x1010_ec74, 5);  call(0x100d_52a8, -0x3_99d1);         /* call 0x100d52a8 */
            ii(0x1010_ec79, 1);  push(eax);                            /* push eax */
            ii(0x1010_ec7a, 5);  call(0x100d_52d4, -0x3_99ab);         /* call 0x100d52d4 */
            ii(0x1010_ec7f, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1010_ec82, 5);  call(0x100d_52f8, -0x3_998f);         /* call 0x100d52f8 */
            ii(0x1010_ec87, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1010_ec8a, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_ec8d, 3);  mov(edx, memd[ds, eax + 10]);         /* mov edx, [eax+0xa] */
            ii(0x1010_ec90, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ec94, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_ec97, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1010_ec9a, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1010_ec9d, 5);  call(0x100c_ef64, -0x3_fd3e);         /* call 0x100cef64 */
        l_0x1010_eca2:
            ii(0x1010_eca2, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_eca6, 2);  if(jz(0x1010_ecdd, 0x35)) goto l_0x1010_ecdd;/* jz 0x1010ecdd */
            ii(0x1010_eca8, 5);  mov(edx, 5);                          /* mov edx, 0x5 */
            ii(0x1010_ecad, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ecb1, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_ecb4, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1010_ecb7, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1010_ecba, 5);  call(0x100d_5194, -0x3_9b2b);         /* call 0x100d5194 */
            ii(0x1010_ecbf, 4);  movsx(edx, memb[ss, ebp - 8]);        /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_ecc3, 6);  add(edx, 0x3e8);                      /* add edx, 0x3e8 */
            ii(0x1010_ecc9, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_eccd, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_ecd0, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1010_ecd3, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1010_ecd6, 5);  call(0x100d_5164, -0x3_9b77);         /* call 0x100d5164 */
            ii(0x1010_ecdb, 2);  jmp(0x1010_ed29, 0x4c); goto l_0x1010_ed29;/* jmp 0x1010ed29 */
        l_0x1010_ecdd:
            ii(0x1010_ecdd, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_ecdf, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ece3, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_ece6, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1010_ece9, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1010_ecec, 5);  call(0x100d_5194, -0x3_9b5d);         /* call 0x100d5194 */
            ii(0x1010_ecf1, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ecf5, 6);  lea(edx, memd[ds, eax + 1000]);       /* lea edx, [eax+0x3e8] */
            ii(0x1010_ecfb, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ecff, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_ed02, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1010_ed05, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1010_ed08, 5);  call(0x100d_5134, -0x3_9bd9);         /* call 0x100d5134 */
            ii(0x1010_ed0d, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ed11, 6);  lea(edx, memd[ds, eax + 0x7000]);     /* lea edx, [eax+0x7000] */
            ii(0x1010_ed17, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ed1b, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_ed1e, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1010_ed21, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1010_ed24, 5);  call(0x100d_5164, -0x3_9bc5);         /* call 0x100d5164 */
        l_0x1010_ed29:
            ii(0x1010_ed29, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_ed2c, 3);  mov(edx, memd[ds, eax + 20]);         /* mov edx, [eax+0x14] */
            ii(0x1010_ed2f, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_ed32, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ed36, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_ed39, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1010_ed3c, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1010_ed3f, 5);  call(0x100d_50d4, -0x3_9c70);         /* call 0x100d50d4 */
            ii(0x1010_ed44, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_ed47, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_ed49, 3);  mov(edx, memd[ds, eax + 18]);         /* mov edx, [eax+0x12] */
            ii(0x1010_ed4c, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ed50, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_ed53, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1010_ed56, 3);  mov(eax, memd[ds, eax + 25]);         /* mov eax, [eax+0x19] */
            ii(0x1010_ed59, 5);  call(0x100c_f85c, -0x3_f502);         /* call 0x100cf85c */
            ii(0x1010_ed5e, 4);  movsx(edx, memb[ss, ebp - 8]);        /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_ed62, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ed66, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1010_ed69, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1010_ed6c, 6);  add(edx, 0x3e8);                      /* add edx, 0x3e8 */
            ii(0x1010_ed72, 3);  mov(memd[ds, eax + 77], edx);         /* mov [eax+0x4d], edx */
            ii(0x1010_ed75, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ed79, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1010_ed7c, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_ed7f, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_ed81, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_ed84, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x1010_ed87, 3);  mov(memd[ds, edx + 81], eax);         /* mov [edx+0x51], eax */
            ii(0x1010_ed8a, 4);  movsx(eax, memb[ss, ebp - 8]);        /* movsx eax, byte [ebp-0x8] */
            ii(0x1010_ed8e, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1010_ed91, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_ed94, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_ed96, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_ed99, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1010_ed9c, 3);  mov(memd[ds, edx + 85], eax);         /* mov [edx+0x55], eax */
        l_0x1010_ed9f:
            ii(0x1010_ed9f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_eda1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_eda2, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_eda3, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_eda4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_eda5, 1);  ret();                                /* ret */
        }
    }
}
