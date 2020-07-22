using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_d9c8-e663d5c1")]
        public void Method_1007_d9c8()
        {
            ii(0x1007_d9c8, 5);  push(0x74);                           /* push 0x74 */
            ii(0x1007_d9cd, 5);  call(Definitions.sys_check_available_stack_size, 0xe_8380);/* call 0x10165d52 */
            ii(0x1007_d9d2, 1);  push(esi);                            /* push esi */
            ii(0x1007_d9d3, 1);  push(edi);                            /* push edi */
            ii(0x1007_d9d4, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_d9d5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_d9d7, 6);  sub(esp, 0x58);                       /* sub esp, 0x58 */
            ii(0x1007_d9dd, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_d9e0, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1007_d9e3, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1007_d9e6, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1007_d9e9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_d9ec, 5);  call(0x1007_6338, -0x76b9);           /* call 0x10076338 */
            ii(0x1007_d9f1, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_d9f3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_d9f6, 5);  call(0x1007_64b8, -0x7543);           /* call 0x100764b8 */
            ii(0x1007_d9fb, 2);  jmp(0x1007_da05, 8); goto l_0x1007_da05;/* jmp 0x1007da05 */
        l_0x1007_d9fd:
            ii(0x1007_d9fd, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_da00, 5);  call(0x1007_6bf8, -0x6e0d);           /* call 0x10076bf8 */
        l_0x1007_da05:
            ii(0x1007_da05, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_da07, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_da0a, 5);  call(0x1013_ad71, 0xb_d362);          /* call 0x1013ad71 */
            ii(0x1007_da0f, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_da11, 6);  if(jz(0x1007_dd48, 0x331)) goto l_0x1007_dd48;/* jz 0x1007dd48 */
            ii(0x1007_da17, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_da1a, 5);  call(0x1007_63a0, -0x767f);           /* call 0x100763a0 */
            ii(0x1007_da1f, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1007_da22, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_da27, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_da29, 2);  if(jle(0x1007_da3f, 0x14)) goto l_0x1007_da3f;/* jle 0x1007da3f */
            ii(0x1007_da2b, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_da2e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_da31, 5);  call(0x1007_63a0, -0x7696);           /* call 0x100763a0 */
            ii(0x1007_da36, 5);  call(0x1015_2a52, 0xd_5017);          /* call 0x10152a52 */
            ii(0x1007_da3b, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_da3d, 2);  if(jnz(0x1007_da41, 2)) goto l_0x1007_da41;/* jnz 0x1007da41 */
        l_0x1007_da3f:
            ii(0x1007_da3f, 2);  jmp(0x1007_da5b, 0x1a); goto l_0x1007_da5b;/* jmp 0x1007da5b */
        l_0x1007_da41:
            ii(0x1007_da41, 5);  call(0x1008_9aac, 0xc066);            /* call 0x10089aac */
            ii(0x1007_da46, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_da48, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1007_da4a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_da4d, 5);  call(0x1007_63d4, -0x767e);           /* call 0x100763d4 */
            ii(0x1007_da52, 5);  call(0x1007_8840, -0x5217);           /* call 0x10078840 */
            ii(0x1007_da57, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_da59, 2);  if(jz(0x1007_da60, 5)) goto l_0x1007_da60;/* jz 0x1007da60 */
        l_0x1007_da5b:
            ii(0x1007_da5b, 5);  jmp(0x1007_dd43, 0x2e3); goto l_0x1007_dd43;/* jmp 0x1007dd43 */
        l_0x1007_da60:
            ii(0x1007_da60, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_da63, 5);  call(0x1007_63a0, -0x76c8);           /* call 0x100763a0 */
            ii(0x1007_da68, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1007_da6b, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1007_da6e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_da71, 5);  call(0x1007_63a0, -0x76d6);           /* call 0x100763a0 */
            ii(0x1007_da76, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1007_da79, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_da7c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_da7f, 5);  call(0x1007_6aac, -0x6fd8);           /* call 0x10076aac */
            ii(0x1007_da84, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1007_da87, 5);  call(Definitions.my_ctor_0x101b_4184, -0x6f9c);/* call 0x10076af0 */
            ii(0x1007_da8c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_da8f, 5);  call(0x1007_63a0, -0x76f4);           /* call 0x100763a0 */
            ii(0x1007_da94, 3);  mov(ebx, memd[ds, eax + 6]);          /* mov ebx, [eax+0x6] */
            ii(0x1007_da97, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1007_da9a, 3);  imul(ebx, ebx, 0x33);                 /* imul ebx, ebx, 0x33 */
            ii(0x1007_da9d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1007_da9f, 6);  mov(al, memb[ds, ebx + 0x101c_81d4]); /* mov al, [ebx+0x101c81d4] */
            ii(0x1007_daa5, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_daa8, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_daab, 5);  call(0x1007_63a0, -0x7710);           /* call 0x100763a0 */
            ii(0x1007_dab0, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1007_dab3, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_dab8, 6);  imul(edx, eax, 0xc5);                 /* imul edx, eax, 0xc5 */
            ii(0x1007_dabe, 5);  mov(eax, 0x101c_31c4);                /* mov eax, 0x101c31c4 */
            ii(0x1007_dac3, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1007_dac5, 5);  call(0x1008_a0c8, 0xc5fe);            /* call 0x1008a0c8 */
            ii(0x1007_daca, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_dacd, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1007_dacf, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1007_dad4, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_dad7, 5);  call(0x1007_63d4, -0x7708);           /* call 0x100763d4 */
            ii(0x1007_dadc, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_dade, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_dae1, 5);  call(0x1007_63a0, -0x7746);           /* call 0x100763a0 */
            ii(0x1007_dae6, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1007_dae9, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_daee, 6);  imul(esi, eax, 0xc5);                 /* imul esi, eax, 0xc5 */
            ii(0x1007_daf4, 5);  mov(eax, 0x101c_31c4);                /* mov eax, 0x101c31c4 */
            ii(0x1007_daf9, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x1007_dafb, 5);  call(0x100c_1fd4, 0x4_44d4);          /* call 0x100c1fd4 */
            ii(0x1007_db00, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_db03, 4);  cmp(memd[ss, ebp - 40], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1007_db07, 6);  if(jz(0x1007_dd43, 0x236)) goto l_0x1007_dd43;/* jz 0x1007dd43 */
            ii(0x1007_db0d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_db10, 5);  call(0x1007_63a0, -0x7775);           /* call 0x100763a0 */
            ii(0x1007_db15, 4);  test(memb[ds, eax + 18], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1007_db19, 2);  if(jz(0x1007_db23, 8)) goto l_0x1007_db23;/* jz 0x1007db23 */
            ii(0x1007_db1b, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x1007_db1e, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1007_db21, 2);  jmp(0x1007_db29, 6); goto l_0x1007_db29;/* jmp 0x1007db29 */
        l_0x1007_db23:
            ii(0x1007_db23, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_db26, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
        l_0x1007_db29:
            ii(0x1007_db29, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1007_db2d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_db30, 3);  add(eax, memd[ss, ebp - 44]);         /* add eax, [ebp-0x2c] */
            ii(0x1007_db33, 4);  movsx(edx, memw[ss, ebp - 22]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1007_db37, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1007_db39, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1007_db3b, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1007_db3d, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_db42, 5);  cmp(eax, 0x80);                       /* cmp eax, 0x80 */
            ii(0x1007_db47, 2);  if(jnz(0x1007_db90, 0x47)) goto l_0x1007_db90;/* jnz 0x1007db90 */
            ii(0x1007_db49, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1007_db4d, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_db50, 3);  mov(edx, memd[ss, ebp - 44]);         /* mov edx, [ebp-0x2c] */
            ii(0x1007_db53, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1007_db55, 4);  movsx(eax, memw[ss, ebp - 22]);       /* movsx eax, word [ebp-0x16] */
            ii(0x1007_db59, 2);  mov(ebx, memd[ds, edx]);              /* mov ebx, [edx] */
            ii(0x1007_db5b, 2);  add(ebx, eax);                        /* add ebx, eax */
            ii(0x1007_db5d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_db60, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1007_db63, 5);  call(0x1007_5e64, -0x7d04);           /* call 0x10075e64 */
            ii(0x1007_db68, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1007_db6a, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x1007_db6d, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1007_db70, 5);  call(0x1007_5e64, -0x7d11);           /* call 0x10075e64 */
            ii(0x1007_db75, 2);  mov(edx, ecx);                        /* mov edx, ecx */
            ii(0x1007_db77, 5);  call(0x100a_5fca, 0x2_844e);          /* call 0x100a5fca */
            ii(0x1007_db7c, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1007_db7f, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1007_db81, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1007_db84, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1007_db86, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1007_db88, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_db8a, 2);  mov(dl, memb[ds, ebx]);               /* mov dl, [ebx] */
            ii(0x1007_db8c, 2);  or(edx, eax);                         /* or edx, eax */
            ii(0x1007_db8e, 2);  mov(memb[ds, ebx], dl);               /* mov [ebx], dl */
        l_0x1007_db90:
            ii(0x1007_db90, 7);  mov(memd[ss, ebp - 56], 0x7fff);      /* mov dword [ebp-0x38], 0x7fff */
            ii(0x1007_db97, 6);  mov(memw[ss, ebp - 28], 0);           /* mov word [ebp-0x1c], 0x0 */
            ii(0x1007_db9d, 2);  jmp(0x1007_dba6, 7); goto l_0x1007_dba6;/* jmp 0x1007dba6 */
        l_0x1007_db9f:
            ii(0x1007_db9f, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_dba2, 4);  inc(memw[ss, ebp - 28]);              /* inc word [ebp-0x1c] */
        l_0x1007_dba6:
            ii(0x1007_dba6, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_dba9, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1007_dbb0, 6);  if(jge(0x1007_dc82, 0xcc)) goto l_0x1007_dc82;/* jge 0x1007dc82 */
            ii(0x1007_dbb6, 6);  mov(memw[ss, ebp - 26], 0);           /* mov word [ebp-0x1a], 0x0 */
            ii(0x1007_dbbc, 2);  jmp(0x1007_dbc5, 7); goto l_0x1007_dbc5;/* jmp 0x1007dbc5 */
        l_0x1007_dbbe:
            ii(0x1007_dbbe, 3);  mov(eax, memd[ss, ebp - 26]);         /* mov eax, [ebp-0x1a] */
            ii(0x1007_dbc1, 4);  inc(memw[ss, ebp - 26]);              /* inc word [ebp-0x1a] */
        l_0x1007_dbc5:
            ii(0x1007_dbc5, 3);  mov(eax, memd[ss, ebp - 26]);         /* mov eax, [ebp-0x1a] */
            ii(0x1007_dbc8, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1007_dbcf, 6);  if(jge(0x1007_dc7d, 0xa8)) goto l_0x1007_dc7d;/* jge 0x1007dc7d */
            ii(0x1007_dbd5, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_dbd9, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_dbdc, 3);  add(eax, memd[ss, ebp - 44]);         /* add eax, [ebp-0x2c] */
            ii(0x1007_dbdf, 4);  movsx(edx, memw[ss, ebp - 26]);       /* movsx edx, word [ebp-0x1a] */
            ii(0x1007_dbe3, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1007_dbe5, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1007_dbe7, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1007_dbe9, 2);  and(al, 0x7f);                        /* and al, 0x7f */
            ii(0x1007_dbeb, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1007_dbed, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1007_dbf0, 4);  movsx(eax, memw[ss, ebp - 60]);       /* movsx eax, word [ebp-0x3c] */
            ii(0x1007_dbf4, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_dbf6, 2);  if(jle(0x1007_dc01, 9)) goto l_0x1007_dc01;/* jle 0x1007dc01 */
            ii(0x1007_dbf8, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_dbfb, 4);  cmp(ax, memw[ss, ebp - 56]);          /* cmp ax, [ebp-0x38] */
            ii(0x1007_dbff, 2);  if(jl(0x1007_dc03, 2)) goto l_0x1007_dc03;/* jl 0x1007dc03 */
        l_0x1007_dc01:
            ii(0x1007_dc01, 2);  jmp(0x1007_dc2e, 0x2b); goto l_0x1007_dc2e;/* jmp 0x1007dc2e */
        l_0x1007_dc03:
            ii(0x1007_dc03, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_dc07, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_dc0a, 3);  add(eax, memd[ss, ebp - 40]);         /* add eax, [ebp-0x28] */
            ii(0x1007_dc0d, 4);  movsx(edx, memw[ss, ebp - 26]);       /* movsx edx, word [ebp-0x1a] */
            ii(0x1007_dc11, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x1007_dc13, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1007_dc15, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1007_dc17, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1007_dc1a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_dc1d, 5);  call(0x1007_63a0, -0x7882);           /* call 0x100763a0 */
            ii(0x1007_dc22, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1007_dc25, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_dc2a, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1007_dc2c, 2);  if(jl(0x1007_dc30, 2)) goto l_0x1007_dc30;/* jl 0x1007dc30 */
        l_0x1007_dc2e:
            ii(0x1007_dc2e, 2);  jmp(0x1007_dc47, 0x17); goto l_0x1007_dc47;/* jmp 0x1007dc47 */
        l_0x1007_dc30:
            ii(0x1007_dc30, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_dc34, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_dc37, 3);  add(eax, memd[ss, ebp - 36]);         /* add eax, [ebp-0x24] */
            ii(0x1007_dc3a, 4);  movsx(edx, memw[ss, ebp - 26]);       /* movsx edx, word [ebp-0x1a] */
            ii(0x1007_dc3e, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1007_dc40, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1007_dc42, 3);  test(memb[ds, eax], 8);               /* test byte [eax], 0x8 */
            ii(0x1007_dc45, 2);  if(jz(0x1007_dc49, 2)) goto l_0x1007_dc49;/* jz 0x1007dc49 */
        l_0x1007_dc47:
            ii(0x1007_dc47, 2);  jmp(0x1007_dc78, 0x2f); goto l_0x1007_dc78;/* jmp 0x1007dc78 */
        l_0x1007_dc49:
            ii(0x1007_dc49, 4);  movsx(edx, memw[ss, ebp - 26]);       /* movsx edx, word [ebp-0x1a] */
            ii(0x1007_dc4d, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1007_dc51, 5);  call(0x1007_3cfd, -0x9f59);           /* call 0x10073cfd */
            ii(0x1007_dc56, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1007_dc59, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1007_dc5d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1007_dc5f, 4);  mov(ax, memw[ss, ebp - 64]);          /* mov ax, [ebp-0x40] */
            ii(0x1007_dc63, 2);  test(edx, eax);                       /* test edx, eax */
            ii(0x1007_dc65, 2);  if(jz(0x1007_dc78, 0x11)) goto l_0x1007_dc78;/* jz 0x1007dc78 */
            ii(0x1007_dc67, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1007_dc6a, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_dc6d, 5);  call(0x1008_8b44, 0xaed2);            /* call 0x10088b44 */
            ii(0x1007_dc72, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1007_dc75, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
        l_0x1007_dc78:
            ii(0x1007_dc78, 5);  jmp(0x1007_dbbe, -0xbf); goto l_0x1007_dbbe;/* jmp 0x1007dbbe */
        l_0x1007_dc7d:
            ii(0x1007_dc7d, 5);  jmp(0x1007_db9f, -0xe3); goto l_0x1007_db9f;/* jmp 0x1007db9f */
        l_0x1007_dc82:
            ii(0x1007_dc82, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1007_dc86, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_dc89, 3);  add(eax, memd[ss, ebp - 44]);         /* add eax, [ebp-0x2c] */
            ii(0x1007_dc8c, 4);  movsx(edx, memw[ss, ebp - 22]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1007_dc90, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1007_dc92, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1007_dc94, 3);  and(memb[ds, eax], -0x80 /* 0x80 */); /* and byte [eax], 0x80 */
            ii(0x1007_dc97, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_dc9a, 5);  call(0x1007_63a0, -0x78ff);           /* call 0x100763a0 */
            ii(0x1007_dc9f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_dca1, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_dca4, 4);  cmp(ax, memw[ds, edx + 26]);          /* cmp ax, [edx+0x1a] */
            ii(0x1007_dca8, 2);  if(jnz(0x1007_dcc1, 0x17)) goto l_0x1007_dcc1;/* jnz 0x1007dcc1 */
            ii(0x1007_dcaa, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_dcad, 5);  call(0x1007_63a0, -0x7912);           /* call 0x100763a0 */
            ii(0x1007_dcb2, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_dcb4, 3);  mov(eax, memd[ss, ebp - 22]);         /* mov eax, [ebp-0x16] */
            ii(0x1007_dcb7, 4);  cmp(ax, memw[ds, edx + 28]);          /* cmp ax, [edx+0x1c] */
            ii(0x1007_dcbb, 6);  if(jz(0x1007_dd43, 0x82)) goto l_0x1007_dd43;/* jz 0x1007dd43 */
        l_0x1007_dcc1:
            ii(0x1007_dcc1, 5);  mov(eax, 0x49);                       /* mov eax, 0x49 */
            ii(0x1007_dcc6, 5);  call(Definitions.sys_new, 0xe_8135);  /* call 0x10165e00 */
            ii(0x1007_dccb, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x1007_dcce, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1007_dcd1, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1007_dcd4, 4);  cmp(memd[ss, ebp - 72], 0);           /* cmp dword [ebp-0x48], 0x0 */
            ii(0x1007_dcd8, 2);  if(jz(0x1007_dd14, 0x3a)) goto l_0x1007_dd14;/* jz 0x1007dd14 */
            ii(0x1007_dcda, 5);  mov(eax, 0x1007_d94c);                /* mov eax, 0x1007d94c */
            ii(0x1007_dcdf, 1);  push(eax);                            /* push eax */
            ii(0x1007_dce0, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x1007_dce3, 3);  lea(eax, memd[ss, ebp - 76]);         /* lea eax, [ebp-0x4c] */
            ii(0x1007_dce6, 5);  call(0x1007_5e64, -0x7e87);           /* call 0x10075e64 */
            ii(0x1007_dceb, 1);  push(eax);                            /* push eax */
            ii(0x1007_dcec, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x1007_dcf1, 1);  push(eax);                            /* push eax */
            ii(0x1007_dcf2, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1007_dcf4, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1007_dcf7, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_dcfa, 5);  call(0x1007_63d4, -0x792b);           /* call 0x100763d4 */
            ii(0x1007_dcff, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_dd01, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1007_dd04, 5);  call(0x100a_c220, 0x2_e517);          /* call 0x100ac220 */
            ii(0x1007_dd09, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x1007_dd0c, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1007_dd0f, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x1007_dd12, 2);  jmp(0x1007_dd1a, 6); goto l_0x1007_dd1a;/* jmp 0x1007dd1a */
        l_0x1007_dd14:
            ii(0x1007_dd14, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1007_dd17, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
        l_0x1007_dd1a:
            ii(0x1007_dd1a, 3);  mov(edx, memd[ss, ebp - 84]);         /* mov edx, [ebp-0x54] */
            ii(0x1007_dd1d, 3);  lea(eax, memd[ss, ebp - 88]);         /* lea eax, [ebp-0x58] */
            ii(0x1007_dd20, 5);  call(0x1008_b060, 0xd33b);            /* call 0x1008b060 */
            ii(0x1007_dd25, 3);  lea(eax, memd[ss, ebp - 88]);         /* lea eax, [ebp-0x58] */
            ii(0x1007_dd28, 5);  call(0x1008_af84, 0xd257);            /* call 0x1008af84 */
            ii(0x1007_dd2d, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_dd2f, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_dd34, 5);  call(0x100a_4d50, 0x2_7017);          /* call 0x100a4d50 */
            ii(0x1007_dd39, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_dd3b, 3);  lea(eax, memd[ss, ebp - 88]);         /* lea eax, [ebp-0x58] */
            ii(0x1007_dd3e, 5);  call(0x1008_8b7c, 0xae39);            /* call 0x10088b7c */
        l_0x1007_dd43:
            ii(0x1007_dd43, 5);  jmp(0x1007_d9fd, -0x34b); goto l_0x1007_d9fd;/* jmp 0x1007d9fd */
        l_0x1007_dd48:
            ii(0x1007_dd48, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_dd4a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_dd4d, 5);  call(0x1007_5f6c, -0x7de6);           /* call 0x10075f6c */
            ii(0x1007_dd52, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_dd54, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_dd55, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_dd56, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_dd57, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
