using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_bdf9-d1429ce1")]
        public void Method_1012_bdf9()
        {
            ii(0x1012_bdf9, 5);  push(0x58);                           /* push 0x58 */
            ii(0x1012_bdfe, 5);  call(Definitions.sys_check_available_stack_size, 0x3_9f4f);/* call 0x10165d52 */
            ii(0x1012_be03, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_be04, 1);  push(esi);                            /* push esi */
            ii(0x1012_be05, 1);  push(edi);                            /* push edi */
            ii(0x1012_be06, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_be07, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_be09, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x1012_be0f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_be12, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1012_be15, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1012_be18, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_be1b, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1012_be1e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1012_be21, 5);  call(0x1007_1f2e, -0xb_9ef8);         /* call 0x10071f2e */
            ii(0x1012_be26, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_be29, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_be2d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_be2f, 2);  if(jz(0x1012_be44, 0x13)) goto l_0x1012_be44;/* jz 0x1012be44 */
            ii(0x1012_be31, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_be34, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_be36, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1012_be39, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_be3b, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1012_be40, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1012_be42, 2);  if(jz(0x1012_be46, 2)) goto l_0x1012_be46;/* jz 0x1012be46 */
        l_0x1012_be44:
            ii(0x1012_be44, 2);  jmp(0x1012_be59, 0x13); goto l_0x1012_be59;/* jmp 0x1012be59 */
        l_0x1012_be46:
            ii(0x1012_be46, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_be49, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1012_be4c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1012_be4f, 5);  call(0x1007_1ff5, -0xb_9e5f);         /* call 0x10071ff5 */
            ii(0x1012_be54, 1);  cwde();                               /* cwde */
            ii(0x1012_be55, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_be57, 2);  if(jz(0x1012_be5e, 5)) goto l_0x1012_be5e;/* jz 0x1012be5e */
        l_0x1012_be59:
            ii(0x1012_be59, 5);  jmp(0x1012_c081, 0x223); goto l_0x1012_c081;/* jmp 0x1012c081 */
        l_0x1012_be5e:
            ii(0x1012_be5e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_be61, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_be64, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1012_be6b, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1012_be72, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1012_be75, 5);  call(0x1007_20b1, -0xb_9dc9);         /* call 0x100720b1 */
            ii(0x1012_be7a, 5);  call(0x1007_6014, -0xb_5e6b);         /* call 0x10076014 */
            ii(0x1012_be7f, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1012_be81, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1012_be83, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x1012_be86, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_be89, 5);  call(0x1007_2388, -0xb_9b06);         /* call 0x10072388 */
            ii(0x1012_be8e, 3);  mov(eax, memd[ss, ebp - 34]);         /* mov eax, [ebp-0x22] */
            ii(0x1012_be91, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_be94, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_be98, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_be9a, 2);  if(jge(0x1012_bed4, 0x38)) goto l_0x1012_bed4;/* jge 0x1012bed4 */
            ii(0x1012_be9c, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_be9e, 1);  push(eax);                            /* push eax */
            ii(0x1012_be9f, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1012_bea4, 1);  push(eax);                            /* push eax */
            ii(0x1012_bea5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_bea8, 2);  neg(eax);                             /* neg eax */
            ii(0x1012_beaa, 1);  cwde();                               /* cwde */
            ii(0x1012_beab, 1);  push(eax);                            /* push eax */
            ii(0x1012_beac, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1012_beb0, 1);  push(eax);                            /* push eax */
            ii(0x1012_beb1, 5);  mov(eax, 0x291);                      /* mov eax, 0x291 */
            ii(0x1012_beb6, 1);  push(eax);                            /* push eax */
            ii(0x1012_beb7, 5);  mov(eax, 0x290);                      /* mov eax, 0x290 */
            ii(0x1012_bebc, 1);  push(eax);                            /* push eax */
            ii(0x1012_bebd, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1012_bec2, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1012_bec5, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_bec8, 5);  mov(eax, StringDefinitions.Power7);   /* mov eax, 0x101a86dd */
            ii(0x1012_becd, 5);  call(0x1012_bd39, -0x199);            /* call 0x1012bd39 */
            ii(0x1012_bed2, 2);  jmp(0x1012_bf0a, 0x36); goto l_0x1012_bf0a;/* jmp 0x1012bf0a */
        l_0x1012_bed4:
            ii(0x1012_bed4, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_bed6, 1);  push(eax);                            /* push eax */
            ii(0x1012_bed7, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1012_bedc, 1);  push(eax);                            /* push eax */
            ii(0x1012_bedd, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_bee1, 1);  push(eax);                            /* push eax */
            ii(0x1012_bee2, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_bee5, 2);  neg(eax);                             /* neg eax */
            ii(0x1012_bee7, 1);  cwde();                               /* cwde */
            ii(0x1012_bee8, 1);  push(eax);                            /* push eax */
            ii(0x1012_bee9, 5);  mov(eax, 0x291);                      /* mov eax, 0x291 */
            ii(0x1012_beee, 1);  push(eax);                            /* push eax */
            ii(0x1012_beef, 5);  mov(eax, 0x290);                      /* mov eax, 0x290 */
            ii(0x1012_bef4, 1);  push(eax);                            /* push eax */
            ii(0x1012_bef5, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1012_befa, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1012_befd, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_bf00, 5);  mov(eax, StringDefinitions.Usage6);   /* mov eax, 0x101a86e3 */
            ii(0x1012_bf05, 5);  call(0x1012_bd39, -0x1d1);            /* call 0x1012bd39 */
        l_0x1012_bf0a:
            ii(0x1012_bf0a, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_bf11, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_bf18, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1012_bf1d, 5);  call(0x1007_6338, -0xb_5bea);         /* call 0x10076338 */
            ii(0x1012_bf22, 3);  lea(ebx, memd[ss, ebp - 44]);         /* lea ebx, [ebp-0x2c] */
            ii(0x1012_bf25, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_bf27, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1012_bf29, 5);  call(0x1007_64b8, -0xb_5a76);         /* call 0x100764b8 */
            ii(0x1012_bf2e, 2);  jmp(0x1012_bf38, 8); goto l_0x1012_bf38;/* jmp 0x1012bf38 */
        l_0x1012_bf30:
            ii(0x1012_bf30, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1012_bf33, 5);  call(0x1007_6bf8, -0xb_5340);         /* call 0x10076bf8 */
        l_0x1012_bf38:
            ii(0x1012_bf38, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_bf3a, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1012_bf3d, 5);  call(0x1013_ad71, 0xee2f);            /* call 0x1013ad71 */
            ii(0x1012_bf42, 2);  test(al, al);                         /* test al, al */
            ii(0x1012_bf44, 6);  if(jz(0x1012_bfc6, 0x7c)) goto l_0x1012_bfc6;/* jz 0x1012bfc6 */
            ii(0x1012_bf4a, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1012_bf4d, 5);  call(0x1007_63a0, -0xb_5bb2);         /* call 0x100763a0 */
            ii(0x1012_bf52, 5);  call(0x1007_6204, -0xb_5d53);         /* call 0x10076204 */
            ii(0x1012_bf57, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_bf59, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_bf5c, 5);  call(0x1007_6204, -0xb_5d5d);         /* call 0x10076204 */
            ii(0x1012_bf61, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1012_bf63, 2);  if(jnz(0x1012_bfc1, 0x5c)) goto l_0x1012_bfc1;/* jnz 0x1012bfc1 */
            ii(0x1012_bf65, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1012_bf68, 5);  call(0x1007_63a0, -0xb_5bcd);         /* call 0x100763a0 */
            ii(0x1012_bf6d, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1012_bf70, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1012_bf73, 5);  call(0x1007_1f2e, -0xb_a04a);         /* call 0x10071f2e */
            ii(0x1012_bf78, 4);  mov(memw[ss, ebp - 34], ax);          /* mov [ebp-0x22], ax */
            ii(0x1012_bf7c, 4);  movsx(eax, memw[ss, ebp - 34]);       /* movsx eax, word [ebp-0x22] */
            ii(0x1012_bf80, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_bf82, 2);  if(jge(0x1012_bf8c, 8)) goto l_0x1012_bf8c;/* jge 0x1012bf8c */
            ii(0x1012_bf84, 3);  mov(eax, memd[ss, ebp - 34]);         /* mov eax, [ebp-0x22] */
            ii(0x1012_bf87, 3);  sub(memd[ss, ebp - 16], eax);         /* sub [ebp-0x10], eax */
            ii(0x1012_bf8a, 2);  jmp(0x1012_bf92, 6); goto l_0x1012_bf92;/* jmp 0x1012bf92 */
        l_0x1012_bf8c:
            ii(0x1012_bf8c, 3);  mov(eax, memd[ss, ebp - 34]);         /* mov eax, [ebp-0x22] */
            ii(0x1012_bf8f, 3);  add(memd[ss, ebp - 20], eax);         /* add [ebp-0x14], eax */
        l_0x1012_bf92:
            ii(0x1012_bf92, 5);  call(0x1007_6014, -0xb_5f83);         /* call 0x10076014 */
            ii(0x1012_bf97, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1012_bf99, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1012_bf9b, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x1012_bf9e, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1012_bfa1, 5);  call(0x1007_63d4, -0xb_5bd2);         /* call 0x100763d4 */
            ii(0x1012_bfa6, 5);  call(0x1007_2388, -0xb_9c23);         /* call 0x10072388 */
            ii(0x1012_bfab, 4);  movsx(eax, memw[ss, ebp - 34]);       /* movsx eax, word [ebp-0x22] */
            ii(0x1012_bfaf, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_bfb1, 2);  if(jge(0x1012_bfbb, 8)) goto l_0x1012_bfbb;/* jge 0x1012bfbb */
            ii(0x1012_bfb3, 3);  mov(eax, memd[ss, ebp - 34]);         /* mov eax, [ebp-0x22] */
            ii(0x1012_bfb6, 3);  sub(memd[ss, ebp - 28], eax);         /* sub [ebp-0x1c], eax */
            ii(0x1012_bfb9, 2);  jmp(0x1012_bfc1, 6); goto l_0x1012_bfc1;/* jmp 0x1012bfc1 */
        l_0x1012_bfbb:
            ii(0x1012_bfbb, 3);  mov(eax, memd[ss, ebp - 34]);         /* mov eax, [ebp-0x22] */
            ii(0x1012_bfbe, 3);  add(memd[ss, ebp - 24], eax);         /* add [ebp-0x18], eax */
        l_0x1012_bfc1:
            ii(0x1012_bfc1, 5);  jmp(0x1012_bf30, -0x96); goto l_0x1012_bf30;/* jmp 0x1012bf30 */
        l_0x1012_bfc6:
            ii(0x1012_bfc6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_bfc9, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1012_bfcc, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1012_bfcf, 5);  call(0x1007_1f2e, -0xb_a0a6);         /* call 0x10071f2e */
            ii(0x1012_bfd4, 1);  cwde();                               /* cwde */
            ii(0x1012_bfd5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_bfd7, 2);  if(jle(0x1012_c00f, 0x36)) goto l_0x1012_c00f;/* jle 0x1012c00f */
            ii(0x1012_bfd9, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_bfdb, 1);  push(eax);                            /* push eax */
            ii(0x1012_bfdc, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1012_bfe1, 1);  push(eax);                            /* push eax */
            ii(0x1012_bfe2, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_bfe6, 1);  push(eax);                            /* push eax */
            ii(0x1012_bfe7, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_bfeb, 1);  push(eax);                            /* push eax */
            ii(0x1012_bfec, 5);  mov(eax, 0x291);                      /* mov eax, 0x291 */
            ii(0x1012_bff1, 1);  push(eax);                            /* push eax */
            ii(0x1012_bff2, 5);  mov(eax, 0x290);                      /* mov eax, 0x290 */
            ii(0x1012_bff7, 1);  push(eax);                            /* push eax */
            ii(0x1012_bff8, 5);  mov(ecx, 2);                          /* mov ecx, 0x2 */
            ii(0x1012_bffd, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1012_c000, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_c003, 5);  mov(eax, StringDefinitions.Total7);   /* mov eax, 0x101a86e9 */
            ii(0x1012_c008, 5);  call(0x1012_bd39, -0x2d4);            /* call 0x1012bd39 */
            ii(0x1012_c00d, 2);  jmp(0x1012_c077, 0x68); goto l_0x1012_c077;/* jmp 0x1012c077 */
        l_0x1012_c00f:
            ii(0x1012_c00f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_c011, 1);  push(eax);                            /* push eax */
            ii(0x1012_c012, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1012_c017, 1);  push(eax);                            /* push eax */
            ii(0x1012_c018, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_c01c, 1);  push(eax);                            /* push eax */
            ii(0x1012_c01d, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1012_c021, 1);  push(eax);                            /* push eax */
            ii(0x1012_c022, 5);  mov(eax, 0x291);                      /* mov eax, 0x291 */
            ii(0x1012_c027, 1);  push(eax);                            /* push eax */
            ii(0x1012_c028, 5);  mov(eax, 0x290);                      /* mov eax, 0x290 */
            ii(0x1012_c02d, 1);  push(eax);                            /* push eax */
            ii(0x1012_c02e, 5);  mov(ecx, 2);                          /* mov ecx, 0x2 */
            ii(0x1012_c033, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1012_c036, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_c039, 5);  mov(eax, StringDefinitions.Total8);   /* mov eax, 0x101a86ef */
            ii(0x1012_c03e, 5);  call(0x1012_bd39, -0x30a);            /* call 0x1012bd39 */
            ii(0x1012_c043, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_c045, 1);  push(eax);                            /* push eax */
            ii(0x1012_c046, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1012_c04b, 1);  push(eax);                            /* push eax */
            ii(0x1012_c04c, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_c050, 1);  push(eax);                            /* push eax */
            ii(0x1012_c051, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1012_c055, 1);  push(eax);                            /* push eax */
            ii(0x1012_c056, 5);  mov(eax, 0x291);                      /* mov eax, 0x291 */
            ii(0x1012_c05b, 1);  push(eax);                            /* push eax */
            ii(0x1012_c05c, 5);  mov(eax, 0x290);                      /* mov eax, 0x290 */
            ii(0x1012_c061, 1);  push(eax);                            /* push eax */
            ii(0x1012_c062, 5);  mov(ecx, 3);                          /* mov ecx, 0x3 */
            ii(0x1012_c067, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1012_c06a, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_c06d, 5);  mov(eax, StringDefinitions.Usage5);   /* mov eax, 0x101a86f5 */
            ii(0x1012_c072, 5);  call(0x1012_bd39, -0x33e);            /* call 0x1012bd39 */
        l_0x1012_c077:
            ii(0x1012_c077, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_c079, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1012_c07c, 5);  call(0x1007_5f6c, -0xb_6115);         /* call 0x10075f6c */
        l_0x1012_c081:
            ii(0x1012_c081, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_c083, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_c084, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_c085, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_c086, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_c087, 1);  ret();                                /* ret */
        }
    }
}
