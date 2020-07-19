using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_fbb7-93716a00")]
        public void Method_100a_fbb7()
        {
            ii(0x100a_fbb7, 5);  push(0x60);                           /* push 0x60 */
            ii(0x100a_fbbc, 5);  call(Definitions.sys_check_available_stack_size, 0xb_6191);/* call 0x10165d52 */
            ii(0x100a_fbc1, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_fbc2, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_fbc3, 1);  push(esi);                            /* push esi */
            ii(0x100a_fbc4, 1);  push(edi);                            /* push edi */
            ii(0x100a_fbc5, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_fbc6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_fbc8, 6);  sub(esp, 0x44);                       /* sub esp, 0x44 */
            ii(0x100a_fbce, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_fbd1, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_fbd4, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_fbd7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fbda, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_fbdd, 5);  call(0x1007_6574, -0x3_966e);         /* call 0x10076574 */
            ii(0x100a_fbe2, 5);  call(0x1015_2a52, 0xa_2e6b);          /* call 0x10152a52 */
            ii(0x100a_fbe7, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_fbe9, 2);  if(jz(0x100a_fbf1, 6)) goto l_0x100a_fbf1;/* jz 0x100afbf1 */
            ii(0x100a_fbeb, 4);  cmp(memd[ss, ebp - 4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_fbef, 2);  if(jnz(0x100a_fbf3, 2)) goto l_0x100a_fbf3;/* jnz 0x100afbf3 */
        l_0x100a_fbf1:
            ii(0x100a_fbf1, 2);  jmp(0x100a_fc15, 0x22); goto l_0x100a_fc15;/* jmp 0x100afc15 */
        l_0x100a_fbf3:
            ii(0x100a_fbf3, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100a_fbf5, 5);  mov(al, memb[ds, 0x101c_37c9]);       /* mov al, [0x101c37c9] */
            ii(0x100a_fbfa, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_fbfc, 2);  if(jnz(0x100a_fc13, 0x15)) goto l_0x100a_fc13;/* jnz 0x100afc13 */
            ii(0x100a_fbfe, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fc01, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x100a_fc04, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_fc07, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_fc09, 6);  mov(dl, memb[ds, 0x101c_37c8]);       /* mov dl, [0x101c37c8] */
            ii(0x100a_fc0f, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100a_fc11, 2);  if(jnz(0x100a_fc15, 2)) goto l_0x100a_fc15;/* jnz 0x100afc15 */
        l_0x100a_fc13:
            ii(0x100a_fc13, 2);  jmp(0x100a_fc1a, 5); goto l_0x100a_fc1a;/* jmp 0x100afc1a */
        l_0x100a_fc15:
            ii(0x100a_fc15, 5);  jmp(0x100a_ff7c, 0x362); goto l_0x100a_ff7c;/* jmp 0x100aff7c */
        l_0x100a_fc1a:
            ii(0x100a_fc1a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fc1d, 4);  cmp(memb[ds, eax + 25], 0);           /* cmp byte [eax+0x19], 0x0 */
            ii(0x100a_fc21, 2);  if(jle(0x100a_fc47, 0x24)) goto l_0x100a_fc47;/* jle 0x100afc47 */
            ii(0x100a_fc23, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_fc26, 3);  add(edx, 0x1a);                       /* add edx, 0x1a */
            ii(0x100a_fc29, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100a_fc2c, 5);  call(0x1007_5e64, -0x3_9dcd);         /* call 0x10075e64 */
            ii(0x100a_fc31, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_fc33, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fc36, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_fc39, 5);  call(0x1007_65d0, -0x3_966e);         /* call 0x100765d0 */
            ii(0x100a_fc3e, 5);  call(0x100a_b5f3, -0x4650);           /* call 0x100ab5f3 */
            ii(0x100a_fc43, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_fc45, 2);  if(jnz(0x100a_fc4c, 5)) goto l_0x100a_fc4c;/* jnz 0x100afc4c */
        l_0x100a_fc47:
            ii(0x100a_fc47, 5);  jmp(0x100a_fed8, 0x28c); goto l_0x100a_fed8;/* jmp 0x100afed8 */
        l_0x100a_fc4c:
            ii(0x100a_fc4c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fc4f, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_fc52, 5);  call(0x1007_6574, -0x3_96e3);         /* call 0x10076574 */
            ii(0x100a_fc57, 5);  call(0x1007_623c, -0x3_9a20);         /* call 0x1007623c */
            ii(0x100a_fc5c, 4);  mov(ax, memw[ds, eax + 20]);          /* mov ax, [eax+0x14] */
            ii(0x100a_fc60, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_fc63, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fc66, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_fc69, 5);  call(0x1007_6574, -0x3_96fa);         /* call 0x10076574 */
            ii(0x100a_fc6e, 5);  call(0x1007_623c, -0x3_9a37);         /* call 0x1007623c */
            ii(0x100a_fc73, 4);  mov(ax, memw[ds, eax + 16]);          /* mov ax, [eax+0x10] */
            ii(0x100a_fc77, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_fc7a, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100a_fc7e, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100a_fc82, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100a_fc84, 4);  movsx(ebx, memw[ss, ebp - 16]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x100a_fc88, 1);  dec(edx);                             /* dec edx */
            ii(0x100a_fc89, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100a_fc8b, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100a_fc8e, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100a_fc90, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_fc93, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fc96, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_fc99, 5);  call(0x1007_6574, -0x3_972a);         /* call 0x10076574 */
            ii(0x100a_fc9e, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x100a_fca1, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x100a_fca3, 3);  sub(eax, memd[ss, ebp - 24]);         /* sub eax, [ebp-0x18] */
            ii(0x100a_fca6, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100a_fca9, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_fcac, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fcaf, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_fcb2, 5);  call(0x1007_6574, -0x3_9743);         /* call 0x10076574 */
            ii(0x100a_fcb7, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x100a_fcba, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100a_fcbd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fcc0, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_fcc3, 5);  call(0x1007_6574, -0x3_9754);         /* call 0x10076574 */
            ii(0x100a_fcc8, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x100a_fccb, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100a_fcce, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100a_fcd1, 5);  call(0x1007_6aac, -0x3_922a);         /* call 0x10076aac */
            ii(0x100a_fcd6, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x100a_fcd9, 5);  call(Definitions.my_ctor_0x101b_4184, -0x3_91ee);/* call 0x10076af0 */
            ii(0x100a_fcde, 7);  mov(memd[ss, ebp - 40], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x100a_fce5, 3);  lea(edx, memd[ss, ebp - 44]);         /* lea edx, [ebp-0x2c] */
            ii(0x100a_fce8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_fceb, 5);  call(0x100b_8204, 0x8514);            /* call 0x100b8204 */
            ii(0x100a_fcf0, 7);  mov(memd[ss, ebp - 48], 0);           /* mov dword [ebp-0x30], 0x0 */
        l_0x100a_fcf7:
            ii(0x100a_fcf7, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100a_fcfa, 5);  call(0x100b_82bc, 0x85bd);            /* call 0x100b82bc */
            ii(0x100a_fcff, 4);  cmp(ax, memw[ss, ebp - 48]);          /* cmp ax, [ebp-0x30] */
            ii(0x100a_fd03, 6);  if(jle(0x100a_fdc1, 0xb8)) goto l_0x100a_fdc1;/* jle 0x100afdc1 */
            ii(0x100a_fd09, 4);  movsx(edx, memw[ss, ebp - 48]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100a_fd0d, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100a_fd10, 5);  call(0x100b_827c, 0x8567);            /* call 0x100b827c */
            ii(0x100a_fd15, 4);  movsx(ax, memb[ds, eax]);             /* movsx ax, byte [eax] */
            ii(0x100a_fd19, 3);  mov(edx, memd[ss, ebp - 32]);         /* mov edx, [ebp-0x20] */
            ii(0x100a_fd1c, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100a_fd1e, 4);  mov(memw[ss, ebp - 36], dx);          /* mov [ebp-0x24], dx */
            ii(0x100a_fd22, 4);  movsx(edx, memw[ss, ebp - 48]);       /* movsx edx, word [ebp-0x30] */
            ii(0x100a_fd26, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100a_fd29, 5);  call(0x100b_827c, 0x854e);            /* call 0x100b827c */
            ii(0x100a_fd2e, 5);  movsx(ax, memb[ds, eax + 1]);         /* movsx ax, byte [eax+0x1] */
            ii(0x100a_fd33, 3);  mov(edx, memd[ss, ebp - 30]);         /* mov edx, [ebp-0x1e] */
            ii(0x100a_fd36, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100a_fd38, 4);  mov(memw[ss, ebp - 34], dx);          /* mov [ebp-0x22], dx */
            ii(0x100a_fd3c, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x100a_fd41, 1);  push(eax);                            /* push eax */
            ii(0x100a_fd42, 4);  movsx(ecx, memw[ss, ebp - 34]);       /* movsx ecx, word [ebp-0x22] */
            ii(0x100a_fd46, 4);  movsx(ebx, memw[ss, ebp - 36]);       /* movsx ebx, word [ebp-0x24] */
            ii(0x100a_fd4a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fd4d, 3);  mov(edx, memd[ds, eax + 7]);          /* mov edx, [eax+0x7] */
            ii(0x100a_fd50, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100a_fd53, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fd56, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_fd59, 5);  call(0x1007_6574, -0x3_97ea);         /* call 0x10076574 */
            ii(0x100a_fd5e, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100a_fd61, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_fd64, 5);  call(0x1007_02b9, -0x3_fab0);         /* call 0x100702b9 */
            ii(0x100a_fd69, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100a_fd6c, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100a_fd6f, 4);  cmp(ax, memw[ss, ebp - 32]);          /* cmp ax, [ebp-0x20] */
            ii(0x100a_fd73, 2);  if(jz(0x100a_fd7e, 9)) goto l_0x100a_fd7e;/* jz 0x100afd7e */
            ii(0x100a_fd75, 3);  mov(eax, memd[ss, ebp - 34]);         /* mov eax, [ebp-0x22] */
            ii(0x100a_fd78, 4);  cmp(ax, memw[ss, ebp - 30]);          /* cmp ax, [ebp-0x1e] */
            ii(0x100a_fd7c, 2);  if(jnz(0x100a_fd80, 2)) goto l_0x100a_fd80;/* jnz 0x100afd80 */
        l_0x100a_fd7e:
            ii(0x100a_fd7e, 2);  jmp(0x100a_fd93, 0x13); goto l_0x100a_fd93;/* jmp 0x100afd93 */
        l_0x100a_fd80:
            ii(0x100a_fd80, 4);  movsx(edx, memw[ss, ebp - 40]);       /* movsx edx, word [ebp-0x28] */
            ii(0x100a_fd84, 3);  lea(edx, memd[ds, edx + edx * 2]);    /* lea edx, [edx+edx*2] */
            ii(0x100a_fd87, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100a_fd89, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100a_fd8c, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100a_fd8e, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100a_fd90, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
        l_0x100a_fd93:
            ii(0x100a_fd93, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x100a_fd96, 3);  sub(memd[ss, ebp - 28], eax);         /* sub [ebp-0x1c], eax */
            ii(0x100a_fd99, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100a_fd9d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_fd9f, 2);  if(jz(0x100a_fda9, 8)) goto l_0x100a_fda9;/* jz 0x100afda9 */
            ii(0x100a_fda1, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100a_fda5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_fda7, 2);  if(jge(0x100a_fdab, 2)) goto l_0x100a_fdab;/* jge 0x100afdab */
        l_0x100a_fda9:
            ii(0x100a_fda9, 2);  jmp(0x100a_fdc1, 0x16); goto l_0x100a_fdc1;/* jmp 0x100afdc1 */
        l_0x100a_fdab:
            ii(0x100a_fdab, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x100a_fdae, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100a_fdb1, 5);  call(0x1008_8b44, -0x2_7272);         /* call 0x10088b44 */
            ii(0x100a_fdb6, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x100a_fdb9, 3);  inc(memd[ss, ebp - 48]);              /* inc dword [ebp-0x30] */
            ii(0x100a_fdbc, 5);  jmp(0x100a_fcf7, -0xca); goto l_0x100a_fcf7;/* jmp 0x100afcf7 */
        l_0x100a_fdc1:
            ii(0x100a_fdc1, 4);  movsx(eax, memw[ss, ebp - 48]);       /* movsx eax, word [ebp-0x30] */
            ii(0x100a_fdc5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_fdc7, 6);  if(jle(0x100a_fea4, 0xd7)) goto l_0x100a_fea4;/* jle 0x100afea4 */
            ii(0x100a_fdcd, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_fdd0, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_fdd3, 4);  cmp(ax, memw[ds, edx + 26]);          /* cmp ax, [edx+0x1a] */
            ii(0x100a_fdd7, 2);  if(jnz(0x100a_fde5, 0xc)) goto l_0x100a_fde5;/* jnz 0x100afde5 */
            ii(0x100a_fdd9, 3);  mov(eax, memd[ss, ebp - 30]);         /* mov eax, [ebp-0x1e] */
            ii(0x100a_fddc, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_fddf, 4);  cmp(ax, memw[ds, edx + 28]);          /* cmp ax, [edx+0x1c] */
            ii(0x100a_fde3, 2);  if(jz(0x100a_fdf6, 0x11)) goto l_0x100a_fdf6;/* jz 0x100afdf6 */
        l_0x100a_fde5:
            ii(0x100a_fde5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fde8, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_fdeb, 5);  call(0x1007_6574, -0x3_987c);         /* call 0x10076574 */
            ii(0x100a_fdf0, 4);  test(memb[ds, eax + 18], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x100a_fdf4, 2);  if(jz(0x100a_fdf8, 2)) goto l_0x100a_fdf8;/* jz 0x100afdf8 */
        l_0x100a_fdf6:
            ii(0x100a_fdf6, 2);  jmp(0x100a_fe06, 0xe); goto l_0x100a_fe06;/* jmp 0x100afe06 */
        l_0x100a_fdf8:
            ii(0x100a_fdf8, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100a_fdfb, 5);  call(0x100b_82bc, 0x84bc);            /* call 0x100b82bc */
            ii(0x100a_fe00, 4);  cmp(ax, memw[ss, ebp - 48]);          /* cmp ax, [ebp-0x30] */
            ii(0x100a_fe04, 2);  if(jg(0x100a_fe0b, 5)) goto l_0x100a_fe0b;/* jg 0x100afe0b */
        l_0x100a_fe06:
            ii(0x100a_fe06, 5);  jmp(0x100a_fe94, 0x89); goto l_0x100a_fe94;/* jmp 0x100afe94 */
        l_0x100a_fe0b:
            ii(0x100a_fe0b, 5);  mov(eax, 0x1c);                       /* mov eax, 0x1c */
            ii(0x100a_fe10, 5);  call(Definitions.sys_new, 0xb_5feb);  /* call 0x10165e00 */
            ii(0x100a_fe15, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x100a_fe18, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100a_fe1b, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x100a_fe1e, 4);  cmp(memd[ss, ebp - 56], 0);           /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100a_fe22, 2);  if(jz(0x100a_fe3f, 0x1b)) goto l_0x100a_fe3f;/* jz 0x100afe3f */
            ii(0x100a_fe24, 4);  movsx(ebx, memw[ss, ebp - 30]);       /* movsx ebx, word [ebp-0x1e] */
            ii(0x100a_fe28, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x100a_fe2c, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100a_fe2f, 5);  call(Definitions.my_ctor_c20, 0x6_a122);/* call 0x10119f56 */
            ii(0x100a_fe34, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100a_fe37, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x100a_fe3a, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x100a_fe3d, 2);  jmp(0x100a_fe45, 6); goto l_0x100a_fe45;/* jmp 0x100afe45 */
        l_0x100a_fe3f:
            ii(0x100a_fe3f, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x100a_fe42, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
        l_0x100a_fe45:
            ii(0x100a_fe45, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x100a_fe48, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_fe4b, 7);  mov(memd[ss, ebp - 68], 0);           /* mov dword [ebp-0x44], 0x0 */
            ii(0x100a_fe52, 2);  jmp(0x100a_fe5a, 6); goto l_0x100a_fe5a;/* jmp 0x100afe5a */
        l_0x100a_fe54:
            ii(0x100a_fe54, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x100a_fe57, 3);  inc(memd[ss, ebp - 68]);              /* inc dword [ebp-0x44] */
        l_0x100a_fe5a:
            ii(0x100a_fe5a, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x100a_fe5d, 4);  cmp(ax, memw[ss, ebp - 48]);          /* cmp ax, [ebp-0x30] */
            ii(0x100a_fe61, 2);  if(jg(0x100a_fe94, 0x31)) goto l_0x100a_fe94;/* jg 0x100afe94 */
            ii(0x100a_fe63, 4);  movsx(edx, memw[ss, ebp - 68]);       /* movsx edx, word [ebp-0x44] */
            ii(0x100a_fe67, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100a_fe6a, 5);  call(0x100b_827c, 0x840d);            /* call 0x100b827c */
            ii(0x100a_fe6f, 5);  movsx(ax, memb[ds, eax + 1]);         /* movsx ax, byte [eax+0x1] */
            ii(0x100a_fe74, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100a_fe77, 4);  movsx(edx, memw[ss, ebp - 68]);       /* movsx edx, word [ebp-0x44] */
            ii(0x100a_fe7b, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100a_fe7e, 5);  call(0x100b_827c, 0x83f9);            /* call 0x100b827c */
            ii(0x100a_fe83, 4);  movsx(ax, memb[ds, eax]);             /* movsx ax, byte [eax] */
            ii(0x100a_fe87, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100a_fe8a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_fe8d, 5);  call(0x1011_aca3, 0x6_ae11);          /* call 0x1011aca3 */
            ii(0x100a_fe92, 2);  jmp(0x100a_fe54, -0x40); goto l_0x100a_fe54;/* jmp 0x100afe54 */
        l_0x100a_fe94:
            ii(0x100a_fe94, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x100a_fe97, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fe9a, 3);  add(eax, 0x1a);                       /* add eax, 0x1a */
            ii(0x100a_fe9d, 5);  call(0x1008_8b44, -0x2_735e);         /* call 0x10088b44 */
            ii(0x100a_fea2, 2);  jmp(0x100a_fece, 0x2a); goto l_0x100a_fece;/* jmp 0x100afece */
        l_0x100a_fea4:
            ii(0x100a_fea4, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100a_fea8, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_feaa, 2);  if(jz(0x100a_fece, 0x22)) goto l_0x100a_fece;/* jz 0x100afece */
            ii(0x100a_feac, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_feaf, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_feb2, 5);  call(0x1007_6574, -0x3_9943);         /* call 0x10076574 */
            ii(0x100a_feb7, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_feb9, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x100a_febc, 3);  mov(memb[ds, edx + 78], al);          /* mov [edx+0x4e], al */
            ii(0x100a_febf, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_fec1, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100a_fec4, 5);  call(0x100b_7294, 0x73cb);            /* call 0x100b7294 */
            ii(0x100a_fec9, 5);  jmp(0x100a_ff7c, 0xae); goto l_0x100a_ff7c;/* jmp 0x100aff7c */
        l_0x100a_fece:
            ii(0x100a_fece, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_fed0, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100a_fed3, 5);  call(0x100b_7294, 0x73bc);            /* call 0x100b7294 */
        l_0x100a_fed8:
            ii(0x100a_fed8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fedb, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_fede, 5);  call(0x1007_6574, -0x3_996f);         /* call 0x10076574 */
            ii(0x100a_fee3, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_fee6, 4);  mov(dx, memw[ds, edx + 26]);          /* mov dx, [edx+0x1a] */
            ii(0x100a_feea, 4);  mov(memw[ds, eax + 65], dx);          /* mov [eax+0x41], dx */
            ii(0x100a_feee, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_fef1, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_fef4, 5);  call(0x1007_6574, -0x3_9985);         /* call 0x10076574 */
            ii(0x100a_fef9, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_fefc, 4);  mov(dx, memw[ds, edx + 28]);          /* mov dx, [edx+0x1c] */
            ii(0x100a_ff00, 4);  mov(memw[ds, eax + 67], dx);          /* mov [eax+0x43], dx */
            ii(0x100a_ff04, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ff07, 4);  mov(memb[ds, eax + 70], 1);           /* mov byte [eax+0x46], 0x1 */
            ii(0x100a_ff0b, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100a_ff0d, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100a_ff12, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ff15, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_ff18, 5);  call(0x1007_6574, -0x3_99a9);         /* call 0x10076574 */
            ii(0x100a_ff1d, 5);  call(0x100a_b120, -0x4e02);           /* call 0x100ab120 */
            ii(0x100a_ff22, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ff25, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_ff28, 5);  call(0x1007_6574, -0x3_99b9);         /* call 0x10076574 */
            ii(0x100a_ff2d, 4);  test(memb[ds, eax + 18], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x100a_ff31, 2);  if(jz(0x100a_ff4c, 0x19)) goto l_0x100a_ff4c;/* jz 0x100aff4c */
            ii(0x100a_ff33, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100a_ff35, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x100a_ff3a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ff3d, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_ff40, 5);  call(0x1007_65d0, -0x3_9975);         /* call 0x100765d0 */
            ii(0x100a_ff45, 5);  call(0x1016_3053, 0xb_3109);          /* call 0x10163053 */
            ii(0x100a_ff4a, 2);  jmp(0x100a_ff7c, 0x30); goto l_0x100a_ff7c;/* jmp 0x100aff7c */
        l_0x100a_ff4c:
            ii(0x100a_ff4c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_ff4f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ff52, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_ff55, 5);  call(0x1007_6574, -0x3_99e6);         /* call 0x10076574 */
            ii(0x100a_ff5a, 3);  add(eax, 0x65);                       /* add eax, 0x65 */
            ii(0x100a_ff5d, 5);  call(0x1007_6a34, -0x3_952e);         /* call 0x10076a34 */
            ii(0x100a_ff62, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100a_ff67, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x100a_ff6c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ff6f, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_ff72, 5);  call(0x1007_65d0, -0x3_99a7);         /* call 0x100765d0 */
            ii(0x100a_ff77, 5);  call(0x1016_3053, 0xb_30d7);          /* call 0x10163053 */
        l_0x100a_ff7c:
            ii(0x100a_ff7c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_ff7e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_ff7f, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_ff80, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_ff81, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_ff82, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_ff83, 1);  ret();                                /* ret */
        }
    }
}
