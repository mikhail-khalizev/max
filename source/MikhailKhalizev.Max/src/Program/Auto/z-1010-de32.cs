using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_de32-a7eb1267")]
        public void Method_1010_de32()
        {
            ii(0x1010_de32, 5);  push(0x94);                           /* push 0x94 */
            ii(0x1010_de37, 5);  call(Definitions.sys_check_available_stack_size, 0x5_7f16);/* call 0x10165d52 */
            ii(0x1010_de3c, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_de3d, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_de3e, 1);  push(edx);                            /* push edx */
            ii(0x1010_de3f, 1);  push(esi);                            /* push esi */
            ii(0x1010_de40, 1);  push(edi);                            /* push edi */
            ii(0x1010_de41, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_de42, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_de44, 6);  sub(esp, 0x74);                       /* sub esp, 0x74 */
            ii(0x1010_de4a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_de4d, 7);  mov(memd[ss, ebp - 8], 0xc);          /* mov dword [ebp-0x8], 0xc */
            ii(0x1010_de54, 2);  jmp(0x1010_de5c, 6); goto l_0x1010_de5c;/* jmp 0x1010de5c */
        l_0x1010_de56:
            ii(0x1010_de56, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_de59, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x1010_de5c:
            ii(0x1010_de5c, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_de60, 3);  cmp(eax, 0x10);                       /* cmp eax, 0x10 */
            ii(0x1010_de63, 2);  if(jge(0x1010_deb6, 0x51)) goto l_0x1010_deb6;/* jge 0x1010deb6 */
            ii(0x1010_de65, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_de69, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_de6c, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1010_de6f, 4);  cmp(memd[ds, eax + 20], 0);           /* cmp dword [eax+0x14], 0x0 */
            ii(0x1010_de73, 2);  if(jz(0x1010_dea6, 0x31)) goto l_0x1010_dea6;/* jz 0x1010dea6 */
            ii(0x1010_de75, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_de79, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_de7c, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1010_de7f, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x1010_de82, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_de85, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_de89, 2);  if(jz(0x1010_de9f, 0x14)) goto l_0x1010_de9f;/* jz 0x1010de9f */
            ii(0x1010_de8b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_de8d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_de90, 5);  call(Definitions.my_dtor_d2, -0x3_f95d);/* call 0x100ce538 */
            ii(0x1010_de95, 5);  call(Definitions.sys_delete, 0x5_80ca);/* call 0x10165f64 */
            ii(0x1010_de9a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_de9d, 2);  jmp(0x1010_dea6, 7); goto l_0x1010_dea6;/* jmp 0x1010dea6 */
        l_0x1010_de9f:
            ii(0x1010_de9f, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_dea6:
            ii(0x1010_dea6, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1010_dea8, 4);  movsx(edx, memb[ss, ebp - 8]);        /* movsx edx, byte [ebp-0x8] */
            ii(0x1010_deac, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_deaf, 5);  call(0x1010_daa7, -0x40d);            /* call 0x1010daa7 */
            ii(0x1010_deb4, 2);  jmp(0x1010_de56, -0x60); goto l_0x1010_de56;/* jmp 0x1010de56 */
        l_0x1010_deb6:
            ii(0x1010_deb6, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1010_debb, 5);  call(/* sys */ 0x1016_a24c, 0x5_c38c);/* call 0x1016a24c */
            ii(0x1010_dec0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_dec3, 4);  cmp(memd[ds, eax + 12], 0);           /* cmp dword [eax+0xc], 0x0 */
            ii(0x1010_dec7, 2);  if(jz(0x1010_ded8, 0xf)) goto l_0x1010_ded8;/* jz 0x1010ded8 */
            ii(0x1010_dec9, 5);  mov(edx, StringDefinitions.CustomGameMenu);/* mov edx, 0x101a4584 */
            ii(0x1010_dece, 3);  lea(eax, memd[ss, ebp - 116]);        /* lea eax, [ebp-0x74] */
            ii(0x1010_ded1, 5);  call(Definitions.sys_strcpy, 0x5_7ff9);/* call 0x10165ecf */
            ii(0x1010_ded6, 2);  jmp(0x1010_dee5, 0xd); goto l_0x1010_dee5;/* jmp 0x1010dee5 */
        l_0x1010_ded8:
            ii(0x1010_ded8, 5);  mov(edx, StringDefinitions.HotSeatMenu);/* mov edx, 0x101a4595 */
            ii(0x1010_dedd, 3);  lea(eax, memd[ss, ebp - 116]);        /* lea eax, [ebp-0x74] */
            ii(0x1010_dee0, 5);  call(Definitions.sys_strcpy, 0x5_7fea);/* call 0x10165ecf */
        l_0x1010_dee5:
            ii(0x1010_dee5, 3);  lea(eax, memd[ss, ebp - 116]);        /* lea eax, [ebp-0x74] */
            ii(0x1010_dee8, 5);  mov(memd[ds, 0x101b_9b5c], eax);      /* mov [0x101b9b5c], eax */
            ii(0x1010_deed, 6);  mov(memw[ss, ebp - 8], 6);            /* mov word [ebp-0x8], 0x6 */
        l_0x1010_def3:
            ii(0x1010_def3, 4);  dec(memw[ss, ebp - 8]);               /* dec word [ebp-0x8] */
            ii(0x1010_def7, 5);  cmp(memw[ss, ebp - 8], -1 /* 0xff */);/* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_defc, 2);  if(jz(0x1010_df2d, 0x2f)) goto l_0x1010_df2d;/* jz 0x1010df2d */
            ii(0x1010_defe, 5);  call(0x1011_5318, 0x7415);            /* call 0x10115318 */
            ii(0x1010_df03, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1010_df08, 1);  push(eax);                            /* push eax */
            ii(0x1010_df09, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x1010_df0e, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x1010_df13, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_df17, 3);  imul(eax, eax, 0x14);                 /* imul eax, eax, 0x14 */
            ii(0x1010_df1a, 5);  mov(edx, 0x101b_9b4c);                /* mov edx, 0x101b9b4c */
            ii(0x1010_df1f, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_df21, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_df24, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_df26, 5);  call(0x1010_8a05, -0x5526);           /* call 0x10108a05 */
            ii(0x1010_df2b, 2);  jmp(0x1010_def3, -0x3a); goto l_0x1010_def3;/* jmp 0x1010def3 */
        l_0x1010_df2d:
            ii(0x1010_df2d, 6);  mov(memw[ss, ebp - 8], 0x13);         /* mov word [ebp-0x8], 0x13 */
        l_0x1010_df33:
            ii(0x1010_df33, 4);  dec(memw[ss, ebp - 8]);               /* dec word [ebp-0x8] */
            ii(0x1010_df37, 5);  cmp(memw[ss, ebp - 8], -1 /* 0xff */);/* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_df3c, 6);  if(jz(0x1010_dfbb, 0x79)) goto l_0x1010_dfbb;/* jz 0x1010dfbb */
            ii(0x1010_df42, 5);  call(0x100d_51e4, -0x3_8d63);         /* call 0x100d51e4 */
            ii(0x1010_df47, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1010_df49, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1010_df4b, 5);  call(0x100d_5204, -0x3_8d4c);         /* call 0x100d5204 */
            ii(0x1010_df50, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_df52, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1010_df54, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_df58, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_df5b, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1010_df5e, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x1010_df61, 5);  call(0x100c_fa7c, -0x3_e4ea);         /* call 0x100cfa7c */
            ii(0x1010_df66, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_df6a, 3);  cmp(eax, 0xc);                        /* cmp eax, 0xc */
            ii(0x1010_df6d, 2);  if(jl(0x1010_df78, 9)) goto l_0x1010_df78;/* jl 0x1010df78 */
            ii(0x1010_df6f, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_df73, 3);  cmp(eax, 0x10);                       /* cmp eax, 0x10 */
            ii(0x1010_df76, 2);  if(jl(0x1010_df7a, 2)) goto l_0x1010_df7a;/* jl 0x1010df7a */
        l_0x1010_df78:
            ii(0x1010_df78, 2);  jmp(0x1010_dfb6, 0x3c); goto l_0x1010_dfb6;/* jmp 0x1010dfb6 */
        l_0x1010_df7a:
            ii(0x1010_df7a, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1010_df7d, 2);  add(al, 0x5b);                        /* add al, 0x5b */
            ii(0x1010_df7f, 3);  movsx(eax, al);                       /* movsx eax, al */
            ii(0x1010_df82, 5);  call(0x1007_5fdc, -0x9_7fab);         /* call 0x10075fdc */
            ii(0x1010_df87, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1010_df8a, 2);  if(jnz(0x1010_df9b, 0xf)) goto l_0x1010_df9b;/* jnz 0x1010df9b */
            ii(0x1010_df8c, 5);  mov(eax, 0x3e);                       /* mov eax, 0x3e */
            ii(0x1010_df91, 5);  call(0x1007_5fdc, -0x9_7fba);         /* call 0x10075fdc */
            ii(0x1010_df96, 3);  cmp(eax, 9);                          /* cmp eax, 0x9 */
            ii(0x1010_df99, 2);  if(jnz(0x1010_dfb6, 0x1b)) goto l_0x1010_dfb6;/* jnz 0x1010dfb6 */
        l_0x1010_df9b:
            ii(0x1010_df9b, 5);  call(0x100d_51c4, -0x3_8ddc);         /* call 0x100d51c4 */
            ii(0x1010_dfa0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_dfa2, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1010_dfa4, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_dfa8, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_dfab, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1010_dfae, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x1010_dfb1, 5);  call(0x100c_fb06, -0x3_e4b0);         /* call 0x100cfb06 */
        l_0x1010_dfb6:
            ii(0x1010_dfb6, 5);  jmp(0x1010_df33, -0x88); goto l_0x1010_df33;/* jmp 0x1010df33 */
        l_0x1010_dfbb:
            ii(0x1010_dfbb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_dfbe, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1010_dfc0, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1010_dfc3, 5);  call(Definitions.sys_display_draw_0, 0x5_94bc);/* call 0x10167484 */
            ii(0x1010_dfc8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_dfca, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_dfcb, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_dfcc, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_dfcd, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_dfce, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_dfcf, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_dfd0, 1);  ret();                                /* ret */
        }
    }
}
