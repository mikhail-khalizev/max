using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_dc7b-aad57b0c")]
        public void Method_100f_dc7b()
        {
            ii(0x100f_dc7b, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100f_dc80, 5);  call(Definitions.sys_check_available_stack_size, 0x6_80cd);/* call 0x10165d52 */
            ii(0x100f_dc85, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_dc86, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_dc87, 1);  push(edx);                            /* push edx */
            ii(0x100f_dc88, 1);  push(esi);                            /* push esi */
            ii(0x100f_dc89, 1);  push(edi);                            /* push edi */
            ii(0x100f_dc8a, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_dc8b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_dc8d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100f_dc93, 9);  mov(memw[ds, 0x101c_3982], 0);        /* mov word [0x101c3982], 0x0 */
            ii(0x100f_dc9c, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_dca3, 2);  if(jz(0x100f_dcb3, 0xe)) goto l_0x100f_dcb3;/* jz 0x100fdcb3 */
            ii(0x100f_dca5, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_dca7, 5);  call(/* sys */ 0x1017_8f78, 0x7_b2cc);/* call 0x10178f78 */
            ii(0x100f_dcac, 5);  call(/* sys */ 0x1016_5ebf, 0x6_820e);/* call 0x10165ebf */
            ii(0x100f_dcb1, 2);  jmp(0x100f_dcb8, 5); goto l_0x100f_dcb8;/* jmp 0x100fdcb8 */
        l_0x100f_dcb3:
            ii(0x100f_dcb3, 5);  call(0x1013_6316, 0x3_865e);          /* call 0x10136316 */
        l_0x100f_dcb8:
            ii(0x100f_dcb8, 7);  mov(memd[ss, ebp - 4], 4);            /* mov dword [ebp-0x4], 0x4 */
        l_0x100f_dcbf:
            ii(0x100f_dcbf, 3);  dec(memd[ss, ebp - 4]);               /* dec dword [ebp-0x4] */
            ii(0x100f_dcc2, 5);  cmp(memw[ss, ebp - 4], -1 /* 0xff */);/* cmp word [ebp-0x4], 0xffff */
            ii(0x100f_dcc7, 2);  if(jz(0x100f_dd07, 0x3e)) goto l_0x100f_dd07;/* jz 0x100fdd07 */
            ii(0x100f_dcc9, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_dccd, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_dcd3, 5);  mov(edx, 0x101c_a468);                /* mov edx, 0x101ca468 */
            ii(0x100f_dcd8, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100f_dcda, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x100f_dcdd, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_dce1, 6);  mov(eax, memd[ds, eax + 0x101b_873d]);/* mov eax, [eax+0x101b873d] */
            ii(0x100f_dce7, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x100f_dcea, 5);  call(0x1007_5fdc, -0x8_7d13);         /* call 0x10075fdc */
            ii(0x100f_dcef, 4);  mov(memw[ss, ebp - 12], ax);          /* mov [ebp-0xc], ax */
            ii(0x100f_dcf3, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100f_dcf6, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100f_dcf9, 3);  mov(memb[ds, edx + 40], al);          /* mov [edx+0x28], al */
            ii(0x100f_dcfc, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_dd00, 5);  call(0x1013_61f9, 0x3_84f4);          /* call 0x101361f9 */
            ii(0x100f_dd05, 2);  jmp(0x100f_dcbf, -0x48); goto l_0x100f_dcbf;/* jmp 0x100fdcbf */
        l_0x100f_dd07:
            ii(0x100f_dd07, 5);  mov(eax, 4);                          /* mov eax, 0x4 */
            ii(0x100f_dd0c, 5);  call(0x1013_61f9, 0x3_84e8);          /* call 0x101361f9 */
            ii(0x100f_dd11, 5);  call(0x100f_dbfd, -0x119);            /* call 0x100fdbfd */
            ii(0x100f_dd16, 7);  mov(memd[ss, ebp - 4], 4);            /* mov dword [ebp-0x4], 0x4 */
            ii(0x100f_dd1d, 7);  mov(memb[ds, 0x101c_37da], 4);        /* mov byte [0x101c37da], 0x4 */
        l_0x100f_dd24:
            ii(0x100f_dd24, 3);  dec(memd[ss, ebp - 4]);               /* dec dword [ebp-0x4] */
            ii(0x100f_dd27, 5);  cmp(memw[ss, ebp - 4], -1 /* 0xff */);/* cmp word [ebp-0x4], 0xffff */
            ii(0x100f_dd2c, 2);  if(jz(0x100f_dd63, 0x35)) goto l_0x100f_dd63;/* jz 0x100fdd63 */
            ii(0x100f_dd2e, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_dd32, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_dd38, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_dd3e, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100f_dd43, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x100f_dd46, 2);  if(jnz(0x100f_dd61, 0x19)) goto l_0x100f_dd61;/* jnz 0x100fdd61 */
            ii(0x100f_dd48, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_dd4c, 5);  call(0x100f_c150, -0x1c01);           /* call 0x100fc150 */
            ii(0x100f_dd51, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_dd53, 2);  if(jnz(0x100f_dd61, 0xc)) goto l_0x100f_dd61;/* jnz 0x100fdd61 */
            ii(0x100f_dd55, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_dd5c, 5);  jmp(0x100f_dec8, 0x167); goto l_0x100f_dec8;/* jmp 0x100fdec8 */
        l_0x100f_dd61:
            ii(0x100f_dd61, 2);  jmp(0x100f_dd24, -0x3f); goto l_0x100f_dd24;/* jmp 0x100fdd24 */
        l_0x100f_dd63:
            ii(0x100f_dd63, 7);  cmp(memb[ds, 0x101c_388b], 0);        /* cmp byte [0x101c388b], 0x0 */
            ii(0x100f_dd6a, 2);  if(jz(0x100f_dd75, 9)) goto l_0x100f_dd75;/* jz 0x100fdd75 */
            ii(0x100f_dd6c, 5);  call(0x100f_c072, -0x1cff);           /* call 0x100fc072 */
            ii(0x100f_dd71, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_dd73, 2);  if(jz(0x100f_dd77, 2)) goto l_0x100f_dd77;/* jz 0x100fdd77 */
        l_0x100f_dd75:
            ii(0x100f_dd75, 2);  jmp(0x100f_dd83, 0xc); goto l_0x100f_dd83;/* jmp 0x100fdd83 */
        l_0x100f_dd77:
            ii(0x100f_dd77, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_dd7e, 5);  jmp(0x100f_dec8, 0x145); goto l_0x100f_dec8;/* jmp 0x100fdec8 */
        l_0x100f_dd83:
            ii(0x100f_dd83, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_dd8a, 2);  jmp(0x100f_dd92, 6); goto l_0x100f_dd92;/* jmp 0x100fdd92 */
        l_0x100f_dd8c:
            ii(0x100f_dd8c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_dd8f, 3);  inc(memd[ss, ebp - 4]);               /* inc dword [ebp-0x4] */
        l_0x100f_dd92:
            ii(0x100f_dd92, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_dd96, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x100f_dd99, 2);  if(jge(0x100f_ddf8, 0x5d)) goto l_0x100f_ddf8;/* jge 0x100fddf8 */
            ii(0x100f_dd9b, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_dd9f, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_dda5, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_ddab, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100f_ddb0, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100f_ddb3, 2);  if(jnz(0x100f_ddf6, 0x41)) goto l_0x100f_ddf6;/* jnz 0x100fddf6 */
            ii(0x100f_ddb5, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_ddb7, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_ddbc, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x100f_ddbf, 2);  if(jnz(0x100f_ddc9, 8)) goto l_0x100f_ddc9;/* jnz 0x100fddc9 */
            ii(0x100f_ddc1, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100f_ddc4, 5);  mov(memb[ds, 0x101c_37da], al);       /* mov [0x101c37da], al */
        l_0x100f_ddc9:
            ii(0x100f_ddc9, 7);  cmp(memd[ds, 0x101c_9450], 0);        /* cmp dword [0x101c9450], 0x0 */
            ii(0x100f_ddd0, 2);  if(jnz(0x100f_ddd7, 5)) goto l_0x100f_ddd7;/* jnz 0x100fddd7 */
            ii(0x100f_ddd2, 5);  call(0x100f_b82b, -0x25ac);           /* call 0x100fb82b */
        l_0x100f_ddd7:
            ii(0x100f_ddd7, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_dddb, 5);  call(0x100a_267a, -0x5_b766);         /* call 0x100a267a */
            ii(0x100f_dde0, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_dde2, 2);  if(jz(0x100f_ddf6, 0x12)) goto l_0x100f_ddf6;/* jz 0x100fddf6 */
            ii(0x100f_dde4, 7);  cmp(memd[ds, 0x101c_5624], 0);        /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_ddeb, 2);  if(jz(0x100f_ddf6, 9)) goto l_0x100f_ddf6;/* jz 0x100fddf6 */
            ii(0x100f_dded, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_ddf1, 5);  call(0x1012_8f02, 0x2_b10c);          /* call 0x10128f02 */
        l_0x100f_ddf6:
            ii(0x100f_ddf6, 2);  jmp(0x100f_dd8c, -0x6c); goto l_0x100f_dd8c;/* jmp 0x100fdd8c */
        l_0x100f_ddf8:
            ii(0x100f_ddf8, 5);  call(0x100f_d045, -0xdb8);            /* call 0x100fd045 */
            ii(0x100f_ddfd, 5);  mov(eax, 0x2c);                       /* mov eax, 0x2c */
            ii(0x100f_de02, 5);  call(0x1007_5fdc, -0x8_7e2b);         /* call 0x10075fdc */
            ii(0x100f_de07, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100f_de0a, 5);  mov(eax, 0x2b);                       /* mov eax, 0x2b */
            ii(0x100f_de0f, 5);  call(0x1007_5fdc, -0x8_7e38);         /* call 0x10075fdc */
            ii(0x100f_de14, 1);  cwde();                               /* cwde */
            ii(0x100f_de15, 5);  call(0x100f_da28, -0x3f2);            /* call 0x100fda28 */
            ii(0x100f_de1a, 6);  mov(memw[ss, ebp - 4], 4);            /* mov word [ebp-0x4], 0x4 */
        l_0x100f_de20:
            ii(0x100f_de20, 4);  dec(memw[ss, ebp - 4]);               /* dec word [ebp-0x4] */
            ii(0x100f_de24, 5);  cmp(memw[ss, ebp - 4], -1 /* 0xff */);/* cmp word [ebp-0x4], 0xffff */
            ii(0x100f_de29, 2);  if(jz(0x100f_de5d, 0x32)) goto l_0x100f_de5d;/* jz 0x100fde5d */
            ii(0x100f_de2b, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_de2f, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_de35, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_de3b, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100f_de40, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_de42, 2);  if(jz(0x100f_de5b, 0x17)) goto l_0x100f_de5b;/* jz 0x100fde5b */
            ii(0x100f_de44, 7);  cmp(memd[ds, 0x101c_9450], 0);        /* cmp dword [0x101c9450], 0x0 */
            ii(0x100f_de4b, 2);  if(jnz(0x100f_de52, 5)) goto l_0x100f_de52;/* jnz 0x100fde52 */
            ii(0x100f_de4d, 5);  call(0x100f_b82b, -0x2627);           /* call 0x100fb82b */
        l_0x100f_de52:
            ii(0x100f_de52, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_de56, 5);  call(0x1010_1cf8, 0x3e9d);            /* call 0x10101cf8 */
        l_0x100f_de5b:
            ii(0x100f_de5b, 2);  jmp(0x100f_de20, -0x3d); goto l_0x100f_de20;/* jmp 0x100fde20 */
        l_0x100f_de5d:
            ii(0x100f_de5d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_de5f, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_de64, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_de67, 7);  mov(ax, memw[ds, eax + 0x101c_35bc]); /* mov ax, [eax+0x101c35bc] */
            ii(0x100f_de6e, 6);  mov(memw[ds, 0x101c_38e2], ax);       /* mov [0x101c38e2], ax */
            ii(0x100f_de74, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_de76, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_de7b, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100f_de7e, 7);  mov(ax, memw[ds, eax + 0x101c_35be]); /* mov ax, [eax+0x101c35be] */
            ii(0x100f_de85, 6);  mov(memw[ds, 0x101c_38e4], ax);       /* mov [0x101c38e4], ax */
            ii(0x100f_de8b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_de8d, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_de92, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_de98, 7);  mov(dx, memw[ds, 0x101c_38e2]);       /* mov dx, [0x101c38e2] */
            ii(0x100f_de9f, 7);  mov(memw[ds, eax + 0x101c_a56c], dx); /* mov [eax+0x101ca56c], dx */
            ii(0x100f_dea6, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_dea8, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x100f_dead, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100f_deb3, 7);  mov(dx, memw[ds, 0x101c_38e4]);       /* mov dx, [0x101c38e4] */
            ii(0x100f_deba, 7);  mov(memw[ds, eax + 0x101c_a56e], dx); /* mov [eax+0x101ca56e], dx */
            ii(0x100f_dec1, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
        l_0x100f_dec8:
            ii(0x100f_dec8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_decb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_decd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_dece, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_decf, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_ded0, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_ded1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_ded2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_ded3, 1);  ret();                                /* ret */
        }
    }
}
