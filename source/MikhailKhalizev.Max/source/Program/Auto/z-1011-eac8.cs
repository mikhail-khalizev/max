using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_eac8-797397ae")]
        public void Method_1011_eac8()
        {
            ii(0x1011_eac8, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x1011_eacd, 5);  call(Definitions.sys_check_available_stack_size, 0x4_7280);/* call 0x10165d52 */
            ii(0x1011_ead2, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_ead3, 1);  push(esi);                            /* push esi */
            ii(0x1011_ead4, 1);  push(edi);                            /* push edi */
            ii(0x1011_ead5, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_ead6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_ead8, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x1011_eade, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_eae1, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_eae4, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1011_eae7, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1011_eae9, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_eaec, 3);  mov(al, memb[ds, edx + 38]);          /* mov al, [edx+0x26] */
            ii(0x1011_eaef, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_eaf2, 5);  mov(eax, 0x101c_8178);                /* mov eax, 0x101c8178 */
            ii(0x1011_eaf7, 5);  call(0x1007_6338, -0xa_87c4);         /* call 0x10076338 */
            ii(0x1011_eafc, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x1011_eaff, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_eb01, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1011_eb03, 5);  call(0x1007_64b8, -0xa_8650);         /* call 0x100764b8 */
            ii(0x1011_eb08, 2);  jmp(0x1011_eb12, 8); goto l_0x1011_eb12;/* jmp 0x1011eb12 */
        l_0x1011_eb0a:
            ii(0x1011_eb0a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eb0d, 5);  call(0x1007_6bf8, -0xa_7f1a);         /* call 0x10076bf8 */
        l_0x1011_eb12:
            ii(0x1011_eb12, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_eb14, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eb17, 5);  call(0x1013_ad71, 0x1_c255);          /* call 0x1013ad71 */
            ii(0x1011_eb1c, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_eb1e, 6);  if(jz(0x1011_ec9e, 0x17a)) goto l_0x1011_ec9e;/* jz 0x1011ec9e */
            ii(0x1011_eb24, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_eb28, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eb2b, 5);  call(0x1007_63a0, -0xa_8790);         /* call 0x100763a0 */
            ii(0x1011_eb30, 5);  call(0x1007_6074, -0xa_8ac1);         /* call 0x10076074 */
            ii(0x1011_eb35, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_eb37, 2);  if(jnz(0x1011_eb52, 0x19)) goto l_0x1011_eb52;/* jnz 0x1011eb52 */
            ii(0x1011_eb39, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_eb3d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eb40, 5);  call(0x1007_63a0, -0xa_87a5);         /* call 0x100763a0 */
            ii(0x1011_eb45, 5);  call(0x1007_6274, -0xa_88d6);         /* call 0x10076274 */
            ii(0x1011_eb4a, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_eb4c, 6);  if(jz(0x1011_ec99, 0x147)) goto l_0x1011_ec99;/* jz 0x1011ec99 */
        l_0x1011_eb52:
            ii(0x1011_eb52, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eb55, 5);  call(0x1007_63a0, -0xa_87ba);         /* call 0x100763a0 */
            ii(0x1011_eb5a, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1011_eb5e, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_eb61, 5);  jmp(0x1011_ec5e, 0xf8); goto l_0x1011_ec5e;/* jmp 0x1011ec5e */
        l_0x1011_eb66:
            ii(0x1011_eb66, 6);  test(memw[ss, ebp - 4], 1);           /* test word [ebp-0x4], 0x1 */
            ii(0x1011_eb6c, 2);  if(jz(0x1011_eb9b, 0x2d)) goto l_0x1011_eb9b;/* jz 0x1011eb9b */
            ii(0x1011_eb6e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eb71, 5);  call(0x1007_63a0, -0xa_87d6);         /* call 0x100763a0 */
            ii(0x1011_eb76, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1011_eb79, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_eb7c, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_eb7f, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_eb82, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_eb84, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eb87, 5);  call(0x1007_63a0, -0xa_87ec);         /* call 0x100763a0 */
            ii(0x1011_eb8c, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x1011_eb8f, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_eb92, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1011_eb94, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_eb96, 3);  mov(memb[ds, eax], 4);                /* mov byte [eax], 0x4 */
            ii(0x1011_eb99, 2);  jmp(0x1011_ebc6, 0x2b); goto l_0x1011_ebc6;/* jmp 0x1011ebc6 */
        l_0x1011_eb9b:
            ii(0x1011_eb9b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eb9e, 5);  call(0x1007_63a0, -0xa_8803);         /* call 0x100763a0 */
            ii(0x1011_eba3, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1011_eba6, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_eba9, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_ebac, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_ebaf, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_ebb1, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ebb4, 5);  call(0x1007_63a0, -0xa_8819);         /* call 0x100763a0 */
            ii(0x1011_ebb9, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x1011_ebbc, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_ebbf, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1011_ebc1, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_ebc3, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x1011_ebc6:
            ii(0x1011_ebc6, 5);  jmp(0x1011_ec99, 0xce); goto l_0x1011_ec99;/* jmp 0x1011ec99 */
        l_0x1011_ebcb:
            ii(0x1011_ebcb, 6);  test(memw[ss, ebp - 4], 1);           /* test word [ebp-0x4], 0x1 */
            ii(0x1011_ebd1, 2);  if(jz(0x1011_ebfe, 0x2b)) goto l_0x1011_ebfe;/* jz 0x1011ebfe */
            ii(0x1011_ebd3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ebd6, 5);  call(0x1007_63a0, -0xa_883b);         /* call 0x100763a0 */
            ii(0x1011_ebdb, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1011_ebde, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_ebe1, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_ebe4, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_ebe7, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_ebe9, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ebec, 5);  call(0x1007_63a0, -0xa_8851);         /* call 0x100763a0 */
            ii(0x1011_ebf1, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x1011_ebf4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_ebf7, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1011_ebf9, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_ebfb, 3);  mov(memb[ds, eax], 4);                /* mov byte [eax], 0x4 */
        l_0x1011_ebfe:
            ii(0x1011_ebfe, 5);  jmp(0x1011_ec99, 0x96); goto l_0x1011_ec99;/* jmp 0x1011ec99 */
        l_0x1011_ec03:
            ii(0x1011_ec03, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ec06, 5);  call(0x1007_63a0, -0xa_886b);         /* call 0x100763a0 */
            ii(0x1011_ec0b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_ec0d, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1011_ec10, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1011_ec14, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1011_ec16, 2);  if(jz(0x1011_ec2d, 0x15)) goto l_0x1011_ec2d;/* jz 0x1011ec2d */
            ii(0x1011_ec18, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_ec1c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ec1f, 5);  call(0x1007_63a0, -0xa_8884);         /* call 0x100763a0 */
            ii(0x1011_ec24, 5);  call(0x1007_6274, -0xa_89b5);         /* call 0x10076274 */
            ii(0x1011_ec29, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_ec2b, 2);  if(jnz(0x1011_ec2f, 2)) goto l_0x1011_ec2f;/* jnz 0x1011ec2f */
        l_0x1011_ec2d:
            ii(0x1011_ec2d, 2);  jmp(0x1011_ec5a, 0x2b); goto l_0x1011_ec5a;/* jmp 0x1011ec5a */
        l_0x1011_ec2f:
            ii(0x1011_ec2f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ec32, 5);  call(0x1007_63a0, -0xa_8897);         /* call 0x100763a0 */
            ii(0x1011_ec37, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1011_ec3a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_ec3d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_ec40, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_ec43, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_ec45, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ec48, 5);  call(0x1007_63a0, -0xa_88ad);         /* call 0x100763a0 */
            ii(0x1011_ec4d, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x1011_ec50, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_ec53, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1011_ec55, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_ec57, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x1011_ec5a:
            ii(0x1011_ec5a, 2);  jmp(0x1011_ec99, 0x3d); goto l_0x1011_ec99;/* jmp 0x1011ec99 */
        l_0x1011_ec5c:
            ii(0x1011_ec5c, 2);  jmp(0x1011_ec99, 0x3b); goto l_0x1011_ec99;/* jmp 0x1011ec99 */
        l_0x1011_ec5e:
            ii(0x1011_ec5e, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_ec61, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_ec64, 5);  cmp(memw[ss, ebp - 28], 0x27);        /* cmp word [ebp-0x1c], 0x27 */
            ii(0x1011_ec69, 2);  if(jb(0x1011_ec8c, 0x21)) goto l_0x1011_ec8c;/* jb 0x1011ec8c */
            ii(0x1011_ec6b, 5);  cmp(memw[ss, ebp - 28], 0x27);        /* cmp word [ebp-0x1c], 0x27 */
            ii(0x1011_ec70, 6);  if(jbe(0x1011_ebcb, -0xab)) goto l_0x1011_ebcb;/* jbe 0x1011ebcb */
            ii(0x1011_ec76, 5);  cmp(memw[ss, ebp - 28], 0x29);        /* cmp word [ebp-0x1c], 0x29 */
            ii(0x1011_ec7b, 2);  if(jb(0x1011_ec8a, 0xd)) goto l_0x1011_ec8a;/* jb 0x1011ec8a */
            ii(0x1011_ec7d, 5);  cmp(memw[ss, ebp - 28], 0x2a);        /* cmp word [ebp-0x1c], 0x2a */
            ii(0x1011_ec82, 6);  if(jbe(0x1011_ec03, -0x85)) goto l_0x1011_ec03;/* jbe 0x1011ec03 */
            ii(0x1011_ec88, 2);  jmp(0x1011_ec5c, -0x2e); goto l_0x1011_ec5c;/* jmp 0x1011ec5c */
        l_0x1011_ec8a:
            ii(0x1011_ec8a, 2);  jmp(0x1011_ec5c, -0x30); goto l_0x1011_ec5c;/* jmp 0x1011ec5c */
        l_0x1011_ec8c:
            ii(0x1011_ec8c, 5);  cmp(memw[ss, ebp - 28], 0x21);        /* cmp word [ebp-0x1c], 0x21 */
            ii(0x1011_ec91, 6);  if(jz(0x1011_eb66, -0x131)) goto l_0x1011_eb66;/* jz 0x1011eb66 */
            ii(0x1011_ec97, 2);  jmp(0x1011_ec5c, -0x3d); goto l_0x1011_ec5c;/* jmp 0x1011ec5c */
        l_0x1011_ec99:
            ii(0x1011_ec99, 5);  jmp(0x1011_eb0a, -0x194); goto l_0x1011_eb0a;/* jmp 0x1011eb0a */
        l_0x1011_ec9e:
            ii(0x1011_ec9e, 6);  test(memw[ss, ebp - 4], 1);           /* test word [ebp-0x4], 0x1 */
            ii(0x1011_eca4, 2);  if(jz(0x1011_ecb2, 0xc)) goto l_0x1011_ecb2;/* jz 0x1011ecb2 */
            ii(0x1011_eca6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_eca9, 5);  call(0x1008_aa4c, -0x9_4262);         /* call 0x1008aa4c */
            ii(0x1011_ecae, 2);  cmp(al, 2);                           /* cmp al, 0x2 */
            ii(0x1011_ecb0, 2);  if(jnz(0x1011_ecb4, 2)) goto l_0x1011_ecb4;/* jnz 0x1011ecb4 */
        l_0x1011_ecb2:
            ii(0x1011_ecb2, 2);  jmp(0x1011_ecc0, 0xc); goto l_0x1011_ecc0;/* jmp 0x1011ecc0 */
        l_0x1011_ecb4:
            ii(0x1011_ecb4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_ecb7, 5);  call(0x1008_aa4c, -0x9_4270);         /* call 0x1008aa4c */
            ii(0x1011_ecbc, 2);  cmp(al, 1);                           /* cmp al, 0x1 */
            ii(0x1011_ecbe, 2);  if(jnz(0x1011_ecc5, 5)) goto l_0x1011_ecc5;/* jnz 0x1011ecc5 */
        l_0x1011_ecc0:
            ii(0x1011_ecc0, 5);  jmp(0x1011_edf7, 0x132); goto l_0x1011_edf7;/* jmp 0x1011edf7 */
        l_0x1011_ecc5:
            ii(0x1011_ecc5, 5);  mov(eax, 0x101c_8178);                /* mov eax, 0x101c8178 */
            ii(0x1011_ecca, 5);  call(0x1007_6338, -0xa_8997);         /* call 0x10076338 */
            ii(0x1011_eccf, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x1011_ecd2, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_ecd4, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1011_ecd6, 5);  call(0x1007_643c, -0xa_889f);         /* call 0x1007643c */
            ii(0x1011_ecdb, 2);  jmp(0x1011_ece5, 8); goto l_0x1011_ece5;/* jmp 0x1011ece5 */
        l_0x1011_ecdd:
            ii(0x1011_ecdd, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ece0, 5);  call(0x1007_6bf8, -0xa_80ed);         /* call 0x10076bf8 */
        l_0x1011_ece5:
            ii(0x1011_ece5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_ece7, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ecea, 5);  call(0x1013_ad71, 0x1_c082);          /* call 0x1013ad71 */
            ii(0x1011_ecef, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_ecf1, 6);  if(jz(0x1011_edf7, 0x100)) goto l_0x1011_edf7;/* jz 0x1011edf7 */
            ii(0x1011_ecf7, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_ecfb, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ecfe, 5);  call(0x1007_63a0, -0xa_8963);         /* call 0x100763a0 */
            ii(0x1011_ed03, 5);  call(0x1007_6074, -0xa_8c94);         /* call 0x10076074 */
            ii(0x1011_ed08, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_ed0a, 2);  if(jnz(0x1011_ed25, 0x19)) goto l_0x1011_ed25;/* jnz 0x1011ed25 */
            ii(0x1011_ed0c, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_ed10, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ed13, 5);  call(0x1007_63a0, -0xa_8978);         /* call 0x100763a0 */
            ii(0x1011_ed18, 5);  call(0x1007_6274, -0xa_8aa9);         /* call 0x10076274 */
            ii(0x1011_ed1d, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_ed1f, 6);  if(jz(0x1011_edf2, 0xcd)) goto l_0x1011_edf2;/* jz 0x1011edf2 */
        l_0x1011_ed25:
            ii(0x1011_ed25, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ed28, 5);  call(0x1007_63a0, -0xa_898d);         /* call 0x100763a0 */
            ii(0x1011_ed2d, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1011_ed31, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_ed34, 5);  cmp(memw[ss, ebp - 32], 0x15);        /* cmp word [ebp-0x20], 0x15 */
            ii(0x1011_ed39, 2);  if(jz(0x1011_ed42, 7)) goto l_0x1011_ed42;/* jz 0x1011ed42 */
            ii(0x1011_ed3b, 5);  cmp(memw[ss, ebp - 32], 0x12);        /* cmp word [ebp-0x20], 0x12 */
            ii(0x1011_ed40, 2);  if(jnz(0x1011_ed44, 2)) goto l_0x1011_ed44;/* jnz 0x1011ed44 */
        l_0x1011_ed42:
            ii(0x1011_ed42, 2);  jmp(0x1011_ed4b, 7); goto l_0x1011_ed4b;/* jmp 0x1011ed4b */
        l_0x1011_ed44:
            ii(0x1011_ed44, 5);  cmp(memw[ss, ebp - 32], 0x11);        /* cmp word [ebp-0x20], 0x11 */
            ii(0x1011_ed49, 2);  if(jnz(0x1011_ed4d, 2)) goto l_0x1011_ed4d;/* jnz 0x1011ed4d */
        l_0x1011_ed4b:
            ii(0x1011_ed4b, 2);  jmp(0x1011_ed58, 0xb); goto l_0x1011_ed58;/* jmp 0x1011ed58 */
        l_0x1011_ed4d:
            ii(0x1011_ed4d, 5);  cmp(memw[ss, ebp - 32], 0x27);        /* cmp word [ebp-0x20], 0x27 */
            ii(0x1011_ed52, 6);  if(jnz(0x1011_edf2, 0x9a)) goto l_0x1011_edf2;/* jnz 0x1011edf2 */
        l_0x1011_ed58:
            ii(0x1011_ed58, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ed5b, 5);  call(0x1007_63a0, -0xa_89c0);         /* call 0x100763a0 */
            ii(0x1011_ed60, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1011_ed63, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_ed66, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_ed69, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_ed6c, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_ed6e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ed71, 5);  call(0x1007_63a0, -0xa_89d6);         /* call 0x100763a0 */
            ii(0x1011_ed76, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1011_ed79, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1011_ed7c, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x1011_ed7e, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1011_ed80, 3);  mov(memb[ds, eax], 2);                /* mov byte [eax], 0x2 */
            ii(0x1011_ed83, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ed86, 5);  call(0x1007_63a0, -0xa_89eb);         /* call 0x100763a0 */
            ii(0x1011_ed8b, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1011_ed8f, 2);  if(jz(0x1011_edf2, 0x61)) goto l_0x1011_edf2;/* jz 0x1011edf2 */
            ii(0x1011_ed91, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ed94, 5);  call(0x1007_63a0, -0xa_89f9);         /* call 0x100763a0 */
            ii(0x1011_ed99, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1011_ed9d, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_eda0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eda3, 5);  call(0x1007_63a0, -0xa_8a08);         /* call 0x100763a0 */
            ii(0x1011_eda8, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x1011_edac, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_edaf, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_edb3, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_edb6, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1011_edb9, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1011_edbd, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_edbf, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_edc1, 4);  mov(memb[ds, eax + 1], 2);            /* mov byte [eax+0x1], 0x2 */
            ii(0x1011_edc5, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_edc9, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_edcc, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1011_edcf, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1011_edd3, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_edd6, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_edd8, 3);  mov(memb[ds, eax], 2);                /* mov byte [eax], 0x2 */
            ii(0x1011_eddb, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_eddf, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_ede2, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1011_ede5, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1011_ede9, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_edec, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_edee, 4);  mov(memb[ds, eax + 1], 2);            /* mov byte [eax+0x1], 0x2 */
        l_0x1011_edf2:
            ii(0x1011_edf2, 5);  jmp(0x1011_ecdd, -0x11a); goto l_0x1011_ecdd;/* jmp 0x1011ecdd */
        l_0x1011_edf7:
            ii(0x1011_edf7, 5);  mov(eax, 0x101c_8178);                /* mov eax, 0x101c8178 */
            ii(0x1011_edfc, 5);  call(0x1007_6338, -0xa_8ac9);         /* call 0x10076338 */
            ii(0x1011_ee01, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x1011_ee04, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1011_ee06, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1011_ee08, 5);  call(0x1007_643c, -0xa_89d1);         /* call 0x1007643c */
            ii(0x1011_ee0d, 2);  jmp(0x1011_ee17, 8); goto l_0x1011_ee17;/* jmp 0x1011ee17 */
        l_0x1011_ee0f:
            ii(0x1011_ee0f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ee12, 5);  call(0x1007_6bf8, -0xa_821f);         /* call 0x10076bf8 */
        l_0x1011_ee17:
            ii(0x1011_ee17, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_ee19, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ee1c, 5);  call(0x1013_ad71, 0x1_bf50);          /* call 0x1013ad71 */
            ii(0x1011_ee21, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_ee23, 6);  if(jz(0x1011_ef17, 0xee)) goto l_0x1011_ef17;/* jz 0x1011ef17 */
            ii(0x1011_ee29, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_ee2d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ee30, 5);  call(0x1007_63a0, -0xa_8a95);         /* call 0x100763a0 */
            ii(0x1011_ee35, 5);  call(0x1007_6074, -0xa_8dc6);         /* call 0x10076074 */
            ii(0x1011_ee3a, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_ee3c, 2);  if(jnz(0x1011_ee57, 0x19)) goto l_0x1011_ee57;/* jnz 0x1011ee57 */
            ii(0x1011_ee3e, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1011_ee42, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ee45, 5);  call(0x1007_63a0, -0xa_8aaa);         /* call 0x100763a0 */
            ii(0x1011_ee4a, 5);  call(0x1007_6274, -0xa_8bdb);         /* call 0x10076274 */
            ii(0x1011_ee4f, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_ee51, 6);  if(jz(0x1011_ef12, 0xbb)) goto l_0x1011_ef12;/* jz 0x1011ef12 */
        l_0x1011_ee57:
            ii(0x1011_ee57, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ee5a, 5);  call(0x1007_63a0, -0xa_8abf);         /* call 0x100763a0 */
            ii(0x1011_ee5f, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1011_ee63, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_ee66, 5);  cmp(memw[ss, ebp - 32], 0xf);         /* cmp word [ebp-0x20], 0xf */
            ii(0x1011_ee6b, 2);  if(jz(0x1011_ee78, 0xb)) goto l_0x1011_ee78;/* jz 0x1011ee78 */
            ii(0x1011_ee6d, 5);  cmp(memw[ss, ebp - 32], 0x10);        /* cmp word [ebp-0x20], 0x10 */
            ii(0x1011_ee72, 6);  if(jnz(0x1011_ef12, 0x9a)) goto l_0x1011_ef12;/* jnz 0x1011ef12 */
        l_0x1011_ee78:
            ii(0x1011_ee78, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ee7b, 5);  call(0x1007_63a0, -0xa_8ae0);         /* call 0x100763a0 */
            ii(0x1011_ee80, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1011_ee83, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1011_ee86, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_ee89, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1011_ee8c, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1011_ee8e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ee91, 5);  call(0x1007_63a0, -0xa_8af6);         /* call 0x100763a0 */
            ii(0x1011_ee96, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1011_ee99, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1011_ee9c, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x1011_ee9e, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1011_eea0, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
            ii(0x1011_eea3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eea6, 5);  call(0x1007_63a0, -0xa_8b0b);         /* call 0x100763a0 */
            ii(0x1011_eeab, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1011_eeaf, 2);  if(jz(0x1011_ef12, 0x61)) goto l_0x1011_ef12;/* jz 0x1011ef12 */
            ii(0x1011_eeb1, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eeb4, 5);  call(0x1007_63a0, -0xa_8b19);         /* call 0x100763a0 */
            ii(0x1011_eeb9, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1011_eebd, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1011_eec0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_eec3, 5);  call(0x1007_63a0, -0xa_8b28);         /* call 0x100763a0 */
            ii(0x1011_eec8, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x1011_eecc, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1011_eecf, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_eed3, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_eed6, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1011_eed9, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1011_eedd, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1011_eedf, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_eee1, 4);  mov(memb[ds, eax + 1], 0);            /* mov byte [eax+0x1], 0x0 */
            ii(0x1011_eee5, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_eee9, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_eeec, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1011_eeef, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1011_eef3, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_eef6, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_eef8, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
            ii(0x1011_eefb, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1011_eeff, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1011_ef02, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1011_ef05, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1011_ef09, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1011_ef0c, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1011_ef0e, 4);  mov(memb[ds, eax + 1], 0);            /* mov byte [eax+0x1], 0x0 */
        l_0x1011_ef12:
            ii(0x1011_ef12, 5);  jmp(0x1011_ee0f, -0x108); goto l_0x1011_ee0f;/* jmp 0x1011ee0f */
        l_0x1011_ef17:
            ii(0x1011_ef17, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_ef19, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_ef1c, 5);  call(0x1007_5f6c, -0xa_8fb5);         /* call 0x10075f6c */
            ii(0x1011_ef21, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_ef23, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_ef24, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_ef25, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_ef26, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_ef27, 1);  ret();                                /* ret */
        }
    }
}
