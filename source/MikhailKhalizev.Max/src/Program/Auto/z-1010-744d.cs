using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_744d-e7b2a19e")]
        public void Method_1010_744d()
        {
            ii(0x1010_744d, 5); push(0x38);                             /* push 0x38 */
            ii(0x1010_7452, 5); call(Definitions.sys_check_available_stack_size, 0x5_e8fb); /* call 0x10165d52 */
            ii(0x1010_7457, 1); push(ebx);                              /* push ebx */
            ii(0x1010_7458, 1); push(ecx);                              /* push ecx */
            ii(0x1010_7459, 1); push(edx);                              /* push edx */
            ii(0x1010_745a, 1); push(esi);                              /* push esi */
            ii(0x1010_745b, 1); push(edi);                              /* push edi */
            ii(0x1010_745c, 1); push(ebp);                              /* push ebp */
            ii(0x1010_745d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_745f, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1010_7465, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_7468, 7); mov(memd[ss, ebp - 0xc], 4);            /* mov dword [ebp-0xc], 0x4 */
            ii(0x1010_746f, 2); jmp(0x1010_7477, 6); goto l_0x1010_7477; /* jmp 0x10107477 */
        l_0x1010_7471:
            ii(0x1010_7471, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_7474, 3); inc(memd[ss, ebp - 0xc]);               /* inc dword [ebp-0xc] */
        l_0x1010_7477:
            ii(0x1010_7477, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_747b, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1010_747e, 2); if(jge(0x1010_74db, 0x5b)) goto l_0x1010_74db; /* jge 0x101074db */
            ii(0x1010_7480, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_7484, 6); imul(edx, eax, 0x276);                  /* imul edx, eax, 0x276 */
            ii(0x1010_748a, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_748f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7491, 4); cmp(memb[ds, eax + 8], 0);              /* cmp byte [eax+0x8], 0x0 */
            ii(0x1010_7495, 2); if(jnz(0x1010_74d9, 0x42)) goto l_0x1010_74d9; /* jnz 0x101074d9 */
            ii(0x1010_7497, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_749b, 6); imul(edx, eax, 0x276);                  /* imul edx, eax, 0x276 */
            ii(0x1010_74a1, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_74a6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_74a8, 5); call(0x1010_7221, -0x28c);              /* call 0x10107221 */
            ii(0x1010_74ad, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_74b1, 6); imul(edx, eax, 0x276);                  /* imul edx, eax, 0x276 */
            ii(0x1010_74b7, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_74bc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_74be, 4); mov(memb[ds, eax + 8], 0);              /* mov byte [eax+0x8], 0x0 */
            ii(0x1010_74c2, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1010_74c6, 6); imul(eax, eax, 0x276);                  /* imul eax, eax, 0x276 */
            ii(0x1010_74cc, 6); mov(edx, memd[ds, 0x101c_4dac]);        /* mov edx, [0x101c4dac] */
            ii(0x1010_74d2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_74d4, 5); call(0x1010_6ee0, -0x5f9);              /* call 0x10106ee0 */
        l_0x1010_74d9:
            ii(0x1010_74d9, 2); jmp(0x1010_7471, -0x6a); goto l_0x1010_7471; /* jmp 0x10107471 */
        l_0x1010_74db:
            ii(0x1010_74db, 7); mov(memd[ss, ebp - 8], 4);              /* mov dword [ebp-0x8], 0x4 */
        l_0x1010_74e2:
            ii(0x1010_74e2, 3); dec(memd[ss, ebp - 8]);                 /* dec dword [ebp-0x8] */
            ii(0x1010_74e5, 5); cmp(memw[ss, ebp - 8], -1 /* 0xff */);  /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_74ea, 6); if(jz(0x1010_7744, 0x254)) goto l_0x1010_7744; /* jz 0x10107744 */
            ii(0x1010_74f0, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_74f4, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_74f7, 7); cmp(memd[ds, eax + 0x101c_4160], 0);    /* cmp dword [eax+0x101c4160], 0x0 */
            ii(0x1010_74fe, 6); if(jz(0x1010_773f, 0x23b)) goto l_0x1010_773f; /* jz 0x1010773f */
            ii(0x1010_7504, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7508, 6); mov(al, memb[ds, eax + 0x101c_40b0]);   /* mov al, [eax+0x101c40b0] */
            ii(0x1010_750e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_7513, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1010_7515, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1010_7519, 3); shl(edx, 7);                            /* shl edx, 0x7 */
            ii(0x1010_751c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_751e, 8); cmp(memw[ds, eax + 0x101c_4170], 0);    /* cmp word [eax+0x101c4170], 0x0 */
            ii(0x1010_7526, 6); if(jz(0x1010_76de, 0x1b2)) goto l_0x1010_76de; /* jz 0x101076de */
            ii(0x1010_752c, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7530, 6); mov(al, memb[ds, eax + 0x101c_40b0]);   /* mov al, [eax+0x101c40b0] */
            ii(0x1010_7536, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_753b, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_753e, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1010_7542, 3); shl(edx, 8);                            /* shl edx, 0x8 */
            ii(0x1010_7545, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7547, 6); mov(eax, memd[ds, eax + 0x101c_4370]);  /* mov eax, [eax+0x101c4370] */
            ii(0x1010_754d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_7550, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7554, 6); mov(al, memb[ds, eax + 0x101c_40b0]);   /* mov al, [eax+0x101c40b0] */
            ii(0x1010_755a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_755f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1010_7561, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_7563, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7567, 3); shl(eax, 7);                            /* shl eax, 0x7 */
            ii(0x1010_756a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_756c, 7); mov(ax, memw[ds, eax + 0x101c_4170]);   /* mov ax, [eax+0x101c4170] */
            ii(0x1010_7573, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_7576, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_7579, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_757c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_757e, 4); mov(ax, memw[ss, ebp - 0x1c]);          /* mov ax, [ebp-0x1c] */
            ii(0x1010_7582, 3); add(eax, memd[ss, ebp - 0x14]);         /* add eax, [ebp-0x14] */
            ii(0x1010_7585, 5); cmp(eax, 0x400);                        /* cmp eax, 0x400 */
            ii(0x1010_758a, 2); if(jle(0x1010_75e0, 0x54)) goto l_0x1010_75e0; /* jle 0x101075e0 */
            ii(0x1010_758c, 5); mov(eax, 0x400);                        /* mov eax, 0x400 */
            ii(0x1010_7591, 3); sub(eax, memd[ss, ebp - 0x14]);         /* sub eax, [ebp-0x14] */
            ii(0x1010_7594, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_7597, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_7599, 4); mov(bx, memw[ss, ebp - 0x1c]);          /* mov bx, [ebp-0x1c] */
            ii(0x1010_759d, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1010_75a1, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1010_75a4, 6); mov(edx, memd[ds, edx + 0x101c_4140]);  /* mov edx, [edx+0x101c4140] */
            ii(0x1010_75aa, 3); add(edx, memd[ss, ebp - 0x14]);         /* add edx, [ebp-0x14] */
            ii(0x1010_75ad, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_75b0, 5); call(Definitions.sys_memcpy, 0x5_e896); /* call 0x10165e4b */
            ii(0x1010_75b5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_75b7, 4); mov(bx, memw[ss, ebp - 0x18]);          /* mov bx, [ebp-0x18] */
            ii(0x1010_75bb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_75bd, 4); mov(ax, memw[ss, ebp - 0x1c]);          /* mov ax, [ebp-0x1c] */
            ii(0x1010_75c1, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1010_75c3, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1010_75c7, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1010_75ca, 6); mov(edx, memd[ds, edx + 0x101c_4140]);  /* mov edx, [edx+0x101c4140] */
            ii(0x1010_75d0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_75d2, 4); mov(ax, memw[ss, ebp - 0x1c]);          /* mov ax, [ebp-0x1c] */
            ii(0x1010_75d6, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1010_75d9, 5); call(Definitions.sys_memcpy, 0x5_e86d); /* call 0x10165e4b */
            ii(0x1010_75de, 2); jmp(0x1010_75fe, 0x1e); goto l_0x1010_75fe; /* jmp 0x101075fe */
        l_0x1010_75e0:
            ii(0x1010_75e0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_75e2, 4); mov(bx, memw[ss, ebp - 0x1c]);          /* mov bx, [ebp-0x1c] */
            ii(0x1010_75e6, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_75ea, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_75ed, 6); mov(edx, memd[ds, eax + 0x101c_4140]);  /* mov edx, [eax+0x101c4140] */
            ii(0x1010_75f3, 3); add(edx, memd[ss, ebp - 0x14]);         /* add edx, [ebp-0x14] */
            ii(0x1010_75f6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_75f9, 5); call(Definitions.sys_memcpy, 0x5_e84d); /* call 0x10165e4b */
        l_0x1010_75fe:
            ii(0x1010_75fe, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7602, 6); mov(al, memb[ds, eax + 0x101c_40b0]);   /* mov al, [eax+0x101c40b0] */
            ii(0x1010_7608, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_760d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1010_760f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_7611, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7615, 3); shl(eax, 7);                            /* shl eax, 0x7 */
            ii(0x1010_7618, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_761a, 9); mov(memw[ds, eax + 0x101c_4170], 0);    /* mov word [eax+0x101c4170], 0x0 */
            ii(0x1010_7623, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7627, 6); mov(al, memb[ds, eax + 0x101c_40b0]);   /* mov al, [eax+0x101c40b0] */
            ii(0x1010_762d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_7632, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_7635, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_7637, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_763b, 3); shl(eax, 8);                            /* shl eax, 0x8 */
            ii(0x1010_763e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_7640, 10); mov(memd[ds, eax + 0x101c_4370], 0);   /* mov dword [eax+0x101c4370], 0x0 */
            ii(0x1010_764a, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_764e, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_7651, 6); dec(memd[ds, eax + 0x101c_4160]);       /* dec dword [eax+0x101c4160] */
            ii(0x1010_7657, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_765b, 6); inc(memb[ds, eax + 0x101c_40b0]);       /* inc byte [eax+0x101c40b0] */
            ii(0x1010_7661, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_7663, 6); mov(dl, memb[ds, eax + 0x101c_40b0]);   /* mov dl, [eax+0x101c40b0] */
            ii(0x1010_7669, 5); mov(ebx, 0x40);                         /* mov ebx, 0x40 */
            ii(0x1010_766e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_7670, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_7673, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_7675, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7679, 6); mov(memb[ds, eax + 0x101c_40b0], dl);   /* mov [eax+0x101c40b0], dl */
            ii(0x1010_767f, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7683, 7); mov(memb[ds, eax + 0x101c_4d80], 0);    /* mov byte [eax+0x101c4d80], 0x0 */
            ii(0x1010_768a, 7); cmp(memb[ds, 0x101c_59b8], 0);          /* cmp byte [0x101c59b8], 0x0 */
            ii(0x1010_7691, 2); if(jz(0x1010_76ad, 0x1a)) goto l_0x1010_76ad; /* jz 0x101076ad */
            ii(0x1010_7693, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_7697, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_769d, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1010_76a3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_76a8, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1010_76ab, 2); if(jnz(0x1010_76af, 2)) goto l_0x1010_76af; /* jnz 0x101076af */
        l_0x1010_76ad:
            ii(0x1010_76ad, 2); jmp(0x1010_76d3, 0x24); goto l_0x1010_76d3; /* jmp 0x101076d3 */
        l_0x1010_76af:
            ii(0x1010_76af, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_76b3, 6); mov(eax, memd[ds, eax + 0x101b_873d]);  /* mov eax, [eax+0x101b873d] */
            ii(0x1010_76b9, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1010_76bc, 5); call(0x1007_5fdc, -0x9_16e5);           /* call 0x10075fdc */
            ii(0x1010_76c1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_76c3, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_76c7, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1010_76cd, 6); mov(memb[ds, eax + 0x101c_a490], dl);   /* mov [eax+0x101ca490], dl */
        l_0x1010_76d3:
            ii(0x1010_76d3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_76d5, 4); mov(ax, memw[ss, ebp - 0x18]);          /* mov ax, [ebp-0x18] */
            ii(0x1010_76d9, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_76dc, 2); jmp(0x1010_774b, 0x6d); goto l_0x1010_774b; /* jmp 0x1010774b */
        l_0x1010_76de:
            ii(0x1010_76de, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_76e2, 6); mov(al, memb[ds, eax + 0x101c_4d80]);   /* mov al, [eax+0x101c4d80] */
            ii(0x1010_76e8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_76ed, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_76ef, 2); if(jnz(0x1010_773f, 0x4e)) goto l_0x1010_773f; /* jnz 0x1010773f */
            ii(0x1010_76f1, 4); movsx(ecx, memw[ss, ebp - 8]);          /* movsx ecx, word [ebp-0x8] */
            ii(0x1010_76f5, 7); mov(memb[ds, ecx + 0x101c_4d80], 1);    /* mov byte [ecx+0x101c4d80], 0x1 */
            ii(0x1010_76fc, 4); movsx(ecx, memw[ss, ebp - 8]);          /* movsx ecx, word [ebp-0x8] */
            ii(0x1010_7700, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_7702, 6); mov(al, memb[ds, ecx + 0x101c_40b0]);   /* mov al, [ecx+0x101c40b0] */
            ii(0x1010_7708, 6); mov(memw[ds, 0x101b_9009], ax);         /* mov [0x101b9009], ax */
            ii(0x1010_770e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_7710, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_7714, 3); imul(ebx, ebx, 6);                      /* imul ebx, ebx, 0x6 */
            ii(0x1010_7717, 5); mov(eax, 0x101c_4090);                  /* mov eax, 0x101c4090 */
            ii(0x1010_771c, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1010_771e, 5); mov(edx, 5);                            /* mov edx, 0x5 */
            ii(0x1010_7723, 5); mov(eax, 0x101b_9008);                  /* mov eax, 0x101b9008 */
            ii(0x1010_7728, 5); call(0x1010_7e6a, 0x73d);               /* call 0x10107e6a */
            ii(0x1010_772d, 5); call(0x1014_82f4, 0x4_0bc2);            /* call 0x101482f4 */
            ii(0x1010_7732, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1010_7736, 3); shl(ebx, 2);                            /* shl ebx, 0x2 */
            ii(0x1010_7739, 6); mov(memd[ds, ebx + 0x101c_4d84], eax);  /* mov [ebx+0x101c4d84], eax */
        l_0x1010_773f:
            ii(0x1010_773f, 5); jmp(0x1010_74e2, -0x262); goto l_0x1010_74e2; /* jmp 0x101074e2 */
        l_0x1010_7744:
            ii(0x1010_7744, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_774b:
            ii(0x1010_774b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_774e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_7750, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_7751, 1); pop(edi);                               /* pop edi */
            ii(0x1010_7752, 1); pop(esi);                               /* pop esi */
            ii(0x1010_7753, 1); pop(edx);                               /* pop edx */
            ii(0x1010_7754, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_7755, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_7756, 1); ret();                                  /* ret */
        }
    }
}
